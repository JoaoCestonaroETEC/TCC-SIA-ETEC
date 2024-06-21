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
            string sql = "insert into Veiculo(cpfcliente, idmarca, idtipo, corveiculo, placaveiculo, modeloveiculo) " + "values(@cpfcliente, @idmarca, @idtipo, @corveiculo, @placaveiculo, @modeloveiculo);";

            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpfcliente", mVeiculo.getCpfCliente());
                comm.Parameters.AddWithValue("@idmarca", mVeiculo.getIdMarca());
                comm.Parameters.AddWithValue("@idtipo", mVeiculo.getIdTipo());
                comm.Parameters.AddWithValue("@corveiculo", mVeiculo.getCor());
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
