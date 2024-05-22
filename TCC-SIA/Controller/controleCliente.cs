﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;
using TCC_SIA.Controller;



namespace TCC_SIA.Controller
{
    class controleCliente
    {

        public string cadastroCliente(Cliente mCliente)
        {
            string sql = "insert into CLIENTE(NOMECLIENTE, EMAIL, SENHA) " + "values(@nomeCliente, @emailCliente, @senhaCliente);";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nomeCliente", mCliente.getNomeCliente());
                comm.Parameters.AddWithValue("@emailCliente", mCliente.getEmailCliente());
                comm.Parameters.AddWithValue("@senhaCliente", mCliente.getSenhaCliente());

                comm.ExecuteNonQuery();
                return "Cliente cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }

        public string loginCadastro(IdLogin mIdLogin)
        {
            string sql = "SELECT COUNT(1) FROM CLIENTE WHERE NOMECLIENTE=@usuario AND SENHA=@senha;";
            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            comm.Parameters.AddWithValue("@usuario", mIdLogin.getUsuario());
            comm.Parameters.AddWithValue("@senha", mIdLogin.getSenha());

            try
            {
                comm.ExecuteNonQuery();
                return "Sei la";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}