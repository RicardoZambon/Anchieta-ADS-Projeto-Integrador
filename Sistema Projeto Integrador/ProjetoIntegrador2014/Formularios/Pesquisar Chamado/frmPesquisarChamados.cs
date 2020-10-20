using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Threading;
using ProjetoIntegrador2014.Formularios.Novo_Chamado;
using ProjetoIntegrador2014.Formularios;
using ProjetoIntegrador2014.Formularios.Usuario;

namespace ProjetoIntegrador2014
{
    public partial class frmPesquisarChamados : Telerik.WinControls.UI.RadForm
    {
        private Chamados chamado;
        private ChamadoDAL chamadoDAL;
        private ChamadosRespostas chamadoresp;
        private ChamadosRespostasDAL chamadorespDAL;
        private Tools tool;
        public frmPesquisarChamados()
        {
            InitializeComponent();
            this.tool = new Tools();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            this.chamadoDAL = new ChamadoDAL();
            this.chamado = new Chamados();
            dgvChamado.DataSource = null;
            try
            {
                if (cbPesquisa.Text != "" && txtFiltro.Text != "")
                {
                    if (cbPesquisa.SelectedText == "Aberto Por")
                    {
                        this.chamado.AbertoPor = int.Parse(cbPesquisa.Text);
                    }
                    else if (cbPesquisa.SelectedText == "Código")
                    {
                        this.chamado.Codigo = int.Parse(cbPesquisa.Text);
                    }
                    else if (cbPesquisa.SelectedText == "Assunto")
                    {
                        this.chamado.Assunto = cbPesquisa.Text;
                    }

                    this.chamado = this.chamadoDAL.Consultar(this.chamado);
                    dgvChamado.DataSource = this.chamado.DataResult;
                    dgvChamado.AutoResizeColumns();
                }
                else if (cbPesquisa.Text == "" && txtFiltro.Text == "")
                {
                    dgvChamado.DataSource = this.chamadoDAL.Consultar();
                    dgvChamado.AutoResizeColumns();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message, "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvChamado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codUser, codChamado;
            this.chamado = new Chamados();
            List<string> lsstr = new List<string>();
            if (dgvChamado.DataSource != null)
            {
                pvChaAberto.SelectedPage = pgDados;
                //codUser = int.Parse(dgvChamado["abertopor", dgvChamado.CurrentCellAddress.Y].Value.ToString());
                codChamado = int.Parse(dgvChamado["codigo", dgvChamado.CurrentCellAddress.Y].Value.ToString());
                txtCodigo.Text = codChamado.ToString();
                this.chamado = this.chamadoDAL.ConsultaUserEmpDep(codChamado);
                lsstr = (List<string>)this.chamado.ObjNome;
                lblAbertoPor.Text = lsstr[0];
                lblDept.Text = lsstr[1];
                lblDataHora.Text = lsstr[3];
                lblEmpresa.Text = lsstr[2];
                lblPrioridade.Text = lsstr[4];

                PreencherFridHistorico(codChamado);
            }
        }

        private void PreencherFridHistorico(int codChamado)
        {
            this.chamadoresp = new ChamadosRespostas();
            this.chamadorespDAL = new ChamadosRespostasDAL();
            this.chamadoresp = this.chamadorespDAL.Consultar(codChamado);
            dgvHistorico.DataSource = this.chamadoresp.DataResult;
            dgvHistorico.AutoResizeColumns();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.tool.LimpaCampos(rgBox5);
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioDAL userDAL = new UsuarioDAL();
            this.chamado = new Chamados();
            this.chamadoDAL = new ChamadoDAL();
            this.chamadoresp = new ChamadosRespostas();
            this.chamadorespDAL = new ChamadosRespostasDAL();
            try
            {
                if (tool.ChecaCampoNullo(rgBox5))
                {
                    user.NomeAcesso = clsOperadores.NomeLogin;
                    DataTable dt = userDAL.ConsultarCodigo(user);
                    int vUser = int.Parse(dt.DataSet.Tables[0].Rows[0]["codigo"].ToString());
                    this.chamadoresp.Chamado = int.Parse(txtCodigo.Text);
                    this.chamadoresp.Codigo = 0;
                    this.chamadoresp.Resposta = txtResp.Text;
                    this.chamadoresp.Usuario = vUser;
                    this.chamadoresp.DataHora = DateTime.Now;

                    this.chamadorespDAL.Gravar(this.chamadoresp);

                    if (chkValor6.Checked)
                    {
                        this.chamado.FechadoPor = vUser;
                        this.chamado.Codigo = int.Parse(txtCodigo.Text);
                        this.chamadoDAL.FecharChamado(this.chamado);

                        MessageBox.Show("Chamado fechado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.tool.LimpaCampos(rgBox5);

                    }
                    else
                    {
                        MessageBox.Show("Chamado respondido com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.tool.LimpaCampos(rgBox5);
                    }
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

        private void dgvChamado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            PreencherFridHistorico(int.Parse(txtCodigo.Text));
        }
    }
}
