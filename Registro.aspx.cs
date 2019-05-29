//Registro.aspx.cs
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class Registro : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        GestionUsuarios guser = new GestionUsuarios();
        //sólo inserta el nuevo usuario si no está
        //registrado aún
        if (guser.IsRegistrado(txtUsuario.Text, txtPwd.Text))
        {
            lblresultado.Text = "Ya existe un usuario registrado <br/>";
            lblresultado.Text += "con esa combinación de usuario y password";
        }
        else
        {
            Usuario usr = new Usuario(txtUsuario.Text, txtPwd.Text, txtEmail.Text, txtTelefono.Text);
            //informa sobre el resultado de la operación
            if (!guser.GrabarUsuario(usr))
                lblresultado.Text = "!Error en el registro del usuario";
            else
                lblresultado.Text = "El usuario se ha grabado correctamente";
        }
    }
}