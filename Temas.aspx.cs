//Temas.aspx.cs
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
public partial class Temas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //evita que se regenere el vínculo en cada recarga
        if (!this.IsPostBack)
        {
            GestionLibros glibros = new GestionLibros();
            lsttemas.DataTextField = "NomTema";
            lsttemas.DataValueField = "IdTema";
            lsttemas.DataSource = glibros.GetTemas();
            lsttemas.DataBind();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //almacena el idTema en una variable de sesión,
        //a fin de que sea recordado en sucesivas
        //recargas de la página de libros
        this.Session["idTema"] = lsttemas.SelectedValue;
        this.Response.Redirect("Libros.aspx");
    }
}