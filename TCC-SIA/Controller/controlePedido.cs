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
            string sql = "INSERT INTO pedido(corveiculo, marcaveiculo, tipoveiculo, placaveiculo, modeloveiculo, valortotal, observacao, datainicio, datafim) " + "values(@corveiculo, @marcaveiculo, @tipoveiculo, @placaveiculo, @modeloveiculo, @valortotal, @observacao, @datainicio, @datafim);";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@corveiculo", mPedido.getCorVeiculo());
                comm.Parameters.AddWithValue("@marcaveiculo", mPedido.getMarcaVeiculo());
                comm.Parameters.AddWithValue("@tipoveiculo", mPedido.getTipoVeiculo());
                comm.Parameters.AddWithValue("@placaveiculo", mPedido.getPlacaVeiculo());
                comm.Parameters.AddWithValue("@modeloveiculo", mPedido.getModeloVeiculo());
                comm.Parameters.AddWithValue("@valortotal", mPedido.getValorTotal());
                // comm.Parameters.AddWithValue("@valortotalpeca", mPedido.getValorTotalPeca()); add no insert into dps
                // comm.Parameters.AddWithValue("@valortotalpedido", mPedido.getValorTotalServico()); add no insert into dps
                comm.Parameters.AddWithValue("@observacao", mPedido.getObservacao());
                comm.Parameters.AddWithValue("@datainicio", mPedido.getDataInicio());
                comm.Parameters.AddWithValue("@datafim", mPedido.getDataFim());

                comm.ExecuteNonQuery();
                return "Pedido cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }

        public string verificarPedidoCliente(Pedido mPedido)
        {
            bool registroExistente = false;

            string sql = "SELECT EXISTS(SELECT 1 FROM CLIENTE c INNER JOIN CLIENTE_TELEFONE ct ON c.CPFCLIENTE = ct.CPFCLIENTE WHERE c.CPFCLIENTE = @cpf AND c.NOMECLIENTE = @nome AND ct.TELEFONE = @telefone)";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("cpf", 1);
                comm.Parameters.AddWithValue("nome", "1");
                comm.Parameters.AddWithValue("telefone", "1");

                registroExistente = (bool)comm.ExecuteScalar();
                return "Cadastro genérico efetuado com sucesso. (teste)";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }

    public string adicionarPedidoCliente(Pedido mPedido)
    {
        bool registroExistente = false;

        string sql = "SELECT EXISTS(SELECT 1 FROM CLIENTE c INNER JOIN CLIENTE_TELEFONE ct ON c.CPFCLIENTE = ct.CPFCLIENTE WHERE c.CPFCLIENTE = @cpf AND c.NOMECLIENTE = @nome AND ct.TELEFONE = @telefone)";

        conexaoBD con = new conexaoBD();
        NpgsqlConnection conn = con.conectar();
        NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

        try
        {
            comm.Parameters.AddWithValue("cpf", 1);
            comm.Parameters.AddWithValue("nome", "1");
            comm.Parameters.AddWithValue("telefone", "1");

            registroExistente = (bool)comm.ExecuteScalar();
            return "Cadastro genérico efetuado com sucesso. (teste)";
        }
        catch (NpgsqlException ex)
        {
            return ex.ToString();
        }
    }
}
