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
    internal class ControleCliente
    {
        public string cadastroCliente(Cliente mCliente)
        {
            string sql = "INSERT INTO CLIENTE(CPFCLIENTE, NOMECLIENTE, EMAILCLIENTE, DATANASC_CLIENTE, SEXO) " + "values(@CPFCLIENTE, @NOMECLIENTE, @EMAILCLIENTE, @DATANASC_CLIENTE, @SEXO);" +
                "INSERT INTO CLIENTE_TELEFONE(CPFCLIENTE, TELEFONE) " + "values(@CPFCLIENTE, @TELEFONECLIENTE);" +
                "INSERT INTO CLIENTE_ENDERECO(CPFCLIENTE, NUMERO, RUA, BAIRRO, CIDADE, CEP, ESTADO) " + "values(@CPFCLIENTE, @NUMERO, @RUA, @BAIRRO, @CIDADE, @CEP, @ESTADO);";



            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@CPFCLIENTE", mCliente.getCpfCliente());
                comm.Parameters.AddWithValue("@NOMECLIENTE", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE", mCliente.getDataNascCliente());
                comm.Parameters.AddWithValue("@TELEFONECLIENTE", mCliente.getTelefoneCliente());
                comm.Parameters.AddWithValue("@NUMERO", mCliente.getNumero());
                comm.Parameters.AddWithValue("RUA", mCliente.getRua());
                comm.Parameters.AddWithValue("@BAIRRO", mCliente.getBairro());
                comm.Parameters.AddWithValue("@CIDADE", mCliente.getCidade());
                comm.Parameters.AddWithValue("@CEP", mCliente.getCep());
                comm.Parameters.AddWithValue("@ESTADO", mCliente.getUf());
                comm.Parameters.AddWithValue("@SEXO", mCliente.getSexo());

                comm.ExecuteNonQuery();
                return "Login cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}
