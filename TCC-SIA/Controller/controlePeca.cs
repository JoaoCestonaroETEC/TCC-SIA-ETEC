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
        public string cadastroPeca(Peca mPeca)
        {
            string sql = "INSERT INTO PECA(NOMEPECA, DESCPECA, VALORPECA, QUANTPECA, MARCAPECA, GARANTIAPECA) " + "values(@NOMEPECA, @DESCPECA, @VALORPECA, @QUANTPECA, @MARCAPECA, @GARANTIAPECA);";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@NOMEPECA", mPeca.getNomePeca());
                comm.Parameters.AddWithValue("@DESCPECA", mPeca.getDescPeca());
                comm.Parameters.AddWithValue("@VALORPECA", mPeca.getValorPeca());
                comm.Parameters.AddWithValue("@QUANTPECA", mPeca.getQuantPeca());
                comm.Parameters.AddWithValue("@MARCAPECA", mPeca.getMarcaPeca());
                comm.Parameters.AddWithValue("@GARANTIAPECA", mPeca.getGarantiaPeca());

                comm.ExecuteNonQuery();
                return "Peça cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}
