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
    internal class controleLogin
    {
        //Criação do método de cadastrar login
        public string cadastroLogin(LoginEmpresa mLogin)
        {
            //String sql de inserção
            string sql = "INSERT INTO LOGIN(CNPJLOGIN, NOMELOGIN, EMAILLOGIN, SENHALOGIN) " +
                "VALUES(@CNPJLOGIN, @NOMELOGIN, @EMAILLOGIN, @SENHALOGIN);" +
                "INSERT INTO LOGIN_TELEFONE(CNPJLOGIN, TELEFONE) " +
                "VALUES(@CNPJLOGIN, @TELEFONE)";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Transforma a senha definida do cadastro em uma variável
            string senhaTexto = mLogin.getSenha();

            //Cria o Hash da senha
            string hashSenha = BCrypt.Net.BCrypt.HashPassword(senhaTexto);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@CNPJLOGIN", mLogin.getCnpj());
                comm.Parameters.AddWithValue("@NOMELOGIN", mLogin.getNome());
                comm.Parameters.AddWithValue("@EMAILOGIN", mLogin.getEmail());
                comm.Parameters.AddWithValue("@SENHALOGIN", hashSenha);
                comm.Parameters.AddWithValue("@TELEFONE", mLogin.getTelefone());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Cliente cadastrado com sucesso!";
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando o erro
                return ex.ToString();
            }
        }

        //Criação do método de efetuar um login
        public string efetuarLogin(IdLogin mLogin)
        {
            //String sql de de consulta para verificar se o login está correto
            string sql = "SELECT senhalogin FROM Login WHERE nomelogin = @nomelogin or emaillogin = @emaillogin";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@nomelogin", mLogin.getUsuarioLogin());
                comm.Parameters.AddWithValue("@emaillogin", mLogin.getEmailLogin());

                //Deixando o hash nulo para usar depois
                string hashArmazenado = null;

                //Usando o DataReader para ler o valor da senha no banco
                using (NpgsqlDataReader reader = comm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //Transformando o valor da senha numa variável 
                        hashArmazenado = reader["senhalogin"].ToString();
                    }
                }

                //Checando o hash caso ele esteje nulo
                if (hashArmazenado != null)
                {
                    //Definindo o valor do método GetSenha numa variável
                    string senhaInserida = mLogin.getSenhaLogin();

                    //Verifica com um método boolean se a senha inserida é a mesma que a senha do banco
                    bool senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaInserida, hashArmazenado);

                    //Se o método retorna verdadeiro o login é efetuado
                    if (senhaCorreta)
                    {
                        return "Login efetuado!";
                    }
                    //Caso não, o usuário ou a senha está incorreta
                    else
                    {
                        return "Usuário ou senha incorreta!";
                    }
                }
                else
                {
                    //Caso não, o usuário ou a senha está incorreta
                    return "Usuário ou senha incorreta!";
                }
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando o erro
                return ex.ToString();
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }
        }
    }
}