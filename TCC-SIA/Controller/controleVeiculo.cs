using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;
using Npgsql;


namespace TCC_SIA.Controller
{
    internal class controleVeiculo
    {
        #region Cadastrar veículo
        //Criação do método de cadastrar veículo
        public string cadastroVeiculo(Veiculo mVeiculo)
        {
            //String sql de inserção
            string sql = "INSERT INTO VEICULO(CPFCLIENTE, IDMARCAVEICULO, NOMEVEICULO, TIPOVEICULO, CORVEICULO, PLACAVEICULO, MODELOVEICULO) " +
                "VALUES(@CPFCLIENTE, @IDMARCA, @NOMEVEICULO, @TIPOVEICULO, @CORVEICULO, @PLACAVEICULO, @MODELOVEICULO);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@CPFCLIENTE", mVeiculo.getCpfCliente());
                comm.Parameters.AddWithValue("@IDMARCA", mVeiculo.getIdMarca());
                comm.Parameters.AddWithValue("@NOMEVEICULO", mVeiculo.getNomeVeiculo());
                comm.Parameters.AddWithValue("@TIPOVEICULO", mVeiculo.getTipoVeiculo());
                comm.Parameters.AddWithValue("@CORVEICULO", mVeiculo.getCorVeiculo());
                comm.Parameters.AddWithValue("@PLACAVEICULO", mVeiculo.getPlacaVeiculo());
                comm.Parameters.AddWithValue("@MODELOVEICULO", mVeiculo.getModeloVeiculo());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Veículo cadastrado com sucesso!";
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando o erro
                return ex.ToString();
            }
            finally
            {
                //Método de desconectar
                con.desconectar();
            }
        }
        #endregion

        #region Listar veículo
        //Criação do método de listar cliente
        public NpgsqlDataReader listarVeiculo()
        {
            //String sql de listar
            string sql = "SELECT IDVEICULO, NOMEVEICULO FROM VEICULO";

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

        #region Listar veículo por cliente
        //Criação do método de listar veículo por cliente
        public NpgsqlDataReader listarVeiculoPorCliente(string cliente)
        {
            //String sql de listar
            string sql = "SELECT IDVEICULO, NOMEVEICULO FROM VEICULO WHERE CPFCLIENTE ='" + cliente + "';";

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

        #region Pesquisar veículo
        //Criação do método de pesquisar cliente
        public NpgsqlDataReader pesquisarVeiculo(string veiculo)
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM VEICULO WHERE NOMEVEICULO LIKE '" + veiculo + "%';";

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

        #region Pesquisar marca de veiculo por id
        //Criação do método de pesquisar marca de veículo por id
        public string pesquisaMarcaVeiculoPorId(string idMarca)
        {
            //String sql de pesquisar
            string sql = "SELECT NOMEMARCAVEICULO FROM MARCA_VEICULO WHERE IDMARCAVEICULO = '" + idMarca + "';";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {

                //Execute a consulta e retorne o resultado como string
                object result = comm.ExecuteScalar();
                return result != null ? result.ToString() : "Marca não encontrada";
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
