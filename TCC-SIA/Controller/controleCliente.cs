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

        public string cadastroCliente(Login mLogin)
        {
            string sql = "insert into Login(cnpjlogin, nomelogin, senhalogin) " + "values(@cnpjlogin, @nomelogin, @senhalogin);";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            string senhaTexto = mLogin.getSenha();

            // Hash a senha
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(senhaTexto);

            // Converta o hash para um array de bytes
            byte[] hashBytes = System.Text.Encoding.UTF8.GetBytes(hashSenha);

            try
            {
                comm.Parameters.AddWithValue("@cnpjlogin", mLogin.getCnpj());
                comm.Parameters.AddWithValue("@nomelogin", mLogin.getNome());
                comm.Parameters.AddWithValue("@emaiLogin", mLogin.getSenha());
                comm.Parameters.AddWithValue("@senhaCliente", hashBytes);

                comm.ExecuteNonQuery();
                return "Cliente cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }

      

        public string ConverterByteParaSenha(byte[] hashBytes)
        {
            return Convert.ToBase64String(hashBytes);
        }

        public string compararSenha(IdLogin mIdLogin)
        {
            string sql = "SELECT senhaLogin from Login where cpfLogin = @usuario;";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            byte[] storedHash = (byte[])comm.ExecuteScalar();

            // Hash a senha

            // Converta o hash para um array de byte

            comm.Parameters.AddWithValue("@usuario", mIdLogin.getUsuario());

            try
            {
                string originalHash = ConverterByteParaSenha(storedHash);
                int linhasAfetadas = comm.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    return ("Cliente cadastrado com sucesso!");
                }
                else
                {
                    return ("Falha ao cadastrar o cliente.");
                }
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}