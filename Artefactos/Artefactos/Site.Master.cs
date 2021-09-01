using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Artefactos
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grafico.Visible = false;
        }
        protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            Grafico.Src = lista.Value + ".jpg";
            Grafico.Alt = "Grafico Temperatura";
            Grafico.Visible = true;
        }
    }
}