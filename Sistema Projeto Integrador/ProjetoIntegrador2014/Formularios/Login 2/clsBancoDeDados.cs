using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador2014
{
    class clsBancoDeDados
    {
        private SqlConnection Conexao = new SqlConnection();

        private string RetornaStrConexao()
        {
            return "Server=50.31.134.243;Database=Anchieta_ProjetoIntegrador;User Id=AnchietaPI;Password=aiai123;";
            //return "Data Source=localhost;Initial Catalog=Anchieta_ProjetoIntegrador;Integrated Security=True";
        }

        private void Conecta()
        {
            if (Conexao.State == ConnectionState.Closed)
            {
                Conexao.ConnectionString = RetornaStrConexao();
                Conexao.Open();
            }
        }
        private void Desconecta()
        {
            if (Conexao.State == ConnectionState.Open)
            {
                Conexao.Close();
            }
        }

        public DataTable ExecutaSelect(SqlCommand ComandoSQL)
        {
            SqlDataAdapter cmd = new SqlDataAdapter(ComandoSQL.CommandText, Conexao);
            foreach (SqlParameter p in ComandoSQL.Parameters)
            {
                cmd.SelectCommand.Parameters.Add(p.ParameterName, p.SqlDbType).Value = p.Value;
            }
            Conecta();

            DataSet ds = new DataSet();
            cmd.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecutaCommand(SqlCommand ComandoSQL)
        {
            SqlCommand cmd = new SqlCommand(ComandoSQL.CommandText, Conexao);
            foreach (SqlParameter p in ComandoSQL.Parameters)
            {
                cmd.Parameters.Add(p.ParameterName, p.SqlDbType).Value = p.Value;
            }
            Conecta();
            cmd.ExecuteNonQuery();
            Desconecta();
        }
    }
}
