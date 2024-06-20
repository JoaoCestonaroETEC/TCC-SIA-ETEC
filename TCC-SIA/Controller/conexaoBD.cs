using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TCC_SIA.Controller
{
    internal class conexaoBD
    {
        static string server = "127.0.0.1";
        static string porta = "5432";
        static string user = "postgres";
        static string password = "123456";
        static string dataBase = "TCC-SIA";


        //objetos necessários para comunicação
        NpgsqlConnection conn = null;

        string connString = "Server=" + server + ";Port=" + porta + ";UserID=" + user + ";password=" + password + ";dataBase=" + dataBase + ";";

        //metodo para conectar no banco de dados
        public NpgsqlConnection conectar()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                //abre a conexão com o banco de dados
                conn.Open();

                //retornar o status da conexão
                return conn;
            }
            catch (NpgsqlException ex)//executa se a conexão der erro
            {
                //a variavel ex armazena o erro de conexão com o banco
                return null;
            }
        }

        //metodo para desconectar o banco de dados (só muda open para close)
        public NpgsqlConnection desconectar()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                //abre a conexão com o banco de dados
                conn.Close();

                //retornar o status da conexão
                return conn;
            }
            catch (NpgsqlException ex)//executa se a conexão der erro
            {
                //a variavel ex armazena o erro de conexão com o banco
                return null;
            }
        }
    }
}
