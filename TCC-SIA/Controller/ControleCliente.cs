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
            //String sql de inserção
            string sql = "INSERT INTO CLIENTE(CPFCLIENTE, NOMECLIENTE, EMAILCLIENTE, DATANASC_CLIENTE, SEXO) " +
                "VALUES(@CPFCLIENTE, @NOMECLIENTE, @EMAILCLIENTE, @DATANASC_CLIENTE, @SEXO) RETURNING IDCLIENTE;";
            string sql2 = "INSERT INTO CLIENTE_ENDERECO(IDCLIENTE, NUMERO, RUA, CIDADE, CEP, BAIRRO, ESTADO) " +
                "VALUES(@IDCLIENTE, @NUMERO, @RUA, @CIDADE, @CEP, @BAIRRO, @ESTADO);";
            string sql3 = "INSERT INTO CLIENTE_TELEFONE(IDCLIENTE, TELEFONE) " +
                "VALUES(@IDCLIENTE, @TELEFONE);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            NpgsqlCommand comm2 = new NpgsqlCommand(sql2, conn);
            NpgsqlCommand comm3 = new NpgsqlCommand(sql3, conn);
            //Fazendo o try

            var idCliente = 0; // Declarar a variável antes do try
            try
            {

                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                comm.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE", mCliente.getDataNascCliente());
                comm.Parameters.AddWithValue("@SEXO", mCliente.getSexo());

                idCliente = (int)comm.ExecuteScalar();

                comm2.Parameters.AddWithValue("IDCLIENTE", idCliente);
                comm2.Parameters.AddWithValue("@NUMERO", mCliente.getNumero());
                comm2.Parameters.AddWithValue("RUA", mCliente.getRua());
                comm2.Parameters.AddWithValue("@CIDADE", mCliente.getCidade());
                comm2.Parameters.AddWithValue("@CEP", mCliente.getCep());
                comm2.Parameters.AddWithValue("@BAIRRO", mCliente.getBairro());
                comm2.Parameters.AddWithValue("@ESTADO", mCliente.getUf());

                comm2.ExecuteNonQuery();

                comm3.Parameters.AddWithValue("@TELEFONE", mCliente.getTelefone());

                comm3.ExecuteNonQuery();
                //Executando o Query
                //Retornando um valor
                return "Cliente cadastrado com sucesso!";
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
        public NpgsqlDataReader pesquisarCliente(string cliente)
        {
            //String sql de pesquisar
            string sql = "SELECT C.IDCLIENTE, C.CPFCLIENTE, C.NOMECLIENTE, C.EMAILCLIENTE, C.DATANASC_CLIENTE, C.SEXO, " +
             "E.NUMERO, E.RUA, E.CIDADE, E.CEP, E.BAIRRO, E.ESTADO, T.TELEFONE " +
             "FROM CLIENTE C " +
             "INNER JOIN CLIENTE_ENDERECO E ON C.IDCLIENTE = E.IDCLIENTE " +
             "INNER JOIN CLIENTE_TELEFONE T ON C.IDCLIENTE = T.IDCLIENTE " +
             "WHERE C.NOMECLIENTE LIKE '" + cliente + "%';";

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

        public string atualizaCliente(Cliente mCliente)
        {
            string sql = "update cliente set nomecliente = @nomecliente, " +
                "emailcliente = @emailcliente, datanasc_cliente = @datanasc_cliente, " +
                "sexo = @sexo, cpfcliente = @cpfcliente where idcliente = @idcliente;" +
                "update cliente_endereco set numero = @numero, rua = @rua, cidade = @cidade, " +
                "cep = @cep, bairro = @bairro, estado = @estado where idcliente = @idcliente;" +
                "update cliente_telefone set telefone = @telefone where idcliente = @idcliente;";



            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@IDCLIENTE", mCliente.getIDCliente());
                comm.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                comm.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE", mCliente.getDataNascCliente());
                comm.Parameters.AddWithValue("@SEXO", mCliente.getSexo());
                comm.Parameters.AddWithValue("@NUMERO", mCliente.getNumero());
                comm.Parameters.AddWithValue("@RUA", mCliente.getRua());
                comm.Parameters.AddWithValue("@CIDADE", mCliente.getCidade());
                comm.Parameters.AddWithValue("@CEP", mCliente.getCep());
                comm.Parameters.AddWithValue("@BAIRRO", mCliente.getBairro());
                comm.Parameters.AddWithValue("@ESTADO", mCliente.getUf());
                comm.Parameters.AddWithValue("@TELEFONE", mCliente.getTelefone());

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
