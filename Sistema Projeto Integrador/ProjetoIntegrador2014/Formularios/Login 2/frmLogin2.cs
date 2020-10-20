using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace ProjetoIntegrador2014
{
    public partial class frmLogin2 : RadForm
    {
        BackgroundWorker bckLogin = new BackgroundWorker();

        public frmLogin2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2010Black";

            this.Text = Application.CompanyName + " :: " + Application.ProductName;
            lblVersao.Text = "v " + Application.ProductVersion;

            lblImgStatus.Image = null; lblImgStatus.Text = "";
            lblStatus.Text = "";

            bckLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bckLogin_DoWork);
            bckLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bckLogin_RunWorkerCompleted);
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            lblStatus.ToolTipText = lblStatus.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!bckLogin.IsBusy)
            {
                lblImgStatus.Image = global::ProjetoIntegrador2014.Properties.Resources.loader;
                lblStatus.Text = "";
                if (!bckLogin.IsBusy) bckLogin.RunWorkerAsync();
            }
        }

        public void bckLogin_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                e.Result = "usuario";
            }
            else if (txtSenha.Text == "")
            {
                e.Result = "senha";
            }
            else
            {
                try
                {
                    clsOperadores Operador = new clsOperadores();
                    Operador.SUsuario = txtUsuario.Text;
                    Operador.SSenha = txtSenha.Text;

                    clsOperadoresDAL OperadoresDAL = new clsOperadoresDAL();
                    if (OperadoresDAL.EfetuaLogin(Operador) == true)
                        e.Result = "sucesso";
                    else
                        e.Result = "errologin";
                }
                catch (Exception ex)
                {
                    e.Result = ex.Message;
                }
            }
        }
        public void bckLogin_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            string resultado = Convert.ToString(e.Result);
            switch (resultado)
            {
                case "usuario":
                    lblStatus.Text = "Informe o seu usuário.";
                    lblImgStatus.Image = global::ProjetoIntegrador2014.Properties.Resources.status_warning;
                    txtUsuario.Select();
                    break;
                case "senha":
                    lblStatus.Text = "Informe a sua senha.";
                    lblImgStatus.Image = global::ProjetoIntegrador2014.Properties.Resources.status_warning;
                    txtSenha.Select();
                    break;
                case "errologin":
                    lblStatus.Text = "Usuário ou senha inválidos, tente novamente.";
                    lblImgStatus.Image = global::ProjetoIntegrador2014.Properties.Resources.status_warning;
                    break;
                case "sucesso":
                    clsOperadores.NomeLogin = txtUsuario.Text;
                    lblStatus.Text = "Login com sucesso!";
                    this.Hide();

                    frmPrincipal frm = new frmPrincipal();
                    frm.Show();

                    lblImgStatus.Image = global::ProjetoIntegrador2014.Properties.Resources.status_sucess;
                    break;
                default:
                    lblStatus.Text = "Erro: " + e.Result;
                    lblImgStatus.Image = global::ProjetoIntegrador2014.Properties.Resources.status_error;
                    break;
            }
        }
    }
}
