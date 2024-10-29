﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;
using Npgsql;


namespace TCC_SIA.Controller
{
    internal class controleVeiculo
    {
        #region Cadastrar veículo
        //Criação do método de cadastrar veículo
        public string cadastroVeiculo(Veiculo mVeiculo)
        {
            //String sql de inserção
            string sql = "INSERT INTO VEICULO(IDCLIENTE, IDMARCA, NOMEVEICULO, TIPOVEICULO, CORVEICULO, PLACAVEICULO, MODELOVEICULO, CHASSI, ANOFAB, QUILOMETRAGEM, MOTOR, COMBUSTIVEL, DATA, SEGURO) " +
                "VALUES(@IDCLIENTE, @IDMARCA, @NOMEVEICULO, @TIPOVEICULO, @CORVEICULO, @PLACAVEICULO, @MODELOVEICULO, @CHASSI, @ANOFAB, @QUILOMETRAGEM, @MOTOR, @COMBUSTIVEL, @DATA, @SEGURO);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@IDCLIENTE", mVeiculo.getIdCliente());
                comm.Parameters.AddWithValue("@IDMARCA", mVeiculo.getIdMarca());
                comm.Parameters.AddWithValue("@NOMEVEICULO", mVeiculo.getNomeVeiculo());
                comm.Parameters.AddWithValue("@TIPOVEICULO", mVeiculo.getTipoVeiculo());
                comm.Parameters.AddWithValue("@CORVEICULO", mVeiculo.getCorVeiculo());
                comm.Parameters.AddWithValue("@PLACAVEICULO", mVeiculo.getPlacaVeiculo());
                comm.Parameters.AddWithValue("@MODELOVEICULO", mVeiculo.getModeloVeiculo());
                comm.Parameters.AddWithValue("@CHASSI", mVeiculo.getChassi());
                comm.Parameters.AddWithValue("@ANOFAB", mVeiculo.getAnoFabricacao());
                comm.Parameters.AddWithValue("@QUILOMETRAGEM", mVeiculo.getQuilometragem());
                comm.Parameters.AddWithValue("@MOTOR", mVeiculo.getMotor());
                comm.Parameters.AddWithValue("@COMBUSTIVEL", mVeiculo.getCombustivel());
                comm.Parameters.AddWithValue("@DATA", mVeiculo.getData());
                comm.Parameters.AddWithValue("@SEGURO", mVeiculo.getSeguro());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Veículo cadastrado com sucesso!";
            }
            //Fazendo o catch
            catch (NpgsqlException ex)
            {
                //Retornando o erro
                return ex.ToString();
            }
            finally
            {
                //Método de desconectar
                con.desconectar();
            }
        }
        #endregion

        #region Listar veículo
        //Criação do método de listar cliente
        public NpgsqlDataReader listaVeiculo()
        {
            //String sql de listar
            string sql = "SELECT * FROM VEICULO";

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

        #region Listar tipo de veiculo
        public NpgsqlDataReader listaTipo()
        {
            //String sql de listar
            string sql = "SELECT DISTINCT TIPOVEICULO FROM VEICULO WHERE TIPOVEICULO NOT IN ('Motocicleta', 'Scooter', 'Sedan', 'Hatchback', 'SUV', 'Crossover', 'Conversível', 'Coupe', 'Caminhão', 'Van', 'Furgão', 'Micro-ônibus', 'Ônibus', 'ATV', 'Quadriciclo', 'Carro Elétrico', 'Carro Híbrido', 'Caminhão Tanque', 'Reboque')";

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

        #region Listar cor 
        public NpgsqlDataReader listaCor()
        {
            //String sql de listar
            string sql = "SELECT DISTINCT CORVEICULO FROM VEICULO WHERE CORVEICULO NOT IN ('Branco', 'Preto', 'Prata', 'Cinza', 'Azul', 'Vermelho', 'Amarelo', 'Verde', 'Roxo')";

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

        #region Listar combustivel 
        public NpgsqlDataReader listaCombustivel()
        {
            //String sql de listar
            string sql = "SELECT DISTINCT COMBUSTIVEL FROM VEICULO WHERE COMBUSTIVEL NOT IN ('Gasolina', 'Diesel', 'Álcool Etílico (Ethanol)', 'Gás Natural', 'Gás Liquefeito de Petróleo (GLP)', 'Óleo Diesel Biodiesel', 'Óleo de Cocina', 'Biogás')";

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

        #region Listar seguro
        public NpgsqlDataReader listaSeguro()
        {
            //String sql de listar
            string sql = "SELECT DISTINCT SEGURO FROM VEICULO";

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

        #region Listar veículo por cliente
        //Criação do método de listar veículo por cliente
        public NpgsqlDataReader listaVeiculoPorCliente(string cliente)
        {
            //String sql de listar
            string sql = "SELECT * FROM VEICULO WHERE IDCLIENTE = '" + cliente + "';";

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

        #region Pesquisar veículo
        //Criação do método de pesquisar veículo
        public NpgsqlDataReader pesquisaVeiculo(string veiculo)
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM VEICULO WHERE NOMEVEICULO LIKE '" + veiculo + "%';";

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

        #region Pesquisar marca de veiculo por id
        //Criação do método de pesquisar marca de veículo por id
        public string pesquisaMarcaVeiculoPorId(string idMarca)
        {
            //String sql de pesquisar
            string sql = "SELECT NOMEMARCA FROM MARCA WHERE IDMARCA = '" + idMarca + "';";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {

                //Execute a consulta e retorne o resultado como string
                object result = comm.ExecuteScalar();
                return result != null ? result.ToString() : "Marca não encontrada";
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
        #region Pesquisar cliente de veiculo por id
        //Criação do método de pesquisar marca de veículo por id
        public string pesquisaClienteVeiculoPorId(string idCliente)
        {
            //String sql de pesquisar
            string sql = "SELECT NOMECLIENTE FROM CLIENTE WHERE IDCLIENTE = '" + idCliente + "';";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {

                //Execute a consulta e retorne o resultado como string
                object result = comm.ExecuteScalar();
                return result != null ? result.ToString() : "Cliente não encontrado!";
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

        #region Atualizar Veiculo
        public string atualizarVeiculo(Veiculo mVeiculo)
        {
            string sql = "update veiculo set nomeveiculo = @nomeveiculo," +
                "tipoveiculo = @tipoveiculo, corveiculo = @corveiculo, placaveiculo = @placaveiculo, " +
                "modeloveiculo = @modeloveiculo, chassi = @chassi, anofab = @anofab, quilometragem = @quilometragem, " +
                "motor = @motor, combustivel = @combustivel, data = @data, seguro = @seguro where idveiculo = @idveiculo;";


            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@idveiculo", mVeiculo.getIdVeiculo());
                comm.Parameters.AddWithValue("@nomeveiculo", mVeiculo.getNomeVeiculo());
                comm.Parameters.AddWithValue("@tipoveiculo", mVeiculo.getTipoVeiculo());
                comm.Parameters.AddWithValue("@corveiculo", mVeiculo.getCorVeiculo());
                comm.Parameters.AddWithValue("@placaveiculo", mVeiculo.getPlacaVeiculo());
                comm.Parameters.AddWithValue("@modeloveiculo", mVeiculo.getModeloVeiculo());
                comm.Parameters.AddWithValue("@chassi", mVeiculo.getChassi());
                comm.Parameters.AddWithValue("@anofab", mVeiculo.getAnoFabricacao());
                comm.Parameters.AddWithValue("@quilometragem", mVeiculo.getQuilometragem());
                comm.Parameters.AddWithValue("@motor", mVeiculo.getMotor());
                comm.Parameters.AddWithValue("@combustivel", mVeiculo.getCombustivel());
                comm.Parameters.AddWithValue("@data", mVeiculo.getData());
                comm.Parameters.AddWithValue("@seguro", mVeiculo.getSeguro());

                comm.ExecuteNonQuery();
                return "Veiculo atualizado!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
                //return "Erro ao atualizar!";
            }
        }
        #endregion

        public string deletarVeiculo(Veiculo mVeiculo)
        {
            // SQL para deletar a marca
            string sql = "DELETE FROM VEICULO WHERE idveiculo = @idveiculo;";

            // Criação da conexão e comando
            conexaoBD con = new conexaoBD();
            using (NpgsqlConnection conn = con.conectar()) // Conectar ao banco de dados
            using (NpgsqlCommand comm = new NpgsqlCommand(sql, conn))
            {
                try
                {
                    // Executa o comando de exclusão
                    int rowsAffected = comm.ExecuteNonQuery();

                    // Verifica se a exclusão foi bem-sucedida
                    if (rowsAffected > 0)
                    {
                        return "Veículo deletada com sucesso!";
                    }
                    else
                    {
                        return "Nenhuma linha encontrada para deletar.";
                    }
                }
                catch (NpgsqlException ex)
                {
                    return "Erro ao deletar: " + ex.Message;
                }
            }
        }
    }
}
