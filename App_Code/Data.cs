//Data.cs
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
public class Data
{
    //esta clase define los métodos para conectar
    //con la base de datos, tanto en modo conectado
    //como en desconectado
    String cadenaCon;
    public Data()
    {
        //la cadena de conexión de registra en el
        //archivo Web.config
        ConnectionStringSettings settingLibreria;
        settingLibreria =
        ConfigurationManager.ConnectionStrings["cadLibreria"];
        cadenaCon = settingLibreria.ConnectionString;
    }
    //Data.cs cont.
    public SqlConnection GetConnection()
    {
        SqlConnection cn = new SqlConnection(cadenaCon);
        try
        {
            cn.Open();
            return cn;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public SqlDataAdapter getAdapter(String s_Sql)
    {
        SqlDataAdapter adp;
        try
        {
            adp = new SqlDataAdapter(s_Sql, cadenaCon);
            return adp;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}