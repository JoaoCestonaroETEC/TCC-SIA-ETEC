using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;
using TCC_SIA.Controller;
using BCrypt;



namespace TCC_SIA.Controller
{
    class controleCliente
    {

        public string cadastroCliente(Cliente mCliente)
        {
            string sql = "insert into CLIENTE(CPFCLIENTE, NOMECLIENTE, EMAILCLIENTE, SENHACLIENTE) " + "values(@cpfCliente, @nomeCliente, @emailCliente, @senhaCliente);";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            string senhaTexto = mCliente.getSenhaCliente();

            // Hash a senha
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(senhaTexto);

            // Converta o hash para um array de bytes
            byte[] hashBytes = System.Text.Encoding.UTF8.GetBytes(hashSenha);

            try
            {
                comm.Parameters.AddWithValue("@cpfCliente", mCliente.getCpfCliente());
                comm.Parameters.AddWithValue("@nomeCliente", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@emailCliente", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@senhaCliente", hashBytes);

                comm.ExecuteNonQuery();
                return "Cliente cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }

        public string loginCadastro(IdLogin mIdLogin)
        {
            string sql = "SELECT SENHACLIENTE, NOMECLIENTE FROM CLIENTE WHERE NOMECLIENTE = @usuario AND SENHACLIENTE=@senha";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            string senhaTexto = mIdLogin.getSenha();

            // Hash a senha
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(senhaTexto);

            // Converta o hash para um array de bytes
            byte[] hashBytes = System.Text.Encoding.UTF8.GetBytes(hashSenha);

            comm.Parameters.AddWithValue("@usuario", mIdLogin.getUsuario());
            comm.Parameters.AddWithValue("@senha", hashBytes);

            try
            {
                int linhasAfetadas = comm.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return ("Cliente cadastrado com sucesso!");
                }
                else
                {
                    return("Falha ao cadastrar o cliente.");
                }
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}