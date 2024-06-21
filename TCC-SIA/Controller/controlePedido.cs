using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_SIA.Model;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TCC_SIA.Controller
{
    internal class controlePedido
    {
        public string cadastroPedido(Pedido mPedido)
        {
            string sql = "INSERT INTO PEDIDO(IDPEDIDO, IDVEICULO, CPFCLIENTE, VALORTOTALPEDIDO, VALORTOTALPECA, VALORTOTALSERVICO, OBSERVACAO, DATAINICIO, DATAFIM) " + "values(@IDPEDIDO, @IDVEICULO, @CPFCLIENTE, @VALORTOTALPEDIDO, @VALORTOTALPECA, @VALORTOTALSERVICO, @OBSERVACAO, @DATAINICIO, @DATAFIM);" +
                "INSERT INTO PEDIDO_PECA(IDPEDIDO, IDPECA)" + "VALUES(@IDPEDIDO, @IDPECA);" +
                "INSERT INTO PEDIDO_SERVICO(IDPEDIDO, IDSERVICO" + "VALUES(@IDPEDIDO, @IDSERVICO)";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@CPFCLIENTE", mPedido.getCpfCliente());
                comm.Parameters.AddWithValue("@IDVEICULO", mPedido.getIdVeiculo());
                comm.Parameters.AddWithValue("@VALORTOTALPEDIDO", mPedido.getValorTotalPedido());
                comm.Parameters.AddWithValue("@VALORTOTALPECA", mPedido.getValorTotalPeca());
                comm.Parameters.AddWithValue("@VALORTOTALSERVICO", mPedido.getValorTotalServico());
                comm.Parameters.AddWithValue("@OBSERVACAO", mPedido.getObservacao());
                comm.Parameters.AddWithValue("@DATAINICIO", mPedido.getDataInicio());
                comm.Parameters.AddWithValue("@DATAFIM", mPedido.getDataFim());
                comm.Parameters.AddWithValue("@IDPEDIDO", mPedido.getIdPedido());
                comm.Parameters.AddWithValue("@IDSERVICO", mPedido.getServico());
                comm.Parameters.AddWithValue("@IDPECA", mPedido.getPecas());



                comm.ExecuteNonQuery();
                return "Pedido cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }

        public int ProximoIdPedido(Pedido mPedido)
        {
            string sql = "SELECT MAX(idpedido) AS max_idpedido FROM pedido;";
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            // Consulta SQL para obter o maior valor de idpedido no banco de dados

            // Executar a consulta usando o contexto do Entity Framework

            // Incrementa o maior valor encontrado

            try
            {
                // Executar a consulta e obter o resultado
                var result = comm.ExecuteNonQuery();

                // Converter o resultado para Int64 (long) e incrementar
                var maiorId = Convert.ToInt64(result);
                  
                if (maiorId < 0)
                {
                    maiorId = 0;
                }

                var proximoIdPedido = maiorId + 1;
                var resultadoFinal = Convert.ToInt32(result);

                return resultadoFinal;

            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine($"Erro ao obter próximo idpedido: {ex.Message}");
                throw; // Você pode lançar a exceção novamente ou tratar de outra forma
            }
        }
    }
}
