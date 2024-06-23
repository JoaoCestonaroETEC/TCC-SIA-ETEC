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
            string sql = "INSERT INTO PEDIDO(IDPEDIDO, IDVEICULO, CPFCLIENTE, VALORTOTALPEDIDO, VALORTOTALPECA, VALORTOTALSERVICO, OBSERVACAO, DATAINICIO, DATAFIM) " +
                    "VALUES(@IDPEDIDO, @IDVEICULO, @CPFCLIENTE, @VALORTOTALPEDIDO, @VALORTOTALPECA, @VALORTOTALSERVICO, @OBSERVACAO, @DATAINICIO, @DATAFIM);";

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
                comm.Parameters.AddWithValue("@CPFCLIENTE", mPedido.getCpfCliente());
                comm.Parameters.AddWithValue("@VALORTOTALPEDIDO", mPedido.getValorTotalPeca());
                comm.Parameters.AddWithValue("@VALORTOTALPECA", mPedido.getValorTotalPeca());
                comm.Parameters.AddWithValue("@VALORTOTALSERVICO", mPedido.getValorTotalServico());
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
        //Criação do método de cadastrar pedido de peças
        public string cadastroPedidoPecas(List<Pedido_Peca> mPedidoPeca, Pedido mPedido)
        {
            //String sql de inserção
            string sql = "INSERT INTO PEDIDO_PECA(IDPEDIDO, IDMARCAPECA, NOMEPECA, TIPOPECA, DESCPECA, VALORPECA, QUANTPECA, GARANTIAPECA) " +
                    "VALUES(@IDPEDIDO, @IDMARCAPECA, @NOMEPECA, @TIPOPECA, @DESCPECA, @VALORPECA, @QUANTPECA, @GARANTIAPECA);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Criando o loop de repetição para cada linha selecionada
                foreach (var peca in mPedidoPeca)
                {
                    {
                        //Definindo os valores a serem postos nos campos
                        comm.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                        comm.Parameters.AddWithValue("@IDMARCAPECA", peca.getIdMarca());
                        comm.Parameters.AddWithValue("@NOMEPECA", peca.getNomePeca());
                        comm.Parameters.AddWithValue("@TIPOPECA", peca.getTipoPeca());
                        comm.Parameters.AddWithValue("@DESCPECA", peca.getDescPeca());
                        comm.Parameters.AddWithValue("@VALORPECA", peca.getValorPeca());
                        comm.Parameters.AddWithValue("@QUANTPECA", peca.getQuantPeca());
                        comm.Parameters.AddWithValue("@GARANTIAPECA", peca.getGarantiaPeca());

                        // Executando o Query
                        comm.ExecuteNonQuery();
                    }
                }

                //Retornando um valor
                return "Todos as peças cadastradas com sucesso!";
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

        #region Cadastrar serviços
        //Criação do método de cadastrar serviços
        public string cadastroPedidoServicos(List<Servico> mServico, Pedido mPedido)
        {
            //String sql de inserção
            string sql = "INSERT INTO PEDIDO_SERVICO(IDPEDIDO, NOMESERVICO, DESCSERVICO, VALORSERVICO) " +
                    "VALUES(@IDPEDIDO, @NOMESERVICO, @DESCSERVICO, @VALORSERVICO);";

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
                        comm.Parameters.AddWithValue("@NOMESERVICO", peca.getNomeServico());
                        comm.Parameters.AddWithValue("@DESCSERVICO", peca.getDescServico());
                        comm.Parameters.AddWithValue("@VALORSERVICO", peca.getValorServico());
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

        #region Cadastrar peças
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
