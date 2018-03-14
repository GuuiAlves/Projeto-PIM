using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dashboard.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txbLogin_Click(object sender, EventArgs e)
        {
            if(txbUsuario.Text == "Admin")
            {
                txbUsuario.Text = "Logado!";
            }
            else
            {
                txbUsuario.Text = "Falha!";
            }
        }
    }
}