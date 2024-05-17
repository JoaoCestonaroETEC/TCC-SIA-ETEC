using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;

namespace TCC_SIA.Controller
{
    internal class controleCadastro
    {
        string sql = "insert into Cliente(NOMECLIENTE, SENHACLIENTE, EMAILCLIENTE) " + "values(@nomeCliente, senhaCliente, emailCliente);";


        conectaPG con = new conectaPG();

        NpgsqlConnection conn = con.conectar();

        NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                // Enviar os dados da calsse modelo para o BD
                comm.Parameters.AddWithValue("@nome_produto", mProduto.getNome_PR());
                comm.Parameters.AddWithValue("@cod_marca", mProduto.getCod_Marca_PR());
                comm.Parameters.AddWithValue("@cod_tipo", mProduto.getCod_Tipo_PR());
                comm.Parameters.AddWithValue("@preco_custo", mProduto.getPreco_custo_PR());
                comm.Parameters.AddWithValue("@preco_venda", mProduto.getPreco_venda_PR());
                comm.Parameters.AddWithValue("@quantidade", mProduto.getQuantidade_PR());
                comm.Parameters.AddWithValue("@unidade", mProduto.getUnidade_PR());
                comm.Parameters.AddWithValue("@validade", mProduto.getValidade_PR());
                comm.Parameters.AddWithValue("@descricao", mProduto.getDescricao_PR());

                // Executa o código SQL:
                comm.ExecuteNonQuery();

                return "Produto cadastrado com sucesso!";
            }
            catch (NpgsqlException ex)
            {
                return ex.ToString();
            }
        }

        public NpgsqlDataReader listaProduto()
{
    string sql = "select * from Produto";
    conectaPG con = new conectaPG();
    NpgsqlConnection conn = con.conectar();
    NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

    try
    {
        return comm.ExecuteReader();
    }
    catch (NpgsqlException ex)
    {
        return null;
    }
}

public NpgsqlDataReader pesquisaProduto(string nome)
{
    string sql = "select p.codigo, p.nome_produto, p.preco_venda, p.quantidade, p.validade, p.descricao, " +
        "m.nome_marca, tp.nome_tipo from produto p inner join tipo_produto tp on p.cod_tipo = tp.codigo where " +
        "p.nome_produto like '" + nome + "%';";

    conectaPG con = new conectaPG();
    NpgsqlConnection conn = con.conectar();
    NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

    try
    {
        return comm.ExecuteReader();
    }
    catch (NpgsqlException ex)
    {
        return null;
    }
}
    }
}
