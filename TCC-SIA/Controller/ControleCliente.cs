﻿using Npgsql;
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
            string sql = "INSERT INTO CLIENTE(CPFCLIENTE, NOMECLIENTE, EMAILCLIENTE, DATANASC_CLIENTE, SEXOCLIENTE) " + "values(@CPFCLIENTE, @NOMECLIENTE, @EMAILCLIENTE, @DATANASC_CLIENTE, @SEXOCLIENTE);" +
                "INSERT INTO CLIENTE_TELEFONE(CPFCLIENTE, TELEFONECLIENTE) " + "values(@CPFCLIENTE, @TELEFONECLIENTE);" +
                "INSERT INTO CLIENTE_ENDERECO(CPFCLIENTE, NUMERO, RUA, BAIRRO, CIDADE, CEP, UF) " + "values(@CPFCLIENTE, @NUMERO, @RUA, @BAIRRO, @CIDADE, @CEP, @UF);";



            conexãoBD con = new conexãoBD();
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
                comm.Parameters.AddWithValue("@UF", mCliente.getUf());
                comm.Parameters.AddWithValue("@SEXOCLIENTE", mCliente.getSexo());

                comm.ExecuteNonQuery();
                return "Cliente cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}
