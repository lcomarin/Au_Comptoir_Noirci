using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Au_Comptoir_Noirci
{
    public partial class Detail_Annonce : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
        //    {
        //        String req = "  select a.titre, a.date, a.statut, a.photo, a.contenu, u.id_utilisateur, u.prenom, u.nom from annonce a inner join utilisateur u on a.id_utilisateur = u.id_utilisateur where  a.id_annonce = " + Request.QueryString["IdAnnonce"];
        //        SqlCommand command = new SqlCommand(req, connexion);
        //        connexion.Open();
        //        SqlDataReader dR = command.ExecuteReader();
        //        /* vérification si l'on a une réponse à la requête */
        //        if (dR.HasRows)
        //        {
        //            /* Modification de la page selon la réponse à la requête */
        //            while (dR.Read())
        //            {
        //                titre_annonce.InnerHtml = String.Format("{0}", dR[0]);
        //                date.InnerHtml = String.Format("{0}", dR[1]);
        //                utilisateur.InnerHtml = "<a href='Profil.aspx?idUtilisateur=" + String.Format("{0}", dR[5]) + "'>" + String.Format("{0}", dR[6]) + " " + String.Format("{0}", dR[7]) + "</a>";
        //                statut.InnerHtml = String.Format("{0}", dR[2]);
        //                if (String.Format("{0}", dR[3]) != "No_picture")
        //                {
        //                    photo_annonce.InnerHtml = "<img id='presentation_annonce' src='" + String.Format("{0}", dR[3]) + "'/>";
        //                }
        //                description_texte.InnerHtml = String.Format("{0}", dR[4]);
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
        //        boutons.InnerHtml = "< a class='menuliste list-group-item' href='AddAnnonce.aspx?IdAnnonce="+Request.QueryString["IdAnnonce"]+"'>Modifier l'annonce</a>" +
        //                            "< a class='menuliste list-group-item' href='SuppAnnonce.aspx?IdAnnonce="+Request.QueryString["IdAnnonce"]+"&TitreAnnonce="+titre_annonce.innerText+"'>Supprimer l'annonce</a>" +
        //                            "<a class='menuliste list-group-item' href='Default.aspx'>Retourner à l'accueil</a>";
        //    }
        //}
    }
}