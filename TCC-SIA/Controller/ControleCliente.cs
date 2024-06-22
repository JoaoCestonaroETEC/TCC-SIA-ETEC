using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controleCliente
    {
        //Criação do método de cadastrar cliente
        public string cadastroCliente(Cliente mCliente)
        {
            //String sql de inserção
            string sql = "INSERT INTO CLIENTE(CPFCLIENTE, NOMECLIENTE, EMAILCLIENTE, DATANASC_CLIENTE, SEXO) " +
                "VALUES(@CPFCLIENTE, @NOMECLIENTE, @EMAILCLIENTE, @DATANASC_CLIENTE, @SEXO);" +
                "INSERT INTO CLIENTE_ENDERECO(CPFCLIENTE, NUMERO, RUA, CIDADE, CEP, BAIRRO, ESTADO) " +
                "VALUES(@CPFCLIENTE, @NUMERO, @RUA, @CIDADE, @CEP, @BAIRRO, @ESTADO);" +
                "INSERT INTO CLIENTE_TELEFONE(CPFCLIENTE, TELEFONE) " +
                "VALUES(@CPFCLIENTE, @TELEFONE);";


            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                comm.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE", mCliente.getDataNascCliente());
                comm.Parameters.AddWithValue("@SEXO", mCliente.getSexo());
                comm.Parameters.AddWithValue("@NUMERO", mCliente.getNumero());
                comm.Parameters.AddWithValue("RUA", mCliente.getRua());
                comm.Parameters.AddWithValue("@CIDADE", mCliente.getCidade());
                comm.Parameters.AddWithValue("@CEP", mCliente.getCep());
                comm.Parameters.AddWithValue("@BAIRRO", mCliente.getBairro());
                comm.Parameters.AddWithValue("@ESTADO", mCliente.getUf());
                comm.Parameters.AddWithValue("@TELEFONE", mCliente.getTelefone());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Login cadastrado com sucesso!";
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
    }
}
