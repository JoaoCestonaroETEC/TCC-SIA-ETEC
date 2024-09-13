using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controlePeca
    {
        #region Cadastrar peça
        //Criação do método de cadastrar peça
        public string cadastroPeca(Peca mPeca)
        {
            //String sql de inserção
            string sql = "INSERT INTO PECA(IDMARCAPECA, NOMEPECA, TIPOPECA, DESCPECA, VALORPECA, UNIDADE, QUANTPECA, GARANTIAPECA, FORNECEDOR, DATA_AQUISICAO) " +
                "VALUES(@IDMARCA, @NOMEPECA, @TIPOPECA, @DESCPECA, @VALORPECA, @UNIDADE, @QUANTPECA, @GARANTIAPECA, @FORNECEDORPECA, @DATAAQUIS);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@IDMARCA", mPeca.getIdMarca());
                comm.Parameters.AddWithValue("@NOMEPECA", mPeca.getNomePeca());
                comm.Parameters.AddWithValue("@TIPOPECA", mPeca.getTipoPeca());
                comm.Parameters.AddWithValue("@DESCPECA", mPeca.getDescPeca());
                comm.Parameters.AddWithValue("@VALORPECA", mPeca.getValorPeca());
                comm.Parameters.AddWithValue("@UNIDADE", mPeca.getUnidade());
                comm.Parameters.AddWithValue("@QUANTPECA", mPeca.getQuantPeca());
                comm.Parameters.AddWithValue("@GARANTIAPECA", mPeca.getGarantiaPeca());
                comm.Parameters.AddWithValue("@FORNECEDORPECA", mPeca.getFornecedor());
                comm.Parameters.AddWithValue("@DATAAQUIS", mPeca.getDataAquisicao());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Peça cadastrado com sucesso!";
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

        #region Listar peça
        //Criação do método de listar peça
        public NpgsqlDataReader listaPeca()
        {
            //String sql de listar
            string sql = "SELECT * FROM PECA;";

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

        #region Pesquisar peça
        //Criação do método de pesquisar peça
        public NpgsqlDataReader pesquisaPeca(string peca)
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM PECA WHERE NOMEPECA LIKE '" + peca + "%';";

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

        //Criação do método de pesquisar peça do pedido
        public NpgsqlDataReader pesquisaPecaParaOPedido(string peca)
        {
            //String sql de pesquisar
            string sql = "SELECT IDMARCAPECA FROM PECA WHERE NOMEPECA LIKE '" + peca + "%';";

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

        #region Pesquisar marca de peça por id
        //Criação do método de pesquisar marca de peça por id
        public string pesquisaMarcaPecaPorId(string idMarca)
        {
            //String sql de pesquisar
            string sql = "SELECT NOMEMARCAPECA FROM MARCA_PECA WHERE IDMARCAPECA = '"+ idMarca+ "';";

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

        public string atualizaPeca (Peca mPeca)
        {
            string sql = "UPDATE PECA SET  NOMEPECA = @NOMEPECA, "+
                " TIPOPECA = @TIPOPECA, DESCPECA = @DESCPECA," + 
                " VALORPECA = @VALORPECA, QUANTPECA = @QUANTPECA," + 
                " GARANTIAPECA = @GARANTIAPECA WHERE IDPECA = @IDPECA";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@IDPECA", mPeca.getIdPeca());
                comm.Parameters.AddWithValue("@NOMEPECA", mPeca.getNomePeca());
                comm.Parameters.AddWithValue("@TIPOPECA", mPeca.getTipoPeca());
                comm.Parameters.AddWithValue("@DESCPECA", mPeca.getDescPeca());
                comm.Parameters.AddWithValue("@VALORPECA", mPeca.getValorPeca());
                comm.Parameters.AddWithValue("@QUANTPECA", mPeca.getQuantPeca());
                comm.Parameters.AddWithValue("@GARANTIAPECA", mPeca.getGarantiaPeca());

                comm.ExecuteNonQuery();
                return "Cliente atualizado!";
            }
            catch(NpgsqlException ex)
            {
                return ex.ToString();
                //return "Erro ao atualizar!";
            }
        }
    }
}
