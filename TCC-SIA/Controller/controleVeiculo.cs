using Npgsql;
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
        public string cadastroVeiculo(Veiculo mVeiculo)
        {
            string sql = "insert into Veiculo(cpfcliente, corveiculo, marcaveiculo, tipoveiculo, modeloveiculo, placaveiculo) " + "values(@cpfcliente, @corveiculo, @marcaveiculo, @tipoveiculo, @modeloveiculo, @placaveiculo);";

            conexãoBD con = new conexãoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpfveiculo", mVeiculo.getCpfCliente());
                comm.Parameters.AddWithValue("@corveiculo", mVeiculo.getCor());
                comm.Parameters.AddWithValue("@marcaveiculo", mVeiculo.getMarca());
                comm.Parameters.AddWithValue("@tipoveiculo", mVeiculo.getTipo());
                comm.Parameters.AddWithValue("@modeloveiculo", mVeiculo.getModelo());
                comm.Parameters.AddWithValue("@placaveiculo", mVeiculo.getPlaca());

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
