using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador2014.Formularios.Novo_Chamado
{
    class ChamadosStatus
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }

    class ChamadosStatusDAL
    {
        public DataTable Consultar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Chamados_Status";

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public ChamadosStatus Consultar(int Codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Chamados_Status Where Codigo=@Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
            {
                ChamadosStatus Status = new ChamadosStatus();
                Status.Codigo = int.Parse(Tabela.Rows[0]["Codigo"].ToString());
                Status.Status = Tabela.Rows[0]["Status"].ToString();
                return Status;
            }
            else
                return null;
        }
    }
}
