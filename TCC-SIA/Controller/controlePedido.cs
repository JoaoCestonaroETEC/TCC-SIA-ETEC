using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;
using Npgsql;

namespace TCC_SIA.Controller
{
    internal class controlePedido
    {
        #region Cadastrar pedido
        //Criação do método de cadastrar pedido
        public string cadastroPedido(Pedido mPedido)
        {
            //String sql de inserção
            string sql = "INSERT INTO PEDIDO(IDPEDIDO, IDVEICULO, IDCLIENTE, VALORTOTALPEDIDO, VALORTOTALPECA, VALORTOTALSERVICO, DESCONTOTOTALPORC, DESCONTOTOTALREAIS, DESCONTOSERVICOREAIS, DESCONTOSERVICOPORC, DESCONTOPECAREAIS, DESCONTOPECAPORC, OBSERVACAO, DATAINICIO, DATAFIM) " +
                    "VALUES(@IDPEDIDO, @IDVEICULO, @IDCLIENTE, @VALORTOTALPEDIDO, @VALORTOTALPECA, @VALORTOTALSERVICO, @DESCONTOTOTALPORC, @DESCONTOTOTALREAIS, @DESCONTOSERVICOREAIS, @DESCONTOSERVICOPORC, @DESCONTOPECAREAIS, @DESCONTOPECAPORC, @OBSERVACAO, @DATAINICIO, @DATAFIM);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                comm.Parameters.AddWithValue("@IDVEICULO", mPedido.getIdVeiculo());
                comm.Parameters.AddWithValue("@IDCLIENTE", mPedido.getIdCliente());
                comm.Parameters.AddWithValue("@VALORTOTALPEDIDO", mPedido.getValorTotalPeca());
                comm.Parameters.AddWithValue("@VALORTOTALPECA", mPedido.getValorTotalPeca());
                comm.Parameters.AddWithValue("@VALORTOTALSERVICO", mPedido.getValorTotalServico());
                comm.Parameters.AddWithValue("@DESCONTOTOTALREAIS", mPedido.getDescontoReais());
                comm.Parameters.AddWithValue("@DESCONTOTOTALPORC", mPedido.getDescontoPorCento());
                comm.Parameters.AddWithValue("@DESCONTOSERVICOREAIS", mPedido.getDescontoServReais());
                comm.Parameters.AddWithValue("@DESCONTOSERVICOPORC", mPedido.getDescontoServPorCento());
                comm.Parameters.AddWithValue("@DESCONTOPECAREAIS", mPedido.getDescontoPecaReais());
                comm.Parameters.AddWithValue("@DESCONTOPECAPORC", mPedido.getDescontoPecaPorc());
                comm.Parameters.AddWithValue("@DESCONTOPORC", mPedido.getDescontoPorCento());
                comm.Parameters.AddWithValue("@DESCONTOREAIS", mPedido.getDescontoReais());
                comm.Parameters.AddWithValue("@OBSERVACAO", mPedido.getObservacao());
                comm.Parameters.AddWithValue("@DATAINICIO", mPedido.getDataInicio());
                comm.Parameters.AddWithValue("@DATAFIM", mPedido.getDataFim());


                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Pedido cadastrado com sucesso!";
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando o erro
                return ex.ToString();
            }
            finally
            {
                //Método de desconectar
                con.desconectar();
            }
        }
        #endregion

        #region Cadastrar peças
        // Criação do método de cadastrar pedido de peças
        public string cadastroPedidoPecas(List<Pedido_Peca> mPedidoPeca, Pedido mPedido)
        {
            // String SQL para verificar a quantidade disponível no estoque
            string sqlVef = "SELECT quantpeca FROM peca WHERE idpeca = @IDPECA";

            // String SQL de inserção
            string sql = "INSERT INTO PEDIDO_PECA(IDPEDIDO, IDPECA, QUANTVEZES) " +
                         "VALUES(@IDPEDIDO, @IDPECA, @QUANTVEZES);";

            // Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand commVef = new NpgsqlCommand(sqlVef, conn);
            NpgsqlCommand commInsert = new NpgsqlCommand(sql, conn);

            // Fazendo o try
            try
            {
                // Loop de repetição para cada peça selecionada
                foreach (var peca in mPedidoPeca)
                {
                    // Limpa os parâmetros anteriores
                    commVef.Parameters.Clear();

                    // Verificando a quantidade disponível no estoque
                    commVef.Parameters.AddWithValue("@IDPECA", peca.getIdPeca());
                    int quantEstoque = Convert.ToInt32(commVef.ExecuteScalar());

                    // Se a quantidade solicitada for maior que a disponível, retorna um erro
                    if (peca.getQuantVezes() > quantEstoque)
                    {
                        return $"Erro: A quantidade da peça {peca.getIdPeca()} excede o estoque disponível.";
                    }

                    // Se a quantidade está disponível, insere o pedido
                    commInsert.Parameters.Clear();
                    commInsert.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                    commInsert.Parameters.AddWithValue("@IDPECA", peca.getIdPeca());
                    commInsert.Parameters.AddWithValue("@QUANTVEZES", peca.getQuantVezes());

                    // Executando a query de inserção
                    commInsert.ExecuteNonQuery();
                }

                // Retornando sucesso
                return "Todas as peças cadastradas com sucesso!";
            }
            // Fazendo o catch para capturar exceções do Npgsql
            catch (NpgsqlException ex)
            {
                // Retornando o erro
                return ex.ToString();
            }
            finally
            {
                // Desconectando do banco de dados
                con.desconectar();
            }
        }
        #endregion



        #region Cadastrar serviços
        //Criação do método de cadastrar serviços
        public string cadastroPedidoServicos(List<Servico> mServico, Pedido mPedido)
        {
            //String sql de inserção
            string sql = "INSERT INTO PEDIDO_SERVICO(IDPEDIDO, IDSERVICO, QUANTVEZES) " +
                    "VALUES(@IDPEDIDO, @IDSERVICO, @QUANTVEZES);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Criando o loop de repetição para cada linha selecionada
                foreach (var peca in mServico)
                {
                    {
                        //Definindo os valores a serem postos nos campos
                        comm.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                        comm.Parameters.AddWithValue("@IDSERVICO", peca.getIDServico());
                        comm.Parameters.AddWithValue("@QUANTVEZES", peca.getQuantVezes());
                        // Executando o Query
                        comm.ExecuteNonQuery();
                    }
                }

                //Retornando um valor
                return "Todos os serviços cadastrados com sucesso!";
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando o erro
                return ex.ToString();
            }
            finally
            {
                //Método de desconectar
                con.desconectar();
            }
            #endregion
        }

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
    }
}
