using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;
using System.Text.RegularExpressions;

namespace TCC_SIA.Controller
{
    internal class controleCliente
    {
        #region Cadastrar cliente
        //Criação do método de cadastrar cliente
        public string cadastroCliente(Cliente mCliente)
        {
            //String SQL de inserção
            string sqlVef = "SELECT COUNT(1) FROM CLIENTE WHERE CPFCLIENTE = @CPFCLIENTE;";

            //Strings de SQL de inserções
            string sql = "INSERT INTO CLIENTE(CPFCLIENTE, CNPJCLIENTE, NOMECLIENTE, EMAILCLIENTE, DATANASC_CLIENTE, SEXO, OBS, RAZAO) " +
                "VALUES(@CPFCLIENTE, @CNPJCLIENTE, @NOMECLIENTE, @EMAILCLIENTE, @DATANASC_CLIENTE, @SEXO, @OBS, @RAZAO) RETURNING IDCLIENTE;";
            string sql2 = "INSERT INTO CLIENTE_ENDERECO(IDCLIENTE, NUMERO, RUA, CIDADE, CEP, BAIRRO, ESTADO) " +
                "VALUES(@IDCLIENTE, @NUMERO, @RUA, @CIDADE, @CEP, @BAIRRO, @ESTADO);";
            string sql3 = "INSERT INTO CLIENTE_TELEFONE(IDCLIENTE, TELEFONE) " +
                "VALUES(@IDCLIENTE, @TELEFONE);";

            // Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand commVef = new NpgsqlCommand(sqlVef, conn);
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            NpgsqlCommand comm2 = new NpgsqlCommand(sql2, conn);
            NpgsqlCommand comm3 = new NpgsqlCommand(sql3, conn);

            try
            {
                //Faz a verificação de o CPF já existe no Banco
                commVef.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                int cpfExists = Convert.ToInt32(commVef.ExecuteScalar());

                if (cpfExists > 0)
                {
                    return "CPF já cadastrado no sistema.";
                }

                commVef.ExecuteNonQuery();
                // Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                comm.Parameters.AddWithValue("@CNPJCLIENTE", mCliente.getCNPJCliente());
                comm.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE", mCliente.getDataNascCliente());
                comm.Parameters.AddWithValue("@SEXO", mCliente.getSexo());
                comm.Parameters.AddWithValue("@OBS", mCliente.getObs());
                comm.Parameters.AddWithValue("@RAZAO", mCliente.getObs());

                // Executa a query e retorna o ID do cliente
                var idCliente = (int)comm.ExecuteScalar();

                // Definindo os valores a serem postos nos campos
                comm2.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm2.Parameters.AddWithValue("@NUMERO", mCliente.getNumero());
                comm2.Parameters.AddWithValue("@RUA", mCliente.getRua());
                comm2.Parameters.AddWithValue("@CIDADE", mCliente.getCidade());
                comm2.Parameters.AddWithValue("@CEP", mCliente.getCep());
                comm2.Parameters.AddWithValue("@BAIRRO", mCliente.getBairro());
                comm2.Parameters.AddWithValue("@ESTADO", mCliente.getUf());

                comm2.ExecuteNonQuery();

                // Definindo os valores a serem postos nos campos
                comm3.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                comm3.Parameters.AddWithValue("@TELEFONE", mCliente.getTelefone());

                comm3.ExecuteNonQuery();

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
            string sql = "SELECT * FROM CLIENTE_F;";

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
        public NpgsqlDataReader pesquisarCliente(string cliente)
        {
            //String sql de pesquisar
            string sql = "SELECT C.IDCLIENTE_F, C.CPFCLIENTE_F, C.NOMECLIENTE_F, C.EMAILCLIENTE_F, C.DATANASC_CLIENTE_F, C.SEXO, " +
             "E.NUMERO, E.RUA, E.CIDADE, E.CEP, E.BAIRRO, E.ESTADO, T.TELEFONE " +
             "FROM CLIENTE_F C " +
             "INNER JOIN CLIENTE_ENDERECO_F E ON C.IDCLIENTE_F = E.IDCLIENTE_F " +
             "INNER JOIN CLIENTE_TELEFONE_F T ON C.IDCLIENTE_F = T.IDCLIENTE_F " +
             "WHERE C.NOMECLIENTE_F LIKE '" + cliente + "%';";

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

        public string atualizaCliente(Cliente mClienteF)
        {
            string sql = "update cliente_f set nomecliente_f = @nomecliente_f, " +
                "emailcliente_f = @emailcliente_f, datanasc_cliente_f = @datanasc_cliente_f, " +
                "sexo = @sexo, cpfcliente_f = @cpfcliente_f where idcliente_f = @idcliente_f;" +
                "update cliente_endereco_f set numero = @numero, rua = @rua, cidade = @cidade, " +
                "cep = @cep, bairro = @bairro, estado = @estado where idcliente_f = @idcliente_f;" +
                "update cliente_telefone_f set telefone = @telefone where idcliente_f = @idcliente_f;";



            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@IDCLIENTE_F", mClienteF.getIdCliente());
                comm.Parameters.AddWithValue("@CPFCLIENTE_F", mClienteF.getCpfCliente());
                comm.Parameters.AddWithValue("@NOMECLIENTE_F", mClienteF.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE_F", mClienteF.getEmailCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE_F", mClienteF.getDataNascCliente());
                comm.Parameters.AddWithValue("@SEXO", mClienteF.getSexo());
                comm.Parameters.AddWithValue("@NUMERO", mClienteF.getNumero());
                comm.Parameters.AddWithValue("@RUA", mClienteF.getRua());
                comm.Parameters.AddWithValue("@CIDADE", mClienteF.getCidade());
                comm.Parameters.AddWithValue("@CEP", mClienteF.getCep());
                comm.Parameters.AddWithValue("@BAIRRO", mClienteF.getBairro());
                comm.Parameters.AddWithValue("@ESTADO", mClienteF.getUf());
                comm.Parameters.AddWithValue("@TELEFONE", mClienteF.getTelefone());

                comm.ExecuteNonQuery();
                return "Cliente atualizado!";
            }
            catch (NpgsqlException ex)
            {
                //return ex.ToString();
                return "Erro ao atualizar!";
            }
        }

    }
}
