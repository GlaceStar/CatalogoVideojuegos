//Libros.aspx.cs
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
public partial class Libros : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        gridlibros.RowCommand += new GridViewCommandEventHandler(gridlibros_RowCommand);
        gridcesta.RowCommand += new GridViewCommandEventHandler(gridcesta_RowCommand);
        GestionLibros glibros = new GestionLibros();
        gridlibros.DataSource = glibros.GetLibrosByTema(int.Parse(this.Session["idTema"].ToString()));
        gridlibros.DataBind();
        //si aún no existe la variable de sesión cesta se crea
        if (this.Session["cesta"] == null)
        {
            this.Session["cesta"] = GestionCompra.CrearCesta();
        }
        if (!this.IsPostBack)
            ActualizaCesta();
    }
    //Libros.aspx.cs cont.
    protected void gridlibros_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int pos = int.Parse(e.CommandArgument.ToString());
            GestionCompra gc = new GestionCompra();
            GestionLibros gl = new GestionLibros();
            //crea el objeto libro a partir del idLibro, el
            //cuál aparece en la segunda columna del GridView
            Libro lb = gl.GetLibroById(int.Parse(gridlibros.Rows[pos].Cells[1].Text));
            gc.AgregarCesta((DataTable)this.Session["cesta"], lb);
            ActualizaCesta();
        }
    }
    protected void gridcesta_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int pos = int.Parse(e.CommandArgument.ToString());
            GestionCompra gc = new GestionCompra();
            gc.EliminaCesta((DataTable)this.Session["cesta"], pos);
            ActualizaCesta();
        }
    }
    //Libros.aspx.cs cont.
    private void ActualizaCesta()
    {
        //si la cesta está vacía o no se ha creado
        //no se visualizarán los controles asociados
        if (this.Session["cesta"] == null ||
        ((DataTable)this.Session["cesta"]).Rows.Count == 0)
        {
            lblcesta.Visible = false;
            lkejecutar.Visible = false;
        }
        else
        {
            lblcesta.Visible = true;
            lkejecutar.Visible = true;
        }
        //vincula el GridView al DataTable de la cesta
        gridcesta.DataSource = (DataTable)this.Session["cesta"];
        gridcesta.DataBind();
    }
    //Libros.aspx.cs
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        GestionCompra gc = new GestionCompra();
        gc.EjecutarCompra((DataTable)this.Session["cesta"], (String)this.Session["pwd"]);
        //cierra la sesión después de comprar
        this.Session.Abandon();
        this.Response.Redirect("Login.aspx");
    }
}