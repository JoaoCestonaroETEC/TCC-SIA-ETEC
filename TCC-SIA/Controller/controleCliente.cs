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

            //transforma a senha definida do cadastro em uma variável
            string senhaTexto = mLogin.getSenha();
            // Hash a senha
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(senhaTexto);

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

        public string loginCadastro(IdLogin mLogin)
        {
            string sql = "SELECT senhalogin FROM Login WHERE cnpjlogin = @cnpjlogin";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cnpjlogin", mLogin.getCnpj());

                string hashArmazenado = null;

                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hashArmazenado = reader["senhalogin"].ToString();
                    }
                }

                if (hashArmazenado != null)
                {
                    string senhaInserida = mLogin.getSenha();
                    bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaInserida, hashArmazenado);

                    if (senhaCorreta)
                    {
                        return "Login efetuado!";
                    }
                    else
                    {
                        return "Senha incorreta!";
                    }
                }
                else
                {
                    return "Usuário não encontrado.";
                }
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}