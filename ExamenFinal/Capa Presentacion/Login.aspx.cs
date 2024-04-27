using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenFinal.CapaDatos;

namespace ExamenFinal.Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected System.Void Page_Load(System.Object sender, System.EventArgs e)
        {
            ClsAgente oAgente = new ClsAgente();

            username.input = oAgente.Nombre;

            password.input = oAgente.Contra;


        }

    }
}