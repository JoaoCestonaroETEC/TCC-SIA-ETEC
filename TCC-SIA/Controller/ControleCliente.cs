﻿using Npgsql;
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

        public string atualizaClienteF(Cliente mClienteF)
        {
            string sql = "UPDATE CLIENTE SET NOMECLIENTE = @NOMECLIENTE, " +
                "EMAILCLIENTE = @EMAILCLIENTE, DATA = @DATA, STATUS = @STATUS RETURNING IDCLIENTE;" +
                "UPDATE CLIENTE_F SET IDCLIENTE = @IDCLIENTE, CPFCLIENTE, DATANASC_CLIENTE = @DATANAS_CLIENTE, " +
                "SEXO = @SEXO, OBS = @OBS;" +
                "UPDATE ENDERECO_CLIENTE SET NUMERO = @NUMERO, RUA = @ RUA, CIDADE = @CIDADE;" +
                "CEP = @CEP, BAIRRO = @BAIRRO, ESTADO = @ESTADO WHERE IDCLIENTE = @IDCLIENTE;" +
                "UPDATE TELEFONE_CLIENTE SERT TELEFONE = @TELEFONE WHERE IDCLIENTE = @IDCLIENTE";



            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            

            try
            {
                comm.Parameters.AddWithValue("@NOMECLIENTE", mClienteF.getNomeCliente());
                comm.Parameters.AddWithValue("@EMAILCLIENTE", mClienteF.getEmailCliente());
                comm.Parameters.AddWithValue("@DATA", mClienteF.getData());
                comm.Parameters.AddWithValue("@STATUS", mClienteF.getStatus());

                var idCliente = (int)comm.ExecuteScalar();

                comm.Parameters.AddWithValue("@IDCLIENTE", mClienteF.getIdCliente());
                comm.Parameters.AddWithValue("@CPFCLIENTE", mClienteF.getCpfCliente());
                comm.Parameters.AddWithValue("@DATANASC_CLIENTE", mClienteF.getDataNascCliente());
                comm.Parameters.AddWithValue("@SEXO", mClienteF.getSexo());
                comm.Parameters.AddWithValue("@OBS", mClienteF.getObs());

                comm.Parameters.AddWithValue("@IDCLIENTE", mClienteF.getIdCliente());
                comm.Parameters.AddWithValue("@NUMERO", mClienteF.getNumero());
                comm.Parameters.AddWithValue("@RUA", mClienteF.getRua());
                comm.Parameters.AddWithValue("@CIDADE", mClienteF.getCidade());
                comm.Parameters.AddWithValue("@CEP", mClienteF.getCep());
                comm.Parameters.AddWithValue("@BAIRRO", mClienteF.getBairro());
                comm.Parameters.AddWithValue("@ESTADO", mClienteF.getUf());

                comm.Parameters.AddWithValue("@IDCLIENTE", mClienteF.getIdCliente());
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
