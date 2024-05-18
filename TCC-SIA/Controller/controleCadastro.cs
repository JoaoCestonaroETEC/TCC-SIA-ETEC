using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;
using TCC_SIA.Controller;



namespace TCC_SIA.Controller
{
    class ControleCadastro
    {



        public string cadastroProduto(Cliente mCliente)
        {
            string sql = "insert into CLIENTE(NOMECLIENTE, EMAILCLIENTE, EMAILCLIENTE) " + "values(@nomeCliente, emailCliente, senhaCliente;";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nomeCliente", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@emailCLiente", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@senhaCliente", mCliente.getSenhaCliente());

                comm.ExecuteNonQuery();
                return "Produto cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}