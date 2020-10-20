using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ProjetoIntegrador2014.Formularios;
using ProjetoIntegrador2014.Formularios.Empresa;

namespace ProjetoIntegrador2014
{
    public partial class frmEmpresa : Telerik.WinControls.UI.RadForm
    {
        private Tools tool;
        private Empresa emp;
        private EmpresaDAL empDAL;
        public frmEmpresa()
        {
            InitializeComponent();
            this.tool = new Tools();
        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void radLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpresaInscricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmpresaSalvar_Click(object sender, EventArgs e)
        {
            this.emp = new Empresa();
            this.empDAL = new EmpresaDAL();
            try
            {
                if (this.tool.ChecaCampoNullo(rgBox1))
                {
                    this.emp.Codigo = 0;
                    this.emp.Cnpj = txtEmpresaCnpj.Text;
                    this.emp.NomeEmpresa = txtNomeEmpresa.Text;
                    this.emp.InscrEstadual = txtEmpresaInscricao.Text;
                    this.emp.Numero = txtNumEmpresa.Text;
                    this.emp.Endereco = txtEmpresaEndereço.Text;
                    this.emp.Bairro = txtEmpresaBairro.Text;
                    this.emp.Cep = txtEmpresaCEP.Text;
                    this.emp.Tel1 = txtEmpresaTel1.Text;
                    this.emp.Tel2 = txtEmpresaTel2.Text;
                    this.emp.Email = txtEmpresaEmail.Text;

                    this.empDAL.Gravar(this.emp);

                    MessageBox.Show("Empresa cadastrada com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

        private void btnEmpresaAlterar_Click(object sender, EventArgs e)
        {
            this.emp = new Empresa();
            this.empDAL = new EmpresaDAL();
            try
            {
                if (this.tool.ChecaCampoNullo(rgBox1))
                {
                    this.emp.Codigo = int.Parse(txtCodigo.Text);
                    this.emp.Cnpj = txtEmpresaCnpj.Text;
                    this.emp.NomeEmpresa = txtNomeEmpresa.Text;
                    this.emp.InscrEstadual = txtEmpresaInscricao.Text;
                    this.emp.Numero = txtNumEmpresa.Text;
                    this.emp.Bairro = txtEmpresaBairro.Text;
                    this.emp.Cep = txtEmpresaCEP.Text;
                    this.emp.Tel1 = txtEmpresaTel1.Text;
                    this.emp.Tel2 = txtEmpresaTel2.Text;

                    this.empDAL.Gravar(this.emp);

                    MessageBox.Show("Empresa atualizada com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

        private void btnEmpresaExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                this.empDAL = new EmpresaDAL();
                if (txtCodigo.Text != "")
                {
                    this.empDAL.Excluir(int.Parse(txtCodigo.Text));
                    btnLimpar_Click(null, null);
                    MessageBox.Show("Cadastro excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.empDAL = new EmpresaDAL();
            this.emp = new Empresa();
            try
            {
                if (cbPesquisa.Text != "" && txtFiltro.Text != "")
                {
                    if (cbPesquisa.SelectedText == "CNPJ")
                    {
                        this.emp.Cnpj = cbPesquisa.Text;
                    }
                    else if (cbPesquisa.SelectedText == "Código")
                    {
                        this.emp.Codigo = int.Parse(cbPesquisa.Text);
                    }
                    else if (cbPesquisa.SelectedText == "Nome Empresa")
                    {
                        this.emp.NomeEmpresa = cbPesquisa.Text;
                    }

                    dgvEmpresa.DataSource = this.empDAL.Consultar(this.emp);
                }
                else if (cbPesquisa.Text == "" && txtFiltro.Text == "")
                {
                    dgvEmpresa.DataSource = this.empDAL.Consultar();
                    dgvEmpresa.AutoResizeColumns();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message, "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
            }
        }

        private void dgvEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpresa.DataSource != null)
            {
                pvEmpresa.SelectedPage = pgCadastro;
                txtCodigo.Enabled = false;
                txtCodigo.Text = dgvEmpresa["codigo", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtEmpresaCnpj.Text = dgvEmpresa["cnpj", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtNomeEmpresa.Text = dgvEmpresa["empresa", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtEmpresaInscricao.Text = dgvEmpresa["InscricaoEstadual", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtEmpresaEndereço.Text = dgvEmpresa["endereco", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtNumEmpresa.Text = dgvEmpresa["EnderecoNum", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtEmpresaBairro.Text = dgvEmpresa["bairro", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtEmpresaCEP.Text = dgvEmpresa["cep", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtEmpresaTel1.Text = dgvEmpresa["telefone1", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtEmpresaTel2.Text = dgvEmpresa["telefone2", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();
                txtEmpresaEmail.Text = dgvEmpresa["email", dgvEmpresa.CurrentCellAddress.Y].Value.ToString();            
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.tool.LimpaCampos(rgBox1);
            txtCodigo.Enabled = true;
            txtCodigo.Clear();
        }
    }
}
