using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoIntegrador.AreaClientes {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!(IsPostBack)) {
                try {
                    if (HttpContext.Current.Request["Acao"] == "Sair") {
                        System.Web.Security.FormsAuthentication.SignOut();
                        Response.Redirect("/");
                    }
                } catch {
                    Response.Redirect("/");
                }
            }
        }
    }
}