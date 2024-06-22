using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controlePeca
    {
        #region Cadastrar peça
        //Criação do método de cadastrar peça
        public string cadastroPeca(Peca mPeca)
        {
            //String sql de inserção
            string sql = "INSERT INTO PECA(IDMARCA, NOMEPECA, TIPOPECA, DESCPECA, VALORPECA, QUANTPECA, GARANTIAPECA) " +
                "VALUES(@IDMARCA, @NOMEPECA, @TIPOPECA, @DESCPECA, @VALORPECA, @QUANTPECA, @GARANTIAPECA);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@IDMARCA", mPeca.getIdMarca());
                comm.Parameters.AddWithValue("@NOMEPECA", mPeca.getNomePeca());
                comm.Parameters.AddWithValue("@TIPOPECA", mPeca.getTipoPeca());
                comm.Parameters.AddWithValue("@DESCPECA", mPeca.getDescPeca());
                comm.Parameters.AddWithValue("@VALORPECA", mPeca.getValorPeca());
                comm.Parameters.AddWithValue("@QUANTPECA", mPeca.getQuantPeca());
                comm.Parameters.AddWithValue("@GARANTIAPECA", mPeca.getGarantiaPeca());

                //Executando o Query
                comm.ExecuteNonQuery();

                //Retornando um valor
                return "Peça cadastrado com sucesso!";
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
    }
}
