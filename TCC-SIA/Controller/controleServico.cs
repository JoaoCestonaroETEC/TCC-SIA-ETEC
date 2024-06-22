using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controleServico
    {
        #region Cadastrar serviço
        //Criação do método de cadastrar serviço
        public string cadastroServico(Servico mServico)
        {
            //String sql de inserção
            string sql = "INSERT INTO SERVICO(NOMESERVICO, DESCSERVICO, VALORSERVICO) " +
                "VALUES(@NOMESERVICO, @DESCSERVICO, @VALORSERVICO);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@NOMESERVICO", mServico.getNomeServico());
                comm.Parameters.AddWithValue("@DESCSERVICO", mServico.getDescServico());
                comm.Parameters.AddWithValue("@VALORSERVICO", mServico.getValorServico());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Serviço cadastrado com sucesso!";
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

        #region Listar serviço
        //Criação do método de listar cliente
        public NpgsqlDataReader listaServico()
        {
            //String sql de listar
            string sql = "SELECT IDSERVICO, NOMESERVICO FROM SERVICO;";

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

        #region Pesquisar serviço
        //Criação do método de pesquisar cliente
        public NpgsqlDataReader pesquisaServico(string servico)
        {
            //String sql de pesquisar
            string sql = "SELECT * FROM SERVICO WHERE NOMESERVICO LIKE '" + servico + "%';";

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
    }
}
