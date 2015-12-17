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
            String reponse = "";
            using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
            {
                String req = " select libelle, description from categorie ";
                SqlCommand command = new SqlCommand(req, connexion);
                connexion.Open();
                SqlDataReader dR = command.ExecuteReader();
                /* vérification si l'on a une réponse à la recherche */
                if (dR.HasRows)
                {
                    /* tant que l'on a une réponse, on rajoute à la variable le texte permettant d'intégrer la ligne de réponse de la requête sql */
                    while (dR.Read())
                    {
                        reponse += "<div class='col-sm-4 col-lg-4 col-md-4'>" +
                                        "<div class='thumbnail'>" +
                                            "<img src='" + String.Format("{0}", dR[0]) + "' width='320' height='150'>" +
                                            "<div class='caption'>" +
                                                "<h4 class='pull-right'>" + String.Format("{0}", dR[1]) + "</h4>" +
                                                "<h4><a href='Detail_Article.aspx?idArticle=" + String.Format("{0}", dR[2]) + "'>" + String.Format("{0}", dR[3]) + "</a></h4>" +
                                            "</div>" +
                                            "<div class='ratings'>" +
                                                "<p class='pull-right'>" + String.Format("{0}", dR[4]) + "</p>" +
                                                "<p>" + String.Format("{0}", dR[5]) + "</p>" +
                                            "</div>" +
                                        "</div>" +
                                    "</div>";
                    }
                    affichage_categorie.InnerHtml = reponse;
                }
                /* Si l'on n'a de réponse à la recherche, redirection vers la page d'erreur */
                else
                {
                    Response.Redirect("Erreur.aspx?codeErreur=1");
                }
                connexion.Close();
            }
        }
    }
}