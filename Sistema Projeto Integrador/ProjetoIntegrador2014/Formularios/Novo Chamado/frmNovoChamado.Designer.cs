namespace ProjetoIntegrador2014
{
    partial class frmNovoChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoChamado));
            this.pvDepartamento = new Telerik.WinControls.UI.RadPageView();
            this.pgConsultaDepartamento = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtDescricao = new Telerik.WinControls.UI.RadGroupBox();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.cbPrioridade = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.btnLimpar = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.btnSalvar = new Telerik.WinControls.UI.RadButton();
            this.txtAbertoPor = new Telerik.WinControls.UI.RadTextBox();
            this.txtAssunto = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabelDepartamento = new Telerik.WinControls.UI.RadLabel();
            this.radPanelDepartamentos = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pvDepartamento)).BeginInit();
            this.pvDepartamento.SuspendLayout();
            this.pgConsultaDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            this.txtDescricao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrioridade.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrioridade.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAbertoPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pvDepartamento
            // 
            this.pvDepartamento.AutoSize = true;
            this.pvDepartamento.Controls.Add(this.pgConsultaDepartamento);
            this.pvDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvDepartamento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvDepartamento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pvDepartamento.Location = new System.Drawing.Point(0, 53);
            this.pvDepartamento.Name = "pvDepartamento";
            // 
            // 
            // 
            this.pvDepartamento.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pvDepartamento.RootElement.Shape = null;
            this.pvDepartamento.SelectedPage = this.pgConsultaDepartamento;
            this.pvDepartamento.Size = new System.Drawing.Size(811, 434);
            this.pvDepartamento.TabIndex = 5;
            this.pvDepartamento.Text = "Dados de cadastro";
            this.pvDepartamento.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pvDepartamento.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.pvDepartamento.GetChildAt(0).GetChildAt(2))).Text = "Dados do Chamado";
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.pvDepartamento.GetChildAt(0).GetChildAt(2))).Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.pvDepartamento.GetChildAt(0).GetChildAt(3))).Text = "Dados do Chamado";
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.pvDepartamento.GetChildAt(0).GetChildAt(3))).Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pgConsultaDepartamento
            // 
            this.pgConsultaDepartamento.Controls.Add(this.txtDescricao);
            this.pgConsultaDepartamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgConsultaDepartamento.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pgConsultaDepartamento.Location = new System.Drawing.Point(10, 44);
            this.pgConsultaDepartamento.Name = "pgConsultaDepartamento";
            this.pgConsultaDepartamento.Size = new System.Drawing.Size(790, 379);
            this.pgConsultaDepartamento.Text = "Dados do Chamado";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.txtDescricao.Controls.Add(this.radTextBox1);
            this.txtDescricao.Controls.Add(this.cbPrioridade);
            this.txtDescricao.Controls.Add(this.radLabel6);
            this.txtDescricao.Controls.Add(this.btnLimpar);
            this.txtDescricao.Controls.Add(this.radLabel5);
            this.txtDescricao.Controls.Add(this.btnSalvar);
            this.txtDescricao.Controls.Add(this.txtAbertoPor);
            this.txtDescricao.Controls.Add(this.txtAssunto);
            this.txtDescricao.Controls.Add(this.radLabel4);
            this.txtDescricao.Controls.Add(this.radLabel3);
            this.txtDescricao.Controls.Add(this.radLabel2);
            this.txtDescricao.Controls.Add(this.radLabel1);
            this.txtDescricao.Controls.Add(this.radLabelDepartamento);
            this.txtDescricao.FooterImageIndex = -1;
            this.txtDescricao.FooterImageKey = "";
            this.txtDescricao.HeaderImageIndex = -1;
            this.txtDescricao.HeaderImageKey = "";
            this.txtDescricao.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.txtDescricao.HeaderText = "";
            this.txtDescricao.Location = new System.Drawing.Point(3, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.txtDescricao.Size = new System.Drawing.Size(784, 367);
            this.txtDescricao.TabIndex = 32;
            this.txtDescricao.ThemeName = "ControlDefault";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(133, 153);
            this.radTextBox1.Multiline = true;
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.NullText = "Informe a descrição do problema";
            // 
            // 
            // 
            this.radTextBox1.RootElement.StretchVertically = true;
            this.radTextBox1.Size = new System.Drawing.Size(640, 190);
            this.radTextBox1.TabIndex = 3;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.ThemeName = "ControlDefault";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // cbPrioridade.NestedRadGridView
            // 
            this.cbPrioridade.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.cbPrioridade.EditorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrioridade.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbPrioridade.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.cbPrioridade.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.cbPrioridade.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.cbPrioridade.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.cbPrioridade.EditorControl.MasterTemplate.EnableGrouping = false;
            this.cbPrioridade.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.cbPrioridade.EditorControl.Name = "NestedRadGridView";
            this.cbPrioridade.EditorControl.ReadOnly = true;
            this.cbPrioridade.EditorControl.ShowGroupPanel = false;
            this.cbPrioridade.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.cbPrioridade.EditorControl.TabIndex = 0;
            this.cbPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPrioridade.Location = new System.Drawing.Point(575, 86);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.NullText = "Selecione a prioridade";
            // 
            // 
            // 
            this.cbPrioridade.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.cbPrioridade.Size = new System.Drawing.Size(198, 24);
            this.cbPrioridade.TabIndex = 1;
            this.cbPrioridade.TabStop = false;
            this.cbPrioridade.ThemeName = "ControlDefault";
            this.cbPrioridade.Click += new System.EventHandler(this.cbPriori_Click);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(646, 59);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(49, 21);
            this.radLabel6.TabIndex = 34;
            this.radLabel6.Text = "Limpar";
            this.radLabel6.ThemeName = "ControlDefault";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(641, 9);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(59, 50);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.ThemeName = "ControlDefault";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLimpar.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLimpar.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnLimpar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Opacity = 10D;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnLimpar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnLimpar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(715, 59);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(43, 21);
            this.radLabel5.TabIndex = 33;
            this.radLabel5.Text = "Salvar";
            this.radLabel5.ThemeName = "ControlDefault";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(706, 9);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 50);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.ThemeName = "ControlDefault";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSalvar.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSalvar.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnSalvar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Opacity = 10D;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnSalvar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).AutoSize = true;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnSalvar.GetChildAt(0).GetChildAt(1).GetChildAt(0))).Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            // 
            // txtAbertoPor
            // 
            this.txtAbertoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbertoPor.Location = new System.Drawing.Point(133, 85);
            this.txtAbertoPor.Name = "txtAbertoPor";
            this.txtAbertoPor.NullText = "Informe o termo para filtrar";
            this.txtAbertoPor.Size = new System.Drawing.Size(327, 24);
            this.txtAbertoPor.TabIndex = 0;
            this.txtAbertoPor.TabStop = false;
            this.txtAbertoPor.ThemeName = "ControlDefault";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(133, 122);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.NullText = "Informe o termo para filtrar";
            this.txtAssunto.Size = new System.Drawing.Size(436, 24);
            this.txtAssunto.TabIndex = 2;
            this.txtAssunto.TabStop = false;
            this.txtAssunto.ThemeName = "ControlDefault";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(30, 83);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(97, 25);
            this.radLabel4.TabIndex = 36;
            this.radLabel4.Text = "Aberto por:";
            this.radLabel4.ThemeName = "ControlDefault";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(38, 172);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(87, 25);
            this.radLabel3.TabIndex = 35;
            this.radLabel3.Text = "problema:";
            this.radLabel3.ThemeName = "ControlDefault";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(20, 152);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(107, 25);
            this.radLabel2.TabIndex = 34;
            this.radLabel2.Text = "Descrição do";
            this.radLabel2.ThemeName = "ControlDefault";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(52, 121);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(75, 25);
            this.radLabel1.TabIndex = 33;
            this.radLabel1.Text = "Assunto:";
            this.radLabel1.ThemeName = "ControlDefault";
            // 
            // radLabelDepartamento
            // 
            this.radLabelDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.radLabelDepartamento.Location = new System.Drawing.Point(476, 83);
            this.radLabelDepartamento.Name = "radLabelDepartamento";
            this.radLabelDepartamento.Size = new System.Drawing.Size(93, 25);
            this.radLabelDepartamento.TabIndex = 32;
            this.radLabelDepartamento.Text = "Prioridade:";
            this.radLabelDepartamento.ThemeName = "ControlDefault";
            // 
            // radPanelDepartamentos
            // 
            this.radPanelDepartamentos.BackColor = System.Drawing.Color.White;
            this.radPanelDepartamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelDepartamentos.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPanelDepartamentos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radPanelDepartamentos.Location = new System.Drawing.Point(0, 0);
            this.radPanelDepartamentos.Name = "radPanelDepartamentos";
            // 
            // 
            // 
            this.radPanelDepartamentos.RootElement.Padding = new System.Windows.Forms.Padding(0);
            this.radPanelDepartamentos.Size = new System.Drawing.Size(811, 53);
            this.radPanelDepartamentos.TabIndex = 4;
            this.radPanelDepartamentos.Text = "Novo Chamado";
            this.radPanelDepartamentos.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radPanelDepartamentos.ThemeName = "ControlDefault";
            // 
            // frmNovoChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 487);
            this.Controls.Add(this.pvDepartamento);
            this.Controls.Add(this.radPanelDepartamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNovoChamado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Novo Chamado";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.pvDepartamento)).EndInit();
            this.pvDepartamento.ResumeLayout(false);
            this.pgConsultaDepartamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            this.txtDescricao.ResumeLayout(false);
            this.txtDescricao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrioridade.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrioridade.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAbertoPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAssunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pvDepartamento;
        private Telerik.WinControls.UI.RadPageViewPage pgConsultaDepartamento;
        private Telerik.WinControls.UI.RadPanel radPanelDepartamentos;
        private Telerik.WinControls.UI.RadGroupBox txtDescricao;
        private Telerik.WinControls.UI.RadTextBox txtAbertoPor;
        private Telerik.WinControls.UI.RadTextBox txtAssunto;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabelDepartamento;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton btnSalvar;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadButton btnLimpar;
        private Telerik.WinControls.UI.RadMultiColumnComboBox cbPrioridade;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
    }
}
