using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ProjetoIntegrador2014.Formularios;
using ProjetoIntegrador2014.Formularios.Departamento;
using ProjetoIntegrador2014.Formularios.Empresa;

namespace ProjetoIntegrador2014
{
    public partial class frmDepartamentos : Telerik.WinControls.UI.RadForm
    {
        private Tools tool;
        private Departamentos dept;
        private DepartamentosDAL deptDAL;
        private Empresa emp;
        private EmpresaDAL empDAL;
        public frmDepartamentos()
        {
            InitializeComponent();
            this.tool = new Tools();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.tool.LimpaCampos(rgBox1);
            txtCodigo.Text = "";
            txtCodigo.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.dept = new Departamentos();
            this.deptDAL = new DepartamentosDAL();
            try
            {
                if (this.tool.ChecaCampoNullo(rgBox1))
                {
                    this.dept.Codigo = 0;
                    this.dept.Departamento = txtDepartamento.Text;
                    this.dept.Empresa = int.Parse(cbEmpresa.SelectedValue.ToString());
                    this.dept.Responsavel = txtGerente.Text;

                    this.deptDAL.Gravar(this.dept);

                    MessageBox.Show("Departamento cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btnLimpar_Click(null, null);
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

        private void cbEmpresa_Click(object sender, EventArgs e)
        {
            this.emp = new Empresa();
            this.empDAL = new EmpresaDAL();

            DataTable dt = new DataTable();
            dt = this.empDAL.ConsultarEmpresa();
            cbEmpresa.DataSource = dt;
            cbEmpresa.DisplayMember = "Empresa";
            cbEmpresa.ValueMember = "Codigo";
            cbEmpresa.BindingContext = this.BindingContext;
            cbEmpresa.BestFitColumns();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.dept = new Departamentos();
            this.deptDAL = new DepartamentosDAL();
            this.empDAL = new EmpresaDAL();
            try
            {
                if (this.tool.ChecaCampoNullo(rgBox1))
                {
                    this.dept.Codigo = int.Parse(txtCodigo.Text);
                    this.dept.Departamento = txtDepartamento.Text;
                    if (cbEmpresa.SelectedValue != null)
                        this.dept.Empresa = int.Parse(cbEmpresa.SelectedValue.ToString());
                    else
                        this.dept.Empresa = this.empDAL.ConsultarEmpresa(cbEmpresa.Text);
                    this.dept.Responsavel = txtGerente.Text;

                    this.deptDAL.Gravar(this.dept);

                    MessageBox.Show("Departamento atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btnLimpar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Por favor preencher todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.deptDAL = new DepartamentosDAL();
                if (txtCodigo.Text != "")
                {
                    this.deptDAL.Excluir(int.Parse(txtCodigo.Text));
                    btnLimpar_Click(null, null);
                    MessageBox.Show("Empresa excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Informe o código do cadastro!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void radButtonPesquisa_Click(object sender, EventArgs e)
        {
            this.deptDAL = new DepartamentosDAL();
            this.dept = new Departamentos();
            try
            {
                if (cbPesquisa.Text != "" && txtFiltro.Text != "")
                {
                    if (cbPesquisa.SelectedText == "Código")
                    {
                        this.dept.Codigo = int.Parse(cbPesquisa.Text);
                    }
                    else if (cbPesquisa.SelectedText == "Nome Departamento")
                    {
                        this.dept.Departamento = cbPesquisa.Text;
                    }

                    dgvDepartamento.DataSource = this.deptDAL.ConsultarDept(this.dept);
                }
                else if (cbPesquisa.Text == "" && txtFiltro.Text == "")
                {
                    dgvDepartamento.DataSource = this.deptDAL.Consultar();
                    dgvDepartamento.AutoResizeColumns();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message, "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartamento.DataSource != null)
            {
                pvDepartamento.SelectedPage = pgCadastro;
                txtCodigo.Enabled = false;
                txtCodigo.Text = dgvDepartamento["codigo", dgvDepartamento.CurrentCellAddress.Y].Value.ToString();
                txtDepartamento.Text = dgvDepartamento["departamento", dgvDepartamento.CurrentCellAddress.Y].Value.ToString();
                txtGerente.Text = dgvDepartamento["Responsavel", dgvDepartamento.CurrentCellAddress.Y].Value.ToString();
                cbEmpresa.Text = dgvDepartamento["empresa", dgvDepartamento.CurrentCellAddress.Y].Value.ToString();
                //cbEmpresa.SelectedValue = int.Parse(dgvDepartamento["codempresa", dgvDepartamento.CurrentCellAddress.Y].Value.ToString());
            }
        }
    }
}
