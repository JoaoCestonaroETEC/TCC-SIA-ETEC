using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controleMarca
    {
        #region Cadastrar marca
        //Criação do método de cadastrar marca
        public string cadastroMarca(Marca mMarca)
        {
            //String sql de inserção
            string sql = "INSERT INTO MARCA(NOMEMARCA, DESCMARCA) " +
                "VALUES(@NOMEMARCA, @DESCMARCA);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@NOMEMARCA", mMarca.getNomeMarca());
                comm.Parameters.AddWithValue("@DESCMARCA", mMarca.getDescMarca());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Marca cadastrada com sucesso!";
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
        #endregion

        #region Listar marca
        //Criação do método de listar marca
        public NpgsqlDataReader listarMarca()
        {
            //String sql de listar
            string sql = "SELECT IDMARCA, NOMEMARCA FROM MARCA;";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Retornando os valores
                return comm.ExecuteReader();
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando como nulo
                return null;
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }

        }
        #endregion

        #region Pesquisar marca
        //Criação do método de pesquisar marca
        public NpgsqlDataReader pesquisaMarca(string marca)
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM MARCA WHERE NOMEMARCA LIKE '" + marca + "%';";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Retornando os valores
                return comm.ExecuteReader();
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando como nulo
                return null;
            }
            //Encerrando a conexão
            finally
            {
                //Método de desconectar
                con.desconectar();
            }

        }
        #endregion
    }
}
