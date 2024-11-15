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
            //String SQL de inserção
            string sqlVef = "SELECT COUNT(1) FROM PECA WHERE NOMEPECA = @NOMEPECA AND IDMARCA = @IDMARCA AND FORNECEDOR = @FORNECEDOR AND TIPOPECA = @TIPOPECA";

            //String sql de inserção
            string sql = "INSERT INTO PECA(IDMARCA, NOMEPECA, TIPOPECA, DESCPECA, VALORPECA, UNIDADE, QUANTPECA, GARANTIAPECA, FORNECEDOR, DATA_AQUISICAO) " +
                "VALUES(@IDMARCA, @NOMEPECA, @TIPOPECA, @DESCPECA, @VALORPECA, @UNIDADE, @QUANTPECA, @GARANTIAPECA, @FORNECEDORPECA, @DATAAQUIS);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            NpgsqlCommand commVef = new NpgsqlCommand(sqlVef, conn);

            //Fazendo o try
            try
            {
                //Faz a verificação de o CPF já existe no Banco
                commVef.Parameters.AddWithValue("@NOMEPECA", mPeca.getNomePeca());
                commVef.Parameters.AddWithValue("@IDMARCA", mPeca.getIdMarca());
                commVef.Parameters.AddWithValue("@FORNECEDOR", mPeca.getFornecedor());
                commVef.Parameters.AddWithValue("@TIPOPECA", mPeca.getTipoPeca());
                int pecaExists = Convert.ToInt32(commVef.ExecuteScalar());

                if (pecaExists > 0)
                {
                    return "Peça já cadastrada no sistema.";
                }

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

        #region Listar Tipo
        //Criação do método de listar peça
        public NpgsqlDataReader listaTipo()
        {
            //String sql de listar
            string sql = "SELECT DISTINCT TIPOPECA FROM PECA WHERE TIPOPECA != 'Motor' AND TIPOPECA != 'Suspensão e Direção' AND TIPOPECA != 'Freio' AND TIPOPECA != 'Transmissão' AND TIPOPECA != 'Elétrica' AND TIPOPECA != 'Arrefecimento' AND TIPOPECA != 'Escape' AND TIPOPECA != 'Estética e Acabamento' AND TIPOPECA != 'Combustível' AND TIPOPECA != 'Pneumáticos' AND TIPOPECA != 'Outro';";

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

        #region Listar fornecedor
        //Criação do método de listar peça
        public NpgsqlDataReader listaFornecedor()
        {
            //String sql de listar
            string sql = "SELECT DISTINCT FORNECEDOR FROM PECA;";

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
            string sql = "SELECT NOMEMARCA FROM MARCA WHERE IDMARCA = '"+ idMarca+ "';";

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

        public string deletarPeca (Peca mPeca)
        {
            // Get the ID from the Peca object using its getter method
            long idPeca = mPeca.getIdPeca();

            try
            {
                // Using the conexaoBD class to establish a connection
                conexaoBD conexao = new conexaoBD();
                using (NpgsqlConnection conn = conexao.conectar())
                {
                    if (conn == null)
                    {
                        return "Failed to connect to the database.";
                    }

                    // SQL query to delete the part based on its ID
                    string query = "DELETE FROM Peca WHERE idPeca = @idPeca";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Add the ID parameter to the SQL command
                        cmd.Parameters.AddWithValue("@idPeca", idPeca);

                        // Execute the delete command and check if a row was affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Return success or error message based on the result
                        if (rowsAffected > 0)
                        {
                            return "Part deleted successfully.";
                        }
                        else
                        {
                            return "No part found with the provided ID.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Return an error message if an exception occurs
                return "Error deleting part: " + ex.Message;
            }
        }
    }
}
