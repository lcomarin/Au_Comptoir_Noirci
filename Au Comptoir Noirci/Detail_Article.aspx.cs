using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Au_Comptoir_Noirci
{
    public partial class Détail_Article : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
        //    {
        //        String req = "  select a.titre, a.date, a.statut, a.photo, a.prix, a.contenu, u.nom, u.prenom from annonce a inner join utilisateur u on a.id_utilisateur = u.id_utilisateur where  a.id_annonce = " + Request.QueryString["IdAnnonce"];
        //        SqlCommand command = new SqlCommand(req, connexion);
        //        connexion.Open();
        //        SqlDataReader dR = command.ExecuteReader();
        //        if (dR.HasRows)
        //        {
        //            while (dR.Read())
        //            {
        //                titre_article.InnerHtml = String.Format("{0}", dR[0]);
        //                date.InnerHtml = String.Format("{0}", dR[1]);
        //                statut.InnerHtml = String.Format("{0}", dR[2]);
        //                if(String.Format("{0}", dR[3]) != "No_picture")
        //                {
        //                    photo_article.InnerHtml = "<img id="presentation_article" src="+ String.Format("{0}", dR[3])+"/>";
        //                }
        //                prix.InnerHtml = String.Format("{0}", dR[4]);
        //                description_texte.InnerHtml = String.Format("{0}", dR[5]);
        //            }
        //        }
        //        else
        //        {

        //        }
        //        connexion.Close();
        //    }
        //}
    }
}