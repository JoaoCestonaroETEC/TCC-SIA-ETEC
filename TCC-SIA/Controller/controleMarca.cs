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
        public string cadastroMarcaVeiculo(Marca mMarca)
        {
            //String SQL de inserção
            string sqlVef = "SELECT COUNT(1) FROM MARCA WHERE NOMEMARCA = @NOMEMARCA AND TIPOMARCA = @TIPOMARCA";
            //String sql de inserção
            string sql = "INSERT INTO MARCA(NOMEMARCA, DESCMARCA, TIPOMARCA) " +
                "VALUES(@NOMEMARCA, @DESCMARCA, @TIPOMARCA);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            NpgsqlCommand commVef = new NpgsqlCommand(sqlVef, conn);

            //Fazendo o try
            try
            {
                //Faz a verificação de o CPF já existe no Banco
                commVef.Parameters.AddWithValue("@NOMEMARCA", mMarca.getNomeMarca());
                commVef.Parameters.AddWithValue("@TIPOMARCA", mMarca.getTipoMarca());
                int marcaExists = Convert.ToInt32(commVef.ExecuteScalar());

                if (marcaExists > 0)
                {
                    return "Marca já cadastrada no sistema.";
                }

                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@NOMEMARCA", mMarca.getNomeMarca());
                comm.Parameters.AddWithValue("@DESCMARCA", mMarca.getDescMarca());
                comm.Parameters.AddWithValue("@TIPOMARCA", mMarca.getTipoMarca());

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
            string sql = "SELECT * FROM MARCA;";

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

        #region Listar marca só de veiculos
        //Criação do método de listar marca
        public NpgsqlDataReader listarMarcaVeiculos()
        {
            //String sql de listar
            string sql = "SELECT * FROM MARCA WHERE TIPOMARCA LIKE '%Veiculos';";

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
        public NpgsqlDataReader pesquisaMarca(string marca, string tipo)
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM MARCA WHERE NOMEMARCA LIKE '" + marca + "%' AND TIPOMARCA LIKE '" + tipo + "%';";

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
