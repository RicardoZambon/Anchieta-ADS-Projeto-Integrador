using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ProjetoIntegrador2014.Formularios.Novo_Chamado;
using ProjetoIntegrador2014.Formularios;
using ProjetoIntegrador2014.Formularios.Usuario;

namespace ProjetoIntegrador2014
{
    public partial class frmNovoChamado : Form
    {
        private Chamados chamado;
        private ChamadoDAL chamadoDAL;
        private ChamadosPrioridades prio;
        private ChamadosPrioridadesDAL prioDAL;
        private Tools tool;
        public frmNovoChamado()
        {
            InitializeComponent();
            this.tool = new Tools();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioDAL userDAL = new UsuarioDAL();
            this.chamado = new Chamados();
            this.chamadoDAL = new ChamadoDAL();
            try
            {
                if (tool.ChecaCampoNullo(txtDescricao))
                {
                    user.NomeAcesso = txtAbertoPor.Text;

                    DataTable dt = userDAL.ConsultarCodigo(user);
                    int vUser = int.Parse(dt.DataSet.Tables[0].Rows[0]["codigo"].ToString());
                    this.chamado.Codigo = 0;
                    this.chamado.AbertoPor = vUser;
                    this.chamado.Assunto = txtAssunto.Text;
                    this.chamado.DataAbertura = DateTime.Now;
                    this.chamado.ProblemaInicial = txtDescricao.Text;
                    this.chamado.Prioridade = int.Parse(cbPrioridade.Text);                    

                    this.chamadoDAL.AbrirChamado(this.chamado);

                    MessageBox.Show("Chamado aberto com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.tool.LimpaCampos(txtDescricao);
                }
                else
                {
                    MessageBox.Show("Por favor preencher todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.tool.LimpaCampos(txtDescricao);
        }

        private void cbPrioridade_Click(object sender, EventArgs e)
        {
            //this.prio = new ChamadosPrioridades();
            //this.prioDAL = new ChamadosPrioridadesDAL();

            //DataTable dt = new DataTable();
            //dt = this.prioDAL.Consultar();
            //cbPrioridade.DataSource = dt;
            //cbPrioridade.DisplayMember = "Prioridade";
            //cbPrioridade.ValueMember = "Codigo";
        }

        private void cbPriori_Click(object sender, EventArgs e)
        {
            this.prio = new ChamadosPrioridades();
            this.prioDAL = new ChamadosPrioridadesDAL();

            DataTable dt = new DataTable();
            dt = this.prioDAL.Consultar();
            cbPrioridade.DataSource = dt;
            cbPrioridade.DisplayMember = "Codigo";
            cbPrioridade.BestFitColumns();
        }
    }
}
