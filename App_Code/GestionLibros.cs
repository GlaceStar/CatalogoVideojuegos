//GestionLibros.cs
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
public class GestionLibros
{
    //esta clase contiene los métodos para
    //operar con los temas y libros
    public GestionLibros()
    {
    }
    private DataTable GetTabla(String Name, String Sql)
    {
        //crea un objeto DataTable con el nombre
        //especificado a partir de la instrucción
        //Select indicada
        DataSet ds = new DataSet();
        Data datos = new Data();
        SqlDataAdapter adp = datos.getAdapter(Sql);
        adp.Fill(ds, Name);
        return ds.Tables[Name];
    }
    //GestionLibros.cs
    public DataTable GetAllLibros()
    {
        return GetTabla("libros", "Select * From Libros");
    }
    public DataTable GetLibrosByTema(int IdTema)
    {
        return GetTabla("libros", "Select * From Libros Where IdTema=" + IdTema);
    }
    //GestionLibros.cs cont.
    public DataTable GetTemas()
    {
        return GetTabla("temas", "Select * From Temas");
    }
    public Libro GetLibroById(int IdLibro)
    {
        Data datos = new Data();
        SqlConnection con = datos.GetConnection();
        SqlDataReader dr;
        String sql = "Select * From Libros Where ";
        sql += "idlibro=" + IdLibro;
        //realiza la operación si se ha conseguido
        //una conexión
        if (con != null)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                dr = cmd.ExecuteReader();
                //GestionLibros.cs cont.
                if (dr.Read())
                {
                    Libro lb = new Libro((int)dr["idLibro"],
                    (int)dr["idTema"],
                    (String)dr["titulo"],
                    (decimal)dr["precio"],
                    (String)dr["autor"]);
                    return lb;
                }
                else
                    return null;
            }
            catch (SqlException ex)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        else
            return null;
    }
}