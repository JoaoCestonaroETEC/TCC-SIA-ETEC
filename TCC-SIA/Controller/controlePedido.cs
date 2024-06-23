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
        //Criação do método de cadastrar pedido
        public string cadastroPedido(Pedido mPedido, Pedido_Peca mPedidoPeca, Servico mServico)
        {
            //String sql de inserção
            string sql = "INSERT INTO PEDIDO(IDPEDIDO, IDVEICULO, CPFCLIENTE, VALORTOTALPEDIDO, VALORTOTALPECA, VALORTOTALSERVICO, OBSERVACAO, DATAINICIO, DATAFIM) " +
                    "VALUES(@IDPEDIDO, @IDVEICULO, @CPFCLIENTE, @VALORTOTALPEDIDO, @VALORTOTALPECA, @VALORTOTALSERVICO, @OBSERVACAO, @DATAINICIO, @DATAFIM);" +
                    "INSERT INTO PEDIDO_PECA(IDPEDIDO, IDMARCAPECA, NOMEPECA, TIPOPECA, DESCPECA, VALORPECA, QUANTPECA, GARANTIAPECA) " +
                    "VALUES(@IDPEDIDO, @IDMARCAPECA, @NOMEPECA, @TIPOPECA, @DESCPECA, @VALORPECA, @QUANTPECA, @GARANTIAPECA);" +
                    "INSERT INTO PEDIDO_SERVICO(IDPEDIDO, NOMESERVICO, DESCSERVICO, VALORSERVICO) " +
                    "VALUES(@IDPEDIDO, @NOMESERVICO, @DESCSERVICO, @VALORSERVICO);";

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
                comm.Parameters.AddWithValue("@IDMARCAPECA", mPedidoPeca.getIdMarca());
                comm.Parameters.AddWithValue("@NOMEPECA", mPedidoPeca.getNomePeca());
                comm.Parameters.AddWithValue("@TIPOPECA", mPedidoPeca.getTipoPeca());
                comm.Parameters.AddWithValue("@DESCPECA", mPedidoPeca.getDescPeca());
                comm.Parameters.AddWithValue("@VALORPECA", mPedidoPeca.getValorPeca());
                comm.Parameters.AddWithValue("@QUANTPECA", mPedidoPeca.getQuantPeca());
                comm.Parameters.AddWithValue("@GARANTIAPECA", mPedidoPeca.getGarantiaPeca());
                comm.Parameters.AddWithValue("@NOMESERVICO", mServico.getNomeServico());
                comm.Parameters.AddWithValue("@DESCSERVICO", mServico.getDescServico());
                comm.Parameters.AddWithValue("@VALORSERVICO", mServico.getValorServico());


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
    }
}
