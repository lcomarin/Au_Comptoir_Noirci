using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Au_Comptoir_Noirci
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* variable pour recueillir la réponse de la requête de recherche */
            String reponse = "";
            /* Affichage des six dernières annonces */
            using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
            {
                /* requête faite sur les dates selon la plus récente avec uniquement 6 résultats */
                String req = "  select photo, id_annonce, titre, statut, date from annonce a order by date desc limit 6";
                SqlCommand command = new SqlCommand(req, connexion);
                connexion.Open();
                SqlDataReader dR = command.ExecuteReader();
                /* vérification si l'on a une réponse à la recherche */
                if (dR.HasRows)
                {
                    /* tant que l'on a une réponse, on rajoute à la variable le texte permettant d'intégrer la ligne de réponse de la requête sql */
                    while (dR.Read())
                    {
                        reponse += "<div class='col-sm-4 col-lg-4 col-md-4 annonce'>" +
                                        "<div class='thumbnail'>" +
                                            "<img src='" + String.Format("{0}", dR[0]) + "' alt=''>" +
                                            "<div class='caption'>" +
                                                "<h4><a href='Detail_Annonce.aspx?IdAnnonce=" + String.Format("{0}", dR[1]) + "'>" + String.Format("{0}", dR[2]) + "</a></h4>" +
                                                "<p>" + String.Format("{0}", dR[3]) + "</p>" +
                                                "<p>" + String.Format("{0}", dR[4]) + "</p>" +
                                            "</div>" +
                                        "</div>" +
                                    "</div>";
                    }
                    dernieres_annonces.InnerHtml = reponse;
                }
                /* Si l'on n'a de réponse à la recherche, redirection vers la page d'erreur */
                else
                {
                    Response.Redirect("Erreur.aspx");
                }
                connexion.Close();
            }
        }
    }
}