//GestionCompra.cs
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
public class GestionCompra
{
    public static DataTable CrearCesta()
    {
        DataTable dt = new DataTable();
        //el DataTable de la cesta tendrá
        //tres campos: idLibro, titulo y precio
        DataColumn dc = new DataColumn("idLibro", System.Type.GetType("System.Int32"));
        dt.Columns.Add(dc);
        dc = new DataColumn("titulo", System.Type.GetType("System.String"));
        dt.Columns.Add(dc);
        dc = new DataColumn("precio", System.Type.GetType("System.Decimal"));
        dt.Columns.Add(dc);
        return dt;
    }
    //GestionCompra.cs
    public void EjecutarCompra(DataTable cesta, String password)
    {
        Data datos = new Data();
        SqlConnection con = datos.GetConnection();
        //inserta un registro en la tabla de ventas
        //por cada elemento del DataTable cesta
        for (int i = 0; i < cesta.Rows.Count; i++)
        {
            String sql = "Insert into ventas ";
            sql += "(idLibro,cliente,fecha) Values(";
            sql += cesta.Rows[i]["IdLibro"];
            sql += ",'" + password + "','";
            sql += DateTime.Now.ToShortDateString() + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        con.Close();
    }
    //GestionCompra.cs cont.
    public void AgregarCesta(DataTable cesta, Libro lb)
    {
        DataRow dr = cesta.NewRow();
        dr["idLibro"] = lb.IdLibro;
        dr["titulo"] = lb.Titulo;
        dr["precio"] = lb.Precio;
        cesta.Rows.Add(dr);
    }
    public void EliminaCesta(DataTable cesta, int pos)
    {
        cesta.Rows.RemoveAt(pos);
        if (cesta.Rows.Count == 0)
            cesta = null;
    }
}