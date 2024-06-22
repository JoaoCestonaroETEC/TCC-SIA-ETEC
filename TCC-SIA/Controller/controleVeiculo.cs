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
        //Criação do método de cadastrar tipo
        public string cadastroVeiculo(Veiculo mVeiculo)
        {
            //String sql de inserção
            string sql = "INSERT INTO VEICULO(CPFCLIENTE, IDMARCA, NOMEVEICULO, TIPOVEICULO, CORVEICULO, PLACAVEICULO, MODELOVEICULO) " +
                "VALUES(@CPFCLIENTE, @IDMARCA, @NOMEVEICULO, @TIPOVEICULO, @CORVEICULO, @PLACAVEICULO, @MODELOVEICULO);";

            //Abrindo conexão com o banco de dados
            conexaoBD con = new conexaoBD();
            NpgsqlConnection conn = con.conectar();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            //Fazendo o try
            try
            {
                //Definindo os valores a serem postos nos campos
                comm.Parameters.AddWithValue("@CPFCLIENTE", mVeiculo.getCpfCliente());
                comm.Parameters.AddWithValue("@IDMARCA", mVeiculo.getIdMarca());
                comm.Parameters.AddWithValue("@NOMEVEICULO", mVeiculo.getNomeVeiculo());
                comm.Parameters.AddWithValue("@TIPOVEICULO", mVeiculo.getTipoVeiculo());
                comm.Parameters.AddWithValue("@CORVEICULO", mVeiculo.getCorVeiculo());
                comm.Parameters.AddWithValue("@PLACAVEICULO", mVeiculo.getPlacaVeiculo());
                comm.Parameters.AddWithValue("@MODELOVEICULO", mVeiculo.getModeloVeiculo());

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
    }
}
