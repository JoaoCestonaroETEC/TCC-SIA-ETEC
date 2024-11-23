using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;
using System.Text.RegularExpressions;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace TCC_SIA.Controller
{
    internal class controleCliente
    {
        #region Cadastrar cliente físico
        //Criação do método de cadastrar cliente
        public string cadastroClienteF(Cliente mCliente)
        {
            //String SQL de inserção
            string sqlVef = "SELECT C.IDCLIENTE, F.CPFCLIENTE FROM CLIENTE C INNER JOIN CLIENTE_F F ON C.IDCLIENTE = F.IDCLIENTE WHERE NOMECLIENTE = @NOMECLIENTE AND CPFCLIENTE = @CPFCLIENTE;";

            // Inserir na tabela CLIENTE (Cliente base)
            string sql = "INSERT INTO CLIENTE(NOMECLIENTE, EMAILCLIENTE, DATA, STATUS) " +
                "VALUES(@NOMECLIENTE, @EMAILCLIENTE, @DATA, @STATUS) RETURNING IDCLIENTE;";

            // Inserir na tabela CLIENTE_F (Cliente Físico)
            string sqlFisico = "INSERT INTO CLIENTE_F(IDCLIENTE, CPFCLIENTE, DATANASC_CLIENTE, SEXO, OBS) " +
                "VALUES(@IDCLIENTE, @CPFCLIENTE, @DATANASC_CLIENTE, @SEXO, @OBS);";

            // Inserir na tabela CLIENTE_ENDERECO
            string sql3 = "INSERT INTO CLIENTE_ENDERECO(IDCLIENTE, NUMERO, RUA, CIDADE, CEP, BAIRRO, ESTADO) " +
                "VALUES(@IDCLIENTE, @NUMERO, @RUA, @CIDADE, @CEP, @BAIRRO, @ESTADO);";

            // Inserir na tabela CLIENTE_TELEFONE
            string sql4 = "INSERT INTO CLIENTE_TELEFONE(IDCLIENTE, TELEFONE) " +
                "VALUES(@IDCLIENTE, @TELEFONE);";


            // Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand commVef = new NpgsqlCommand(sqlVef, conn);
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            NpgsqlCommand commFisico = new NpgsqlCommand(sqlFisico, conn);
            NpgsqlCommand comm3 = new NpgsqlCommand(sql3, conn);
            NpgsqlCommand comm4 = new NpgsqlCommand(sql4, conn);

            try
            {
                //Faz a verificação de o CPF já existe no Banco
                commVef.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                commVef.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                int cpfExists = Convert.ToInt32(commVef.ExecuteScalar());

                if (cpfExists > 0)
                {
                    return "Cliente já cadastrado no sistema.";
                }

                commVef.ExecuteNonQuery();
                // Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@DATA", mCliente.getData());
                comm.Parameters.AddWithValue("@STATUS", mCliente.getStatus());

                // Executa a query e retorna o ID do cliente
                var idCliente = (int)comm.ExecuteScalar();

                // Definindo os valores a serem postos nos campos CLIENTE_F
                commFisico.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                commFisico.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                commFisico.Parameters.AddWithValue("@DATANASC_CLIENTE", mCliente.getDataNascCliente());
                commFisico.Parameters.AddWithValue("@SEXO", mCliente.getSexo());
                commFisico.Parameters.AddWithValue("@OBS", mCliente.getObs());

                commFisico.ExecuteNonQuery();

                // Definindo os valores a serem postos nos campos
                comm3.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm3.Parameters.AddWithValue("@NUMERO", mCliente.getNumero());
                comm3.Parameters.AddWithValue("@RUA", mCliente.getRua());
                comm3.Parameters.AddWithValue("@CIDADE", mCliente.getCidade());
                comm3.Parameters.AddWithValue("@CEP", mCliente.getCep());
                comm3.Parameters.AddWithValue("@BAIRRO", mCliente.getBairro());
                comm3.Parameters.AddWithValue("@ESTADO", mCliente.getUf());

                comm3.ExecuteNonQuery();

                // Definindo os valores a serem postos nos campos
                comm4.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm4.Parameters.AddWithValue("@TELEFONE", mCliente.getTelefone());

                comm4.ExecuteNonQuery();

                // Retornando um valor
                return "Cliente cadastrado com sucesso!";
            }
            catch (Exception ex)  // Capturando todas as exceções para melhor diagnóstico
            {
                // Retornando o erro
                return ex.ToString();
            }
            finally
            {
                // Encerrando a conexão
                con.desconectar();
            }
        }
        #endregion

        #region Cadastrar cliente júridico
        //Criação do método de cadastrar cliente
        public string cadastroClienteJ(Cliente mCliente)
        {
            //String SQL de inserção
            string sqlVef = "SELECT C.IDCLIENTE, J.CNPJCLIENTE FROM CLIENTE C INNER JOIN CLIENTE_J J ON C.IDCLIENTE = J.IDCLIENTE WHERE NOMECLIENTE = @NOMECLIENTE AND CNPJCLIENTE = @CNPJCLIENTE;";

            // Inserir na tabela CLIENTE (Cliente base)
            string sql = "INSERT INTO CLIENTE(NOMECLIENTE, EMAILCLIENTE, DATA, STATUS) " +
                "VALUES(@NOMECLIENTE, @EMAILCLIENTE, @DATA, @STATUS) RETURNING IDCLIENTE;";

            // Inserir na tabela CLIENTE_J (Cliente Físico)
            string sqlJuridico = "INSERT INTO CLIENTE_J(IDCLIENTE, CNPJCLIENTE, RAZAO) " +
                "VALUES(@IDCLIENTE, @CNPJCLIENTE, @RAZAO);";

            // Inserir na tabela CLIENTE_ENDERECO
            string sql3 = "INSERT INTO CLIENTE_ENDERECO(IDCLIENTE, NUMERO, RUA, CIDADE, CEP, BAIRRO, ESTADO) " +
                "VALUES(@IDCLIENTE, @NUMERO, @RUA, @CIDADE, @CEP, @BAIRRO, @ESTADO);";

            // Inserir na tabela CLIENTE_TELEFONE
            string sql4 = "INSERT INTO CLIENTE_TELEFONE(IDCLIENTE, TELEFONE) " +
                "VALUES(@IDCLIENTE, @TELEFONE);";


            // Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand commVef = new NpgsqlCommand(sqlVef, conn);
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            NpgsqlCommand commJuridico = new NpgsqlCommand(sqlJuridico, conn);
            NpgsqlCommand comm3 = new NpgsqlCommand(sql3, conn);
            NpgsqlCommand comm4 = new NpgsqlCommand(sql4, conn);

            try
            {
                //Faz a verificação de o CPF já existe no Banco
                commVef.Parameters.AddWithValue("@CNPJCLIENTE", mCliente.getCNPJCliente());
                commVef.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                int cpfExists = Convert.ToInt32(commVef.ExecuteScalar());

                if (cpfExists > 0)
                {
                    return "Cliente já cadastrado no sistema.";
                }

                commVef.ExecuteNonQuery();
                // Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@DATA", mCliente.getData());
                comm.Parameters.AddWithValue("@STATUS", mCliente.getStatus());

                // Executa a query e retorna o ID do cliente
                var idCliente = (int)comm.ExecuteScalar();

                // Definindo os valores a serem postos nos campos CLIENTE_F
                commJuridico.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                commJuridico.Parameters.AddWithValue("@CNPJCLIENTE", mCliente.getCNPJCliente());
                commJuridico.Parameters.AddWithValue("@RAZAO", mCliente.getRazao());

                commJuridico.ExecuteNonQuery();

                // Definindo os valores a serem postos nos campos
                comm3.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm3.Parameters.AddWithValue("@NUMERO", mCliente.getNumero());
                comm3.Parameters.AddWithValue("@RUA", mCliente.getRua());
                comm3.Parameters.AddWithValue("@CIDADE", mCliente.getCidade());
                comm3.Parameters.AddWithValue("@CEP", mCliente.getCep());
                comm3.Parameters.AddWithValue("@BAIRRO", mCliente.getBairro());
                comm3.Parameters.AddWithValue("@ESTADO", mCliente.getUf());

                comm3.ExecuteNonQuery();

                // Definindo os valores a serem postos nos campos
                comm4.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm4.Parameters.AddWithValue("@TELEFONE", mCliente.getTelefone());

                comm4.ExecuteNonQuery();

                // Retornando um valor
                return "Cliente cadastrado com sucesso!";
            }
            catch (Exception ex)  // Capturando todas as exceções para melhor diagnóstico
            {
                // Retornando o erro
                return ex.ToString();
            }
            finally
            {
                // Encerrando a conexão
                con.desconectar();
            }
        }
        #endregion

        #region Listar cliente
        //Criação do método de listar cliente
        public NpgsqlDataReader listarCliente()
        {
            //String sql de listar
            string sql = "SELECT * FROM CLIENTE;";

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

        #region Pesquisar cliente
        //Criação do método de pesquisar cliente
        public NpgsqlDataReader pesquisarClienteF(string cliente)
        {
            //String sql de pesquisar
            string sql = "SELECT C.IDCLIENTE, C.NOMECLIENTE, C.EMAILCLIENTE, C.DATA, C.STATUS, " +
             "F.CPFCLIENTE, F.DATANASC_CLIENTE, F.SEXO, F.OBS, " +
             "E.NUMERO, E.RUA, E.CIDADE, E.CEP, E.BAIRRO, E.ESTADO, " +
             "T.TELEFONE " +
             "FROM CLIENTE C " +
             "INNER JOIN CLIENTE_F F ON C.IDCLIENTE = F.IDCLIENTE " +
             "INNER JOIN CLIENTE_ENDERECO E ON C.IDCLIENTE = E.IDCLIENTE " +
             "INNER JOIN CLIENTE_TELEFONE T ON C.IDCLIENTE = T.IDCLIENTE " +
             "WHERE C.NOMECLIENTE LIKE '" + cliente + "%'";


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

        #region Pesquisar cliente
        //Criação do método de pesquisar cliente
        public NpgsqlDataReader pesquisarClienteJ(string cliente)
        {
            //String sql de pesquisar
            string sql = "SELECT C.IDCLIENTE, C.NOMECLIENTE, C.EMAILCLIENTE, C.DATA, C.STATUS, " +
             "J.CNPJCLIENTE, J.RAZAO, " +
             "E.NUMERO, E.RUA, E.CIDADE, E.CEP, E.BAIRRO, E.ESTADO, " +
             "T.TELEFONE " +
             "FROM CLIENTE C " +
             "INNER JOIN CLIENTE_J J ON C.IDCLIENTE = J.IDCLIENTE " +
             "INNER JOIN CLIENTE_ENDERECO E ON C.IDCLIENTE = E.IDCLIENTE " +
             "INNER JOIN CLIENTE_TELEFONE T ON C.IDCLIENTE = T.IDCLIENTE " +
             "WHERE C.NOMECLIENTE LIKE '" + cliente + "%'";

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

        public string atualizaClienteF(Cliente mClienteJ)
        {
            // Primeira query com RETURNING para obter o IDCLIENTE
            string sqlUpdateCliente = "UPDATE CLIENTE SET NOMECLIENTE = @NOMECLIENTE, " +
                "EMAILCLIENTE = @EMAILCLIENTE, DATA = @DATA, STATUS = @STATUS " +
                "WHERE IDCLIENTE = @IDCLIENTE RETURNING IDCLIENTE;";

            // Outras queries separadas para as atualizações subsequentes
            string sqlUpdateClienteF = "UPDATE CLIENTE_F SET CPFCLIENTE = @CPFCLIENTE, " +
                "DATANASC_CLIENTE = @DATANASC_CLIENTE, SEXO = @SEXO, OBS = @OBS " +
                "WHERE IDCLIENTE = @IDCLIENTE;";

            string sqlUpdateEndereco = "UPDATE CLIENTE_ENDERECO SET NUMERO = @NUMERO, " +
                "RUA = @RUA, CIDADE = @CIDADE, CEP = @CEP, BAIRRO = @BAIRRO, ESTADO = @ESTADO " +
                "WHERE IDCLIENTE = @IDCLIENTE;";

            string sqlUpdateTelefone = "UPDATE CLIENTE_TELEFONE SET TELEFONE = @TELEFONE " +
                "WHERE IDCLIENTE = @IDCLIENTE;";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();

            try
            {
                // Comando para atualizar CLIENTE e retornar o IDCLIENTE
                NpgsqlCommand comm = new NpgsqlCommand(sqlUpdateCliente, conn);
                comm.Parameters.AddWithValue("@NOMECLIENTE", mClienteJ.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mClienteJ.getEmailCliente());
                comm.Parameters.AddWithValue("@DATA", mClienteJ.getData());
                comm.Parameters.AddWithValue("@STATUS", mClienteJ.getStatus());
                comm.Parameters.AddWithValue("@IDCLIENTE", mClienteJ.getIdCliente());

                // Executa e recupera o IDCLIENTE
                var idCliente = (int)comm.ExecuteScalar();

                // Atualiza CLIENTE_F
                comm.CommandText = sqlUpdateClienteF;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm.Parameters.AddWithValue("@CPFCLIENTE", mClienteJ.getCpfCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE", mClienteJ.getDataNascCliente());
                comm.Parameters.AddWithValue("@SEXO", mClienteJ.getSexo());
                comm.Parameters.AddWithValue("@OBS", mClienteJ.getObs()); 
                comm.ExecuteNonQuery();

                // Atualiza ENDERECO_CLIENTE
                comm.CommandText = sqlUpdateEndereco;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm.Parameters.AddWithValue("@NUMERO", mClienteJ.getNumero());
                comm.Parameters.AddWithValue("@RUA", mClienteJ.getRua());
                comm.Parameters.AddWithValue("@CIDADE", mClienteJ.getCidade());
                comm.Parameters.AddWithValue("@CEP", mClienteJ.getCep());
                comm.Parameters.AddWithValue("@BAIRRO", mClienteJ.getBairro());
                comm.Parameters.AddWithValue("@ESTADO", mClienteJ.getUf());
                comm.ExecuteNonQuery();

                // Atualiza TELEFONE_CLIENTE
                comm.CommandText = sqlUpdateTelefone;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm.Parameters.AddWithValue("@TELEFONE", mClienteJ.getTelefone());
                comm.ExecuteNonQuery();

                return "Cliente atualizado!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString(); // Para debug, talvez seja melhor logar isso em vez de retornar como string.
            }
        }

        public string atualizaClienteJ(Cliente mClienteJ)
        {
            // Primeira query com RETURNING para obter o IDCLIENTE
            string sqlUpdateCliente = "UPDATE CLIENTE SET NOMECLIENTE = @NOMECLIENTE, " +
                "EMAILCLIENTE = @EMAILCLIENTE, DATA = @DATA, STATUS = @STATUS " +
                "WHERE IDCLIENTE = @IDCLIENTE RETURNING IDCLIENTE;";

            // Outras queries separadas para as atualizações subsequentes
            string sqlUpdateClienteJ = "UPDATE CLIENTE_J SET CNPJCLIENTE = @CNPJCLIENTE, " +
                "RAZAO = @RAZAO WHERE IDCLIENTE = @IDCLIENTE;";

            string sqlUpdateEndereco = "UPDATE CLIENTE_ENDERECO SET NUMERO = @NUMERO, " +
                "RUA = @RUA, CIDADE = @CIDADE, CEP = @CEP, BAIRRO = @BAIRRO, ESTADO = @ESTADO " +
                "WHERE IDCLIENTE = @IDCLIENTE;";

            string sqlUpdateTelefone = "UPDATE CLIENTE_TELEFONE SET TELEFONE = @TELEFONE " +
                "WHERE IDCLIENTE = @IDCLIENTE;";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();

            try
            {
                // Comando para atualizar CLIENTE e retornar o IDCLIENTE
                NpgsqlCommand comm = new NpgsqlCommand(sqlUpdateCliente, conn);
                comm.Parameters.AddWithValue("@NOMECLIENTE", mClienteJ.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mClienteJ.getEmailCliente());
                comm.Parameters.AddWithValue("@DATA", mClienteJ.getData());
                comm.Parameters.AddWithValue("@STATUS", mClienteJ.getStatus());
                comm.Parameters.AddWithValue("@IDCLIENTE", mClienteJ.getIdCliente());

                // Executa e recupera o IDCLIENTE
                var idCliente = (int)comm.ExecuteScalar();

                // Atualiza CLIENTE_F
                comm.CommandText = sqlUpdateClienteJ;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm.Parameters.AddWithValue("@CNPJCLIENTE", mClienteJ.getCNPJCliente());
                comm.Parameters.AddWithValue("@RAZAO", mClienteJ.getRazao());
                comm.ExecuteNonQuery();

                // Atualiza ENDERECO_CLIENTE
                comm.CommandText = sqlUpdateEndereco;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm.Parameters.AddWithValue("@NUMERO", mClienteJ.getNumero());
                comm.Parameters.AddWithValue("@RUA", mClienteJ.getRua());
                comm.Parameters.AddWithValue("@CIDADE", mClienteJ.getCidade());
                comm.Parameters.AddWithValue("@CEP", mClienteJ.getCep());
                comm.Parameters.AddWithValue("@BAIRRO", mClienteJ.getBairro());
                comm.Parameters.AddWithValue("@ESTADO", mClienteJ.getUf());
                comm.ExecuteNonQuery();

                // Atualiza TELEFONE_CLIENTE
                comm.CommandText = sqlUpdateTelefone;
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm.Parameters.AddWithValue("@TELEFONE", mClienteJ.getTelefone());
                comm.ExecuteNonQuery();

                return "Cliente atualizado!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString(); // Para debug, talvez seja melhor logar isso em vez de retornar como string.
            }
        }

        public string DeletarClienteF(Cliente mClienteF)
        {
            // Obtém o ID do CLIENTE usando o método getter
            long idCliente = mClienteF.getIdCliente();

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
                            // Exclusões relacionadas ao PEDIDO usando o ID do CLIENTE
                            string sqlDeletePedidoPeca = @"
                    DELETE FROM Pedido_Peca 
                    WHERE idPedido IN (
                        SELECT idPedido FROM Pedido WHERE idCliente = @idCliente
                    );";
                            using (var cmdPeca = new NpgsqlCommand(sqlDeletePedidoPeca, conn))
                            {
                                cmdPeca.Parameters.AddWithValue("@idCliente", idCliente);
                                cmdPeca.ExecuteNonQuery();
                            }

                            string sqlDeletePedidoServico = @"
                    DELETE FROM Pedido_Servico 
                    WHERE idPedido IN (
                        SELECT idPedido FROM Pedido WHERE idCliente = @idCliente
                    );";
                            using (var cmdServico = new NpgsqlCommand(sqlDeletePedidoServico, conn))
                            {
                                cmdServico.Parameters.AddWithValue("@idCliente", idCliente);
                                cmdServico.ExecuteNonQuery();
                            }

                            string sqlDeletePedido = @"
                    DELETE FROM Pedido 
                    WHERE idCliente = @idCliente;";
                            using (var cmdPedido = new NpgsqlCommand(sqlDeletePedido, conn))
                            {
                                cmdPedido.Parameters.AddWithValue("@idCliente", idCliente);
                                cmdPedido.ExecuteNonQuery();
                            }

                            // Exclusões relacionadas ao VEICULO usando o ID do CLIENTE
                            string sqlDeleteVeiculo = @"
                    DELETE FROM VEICULO 
                    WHERE idCliente = @idCliente;";
                            using (var cmdVeiculo = new NpgsqlCommand(sqlDeleteVeiculo, conn))
                            {
                                cmdVeiculo.Parameters.AddWithValue("@idCliente", idCliente);
                                cmdVeiculo.ExecuteNonQuery();
                            }

                            // Exclusões relacionadas ao CLIENTE
                            string sqlDeleteTelefone = "DELETE FROM CLIENTE_TELEFONE WHERE IDCLIENTE = @IDCLIENTE;";
                            using (var cmdTelefone = new NpgsqlCommand(sqlDeleteTelefone, conn))
                            {
                                cmdTelefone.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                                cmdTelefone.ExecuteNonQuery();
                            }

                            string sqlDeleteEndereco = "DELETE FROM CLIENTE_ENDERECO WHERE IDCLIENTE = @IDCLIENTE;";
                            using (var cmdEndereco = new NpgsqlCommand(sqlDeleteEndereco, conn))
                            {
                                cmdEndereco.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                                cmdEndereco.ExecuteNonQuery();
                            }

                            string sqlDeleteClienteF = "DELETE FROM CLIENTE_F WHERE IDCLIENTE = @IDCLIENTE;";
                            using (var cmdClienteF = new NpgsqlCommand(sqlDeleteClienteF, conn))
                            {
                                cmdClienteF.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                                cmdClienteF.ExecuteNonQuery();
                            }

                            string sqlDeleteCliente = "DELETE FROM CLIENTE WHERE IDCLIENTE = @IDCLIENTE;";
                            using (var cmdCliente = new NpgsqlCommand(sqlDeleteCliente, conn))
                            {
                                cmdCliente.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                                int rowsCliente = cmdCliente.ExecuteNonQuery();

                                if (rowsCliente <= 0)
                                {
                                    throw new Exception("Nenhum cliente encontrado com o ID fornecido.");
                                }
                            }

                            // Confirma a transação
                            transaction.Commit();
                            return "Cliente, pedidos, veículos e registros relacionados excluídos com sucesso.";
                        }
                        catch (Exception ex)
                        {
                            // Reverte a transação em caso de erro
                            transaction.Rollback();
                            return "Erro ao excluir registros: " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Erro ao conectar ao banco de dados: " + ex.Message;
            }
        }

        public string DeletarClienteJ(Cliente mClienteJ)
        {
            // Obtém o ID do CLIENTE usando o método getter
            long idCliente = mClienteJ.getIdCliente();

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
                            // Exclusões relacionadas ao PEDIDO usando o ID do CLIENTE
                            string sqlDeletePedidoPeca = @"
                    DELETE FROM Pedido_Peca 
                    WHERE idPedido IN (
                        SELECT idPedido FROM Pedido WHERE idCliente = @idCliente
                    );";
                            using (var cmdPeca = new NpgsqlCommand(sqlDeletePedidoPeca, conn))
                            {
                                cmdPeca.Parameters.AddWithValue("@idCliente", idCliente);
                                cmdPeca.ExecuteNonQuery();
                            }

                            string sqlDeletePedidoServico = @"
                    DELETE FROM Pedido_Servico 
                    WHERE idPedido IN (
                        SELECT idPedido FROM Pedido WHERE idCliente = @idCliente
                    );";
                            using (var cmdServico = new NpgsqlCommand(sqlDeletePedidoServico, conn))
                            {
                                cmdServico.Parameters.AddWithValue("@idCliente", idCliente);
                                cmdServico.ExecuteNonQuery();
                            }

                            string sqlDeletePedido = @"
                    DELETE FROM Pedido 
                    WHERE idCliente = @idCliente;";
                            using (var cmdPedido = new NpgsqlCommand(sqlDeletePedido, conn))
                            {
                                cmdPedido.Parameters.AddWithValue("@idCliente", idCliente);
                                cmdPedido.ExecuteNonQuery();
                            }

                            // Exclusões relacionadas ao VEICULO usando o ID do CLIENTE
                            string sqlDeleteVeiculo = @"
                    DELETE FROM VEICULO 
                    WHERE idCliente = @idCliente;";
                            using (var cmdVeiculo = new NpgsqlCommand(sqlDeleteVeiculo, conn))
                            {
                                cmdVeiculo.Parameters.AddWithValue("@idCliente", idCliente);
                                cmdVeiculo.ExecuteNonQuery();
                            }

                            // Exclusões relacionadas ao CLIENTE
                            string sqlDeleteTelefone = "DELETE FROM CLIENTE_TELEFONE WHERE IDCLIENTE = @IDCLIENTE;";
                            using (var cmdTelefone = new NpgsqlCommand(sqlDeleteTelefone, conn))
                            {
                                cmdTelefone.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                                cmdTelefone.ExecuteNonQuery();
                            }

                            string sqlDeleteEndereco = "DELETE FROM CLIENTE_ENDERECO WHERE IDCLIENTE = @IDCLIENTE;";
                            using (var cmdEndereco = new NpgsqlCommand(sqlDeleteEndereco, conn))
                            {
                                cmdEndereco.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                                cmdEndereco.ExecuteNonQuery();
                            }

                            string sqlDeleteClienteJ = "DELETE FROM CLIENTE_J WHERE IDCLIENTE = @IDCLIENTE;";
                            using (var cmdClienteJ = new NpgsqlCommand(sqlDeleteClienteJ, conn))
                            {
                                cmdClienteJ.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                                cmdClienteJ.ExecuteNonQuery();
                            }

                            string sqlDeleteCliente = "DELETE FROM CLIENTE WHERE IDCLIENTE = @IDCLIENTE;";
                            using (var cmdCliente = new NpgsqlCommand(sqlDeleteCliente, conn))
                            {
                                cmdCliente.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                                int rowsCliente = cmdCliente.ExecuteNonQuery();

                                if (rowsCliente <= 0)
                                {
                                    throw new Exception("Nenhum cliente encontrado com o ID fornecido.");
                                }
                            }

                            // Confirma a transação
                            transaction.Commit();
                            return "Cliente, pedidos, veículos e registros relacionados excluídos com sucesso.";
                        }
                        catch (Exception ex)
                        {
                            // Reverte a transação em caso de erro
                            transaction.Rollback();
                            return "Erro ao excluir registros: " + ex.Message;
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
