using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoIntegrador {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnLogin_Click(object sender, EventArgs e) {
            string sErro = "";
            if (txtUsuario.Text == "")
                sErro = "Informe o seu nome de usuário.";
            else if (txtSenha.Text == "")
                sErro = "Informe a sua senha.";
            else {
                try {
                    clsOperadores Operador = new clsOperadores();
                    Operador.SUsuario = txtUsuario.Text;
                    Operador.SSenha = txtSenha.Text;

                    clsOperadoresDAL OperadoresDAL = new clsOperadoresDAL();
                    if (OperadoresDAL.EfetuaLogin(Operador) == false)
                        sErro = "Falha no login, verifique o seu nome de usuário e senha.";
                    else {
                        System.Web.Security.FormsAuthentication.SetAuthCookie(Operador.SUsuario, true);
                        Session["LoginUsr"] = Operador.SUsuario;
                        Response.Redirect("/AreaClientes");
                    }
                }
                catch (Exception ex) {
                    sErro = ex.Message;
                }
            }

            if (sErro != "")
                ScriptManager.RegisterClientScriptBlock(btnLogin,GetType(), "Erro", "<script>alert('" + sErro + "');</script>", false);
        }
    }
}