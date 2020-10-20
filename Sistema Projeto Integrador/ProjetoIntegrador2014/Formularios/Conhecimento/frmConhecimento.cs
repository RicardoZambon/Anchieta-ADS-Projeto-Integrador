using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ProjetoIntegrador2014.Formularios.Novo_Chamado;

namespace ProjetoIntegrador2014
{
    public partial class frmConhecimento : Telerik.WinControls.UI.RadForm
    {
        private Chamados chamado;
        private ChamadoDAL chamadoDAL;
        private ChamadosRespostas chamadoresp;
        private ChamadosRespostasDAL chamadorespDAL;
        public frmConhecimento()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.chamadoDAL = new ChamadoDAL();
            this.chamado = new Chamados();
            this.chamadorespDAL = new ChamadosRespostasDAL();
            this.chamadoresp = new ChamadosRespostas();
            dgvConsulta.DataSource = null;
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

                    this.chamado = this.chamadoDAL.ConsultarFechado(this.chamado);
                    dgvConsulta.DataSource = this.chamado.DataResult;
                    dgvConsulta.AutoResizeColumns();
                }
                else if (cbPesquisa.Text == "" && txtFiltro.Text == "")
                {
                    dgvConsulta.DataSource = this.chamadoDAL.ConsultarFechado();
                    dgvConsulta.AutoResizeColumns();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message, "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codChamado;
            this.chamado = new Chamados();
            List<string> lsstr = new List<string>();
            if (dgvConsulta.DataSource != null)
            {
                pvConhecimento.SelectedPage = pgCadastro;
                //codUser = int.Parse(dgvChamado["abertopor", dgvChamado.CurrentCellAddress.Y].Value.ToString());
                codChamado = int.Parse(dgvConsulta["codigo", dgvConsulta.CurrentCellAddress.Y].Value.ToString());
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
            this.chamadorespDAL = new ChamadosRespostasDAL();
            dgvHistorico.DataSource = this.chamadorespDAL.ConsultarHistorico(codChamado);
            dgvHistorico.AutoResizeColumns();
        }
    }
}
