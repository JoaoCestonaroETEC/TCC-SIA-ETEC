using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;
using Npgsql;
using System.Transactions;
using System.Data.Common;

namespace TCC_SIA.Controller
{
    internal class controlePedido
    {
        #region Cadastrar Pedido Completo (Pedido, Peças e Serviços)
        public string cadastroCompletoPedido(Pedido mPedido, List<Pedido_Peca> mPedidoPeca, List<Servico> mServico)
        {
            // Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlTransaction transaction = conn.BeginTransaction(); // Inicia a transação

            try
            {
                // SQL de inserção para o pedido
                string sqlPedido = "INSERT INTO PEDIDO(IDPEDIDO, IDVEICULO, IDCLIENTE, VALORTOTALPEDIDO, VALORTOTALPECA, VALORTOTALSERVICO, " +
                                   "DESCONTOTOTALPORC, DESCONTOTOTALREAIS, DESCONTOSERVICOREAIS, DESCONTOSERVICOPORC, DESCONTOPECAREAIS, " +
                                   "DESCONTOPECAPORC, OBSERVACAO, DATAINICIO, DATAFIM) VALUES(@IDPEDIDO, @IDVEICULO, @IDCLIENTE, @VALORTOTALPEDIDO, " +
                                   "@VALORTOTALPECA, @VALORTOTALSERVICO, @DESCONTOTOTALPORC, @DESCONTOTOTALREAIS, @DESCONTOSERVICOREAIS, " +
                                   "@DESCONTOSERVICOPORC, @DESCONTOPECAREAIS, @DESCONTOPECAPORC, @OBSERVACAO, @DATAINICIO, @DATAFIM);";
                NpgsqlCommand commPedido = new NpgsqlCommand(sqlPedido, conn);
                commPedido.Transaction = transaction;

                // Definindo parâmetros do pedido
                commPedido.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                commPedido.Parameters.AddWithValue("@IDVEICULO", mPedido.getIdVeiculo());
                commPedido.Parameters.AddWithValue("@IDCLIENTE", mPedido.getIdCliente());
                commPedido.Parameters.AddWithValue("@VALORTOTALPEDIDO", mPedido.getValorTotalPedido());
                commPedido.Parameters.AddWithValue("@VALORTOTALPECA", mPedido.getValorTotalPeca());
                commPedido.Parameters.AddWithValue("@VALORTOTALSERVICO", mPedido.getValorTotalServico());
                commPedido.Parameters.AddWithValue("@DESCONTOTOTALREAIS", mPedido.getDescontoReais());
                commPedido.Parameters.AddWithValue("@DESCONTOTOTALPORC", mPedido.getDescontoPorCento());
                commPedido.Parameters.AddWithValue("@DESCONTOSERVICOREAIS", mPedido.getDescontoServReais());
                commPedido.Parameters.AddWithValue("@DESCONTOSERVICOPORC", mPedido.getDescontoServPorCento());
                commPedido.Parameters.AddWithValue("@DESCONTOPECAREAIS", mPedido.getDescontoPecaReais());
                commPedido.Parameters.AddWithValue("@DESCONTOPECAPORC", mPedido.getDescontoPecaPorc());
                commPedido.Parameters.AddWithValue("@OBSERVACAO", mPedido.getObservacao());
                commPedido.Parameters.AddWithValue("@DATAINICIO", mPedido.getDataInicio());
                commPedido.Parameters.AddWithValue("@DATAFIM", mPedido.getDataFim());

                // Executando a query de inserção do pedido
                commPedido.ExecuteNonQuery();

                // SQL para verificar quantidade disponível e inserir peças do pedido
                string sqlVerificaPeca = "SELECT quantpeca FROM peca WHERE idpeca = @IDPECA";
                string sqlInsertPeca = "INSERT INTO PEDIDO_PECA(IDPEDIDO, IDPECA, QUANTVEZES) VALUES(@IDPEDIDO, @IDPECA, @QUANTVEZES);";

                foreach (var peca in mPedidoPeca)
                {
                    NpgsqlCommand commVerificaPeca = new NpgsqlCommand(sqlVerificaPeca, conn);
                    commVerificaPeca.Transaction = transaction;
                    commVerificaPeca.Parameters.AddWithValue("@IDPECA", peca.getIdPeca());

                    int quantEstoque = Convert.ToInt32(commVerificaPeca.ExecuteScalar());

                    if (peca.getQuantVezes() > quantEstoque)
                    {
                        transaction.Rollback();
                        return $"Erro: A quantidade da peça {peca.getIdPeca()} excede o estoque disponível.";
                    }

                    NpgsqlCommand commInsertPeca = new NpgsqlCommand(sqlInsertPeca, conn);
                    commInsertPeca.Transaction = transaction;
                    commInsertPeca.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                    commInsertPeca.Parameters.AddWithValue("@IDPECA", peca.getIdPeca());
                    commInsertPeca.Parameters.AddWithValue("@QUANTVEZES", peca.getQuantVezes());

                    commInsertPeca.ExecuteNonQuery();
                }

                // SQL para inserir serviços do pedido
                string sqlInsertServico = "INSERT INTO PEDIDO_SERVICO(IDPEDIDO, IDSERVICO, QUANTVEZES) VALUES(@IDPEDIDO, @IDSERVICO, @QUANTVEZES);";

                foreach (var servico in mServico)
                {
                    NpgsqlCommand commInsertServico = new NpgsqlCommand(sqlInsertServico, conn);
                    commInsertServico.Transaction = transaction;

                    commInsertServico.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                    commInsertServico.Parameters.AddWithValue("@IDSERVICO", servico.getIDServico());
                    commInsertServico.Parameters.AddWithValue("@QUANTVEZES", servico.getQuantVezes());

                    commInsertServico.ExecuteNonQuery();
                }

                // Se tudo for bem-sucedido, confirma a transação
                transaction.Commit();
                return "Pedido, peças e serviços cadastrados com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                // Em caso de erro, reverte a transação
                transaction.Rollback();
                return ex.ToString();
            }
            finally
            {
                con.desconectar();
            }
        }
        #endregion


