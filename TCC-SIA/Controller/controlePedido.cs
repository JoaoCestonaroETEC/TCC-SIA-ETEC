using Npgsql;
using System;
using System.Collections.Generic;
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
            string sql = "INSERT INTO PEDIDO(CPFCLIENTE, IDVEICULO, VALORTOTALPEDIDO, VALORTOTALPECA, VALORTOTALSERVICO, OBSERVACAO, DATAINICIO, DATAFIM) " + "values(@CPFCLIENTE, @IDVEICULO, @VALORTOTALPEDIDO, @VALORTOTALEPCA, @VALORTOTALSERVICO, @OBSERVACAO, @DATAINICIO, @DATAFIM);";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@CPFCLIENTE", mPedido.getCpfCliente());
                comm.Parameters.AddWithValue("@IDVEICULO", mPedido.getIdVeiculo());
                comm.Parameters.AddWithValue("@VALORPEDIDOTOTAL", mPedido.getValorTotalServico());
                comm.Parameters.AddWithValue("@VALORTOTALPECA", mPedido.getValorTotalPeca());
                comm.Parameters.AddWithValue("@VALORTOTALSERVICO", mPedido.getValorTotalServico());
                comm.Parameters.AddWithValue("@OBSERVACAO", mPedido.getObservacao());
                comm.Parameters.AddWithValue("@DATAINICIO", mPedido.getDataInicio());
                comm.Parameters.AddWithValue("@DATAFIM", mPedido.getDataFim());

                comm.ExecuteNonQuery();
                return "Pedido cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}
