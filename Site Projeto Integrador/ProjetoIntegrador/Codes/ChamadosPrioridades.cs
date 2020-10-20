using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador {
    class clsChamadosPrioridades {
        private int codigo;
        public int Codigo {
            get { return codigo; }
            set { codigo = value; }
        }

        private string prioridade;
        public string Prioridade {
            get { return prioridade; }
            set { prioridade = value; }
        }
    }

    class clsChamadosPrioridadesDAL {
        public DataTable Consultar() {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Prioridades";

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public clsChamadosPrioridades Consultar(int Codigo) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Prioridades Where Codigo=@Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0) {
                clsChamadosPrioridades Prioridade = new clsChamadosPrioridades();
                Prioridade.Codigo = int.Parse(Tabela.Rows[0]["Codigo"].ToString());
                Prioridade.Prioridade = Tabela.Rows[0]["Prioridade"].ToString();
                return Prioridade;
            } else
                return null;
        }
    }
}