        #region Pesquisar pedido
        public NpgsqlDataReader pesquisaPedido(int cliente, int veiculo)
        {
            string sql = "SELECT * FROM PEDIDO WHERE IDCLIENTE = @cliente AND IDVEICULO = @veiculo;";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            // Adiciona os parâmetros
            comm.Parameters.AddWithValue("@cliente", cliente);
            comm.Parameters.AddWithValue("@veiculo", veiculo);

            try
            {
                return comm.ExecuteReader();
            }
            catch (NpgsqlException ex)
            {
                return null;
            }
            finally
            {
                con.desconectar();
            }
        }

        #endregion

        #region
        //Criação do método de pesquisar o pedido
        public NpgsqlDataReader pesquisaPecaParaOPedido(string peca)
        {
            //String sql de pesquisar
            string sql = "SELECT IDMARCAPECA FROM PECA WHERE NOMEPECA LIKE '" + peca + "%';";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Retornando os valores
                return comm.ExecuteReader();
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando como nulo
                return null;
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }

        }
        #endregion

        #region Pesquisar pedido
        //Criação do método de pesquisar peça
        public NpgsqlDataReader listarPedido()
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM PEDIDO;";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Retornando os valores
                return comm.ExecuteReader();
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando como nulo
                return null;
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }

        }
        #endregion

        #region
        //Criação do método de pesquisar peça do pedido
        public NpgsqlDataReader listarPedido(string peca)
        {
            //String sql de pesquisar
            string sql = "SELECT IDMARCAPECA FROM PECA WHERE NOMEPECA LIKE '" + peca + "%';";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Retornando os valores
                return comm.ExecuteReader();
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando como nulo
                return null;
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }

        }
        #endregion

        #region Listar idpedido
        //Criação do método de listar o id do pedido
        public NpgsqlDataReader listarIdPedido()
        {
            //String sql de inserção
            string sql = "SELECT MAX(IDPEDIDO) FROM PEDIDO";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            Pedido mPedido = new Pedido();

            //Fazendo o try
            try
            {
                //Retornando os valores
                return comm.ExecuteReader();
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando como nulo
                return null;
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }
        }
        #endregion


        #region Pesquisar cliente por id
        //Criação do método de pesquisar marca de peça por id
        public string pesquisarClientePorId(string idCliente)
        {
            //String sql de pesquisar
            string sql = "SELECT NOMECLIENTE FROM CLIENTE WHERE IDCLIENTE = '" + idCliente + "';";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Execute a consulta e retorne o resultado como string
                object result = comm.ExecuteScalar();
                return result != null ? result.ToString() : "Marca não encontrada";
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando como nulo
                return null;
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }

        }
        #endregion


        #region Pesquisar Veiculo por id
        //Criação do método de pesquisar marca de peça por id
        public string pesquisarVeiculoPorId(string IdVeiculo)
        {
            //String sql de pesquisar
            string sql = "SELECT NOMEVEICULO FROM VEICULO WHERE IDVEICULO = '" + IdVeiculo + "';";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Execute a consulta e retorne o resultado como string
                object result = comm.ExecuteScalar();
                return result != null ? result.ToString() : "Marca não encontrada";
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando como nulo
                return null;
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }

        }
        #endregion

        #region Lista de Peças
        public NpgsqlDataReader listarPecas(long idPedido)
        {
            string sql = "SELECT PEP.IDPEDIDO, PEP.IDPECA, M.NOMEMARCA, PE.NOMEPECA, PE.TIPOPECA, \r\nPE.DESCPECA, PE.VALORPECA, PE.QUANTPECA, PE.GARANTIAPECA, PE.UNIDADE, \r\nPE.DATA_AQUISICAO, PE.FORNECEDOR, PEP.QUANTVEZES FROM PEDIDO_PECA PEP INNER JOIN PECA PE\r\nON PEP.IDPECA = PE.IDPECA INNER JOIN MARCA M ON PE.IDMARCA = M.IDMARCA WHERE PEP.IDPEDIDO = @IdPedido";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@IdPedido", idPedido);

            return comm.ExecuteReader(); // Certifique-se de que o método realmente retorne um NpgsqlDataReader
        }

        #endregion

        #region Lista de Serviços
        public NpgsqlDataReader listarServico(long idPedido)
        {
            string sql = "SELECT PES.IDPEDIDO, PES.IDSERVICO, S.NOMESERVICO, S.DESCSERVICO, S.VALORSERVICO, \r\nS.FUNCIONARIO, S.GARANTIASERVICO, PES.QUANTVEZES FROM PEDIDO_SERVICO PES INNER JOIN SERVICO S\r\nON PES.IDSERVICO = S.IDSERVICO WHERE PES.IDPEDIDO= @IdPedido;";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@IdPedido", idPedido);

            return comm.ExecuteReader(); // Certifique-se de que o método realmente retorne um NpgsqlDataReader
        }

        #endregion

        public string atualizarPedido(Pedido mPedido)
        {
            string sql = "UPDATE PEDIDO SET  VALORTOTALPEDIDO = @VALORTOTALPEDIDO, " +
                " OBSERVACAO = @OBSERVACAO, DATAINICIO = @DATAINICIO," +
                " DATAFIM = @DATAFIM" +
                " WHERE IDPEDIDO = @IDPEDIDO;";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                comm.Parameters.AddWithValue("@VALORTOTALPEDIDO", mPedido.getValorTotalPedido());
                comm.Parameters.AddWithValue("@OBSERVACAO", mPedido.getObservacao());
                comm.Parameters.AddWithValue("@DATAINICIO", mPedido.getDataInicio());
                comm.Parameters.AddWithValue("@DATAFIM", mPedido.getDataFim());
                
                comm.ExecuteNonQuery();
                return "Pedido atualizado!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
                //return "Erro ao atualizar!";
            }
        }
    }
}
