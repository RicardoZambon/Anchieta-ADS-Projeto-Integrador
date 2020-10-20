using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoIntegrador2014.Formularios.Novo_Chamado
{
    class ChamadosRespostas
    {

        public DataTable DataResult;

        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private int usuario;
        public int Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private DateTime dataHora;
        public DateTime DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }

        private int chamado;
        public int Chamado
        {
            get { return chamado; }
            set { chamado = value; }
        }

        private string resposta;
        public string Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }
    }

    class ChamadosRespostasDAL
    {
        public DataTable Consultar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Chamados_Respostas Where Chamado=@CodigoChamado";
            //cmd.Parameters.Add("CodigoChamado", SqlDbType.Int).Value = CodigoChamado;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public DataTable ConsultarHistorico(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select ch.Codigo, ch.DataAbertura, ch.Assunto, ch.DataFechamento, ch.Prioridade, 
                                ch.Status, ch.FechadoPor, cr.Codigo codResp, cr.Resposta from Chamados ch, Chamados_Respostas cr
                                where ch.Codigo = cr.Chamado
                                and ch.Codigo = @Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);

            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
                return Tabela;
            else
                return null;
        }

        public ChamadosRespostas Consultar(int Codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From Chamados_Respostas Where Chamado=@Codigo";
            cmd.Parameters.Add("Codigo", SqlDbType.Int).Value = Codigo;

            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            DataTable Tabela = BancoDeDados.ExecutaSelect(cmd);


            if (Tabela.DataSet.Tables[0].Rows.Count > 0)
            {
                ChamadosRespostas Resposta = new ChamadosRespostas();
                Resposta.Codigo = int.Parse(Tabela.Rows[0]["Codigo"].ToString());
                Resposta.Chamado = int.Parse(Tabela.Rows[0]["Chamado"].ToString());
                Resposta.Usuario = int.Parse(Tabela.Rows[0]["Usuario"].ToString());
                Resposta.DataHora = DateTime.Parse(Tabela.Rows[0]["DataHora"].ToString());
                Resposta.Resposta = Tabela.Rows[0]["Resposta"].ToString();
                Resposta.DataResult = Tabela;
                return Resposta;
            }
            else
                return null;
        }

        public void Gravar(ChamadosRespostas Resposta)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into Chamados_Respostas (Chamado,Usuario,DataHora,Resposta) Values(@Chamado,@Usuario,@DataHora,@Resposta)";
            cmd.Parameters.Add("Chamado", SqlDbType.Int).Value = Resposta.Chamado;
            cmd.Parameters.Add("Usuario", SqlDbType.Int).Value = Resposta.Usuario;
            cmd.Parameters.Add("DataHora", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("Resposta", SqlDbType.VarChar).Value = Resposta.Resposta;
            clsBancoDeDados BancoDeDados = new clsBancoDeDados();
            BancoDeDados.ExecutaCommand(cmd);
        }
    }
}
