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
        //        String req = "  select a.titre, a.date, a.statut, a.photo, a.prix, a.contenu, u.id_utilisateur, u.nom, u.prenom from annonce a inner join utilisateur u on a.id_utilisateur = u.id_utilisateur where  a.id_annonce = " + Request.QueryString["IdAnnonce"];
        //        SqlCommand command = new SqlCommand(req, connexion);
        //        connexion.Open();
        //        SqlDataReader dR = command.ExecuteReader();
        //        /* vérification si l'on a une réponse à la requête */
        //        if (dR.HasRows)
        //        {
        //            /* Modification de la page selon la réponse à la requête */
        //            while (dR.Read())
        //            {
        //                titre_article.InnerHtml = String.Format("{0}", dR[0]);
        //                date.InnerHtml = String.Format("{0}", dR[1]);
        //                utilisateur.InnerHtml = "<a href='Profil.aspx?idUtilisateur=" + String.Format("{0}", dR[6]) + "'>" + String.Format("{0}", dR[7]) + " " + String.Format("{0}", dR[6]) + "</a>";
        //                statut.InnerHtml = String.Format("{0}", dR[2]);
        //                if (String.Format("{0}", dR[3]) != "No_picture")
        //                {
        //                    photo_article.InnerHtml = "<img id='presentation_article' src='" + String.Format("{0}", dR[3]) + "'/>";
        //                }
        //                prix.InnerHtml = String.Format("{0}", dR[4]);
        //                description_texte.InnerHtml = String.Format("{0}", dR[5]);
        //            }
        //        }
        //        /* Redirection vers la page d'erreur si l'on n'a eu de réponse*/
        //        else
        //        {
        //            Response.Redirect("Erreur.aspx?codeErreur=404");
        //        }
        //        connexion.Close();
        //    }
        //    /* A définir */
        //    if (utilisateur == utilisateur_connecte)
        //    {
        //        boutons.InnerHtml = "< a class='menuliste list-group-item' href='AddArticle.aspx?IdAnnonce="+Request.QueryString["IdAnnonce"]+"'>Supprimer l'annonce</a>" +
        //                            "< a class='menuliste list-group-item' href='Default.aspx'>Supprimer l'annonce</a>" +
        //                            "<a class='menuliste list-group-item' href='Default.aspx'>Retourner à l'accueil</a>";
        //    }
        //}
    }
}