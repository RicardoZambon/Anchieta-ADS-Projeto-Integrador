using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Docking;

namespace ProjetoIntegrador2014
{
    public partial class frmPrincipal : Telerik.WinControls.UI.RadForm
    {
        public frmPrincipal()
        {
            InitializeComponent();

            
            this.radDock1.AutoDetectMdiChildren = true;            
            //this.documentContainer1.SendToBack();
            //this.radDock1.DockControl(this, DockPosition.Right);
            //this.toolWindow1.DockTo(this.toolWindow1, DockPosition.Right);
        }

        private void radImageButtonElement1_Click(object sender, EventArgs e)
        {
            frmUsuario RadTest = new frmUsuario();

            if (Application.OpenForms["frmUsuario"] == null)
            {
                RadTest.MdiParent = this;
                RadTest.Show();
            }
            else
            {
                Application.OpenForms["frmUsuario"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmUsuario"].Focus();
            }
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2010Black";

            timer1.Start();
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void radRibbonBarGroup9_Click(object sender, EventArgs e)
        {
            frmUsuario RadTest = new frmUsuario();

            if (Application.OpenForms["frmUsuario"] == null)
            {
                RadTest.MdiParent = this;
                RadTest.Show();
            }
            else
            {
                Application.OpenForms["frmUsuario"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmUsuario"].Focus();
            }
        }

        private void radRibbonBarGroup6_Click(object sender, EventArgs e)
        {
            frmPesquisarChamados RadTest = new frmPesquisarChamados();

            if (Application.OpenForms["frmPesquisarChamados"] == null)
            {
                RadTest.MdiParent = this;
                RadTest.Show();
            }
            else
            {
                Application.OpenForms["frmPesquisarChamados"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmPesquisarChamados"].Focus();
            }
        }

        private void imgPesBase_Click(object sender, EventArgs e)
        {
            radRibbonBarGroup6_Click(null, null);
        }

        private void radRibbonBarGroup2_Click(object sender, EventArgs e)
        {
            frmEmpresa RadTest = new frmEmpresa();

            if (Application.OpenForms["frmEmpresa"] == null)
            {
                RadTest.MdiParent = this;
                RadTest.Show();
            }
            else
            {
                Application.OpenForms["frmEmpresa"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmEmpresa"].Focus();
            }
        }

        private void radImageButtonElement4_Click(object sender, EventArgs e)
        {
            radRibbonBarGroup2_Click(null, null);
        }

        private void radRibbonBarGroup1_Click(object sender, EventArgs e)
        {
            frmDepartamentos RadTest = new frmDepartamentos();

            if (Application.OpenForms["frmDepartamentos"] == null)
            {
                RadTest.MdiParent = this;
                RadTest.Show();
            }

            else
            {
                Application.OpenForms["frmDepartamentos"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmDepartamentos"].Focus();
            }
        }

        private void radImageButtonElement5_Click(object sender, EventArgs e)
        {
            radRibbonBarGroup1_Click(null, null);
        }

        private void radRibbonBarGroup5_Click(object sender, EventArgs e)
        {
            frmConhecimento RadTest = new frmConhecimento();

            if (Application.OpenForms["frmConhecimento"] == null)
            {
                RadTest.MdiParent = this;
                RadTest.Show();
            }
            else
            {
                Application.OpenForms["frmConhecimento"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmConhecimento"].Focus();
            }
        }

        private void imgPesChamados_Click(object sender, EventArgs e)
        {
            radRibbonBarGroup5_Click(null, null);
        }

        private void radRibbonBarGroup4_Click(object sender, EventArgs e)
        {
            frmNovoChamado RadTest = new frmNovoChamado();

            if (Application.OpenForms["frmNovoChamado"] == null)
            {
                RadTest.MdiParent = this;
                RadTest.Show();
            }
            else
            {
                Application.OpenForms["frmNovoChamado"].WindowState = FormWindowState.Normal;
                Application.OpenForms["frmNovoChamado"].Focus();
            }
        }

        private void imgRegChamado_Click(object sender, EventArgs e)
        {
            radRibbonBarGroup4_Click(null, null);
        }

        private void PrepareMDIContainerForThemeChange()
        {
            if (this.ActiveMdiChild == null)
                return;
            if (this.ActiveMdiChild.WindowState == FormWindowState.Maximized)
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Normal;
            }
        }

        private void radImageButtonElement7_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplicationThemeName = "Office2010Black";
        }

        private void radImageButtonElement8_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplicationThemeName = "Office2010Silver";
        }

        private void radImageButtonElement9_Click(object sender, EventArgs e)
        {
            this.PrepareMDIContainerForThemeChange();
            ThemeResolutionService.ApplicationThemeName = "Breeze";
        }

        private void radImageButtonElement6_Click(object sender, EventArgs e)
        {
            radRibbonBarGroup5_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
