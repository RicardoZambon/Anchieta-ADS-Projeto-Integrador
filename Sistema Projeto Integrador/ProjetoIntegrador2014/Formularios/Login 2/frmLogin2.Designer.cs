namespace ProjetoIntegrador2014
{
    partial class frmLogin2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin2));
            this.txtUsuario = new Telerik.WinControls.UI.RadTextBox();
            this.stsStatus = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblImgStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.lblVersao = new Telerik.WinControls.UI.RadLabelElement();
            this.txtSenha = new Telerik.WinControls.UI.RadTextBox();
            this.office2010Silver = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.btnLogin = new Telerik.WinControls.UI.RadButton();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgTitulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.txtUsuario.Location = new System.Drawing.Point(172, 85);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NullText = "Informe o seu usuário";
            // 
            // 
            // 
            this.txtUsuario.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.txtUsuario.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.txtUsuario.RootElement.UseDefaultDisabledPaint = true;
            this.txtUsuario.Size = new System.Drawing.Size(268, 25);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.ThemeName = "ControlDefault";
            this.txtUsuario.UseGenericBorderPaint = true;
            // 
            // stsStatus
            // 
            this.stsStatus.AutoSize = true;
            this.stsStatus.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblImgStatus,
            this.lblStatus,
            this.commandBarSeparator1,
            this.lblVersao});
            this.stsStatus.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.stsStatus.Location = new System.Drawing.Point(0, 189);
            this.stsStatus.MaximumSize = new System.Drawing.Size(0, 24);
            this.stsStatus.Name = "stsStatus";
            // 
            // 
            // 
            this.stsStatus.RootElement.MaxSize = new System.Drawing.Size(0, 24);
            this.stsStatus.Size = new System.Drawing.Size(452, 24);
            this.stsStatus.SizingGrip = false;
            this.stsStatus.TabIndex = 2;
            this.stsStatus.Text = "radStatusStrip1";
            this.stsStatus.ThemeName = "ControlDefault";
            // 
            // lblImgStatus
            // 
            this.lblImgStatus.AccessibleDescription = "img";
            this.lblImgStatus.AccessibleName = "img";
            this.lblImgStatus.Image = null;
            this.lblImgStatus.MaxSize = new System.Drawing.Size(0, 18);
            this.lblImgStatus.Name = "lblImgStatus";
            this.stsStatus.SetSpring(this.lblImgStatus, false);
            this.lblImgStatus.Text = "";
            this.lblImgStatus.TextWrap = true;
            this.lblImgStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lblStatus
            // 
            this.lblStatus.AccessibleDescription = "Status";
            this.lblStatus.AccessibleName = "Status";
            this.lblStatus.AutoToolTip = true;
            this.lblStatus.MaxSize = new System.Drawing.Size(0, 18);
            this.lblStatus.Name = "lblStatus";
            this.stsStatus.SetSpring(this.lblStatus, true);
            this.lblStatus.Text = "Status";
            this.lblStatus.TextWrap = true;
            this.lblStatus.ToolTipText = "Status";
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.DisplayName = null;
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.stsStatus.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // lblVersao
            // 
            this.lblVersao.AccessibleDescription = "v1.0.0.0";
            this.lblVersao.AccessibleName = "v1.0.0.0";
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.MaxSize = new System.Drawing.Size(0, 18);
            this.lblVersao.Name = "lblVersao";
            this.stsStatus.SetSpring(this.lblVersao, false);
            this.lblVersao.Text = "v1.0.0.0";
            this.lblVersao.TextWrap = true;
            this.lblVersao.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.txtSenha.Location = new System.Drawing.Point(172, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.NullText = "Informe a sua senha";
            this.txtSenha.PasswordChar = '•';
            // 
            // 
            // 
            this.txtSenha.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.txtSenha.RootElement.UseDefaultDisabledPaint = true;
            this.txtSenha.Size = new System.Drawing.Size(268, 25);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TabStop = false;
            this.txtSenha.ThemeName = "ControlDefault";
            this.txtSenha.UseGenericBorderPaint = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(240, 147);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.ThemeName = "ControlDefault";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLogo.Image = global::ProjetoIntegrador2014.Properties.Resources.LogoHelp;
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(154, 169);
            this.imgLogo.TabIndex = 5;
            this.imgLogo.TabStop = false;
            // 
            // imgTitulo
            // 
            this.imgTitulo.BackgroundImage = global::ProjetoIntegrador2014.Properties.Resources.Logo_Completo;
            this.imgTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgTitulo.Location = new System.Drawing.Point(172, 12);
            this.imgTitulo.Name = "imgTitulo";
            this.imgTitulo.Size = new System.Drawing.Size(268, 60);
            this.imgTitulo.TabIndex = 3;
            this.imgTitulo.TabStop = false;
            // 
            // frmLogin2
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 213);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.imgTitulo);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin2";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtUsuario;
        private Telerik.WinControls.UI.RadButton btnLogin;
        private Telerik.WinControls.UI.RadStatusStrip stsStatus;
        private System.Windows.Forms.PictureBox imgTitulo;
        private Telerik.WinControls.UI.RadTextBox txtSenha;
        private System.Windows.Forms.PictureBox imgLogo;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010Silver;
        private Telerik.WinControls.UI.RadLabelElement lblImgStatus;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadLabelElement lblVersao;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;


    }
}

