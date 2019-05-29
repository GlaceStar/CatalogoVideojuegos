/////usuario.cs
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
public class Usuario
{
    //esta clase encapsula los datos de un usuario
    private String s_Usuario;
    private String s_Password;
    private String s_Email;
    private String s_Telefono;
    public Usuario()
    {
    }
    public Usuario(String s_Usuario, String s_Password, String s_Email, String s_Telefono)
    {
        this.s_Usuario = s_Usuario;
        this.s_Password = s_Password;
        this.s_Email = s_Email;
        this.s_Telefono = s_Telefono;
    }
    /////usuario.cs
    public String NomUsuario
    {
        get { return s_Usuario; }
        set { s_Usuario = value; }
    }
    public String Password
    {
        get { return s_Password; }
        set { s_Password = value; }
    }
    public String Email
    {
        get { return s_Email; }
        set { s_Email = value; }
    }
    public String Telefono
    {
        get { return s_Telefono; }
        set { s_Telefono = value; }
    }
}