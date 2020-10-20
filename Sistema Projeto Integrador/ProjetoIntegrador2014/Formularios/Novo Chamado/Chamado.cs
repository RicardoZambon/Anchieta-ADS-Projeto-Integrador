using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador2014.Formularios.Novo_Chamado
{
    class Chamados
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private int abertoPor;
        public int AbertoPor
        {
            get { return abertoPor; }
            set { abertoPor = value; }
        }

        private DateTime dataAbertura;
        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }

        private string assunto;
        public string Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }

        private string problemaInicial;
        public string ProblemaInicial
        {
            get { return problemaInicial; }
            set { problemaInicial = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int fechadoPor;
        public int FechadoPor
        {
            get { return fechadoPor; }
            set { fechadoPor = value; }
        }

        private DateTime dataFechamento;
        public DateTime DataFechamento
        {
            get { return dataFechamento; }
            set { dataFechamento = value; }
        }

        private int prioridade;
        public int Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }

        public DataTable DataResult;
        public object ObjNome;
    }

    class ChamadoDAL
    {
        public DataTable Consultar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select codigo, DataAbertura, Assunto, Status, AbertoPor, Prioridade From Chamados Where Status=1";

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public DataTable ConsultarFechado()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select codigo, DataAbertura, Assunto, Status, AbertoPor, Prioridade From Chamados Where Status=2";

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        } 
        
        public DataTable ConsultarBaseConhecimento()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Chamados Where Status=2";

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public Chamados ConsultarFechado(Chamados chamado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select codigo, DataAbertura, Assunto, Status, AbertoPor, Prioridade From Chamados 
                                Where Codigo like @Codigo
                                  and AbertoPor like @AberPor
                                  and Assunto like @Assunto
                                  and Status = 2";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = chamado.Codigo + "%";
            cmd.Parameters.Add("AberPor", SqlDbType.Int).Value = chamado.AbertoPor + "%";
            cmd.Parameters.Add("Assunto", SqlDbType.Int).Value = chamado.Assunto + "%";


            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
            {
                chamado.DataResult = Tabela;
                Chamados Chamado = new Chamados();
                Chamado.Codigo = int.Parse(Tabela.Rows[0]["Codigo"].ToString());
                Chamado.AbertoPor = int.Parse(Tabela.Rows[0]["AbertoPor"].ToString());
                Chamado.DataAbertura = DateTime.Parse(Tabela.Rows[0]["DataAbertura"].ToString());
                Chamado.Assunto = Tabela.Rows[0]["Assunto"].ToString();
                Chamado.ProblemaInicial = Tabela.Rows[0]["ProblemaInicial"].ToString();
                Chamado.Status = int.Parse(Tabela.Rows[0]["Status"].ToString());
                Chamado.FechadoPor = int.Parse(Tabela.Rows[0]["FechadoPor"].ToString());
                Chamado.DataFechamento = DateTime.Parse(Tabela.Rows[0]["DataFechamento"].ToString());
                return Chamado;
            }
            else
                return null;
        }

        public Chamados Consultar(Chamados chamado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select codigo, DataAbertura, Assunto, Status, AbertoPor, Prioridade From Chamados 
                                Where Codigo like @Codigo
                                  and AbertoPor like @AberPor
                                  and Assunto like @Assunto
                                  and Status = 1";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = chamado.Codigo + "%";
            cmd.Parameters.Add("AberPor", SqlDbType.Int).Value = chamado.AbertoPor + "%";
            cmd.Parameters.Add("Assunto", SqlDbType.Int).Value = chamado.Assunto + "%";


            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
            {
                chamado.DataResult = Tabela;
                Chamados Chamado = new Chamados();
                Chamado.Codigo = int.Parse(Tabela.Rows[0]["Codigo"].ToString());
                Chamado.AbertoPor = int.Parse(Tabela.Rows[0]["AbertoPor"].ToString());
                Chamado.DataAbertura = DateTime.Parse(Tabela.Rows[0]["DataAbertura"].ToString());
                Chamado.Assunto = Tabela.Rows[0]["Assunto"].ToString();
                Chamado.ProblemaInicial = Tabela.Rows[0]["ProblemaInicial"].ToString();
                Chamado.Status = int.Parse(Tabela.Rows[0]["Status"].ToString());
                Chamado.FechadoPor = int.Parse(Tabela.Rows[0]["FechadoPor"].ToString());
                Chamado.DataFechamento = DateTime.Parse(Tabela.Rows[0]["DataFechamento"].ToString());
                return Chamado;
            }
            else
                return null;
        }

        public Chamados ConsultaUserEmpDep(int codigo)
        {
            List<string> lsstr = new List<string>();
            SqlCommand cmd = new SqlCommand();
            Chamados chamado = new Chamados();
            cmd.CommandText = @"select u.usuario, u.empresa, u.departamento, ch.DataAbertura, cs.Prioridade from Chamados ch, Usuarios u, Prioridades cs
                                where u.codigo = ch.AbertoPor and ch.Status = cs.Codigo
                                and ch.codigo = @codigoC";
            
            cmd.Parameters.Add("codigoC", SqlDbType.Int).Value = codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
            {
                lsstr.Add(Tabela.DataSet.Tables[0].Rows[0]["usuario"].ToString());
                lsstr.Add(Tabela.DataSet.Tables[0].Rows[0]["empresa"].ToString());
                lsstr.Add(Tabela.DataSet.Tables[0].Rows[0]["departamento"].ToString());
                lsstr.Add(Tabela.DataSet.Tables[0].Rows[0]["DataAbertura"].ToString());
                lsstr.Add(Tabela.DataSet.Tables[0].Rows[0]["Prioridade"].ToString());
                chamado.ObjNome = lsstr;
                return chamado;
            }   
            else
                return null;
        }

        public void Excluir(int Codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete Chamados Where Codigo=@Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            BancoDeDados.ExecutaCommand(cmd);
        }

        public void AbrirChamado(Chamados Chamado)
        {
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

        public void FecharChamado(Chamados Chamado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Update Chamados Set FechadoPor=@FechadoPor, DataFechamento=@DataFechamento, Status=@Status Where Codigo=@Codigo";
            cmd.Parameters.Add("FechadoPor", SqlDbType.Int).Value = Chamado.FechadoPor;
            cmd.Parameters.Add("DataFechamento", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("Status", SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Chamado.Codigo;
            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            BancoDeDados.ExecutaCommand(cmd);
        }
    }

}
