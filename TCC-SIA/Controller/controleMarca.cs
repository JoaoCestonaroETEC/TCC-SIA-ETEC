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
        #region Cadastrar marca de veículo
        //Criação do método de cadastrar marca de veículo
        public string cadastroMarcaVeiculo(Marca mMarca)
        {
            //String sql de inserção
            string sql = "INSERT INTO MARCA_VEICULO(NOMEMARCAVEICULO, DESCMARCAVEICULO) " +
                "VALUES(@NOMEMARCAVEICULO, @DESCMARCAVEICULO);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@NOMEMARCAVEICULO", mMarca.getNomeMarca());
                comm.Parameters.AddWithValue("@DESCMARCAVEICULO", mMarca.getDescMarca());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Marca de veículo cadastrada com sucesso!";
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

        #region Cadastrar marca de peça
        //Criação do método de cadastrar marca de peça
        public string cadastroMarcaPeca(Marca mMarca)
        {
            //String sql de inserção
            string sql = "INSERT INTO MARCA_PECA(NOMEMARCAPECA, DESCMARCAPECA) " +
                "VALUES(@NOMEMARCAPECA, @DESCMARCAPECA);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@NOMEMARCAPECA", mMarca.getNomeMarca());
                comm.Parameters.AddWithValue("@DESCMARCAPECA", mMarca.getDescMarca());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Marca de peça cadastrada com sucesso!";
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

        #region Listar marca de veículo
        //Criação do método de listar marca de veículo
        public NpgsqlDataReader listarMarcaVeiculo()
        {
            //String sql de listar
            string sql = "SELECT IDMARCAVEICULO, NOMEMARCAVEICULO FROM MARCA_VEICULO;";

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

        #region Listar marca de peça
        //Criação do método de listar marca de peça
        public NpgsqlDataReader listarMarcaPeca()
        {
            //String sql de listar
            string sql = "SELECT IDMARCAPECA, NOMEMARCAPECA FROM MARCA_PECA;";

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

        #region Pesquisar marca de veículo
        //Criação do método de pesquisar marca de veículo
        public NpgsqlDataReader pesquisaMarcaVeiculo(string marca)
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM MARCA_VEICULO WHERE NOMEMARCAVEICULO LIKE '" + marca + "%';";

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

        #region Pesquisar marca de peça
        //Criação do método de pesquisar marca de peça
        public NpgsqlDataReader pesquisaMarcaPeca(string marca)
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM MARCA_PECA WHERE NOMEMARCAPECA LIKE '" + marca + "%';";

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
