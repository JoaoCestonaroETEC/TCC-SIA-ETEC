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
                " MARCAPECA = @MARCAPECA, UNIDADE = @UNIDADE," +
                " FORNECEDOR = @FORNECEDOR, DATAAQUISICAO = @DATAAQUISICAO," +
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
                return "Peça atualizada!";
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
                // Inicializa a conexão com o banco de dados
                conexaoBD conexao = new conexaoBD();
                using (NpgsqlConnection conn = conexao.conectar())
                {
                    if (conn == null)
                    {
                        return "Falha ao conectar ao banco de dados.";
                    }

                    // Inicia uma transação para garantir que todas as exclusões ocorram ou nenhuma seja aplicada
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Exclusões relacionadas à Pedido_Peca usando o ID da Peça
                            string sqlDeletePedidoPeca = @"
                            DELETE FROM Pedido_Peca 
                            WHERE idPeca = @idPeca;";
                            using (var cmdPeca = new NpgsqlCommand(sqlDeletePedidoPeca, conn))
                            {
                                cmdPeca.Parameters.AddWithValue("@idPeca", idPeca);
                                cmdPeca.ExecuteNonQuery();
                            }

                            // Exclusões relacionadas ao Pedido_Servico usando o ID da Peça (caso haja ligação entre a peça e o serviço)
                            string sqlDeletePedidoServico = @"
                            DELETE FROM Pedido_Servico 
                            WHERE idPedido IN (
                            SELECT idPedido FROM Pedido_Peca WHERE idPeca = @idPeca
                            );";
                            using (var cmdServico = new NpgsqlCommand(sqlDeletePedidoServico, conn))
                            {
                                cmdServico.Parameters.AddWithValue("@idPeca", idPeca);
                                cmdServico.ExecuteNonQuery();
                            }

                            // Exclusões relacionadas à Peça na tabela PECA
                            string sqlDeletePeca = @"
                            DELETE FROM PECA 
                            WHERE idPeca = @idPeca;";
                            using (var cmdPecaDelete = new NpgsqlCommand(sqlDeletePeca, conn))
                            {
                                cmdPecaDelete.Parameters.AddWithValue("@idPeca", idPeca);
                                int rowsPeca = cmdPecaDelete.ExecuteNonQuery();

                                if (rowsPeca <= 0)
                                {
                                    throw new Exception("Nenhuma peça encontrada com o ID fornecido.");
                                }
                            }

                            // Exclusão da Marca se a Peça relacionada à Marca for excluída (assumindo que a Marca está associada à Peça)
                            string sqlDeleteMarca = @"
                            DELETE FROM MARCA 
                            WHERE idMarca IN (
                            SELECT idMarca FROM PECA WHERE idPeca = @idPeca
                            );";
                            using (var cmdMarcaDelete = new NpgsqlCommand(sqlDeleteMarca, conn))
                            {
                                cmdMarcaDelete.Parameters.AddWithValue("@idPeca", idPeca);
                                cmdMarcaDelete.ExecuteNonQuery();
                            }

                            // Confirma a transação
                            transaction.Commit();
                            return $"Peça com ID {idPeca}, Marca relacionada e registros associados excluídos com sucesso.";
                        }
                        catch (Exception ex)
                        {
                            // Reverte a transação em caso de erro
                            transaction.Rollback();
                            return "Erro ao excluir registros relacionados à peça e marca: " + ex.Message;
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

        public void AtualizarIdPecaNoBanco(int idPedido, int idPecaAtual, int novoIdPeca)
        {
            // Criando a conexão com o banco
            conexaoBD conexao = new conexaoBD();

            try
            {
                using (NpgsqlConnection conn = conexao.conectar())
                {
                    string query = @"
                UPDATE pedido_peca
                SET idpeca = @idpeca
                WHERE idpedido = @idPedido";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        // Adiciona os parâmetros à query
                        cmd.Parameters.AddWithValue("@novoIdPeca", novoIdPeca);
                        cmd.Parameters.AddWithValue("@idPedido", idPedido);
                        cmd.Parameters.AddWithValue("@idPeca", idPecaAtual);

                        // Executa a atualização
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o banco de dados: {ex.Message}",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
