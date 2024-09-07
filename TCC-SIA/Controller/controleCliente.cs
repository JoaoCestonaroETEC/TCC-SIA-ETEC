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
        public string cadastroClienteF(ClienteF mClienteF)
        {
            //String SQL de inserção
            string sqlVef = "SELECT COUNT(1) FROM CLIENTE_F WHERE CPFCLIENTE_F = @CPFCLIENTE_F;";

            //Strings de SQL de inserções
            string sql = "INSERT INTO CLIENTE_F(CPFCLIENTE_F, NOMECLIENTE_F, EMAILCLIENTE_F, DATANASC_CLIENTE_F, SEXO) " +
                "VALUES(@CPFCLIENTE_F, @NOMECLIENTE_f, @EMAILCLIENTE_F, @DATANASC_CLIENTE_F, @SEXO) RETURNING IDCLIENTE_F;";
            string sql2 = "INSERT INTO CLIENTE_ENDERECO_F(IDCLIENTE_F, NUMERO, RUA, CIDADE, CEP, BAIRRO, ESTADO) " +
                "VALUES(@IDCLIENTE_F, @NUMERO, @RUA, @CIDADE, @CEP, @BAIRRO, @ESTADO);";
            string sql3 = "INSERT INTO CLIENTE_TELEFONE_F(IDCLIENTE_F, TELEFONE) " +
                "VALUES(@IDCLIENTE_F, @TELEFONE);";

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
                commVef.Parameters.AddWithValue("@CPFCLIENTE_F", mClienteF.getCpfCliente());
                int cpfExists = Convert.ToInt32(commVef.ExecuteScalar());

                if (cpfExists > 0)
                {
                    return "CPF já cadastrado no sistema.";
                }

                commVef.ExecuteNonQuery();
                // Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@CPFCLIENTE_F", mClienteF.getCpfCliente());
                comm.Parameters.AddWithValue("@NOMECLIENTE_F", mClienteF.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE_F", mClienteF.getEmailCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE_F", mClienteF.getDataNascCliente());
                comm.Parameters.AddWithValue("@SEXO", mClienteF.getSexo());

                // Executa a query e retorna o ID do cliente
                var idCliente = (int)comm.ExecuteScalar();

                // Definindo os valores a serem postos nos campos
                comm2.Parameters.AddWithValue("@IDCLIENTE_F", idCliente);
                comm2.Parameters.AddWithValue("@NUMERO", mClienteF.getNumero());
                comm2.Parameters.AddWithValue("@RUA", mClienteF.getRua());
                comm2.Parameters.AddWithValue("@CIDADE", mClienteF.getCidade());
                comm2.Parameters.AddWithValue("@CEP", mClienteF.getCep());
                comm2.Parameters.AddWithValue("@BAIRRO", mClienteF.getBairro());
                comm2.Parameters.AddWithValue("@ESTADO", mClienteF.getUf());

                comm2.ExecuteNonQuery();

                // Definindo os valores a serem postos nos campos
                comm3.Parameters.AddWithValue("@IDCLIENTE_F", idCliente);
                comm3.Parameters.AddWithValue("@TELEFONE", mClienteF.getTelefone());

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

        public string atualizaClienteF(ClienteF mClienteF)
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
                comm.Parameters.AddWithValue("@IDCLIENTE_F", mClienteF.getIDCliente());
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
