using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Au_Comptoir_Noirci
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //String reponse = "";
            //using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
            //{
            //    String req = " select libelle, description, id from categorie ";
            //    SqlCommand command = new SqlCommand(req, connexion);
            //    connexion.Open();
            //    SqlDataReader dR = command.ExecuteReader();
            //    /* vérification si l'on a une réponse à la recherche */
            //    if (dR.HasRows)
            //    {
            //        /* tant que l'on a une réponse, on rajoute à la variable le texte permettant d'intégrer la ligne de réponse de la requête sql */
            //        while (dR.Read())
            //        {
            //            /* Si l'utilisateur est un administrateur, il peut modifier la catégorie */
            //            if (utilisateur == admin)
            //            {
            //                reponse += "<div class='categorie panelsteel'>" +
            //                                "<h3>" + String.Format("{0}", dR[0]) + "</h3>" +
            //                                "<p>" + String.Format("{0}", dR[1]) + "</p>" +
            //                                "<div class='bouton_valid'>" +
            //                                    "<a class='bouton_wood' href='AddCategorie.aspx?IdCategorie=" + String.Format("{0}", dR[2]) + "'>Modifier la catégorie</a>" +
            //                                    "<a class='bouton_wood' href='SuppAnnonce.aspx?IdCategorie=" + String.Format("{0}", dR[2]) + "'>Supprimer la catégorie</a>" +
            //                                    "<a class='bouton_wood' href='Recherche.aspx?IdCategorie=" + String.Format("{0}", dR[2]) + "'>Voir les annonces</a>" +
            //                                    "<a class='bouton_wood' href='Default.aspx'>Retourner à l'accueil</a>" +
            //                                "</div>" +
            //                            "</div>";

            //            }
            //            else
            //            {
            //                reponse += "<div class='categorie panelsteel'>" +
            //                                "<h3>" + String.Format("{0}", dR[0]) + "</h3>" +
            //                                "<p>" + String.Format("{0}", dR[1]) + "</p>" +
            //                                "<div class='bouton_valid'>" +
            //                                    "<a class='bouton_wood' href='Recherche.aspx?IdCategorie=" + String.Format("{0}", dR[2]) + "'>Voir les annonces</a>" +
            //                                    "<a class='bouton_wood' href='Default.aspx'>Retourner à l'accueil</a>" +
            //                                "</div>" +
            //                            "</div>";

            //            }
            //        }
            //        affichage_categorie.InnerHtml = reponse;
            //    }
            //    /* Si l'on n'a de réponse à la recherche, redirection vers la page d'erreur */
            //    else
            //    {
            //        Response.Redirect("Erreur.aspx?codeErreur=1");
            //    }
            //    connexion.Close();
            //}
        }
    }
}