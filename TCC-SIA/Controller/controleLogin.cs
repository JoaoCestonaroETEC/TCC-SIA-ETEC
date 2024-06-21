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
    class controleLogin
    {

        public string cadastroCliente(LoginEmpresa mLogin)
        {
            string sql = "insert into Login(cnpjlogin, nomelogin, emaillogin, senhalogin) " + "values(@cnpjlogin, @nomelogin, @emaillogin, @senhalogin);" +
                "insert into login_telefone(cnpjlogin, telefonelogin) " + "values(@cnpjlogin, @telefonelogin)";
            
            conexaoBD con = new conexaoBD();
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
                comm.Parameters.AddWithValue("@emaillogin", mLogin.getEmail());
                comm.Parameters.AddWithValue("@senhalogin", hashSenha);
                comm.Parameters.AddWithValue("@telefonelogin", mLogin.getTelefone());

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
            string sql = "SELECT senhalogin FROM Login WHERE nomelogin = @nomelogin or emaillogin = @emaillogin";
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nomelogin", mLogin.getUsuario());
                comm.Parameters.AddWithValue("@emaillogin", mLogin.getEmail());

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
                        return "Usuário ou senha incorreta!";
                    }
                }
                else
                {
                    return "Usuário ou senha incorreta!";
                }
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}