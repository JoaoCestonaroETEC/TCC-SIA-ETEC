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
        public string cadastroServico(Servico mServico)
        {
            string sql = "INSERT INTO SERVICO(NOMESERVICO, TIPOSERVICO, DESCSERVICO, VALORSERVICO) " + "values(@NOMESERVICO, @TIPOSERVICO, @DESCSERVICO, @VALORSERVICO);";

            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@NOMEPECA", mPeca.getNomePeca());
                comm.Parameters.AddWithValue("@TIPOPECA", mPeca.getTipoPeca());
                comm.Parameters.AddWithValue("@DESCPECA", mPeca.getDescPeca());
                comm.Parameters.AddWithValue("@VALORPECA", mPeca.getValorPeca());
                comm.Parameters.AddWithValue("@QUANTPECA", mPeca.getQuantPeca());
                comm.Parameters.AddWithValue("@MARCAPECA", mPeca.getMarcaPeca());

                comm.ExecuteNonQuery();
                return "Veículo cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }
    }
}
