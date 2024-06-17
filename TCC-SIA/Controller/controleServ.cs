using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_SIA.Model;
using TCC_SIA.Model;
using TCC_SIA.View;
using Npgsql;


namespace TCC_SIA.Controller
{
    internal class controleServ
    {
        public string cadastraServico(modeloServ mServico)
        {
            string sql = "insert sla o  " + "values  ";

            conectaPG con = new conectaPG();

            NpgsqlConnection conn = con.conectar();

            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);



        }
    }
}
