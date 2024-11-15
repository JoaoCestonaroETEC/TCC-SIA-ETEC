using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        #region Listar novas marca
        //Criação do método de listar marca
        public NpgsqlDataReader listarNovasMarca()
        {
            //String sql de listar
            string sql = "SELECT * FROM MARCA WHERE TIPOMARCA NOT IN ('Peças Automotívas', 'Óleos lubrificantes', 'Pneus', 'Ferramentas e Equipamentos para oficinas', 'Veiculos');";

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

        #region Atualizar Marca
        public string atualizaMarca(Marca mMarca)
        {
            string sqlCount = "SELECT COUNT(*) FROM marca WHERE idmarca = @idmarca;";
            string sqlUpdate = "UPDATE marca SET nomemarca = @nomemarca, descmarca = @descmarca, tipomarca = @tipomarca WHERE idmarca = @idmarca;";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();

            try
            {
                // Verifica se existe exatamente uma linha com o idmarca fornecido
                using (NpgsqlCommand countComm = new NpgsqlCommand(sqlCount, conn))
                {
                    countComm.Parameters.AddWithValue("@idmarca", mMarca.getIdMarca());

                    int rowCount = Convert.ToInt32(countComm.ExecuteScalar());

                    if (rowCount == 0)
                    {
                        return "Nenhuma linha encontrada para atualizar.";
                    }
                    else if (rowCount > 1)
                    {
                        return "Selecione penas uma linha";
                    }
                }

                // Continua para o update apenas se houver exatamente uma linha correspondente
                using (NpgsqlCommand updateComm = new NpgsqlCommand(sqlUpdate, conn))
                {
                    updateComm.Parameters.AddWithValue("@idmarca", mMarca.getIdMarca());
                    updateComm.Parameters.AddWithValue("@nomemarca", mMarca.getNomeMarca());
                    updateComm.Parameters.AddWithValue("@descmarca", mMarca.getDescMarca());
                    updateComm.Parameters.AddWithValue("@tipomarca", mMarca.getTipoMarca());

                    int rowsAffected = updateComm.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return "Serviço atualizado com sucesso!";
                    }
                    else
                    {
                        return "Nenhuma linha foi atualizada.";
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                return "Erro ao atualizar: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        public string deletarMarca(Marca mMarca)
        {
            // Obtém o ID da MARCA usando o método getter
            long idMarca = mMarca.getIdMarca();

            try
            {
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
                            // Deleta os registros da tabela MARCA
                            string sqlDeleteMarca = "DELETE FROM MARCA WHERE IDMARCA = @IDMARCA;";
                            using (var cmdMarca = new NpgsqlCommand(sqlDeleteMarca, conn))
                            {
                                cmdMarca.Parameters.AddWithValue("@IDMARCA", idMarca);
                                int rowsAffected = cmdMarca.ExecuteNonQuery();

                                // Verifica se a marca foi excluída
                                if (rowsAffected > 0)
                                {
                                    // Confirma a transação
                                    transaction.Commit();
                                    return $"Marca com ID {idMarca} excluída com sucesso.";
                                }
                                else
                                {
                                    throw new Exception("Nenhuma marca encontrada com o ID fornecido.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Reverte a transação em caso de erro
                            transaction.Rollback();
                            return "Erro ao excluir marca: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Erro ao conectar ao banco de dados: " + ex.Message;
            }
        }
    }
}
