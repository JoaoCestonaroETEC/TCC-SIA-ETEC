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
                comm.Parameters.AddWithValue("@NOMESERVICO", mServico.NomeServico);
                comm.Parameters.AddWithValue("@TIPOSERVICO", mServico.TipoServico);
                comm.Parameters.AddWithValue("@DESCSERVICO", mServico.DescServico);
                comm.Parameters.AddWithValue("@VALORSERVICO", mServico.ValorServico);

                comm.ExecuteNonQuery();
                return "Serviço cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
            finally
            {
                con.desconectar();
            }
        }
    }
}
