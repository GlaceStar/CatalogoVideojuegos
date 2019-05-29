using System;////////////Tema.cs
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
public class Tema
{
    //esta clase encapsula los datos de un tema
    private int i_IdTema;
    private String s_Tema;
    public Tema()
    {
    }
    public Tema(int i_IdTema, String s_Tema)
    {
        this.i_IdTema = i_IdTema;
        this.s_Tema = s_Tema;
    }
    public int IdTema
    {
        get { return i_IdTema; }
        set { i_IdTema = value; }
    }
    public String NomTema
    {
        get { return s_Tema; }
        set { s_Tema = value; }
    }
}