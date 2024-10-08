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
            //String SQL de inserção
            string sqlVef = "SELECT COUNT(1) FROM SERVICO WHERE NOMESERVICO = @NOMESERVICO AND VALORSERVICO = @VALORSERVICO AND GARANTIASERVICO = @GARANTIASERVICO AND FUNCIONARIO = @FUNCIONARIO";

            //String sql de inserção
            string sql = "INSERT INTO SERVICO(NOMESERVICO, DESCSERVICO, VALORSERVICO, GARANTIASERVICO, FUNCIONARIO) " +
                "VALUES(@NOMESERVICO, @DESCSERVICO, @VALORSERVICO, @GARANTIASERVICO, @FUNCIONARIO);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);
            NpgsqlCommand commVef = new NpgsqlCommand(sqlVef, conn);

            //Fazendo o try
            try
            {
                //Faz a verificação do servico já existir no Banco
                commVef.Parameters.AddWithValue("@NOMESERVICO", mServico.getNomeServico());
                commVef.Parameters.AddWithValue("@VALORSERVICO", mServico.getValorServico());
                commVef.Parameters.AddWithValue("@GARANTIASERVICO", mServico.getGarantiaServico());
                commVef.Parameters.AddWithValue("@FUNCIONARIO", mServico.getFuncionario());
                int pecaExists = Convert.ToInt32(commVef.ExecuteScalar());

                if (pecaExists > 0)
                {
                    return "Seviço já cadastrado no sistema.";
                }

                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@NOMESERVICO", mServico.getNomeServico());
                comm.Parameters.AddWithValue("@DESCSERVICO", mServico.getDescServico());
                comm.Parameters.AddWithValue("@VALORSERVICO", mServico.getValorServico());
                comm.Parameters.AddWithValue("@GARANTIASERVICO", mServico.getGarantiaServico());
                comm.Parameters.AddWithValue("@FUNCIONARIO", mServico.getFuncionario());


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
        //Criação do método de listar serviço
        public NpgsqlDataReader listaServico()
        {
            //String sql de listar
            string sql = "SELECT * FROM SERVICO;";

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

        #region Listar funcionário
        //Criação do método de listar funcionário
        public NpgsqlDataReader listaFuncionario()
        {
            //String sql de listar
            string sql = "SELECT DISTINCT FUNCIONARIO FROM SERVICO;";

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
        //Criação do método de pesquisar serviço
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

        #region Atualizar serviço
        public string atualizaServico(Servico mServico)
        {
            string sql = "update servico set nomeservico = @nomeservico," +
                "descservico = @descservico, valorservico = @valorservico , funcionario = @funcionario," +
                "garantiaservico = @garantiaservico where idservico = @idservico;";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@idservico", mServico.getIDServico());
                comm.Parameters.AddWithValue("@nomeservico", mServico.getNomeServico());
                comm.Parameters.AddWithValue("@descservico", mServico.getDescServico());
                comm.Parameters.AddWithValue("@valorservico", mServico.getValorServico());
                comm.Parameters.AddWithValue("@funcionario", mServico.getFuncionario());
                comm.Parameters.AddWithValue("@garantiaservico", mServico.getGarantiaServico());

                comm.ExecuteNonQuery();
                return "Serviço atualizado!";
            }
            catch (NpgsqlException ex)
            {
                //return ex.ToString();
                return "Erro ao atualizar!";
            }
        }
        #endregion
    }
}
