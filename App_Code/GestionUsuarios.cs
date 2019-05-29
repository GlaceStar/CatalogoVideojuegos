//GestionUsuarios.cs
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
public class GestionUsuarios
{
    //esta clase contiene los métodos para
    //operar con la tabla de clientes
    public GestionUsuarios()
    {
    }
    public bool GrabarUsuario(Usuario usr)
    {
        //Si el usuario se puede registrar
        //devolverá true, sino devolverá false
        Data datos = new Data();
        SqlConnection cn = datos.GetConnection();
        //realiza la operación si se ha conseguido
        //una conexión. 
        //GestionUsuarios.cs
        if (cn != null)
        {
            //utiliza el modo conectado pues es una
            //actualización puntual
            SqlCommand cmd;
            String sql = "Insert into clientes values(";
            sql += "'" + usr.NomUsuario + "',";
            sql += "'" + usr.Password + "',";
            sql += "'" + usr.Email + "',";
            sql += "'" + usr.Telefono + "')";
            cmd = new SqlCommand(sql, cn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        else
            return false;
    }
    //GestionUsuarios.cs cont.
    public bool IsRegistrado(String user, String pwd)
    {
        //utiliza el modo conectado, pues es una consulta
        //puntual
        Data datos = new Data();
        SqlConnection cn = datos.GetConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        String sql = "Select * From clientes Where ";
        sql += "NomUsuario='" + user + "' AND Password='" + pwd + "'";
        //realiza la operación si se ha conseguido
        //una conexión
        //GestionUsuarios.cs cont.
        if (cn != null)
        {
            cmd = new SqlCommand(sql, cn);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        else
            return false;
    }
}