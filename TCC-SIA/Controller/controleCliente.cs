using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;
using TCC_SIA.Controller;
using BCrypt;
using TCC_SIA.View;



namespace TCC_SIA.Controller
{
    class controleCliente
    {

        public string cadastroCliente(LoginEmpresa mLogin)
        {
            string sql = "insert into Login(cnpjlogin, senhalogin, nomelogin) " + "values(@cnpjlogin, @senhalogin, @nomelogin);";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            string senhaTexto = mLogin.getSenha();

            // Hash a senha
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(senhaTexto);

            // Converta o hash para um array de bytes

            try
            {
                comm.Parameters.AddWithValue("@cnpjlogin", mLogin.getCnpj());
                comm.Parameters.AddWithValue("@nomelogin", mLogin.getNome());
                comm.Parameters.AddWithValue("@senhalogin", hashSenha);

                comm.ExecuteNonQuery();
                return "Cliente cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }

        public string loginLogin(IdLogin mIdLogin)
        {
            string sql = "SELECT senhalogin from Login where nomelogin = @usuario;";
            string hasharmazenado = "senhalogin";
            string senhaTexto = mIdLogin.getSenha();


            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            // Hash a senha
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(senhaTexto);

            // Converta o hash para um array de bytes

            comm.Parameters.AddWithValue("@usuario", mIdLogin.getUsuario());

            try
            {
                bool SenhaCorreta = BCrypt.Net.BCrypt.Verify(senhaTexto, hasharmazenado);
                if (SenhaCorreta)
                {
                    return "Deu certo!";
                }
                else
                {
                    return "Deu Errado!";
                }
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}