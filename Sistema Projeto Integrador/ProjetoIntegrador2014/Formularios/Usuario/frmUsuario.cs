using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Threading;
using ProjetoIntegrador2014.Formularios;
using ProjetoIntegrador2014.Formularios.Usuario;
using ProjetoIntegrador2014.Formularios.Empresa;
using ProjetoIntegrador2014.Formularios.Departamento;

namespace ProjetoIntegrador2014
{
    public partial class frmUsuario : Telerik.WinControls.UI.RadForm
    {
        private Tools tool;
        private Usuario user;
        private UsuarioDAL userDAL;
        private EmpresaDAL empDAL;
        private DepartamentosDAL deptDAL;
        public frmUsuario()
        {
            InitializeComponent();
            this.tool = new Tools();
        }

        private void RadForm2_Load(object sender, EventArgs e)
        {

        }

        private void radButton6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                //radMaskedEditBox1.PasswordChar = '\0';
            }
        }

        private void radButton6_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void radButton6_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void radButton6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                txtSenha1.PasswordChar = '\0';
                txtSenha2.PasswordChar = '\0';
            }
        }

        private void radButton6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                txtSenha1.PasswordChar = (char)8226;
                txtSenha2.PasswordChar = (char)8226;
            }
        }

        private void radMaskedEditBox2_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void radMaskedEditBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSenha1.Text == txtSenha2.Text)
            {
                pcBox1.Image = global::ProjetoIntegrador2014.Properties.Resources.OkFlag;
            }
            else
            {
                pcBox1.Image = global::ProjetoIntegrador2014.Properties.Resources.ErrorFlag;
            }
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            this.user = new Usuario();
            this.userDAL = new UsuarioDAL();
            try
            {
                if (txtSenha1.Text == txtSenha2.Text)
                {
                    if (tool.ChecaCampoNullo(rgBox1))
                    {
                        this.user.Codigo = 0;
                        this.user.NomeCompleto = txtNomeComp.Text;
                        this.user.NomeAcesso = txtNomeAcesso.Text;
                        this.user.Senha = txtSenha1.Text;
                        this.user.Nivel = int.Parse(cbNivel.SelectedValue.ToString());
                        this.user.Empresa = int.Parse(cbEmpresa.SelectedValue.ToString());
                        this.user.Departamento = int.Parse(cbDepartamento.SelectedValue.ToString()) ;

                        this.userDAL.Gravar(this.user);

                        MessageBox.Show("Usuário cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        btnLimpar_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Por favor preencher todos os campos!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Senhas não combinam!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); 
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.user = new Usuario();
            this.userDAL = new UsuarioDAL();
            this.empDAL = new EmpresaDAL();
            try
            {
                if (txtSenha1.Text == txtSenha2.Text)
                {
                    if (tool.ChecaCampoNullo(rgBox1))
                    {
                        this.user.Codigo = int.Parse(txtCodigo.Text);
                        this.user.NomeCompleto = txtNomeComp.Text;
                        this.user.NomeAcesso = txtNomeAcesso.Text;
                        this.user.Senha = txtSenha1.Text;
                        this.user.Nivel = int.Parse(cbNivel.SelectedValue.ToString());
                        if (cbEmpresa.SelectedValue != null)
                            this.user.Empresa = int.Parse(cbEmpresa.SelectedValue.ToString());
                        else
                            this.user.Empresa = this.empDAL.ConsultarEmpresa(cbEmpresa.Text);
                        this.user.Departamento = int.Parse(cbDepartamento.SelectedValue.ToString());

                        this.userDAL.Gravar(this.user);

                        MessageBox.Show("Usuário atualizado com sucesso", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        btnLimpar_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Por favor preencher todos os campos!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Senhas não combinam!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.userDAL = new UsuarioDAL();
            try
            {                
                if (txtCodigo.Text != "")
                {
                    this.userDAL.Excluir(int.Parse(txtCodigo.Text));
                    MessageBox.Show("Usuário excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    btnLimpar_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Informe o código do usuário!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.userDAL = new UsuarioDAL();
            this.user = new Usuario();
            try
            {
                if (cbPesquisa.Text != "" && txtFiltro.Text != "")
                {
                    if (cbPesquisa.SelectedText == "Nome Completo")
                    {
                        this.user.NomeCompleto = cbPesquisa.Text;
                    }
                    else if (cbPesquisa.SelectedText == "Código")
                    {
                        this.user.Codigo = int.Parse(cbPesquisa.Text);
                    }
                    else if (cbPesquisa.SelectedText == "Nome Acesso")
                    {
                        this.user.NomeAcesso = cbPesquisa.Text;
                    }

                    dgvUsuario.DataSource = this.userDAL.Consultar(this.user);
                }
                else if (cbPesquisa.Text == "" && txtFiltro.Text == "")
                {
                    dgvUsuario.DataSource = this.userDAL.Consultar();
                    dgvUsuario.AutoResizeColumns();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message, "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.DataSource != null)
            {
                pvUsuario.SelectedPage = pgCadastro;
                txtCodigo.Enabled = false;
                txtCodigo.Text = dgvUsuario["codigo", dgvUsuario.CurrentCellAddress.Y].Value.ToString();
                txtNomeComp.Text = dgvUsuario["nome", dgvUsuario.CurrentCellAddress.Y].Value.ToString();
                txtNomeAcesso.Text = dgvUsuario["usuario", dgvUsuario.CurrentCellAddress.Y].Value.ToString();
                txtSenha1.Text = dgvUsuario["senha", dgvUsuario.CurrentCellAddress.Y].Value.ToString();
                txtSenha2.Text = dgvUsuario["senha", dgvUsuario.CurrentCellAddress.Y].Value.ToString();
                cbNivel.Text = dgvUsuario["tipo", dgvUsuario.CurrentCellAddress.Y].Value.ToString();
                cbEmpresa.Text = dgvUsuario["empresa", dgvUsuario.CurrentCellAddress.Y].Value.ToString();
                cbDepartamento.Text = dgvUsuario["departamento", dgvUsuario.CurrentCellAddress.Y].Value.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.tool.LimpaCampos(rgBox1);
            txtCodigo.Enabled = true;
            txtCodigo.Clear();
        }

        private void CbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNivel_Click(object sender, EventArgs e)
        {
            this.userDAL = new UsuarioDAL();
            DataTable dt = new DataTable();
            dt = this.userDAL.BuscarNivel();
            cbNivel.DataSource = dt;
            cbNivel.DisplayMember = "Tipo";
            cbNivel.ValueMember = "Codigo";
            cbNivel.BindingContext = this.BindingContext;
            cbNivel.BestFitColumns();
        }

        private void cbEmpresa_Click(object sender, EventArgs e)
        {
            this.empDAL = new EmpresaDAL();

            DataTable dt = new DataTable();
            dt = this.empDAL.ConsultarEmpresa();
            cbEmpresa.DataSource = dt;
            cbEmpresa.DisplayMember = "Empresa";
            cbEmpresa.ValueMember = "Codigo";
            cbEmpresa.BindingContext = this.BindingContext;
            cbEmpresa.BestFitColumns();
        }

        private void cbDepartamento_Click(object sender, EventArgs e)
        {
            this.deptDAL = new DepartamentosDAL();
            DataTable dt = new DataTable();
            dt = this.deptDAL.ConsultarDept();
            cbDepartamento.DataSource = dt;
            cbDepartamento.DisplayMember = "Departamento";
            cbDepartamento.ValueMember = "Codigo";
            cbDepartamento.BindingContext = this.BindingContext;
            cbDepartamento.BestFitColumns();
        }
    }
}
