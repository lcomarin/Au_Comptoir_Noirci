using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Au_Comptoir_Noirci
{
    public partial class Recherche : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* variable pour recueillir la réponse de la requête de recherche */
            String reponse = "";
            String param = "";
            /* Recherche par utilisateur */
            if (Request.QueryString["id_utilisateur"] != null)
            {
                using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
                {
                    String req = "  select a.photo, a.id_annonce, a.titre, a.statut, a.date, u.prenom, u.nom from annonce a inner join utilisateur u on a.id_utilisateur = u.id_utilisateur where  u.id_utilisateur = " + Request.QueryString["id_utilisateur"];
                    SqlCommand command = new SqlCommand(req, connexion);
                    connexion.Open();
                    SqlDataReader dR = command.ExecuteReader();
                    /* vérification si l'on a une réponse à la recherche */
                    if (dR.HasRows)
                    {
                        /* tant que l'on a une réponse, on rajoute à la variable le texte permettant d'intégrer la ligne de réponse de la requête sql */
                        while (dR.Read())
                        {
                            param = String.Format("{0}", dR[5]) + " " + String.Format("{0}", dR[6]);
                            reponse +=  "<div class='col-sm-4 col-lg-4 col-md-4 annonce'>"+
                                            "<div class='thumbnail'>"+
                                                "<img src='"+String.Format("{0}", dR[0])+"' alt=''>"+
                                                "<div class='caption'>"+
                                                    "<h4><a href='Detail_Annonce.aspx?IdAnnonce="+String.Format("{0}", dR[1])+"'>"+String.Format("{0}", dR[2])+"</a></h4>"+
                                                    "<p>"+String.Format("{0}", dR[3])+"</p>"+
                                                    "<p>"+String.Format("{0}", dR[4])+"</p>"+
                                                "</div>"+
                                            "</div>"+
                                        "</div>";
                        }
                        resultat_recherche.InnerHtml = reponse;
                        titre.InnerText = "Toutes les annonces posté par :" + param;
                    }
                    /* Si l'on n'a de réponse à la recherche, redirection vers la page d'erreur */
                    else
                    {
                        Response.Redirect("Erreur.aspx?codeErreur=1");
                    }
                    connexion.Close();
                }
            }
            /* Recherche par catégorie */
            else if (Request.QueryString["id_categorie"] != null)
            {
                using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
                {
                    String req = "  select a.photo, a.id_annonce, a.titre, a.statut, a.date, c.libelle from annonce a inner join categorie_annonce ca on ca.id_annonce = a.id_annonce inner join categorie c on ca.id_categorie = c.id_categorie where  c.id_categorie = " + Request.QueryString["id_categorie"];
                    SqlCommand command = new SqlCommand(req, connexion);
                    connexion.Open();
                    SqlDataReader dR = command.ExecuteReader();
                    /* vérification si l'on a une réponse à la recherche */
                    if (dR.HasRows)
                    {
                        /* tant que l'on a une réponse, on rajoute à la variable le texte permettant d'intégrer la ligne de réponse de la requête sql */
                        while (dR.Read())
                        {
                            param = String.Format("{0}", dR[5]);
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
                        resultat_recherche.InnerHtml = reponse;
                        titre.InnerText = "Toutes les annonces pour la catégorie :" + param ;
                    }
                    /* Si l'on n'a de réponse à la recherche, redirection vers la page d'erreur */
                    else
                    {
                        Response.Redirect("Erreur.aspx?codeErreur=1");
                    }
                    connexion.Close();
                }
            }
            /* Si l'on n'a fait de recherche selon un utilisateur ou une catégorie, Affichage de*/
            else
            {
                /* Affichage des six dernières annonces */
                using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
                {
                    /* requête faite sur les dates selon la plus récente avec uniquement 6 résultats */
                    String req = "  select photo, id_annonce, titre, statut, date from annonce a order by date desc";
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
                        resultat_recherche.InnerHtml = reponse;
                    }
                    /* Si l'on n'a de réponse à la recherche, redirection vers la page d'erreur */
                    else
                    {
                        Response.Redirect("Erreur.aspx?codeErreur=1");
                    }
                    connexion.Close();
                }
            }

            /* A définir */
            /*if (utilisateur = utilisateur_connecte)
            {
                boutons.InnerHtml = "< a class='menuliste list-group-item' href='Default.aspx'>Supprimer l'annonce</a>" +
                                    "<a class='menuliste list-group-item' href='Default.aspx'>Retourner à l'accueil</a>";
            }*/
        }
    }
}