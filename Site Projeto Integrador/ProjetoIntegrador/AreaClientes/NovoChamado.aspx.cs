using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoIntegrador.AreaClientes {
    public partial class NovoChamado : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!Page.IsPostBack) {
                clsChamadosPrioridadesDAL ChamadosPrioridadesDAL = new clsChamadosPrioridadesDAL();
                cmbPrioridades.DataSource = ChamadosPrioridadesDAL.Consultar();
                cmbPrioridades.DataTextField = "Prioridade";
                cmbPrioridades.DataValueField = "Codigo";
                cmbPrioridades.DataBind();
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e) {
            string sErro = "";
            if (txtAssunto.Text.Trim() == "")
                sErro="Informe o assunto do chamado.";
            else if (txtDescricao.Text.Trim() == "")
                sErro = "Informe a descrição do chamado.";
            else {
                try {
                    clsOperadoresDAL OperadoresDAL = new clsOperadoresDAL();
                    clsOperadores Operador = OperadoresDAL.Carregar(Session["LoginUsr"].ToString());
                    
                    clsChamados Chamado = new clsChamados();
                    Chamado.AbertoPor = Operador.ICodigo;
                    Chamado.Assunto = txtAssunto.Text.Trim();
                    Chamado.Prioridade = int.Parse(cmbPrioridades.SelectedValue.ToString());
                    Chamado.ProblemaInicial = txtDescricao.Text.Trim();

                    clsChamadoDAL ChamadosDAL = new clsChamadoDAL();
                    ChamadosDAL.AbrirChamado(Chamado);

                    sErro = "Chamado aberto com sucesso!";
                    cmbPrioridades.SelectedIndex = -1;
                    txtAssunto.Text = "";
                    txtDescricao.Text = "";

                } catch (Exception ex) {
                    sErro = ex.Message;
                }
            }

            if (sErro != "")
                ScriptManager.RegisterClientScriptBlock(btnGravar, GetType(), "Erro", "<script>alert('" + sErro + "');</script>", false);
        }
    }
}