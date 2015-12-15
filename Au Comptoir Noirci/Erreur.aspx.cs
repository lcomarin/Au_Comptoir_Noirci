using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Au_Comptoir_Noirci
{
    public partial class Erreur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["codeErreur"] == "404")
            {
                consigne.InnerHtml = "<p>Faut arrêter ces conneries de nord et de sud ! Une fois pour toutes, le nord, suivant comment on est tourné, ça change tout !</p><p>La page que vous demandez n'existe pas (plus?) .";
            }
            else if (Request.QueryString["codeErreur"] == "500")
            {
                consigne.InnerHtml = "<p>Ah ! oui... J'l'ai fait trop fulgurant, là. Ça va ?</p><p>Il y a eu un problème serveur. Veuillez nous excuser pour ce désagrément.</p>";
            }
            else if (Request.QueryString["codeErreur"] == "1")
            {
                consigne.InnerHtml = "<p>Si la mémoire est à la tête ce que le passé, peut-on y accéder à six ? Oui, non, zbradaraldjan ?</p><p>Votre recherche ne peut aboutir. Veuillez réitérer avec une autre recherche, ou contacter le roi en lui indiquant le problème </p>";
            }
            else
            {
                consigne.InnerHtml = "<p>Non mais, je le connais pas ce mot-là.</p><p>Une erreur s'est produite. Veuillez nous excuser pour ce désagrément.</p>";
            }
        }
    }
}