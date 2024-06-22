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
        #region Abrir conexão
        //Definindo os atributos para conexão com o banco
        static string server = "127.0.0.1";
        static string porta = "5432";
        static string user = "postgres";
        static string password = "123456";
        static string dataBase = "TCC-SIA";


        //Objetos necessários para comunicação
        NpgsqlConnection conn = null;

        //Srring de conexão com o banco
        string connString = "Server=" + server + ";Port=" + porta + ";UserID=" + user + ";password=" + password + ";dataBase=" + dataBase + ";";

        //Método para conectar no banco de dados
        public NpgsqlConnection conectar()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                //Abre a conexão com o banco de dados
                conn.Open();

                //Retornar o status da conexão
                return conn;
            }
            catch (NpgsqlException ex)//Executa se a conexão der erro
            {
                //A variável "ex" armazena o erro de conexão com o banco
                return null;
            }
        }
        #endregion

        #region Fechar conexão
        //Método para desconectar o banco de dados
        public NpgsqlConnection desconectar()
        {
            conn = new NpgsqlConnection(connString);
            try
            {
                //Fecha a conexão com o banco de dados
                conn.Close();

                //retornar o status da conexão
                return conn;
            }
            catch (NpgsqlException ex)//Executa se der erro
            {
                //A variavel "ex" armazena o erro de conexão com o banco
                return null;
            }
        }
        #endregion
    }
}
