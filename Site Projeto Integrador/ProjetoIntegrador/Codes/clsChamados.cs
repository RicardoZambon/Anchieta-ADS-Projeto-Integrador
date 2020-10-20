using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador {
    class clsChamados {
        private int codigo;
        public int Codigo {
            get { return codigo; }
            set { codigo = value; }
        }

        private int abertoPor;
        public int AbertoPor {
            get { return abertoPor; }
            set { abertoPor = value; }
        }

        private DateTime dataAbertura;
        public DateTime DataAbertura {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }

        private string assunto;
        public string Assunto {
            get { return assunto; }
            set { assunto = value; }
        }

        private string problemaInicial;
        public string ProblemaInicial {
            get { return problemaInicial; }
            set { problemaInicial = value; }
        }

        private int status;
        public int Status {
            get { return status; }
            set { status = value; }
        }

        private int fechadoPor;
        public int FechadoPor {
            get { return fechadoPor; }
            set { fechadoPor = value; }
        }

        private DateTime dataFechamento;
        public DateTime DataFechamento {
            get { return dataFechamento; }
            set { dataFechamento = value; }
        }

        private int prioridade;
        public int Prioridade {
            get { return prioridade; }
            set { prioridade = value; }
        }
    }

    class clsChamadoDAL {
        public void AbrirChamado(clsChamados Chamado) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into Chamados (AbertoPor,DataAbertura,Assunto,Status,ProblemaInicial, Prioridade) Values(@AbertoPor,@DataAbertura,@Assunto,@Status,@ProblemaInicial,@Prioridade)";
            cmd.Parameters.Add("AbertoPor", SqlDbType.Int).Value = Chamado.AbertoPor;
            cmd.Parameters.Add("DataAbertura", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("Assunto", SqlDbType.VarChar).Value = Chamado.Assunto;
            cmd.Parameters.Add("ProblemaInicial", SqlDbType.VarChar).Value = Chamado.ProblemaInicial;
            cmd.Parameters.Add("Prioridade", SqlDbType.Int).Value = Chamado.Prioridade;
            cmd.Parameters.Add("Status", SqlDbType.Int).Value = 1;
            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            BancoDeDados.ExecutaCommand(cmd);
        }
    }
}