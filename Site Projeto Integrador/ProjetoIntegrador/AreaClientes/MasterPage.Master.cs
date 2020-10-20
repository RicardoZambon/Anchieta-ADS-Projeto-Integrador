﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoIntegrador.AreaClientes {
    public partial class MasterPage : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            if (!(IsPostBack)) {
                try {
                    if (Session["LoginUsr"] == null || Session["LoginUsr"].ToString() == "")
                        Response.Redirect("/");
                } catch {
                    Response.Redirect("/");
                }
            }
        }
    }
}