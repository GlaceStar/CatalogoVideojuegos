//Login.aspx.cs
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        GestionUsuarios gusuarios = new GestionUsuarios();
        if (gusuarios.IsRegistrado(txtusuario.Text, txtpassword.Text))
        {
            //almacena el password del usuario en una variable de sesión
            //para recordarlo en el momento de la compra
            this.Session["pwd"] = txtpassword.Text;
            this.Response.Redirect("Temas.aspx");
        }
        else
            lblnoregistrado.Text = "<b>Usuario no registrado<b>";
    }
}