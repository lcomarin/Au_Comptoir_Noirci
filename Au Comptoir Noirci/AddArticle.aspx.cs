using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace Au_Comptoir_Noirci
{
    public partial class AddArticle : System.Web.UI.Page
    {
        /* Liste pour garder les id des catégories concernant l'annonce */
        List<int> categories_annonce = new List<int>();
        /* Liste pour garder les libellés des catégories concernant l'annonce */
        List<String> categories_annonce_lib = new List<String>();
        /* Liste pour garder les id des catégories supprimées de l'annonce */
        List<int> categories_del = new List<int>();
        /* Variable pour garder le libellé des annonces pour l'utilisateur */
        String ca = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.QueryString["IdAnnonce"] != "")
            //{
            //    using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
            //    {
            //        /*Mise en page de l'annonce */
            //        String req = " select titre, photo, statut, contenu from annonce where id = " + Request.QueryString["IdAnnonce"];
            //        SqlCommand command = new SqlCommand(req, connexion);
            //        connexion.Open();
            //        SqlDataReader dR = command.ExecuteReader();
            //        if (dR.HasRows)
            //        {
            //            while (dR.Read())
            //            {
            //                titre_article.Value = String.Format("{0}", dR[0]);
            //                image_article.Value = String.Format("{0}", dR[1]);
            //                statut_article.Value = String.Format("{0}", dR[2]);
            //                description_article.InnerText = String.Format("{0}", dR[3]);
            //            }
            //        }
            //        connexion.Close();
            //        /* Mise en page des catégories concernant l'article */
            //        req = " select c.libelle, c.id from categories c inner join categorie_annonce ca on ca.id_categorie = c.id_categorie inner join annonce a on a.id_annonce = ca.id_annonce  where a.id_annonce = " + Request.QueryString["IdAnnonce"];
            //        command = new SqlCommand(req, connexion);
            //        connexion.Open();
            //        dR = command.ExecuteReader();
            //        if (dR.HasRows)
            //        {
            //            while (dR.Read())
            //            {
            //                categories_annonce.Add(Int32.Parse(String.Format("{0}", dR[1])));
            //                categories_annonce_lib.Add(String.Format("{0}", dR[0]));
            //                ca = "<p><span>" + categories_annonce_lib[categories_annonce.Count - 1] + "</span>" +
            //                     "<asp:ImageButton runat='server' OnClick='supp_categorie()' CommandArgument='<%# Eval(\"" + categories_annonce[categories_annonce.Count - 1] + "\") + \";\" + Eval(\"" + categories_annonce_lib[categories_annonce.Count - 1] + "\") %>'  ImageUrl='Content\\img\\supp.png' BackColor='transparent' BorderWidth='0' CssClass='middle_state' /></p>";
            //            }
            //        }
            //        connexion.Close();
            //    }
            //}
        }

        /* Ajout d'une catégorie à une annonce */
        protected void add_Categorie(object sender, EventArgs e)
        {
            if (categories.Text == "")
            {
                MessageBox.Show("Aucune catégorie n'est sélectionné.");
            }
            else 
            {
                Boolean test= false;
                using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
                {
                    String req = " select libelle, id from categorie ";
                    SqlCommand command = new SqlCommand(req, connexion);
                    connexion.Open();
                    SqlDataReader dR = command.ExecuteReader();
                    /* vérification si l'on a une réponse à la recherche */
                    if (dR.HasRows)
                    {
                        while (dR.Read())
                        {
                            /* On vérifie que la catégorie existe */
                            if (String.Format("{0}", dR[0]) == categories.Text)
                            {
                                test = true;
                                categories_annonce.Add(Int32.Parse(String.Format("{0}", dR[1])));
                                categories_annonce_lib.Add(String.Format("{0}", dR[0]));
                                ca = "<p><span>" + categories_annonce_lib[categories_annonce.Count - 1] + "</span>" +
                                     "<asp:ImageButton runat='server' OnClick='supp_categorie()' CommandArgument='<%# Eval(\"" + categories_annonce[categories_annonce.Count - 1] + "\") + \";\" + Eval(\"" + categories_annonce_lib[categories_annonce.Count - 1] + "\") %>'  ImageUrl='Content\\img\\supp.png' BackColor='transparent' BorderWidth='0' CssClass='middle_state' /></p>";
                            }
                        }
                    }
                    /* Si l'on n'a de réponse à la recherche, on indique que la catégorie n'existe pas */
                    if(test==false)
                    {
                        MessageBox.Show("Cette catégorie n'existe pas.");
                    }
                    connexion.Close();
                }
            }
        }

        protected void supp_categorie(object sender, CommandEventArgs e)
        {
            string Argument = (string)(e.CommandArgument);
            string[] Args = Argument.Split(new string[] { ";" }, StringSplitOptions.None);
            categories_del.Add(Int32.Parse(Args[0]));
            categories_annonce.Remove(Int32.Parse(Args[0]));
            categories_annonce_lib.Remove(Args[1]);
            for(int i=0;i<categories_annonce.Count;i++){
                ca = "<p><span>" + categories_annonce_lib[i] + "</span>" +
                        "<asp:ImageButton runat='server' OnClick='supp_categorie()' CommandArgument='<%# Eval(\"" + categories_annonce[i] + "\") + \";\" + Eval(\"" + categories_annonce_lib[i] + "\") %>'  ImageUrl='Content\\img\\supp.png' BackColor='transparent' BorderWidth='0' CssClass='middle_state' /></p>";
            }
        }

        protected void add_Annonce(object sender, EventArgs e)
        {
            /* Vérification des champs vides */
            if (titre_article.Value == "")
            {
                MessageBox.Show("Vous n'avez entré aucun titre pour cette annonce.");
            }
            else if (image_article.Value == "")
            {
                MessageBox.Show("Vous n'avez entré aucune image pour cette annonce.");
            }
            else if (statut_article.Value == "")
            {
                MessageBox.Show("Vous n'avez entré aucun statut pour cette annonce.");
            }
            else if (description_article.Value == "")
            {
                MessageBox.Show("Vous n'avez entré aucune description pour cette annonce.");
            }
            else if (categories_annonce.Count == 0)
            {
                MessageBox.Show("Vous n'avez mis aucune catégorie pour cette annonce.");
            }
            else
            {
                using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
                {
                    connexion.Open();
                    SqlCommand command = connexion.CreateCommand();
                    SqlTransaction transaction;

                    transaction = connexion.BeginTransaction("InscriptionTransaction");

                    command.Connection = connexion;
                    command.Transaction = transaction;
                    try{
                        if (Request.QueryString["IdAnnonce"] == "")
                        {
                            /* SELECT SCOPE_IDENTITY() --> Récupération de l'id de l'insert */
                            String req = " insert into annonce values (" + titre_article.Value + "," + description_article.Value + "," + DateTime.Now + "," + statut_article.Value + "," + image_article.Value + "); SELECT SCOPE_IDENTITY()";
                            command.CommandText = req;
                            string id_annonce = "" + command.ExecuteScalar();
                            /* Insertion du lien entre les catégories et l'annonce */
                            req = "insert into categorie_annonce values (" + id_annonce + ", " + categories_annonce[0] + ")";
                            /* S'il y a plus d'une catégorie, on ajoute les valeurs à la requête */
                            for (int i = 1; i < categories_annonce.Count; i++)
                            {
                                req+= ", (" + id_annonce + ", " + categories_annonce[i] + ")";
                            }
                            command.CommandText = req;
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            /* Mise à jour de l'annonce */
                            String req = " update annonce set titre = " + titre_article.Value + ", contenu = " + description_article.Value + ", date = " + DateTime.Now + ", statut = " + statut_article.Value + ", photo = " + image_article.Value + " where id_annonce = " + Request.QueryString["IdAnnonce"] + " )";
                            command.CommandText = req;
                            command.ExecuteNonQuery();
                            req = "select id_categorie from categorie_annonce where id_annonce = " + Request.QueryString["IdAnnonce"];
                            command.CommandText = req;
                            SqlDataReader dR = command.ExecuteReader();
                            /* vérification si l'on a un ajout ou une suppression de catégorie à la recherche */
                            if (dR.HasRows)
                            {
                                while (dR.Read())
                                {
                                    for (int i = 0; i < categories_annonce.Count; i++)
                                    {
                                        if (categories_annonce[i] == Int32.Parse(String.Format("{0}", dR[0])))
                                        {
                                            /* Ce n'est pas une nouvelle catégorie, on supprime la catégorie des catégories à ajouter */
                                            categories_annonce.Remove(categories_annonce[i]);
                                        }
                                    }
                                }
                            }
                            /* On supprime les catégories à supprimer */
                            for (int i = 0; i < categories_del.Count; i++)
                            {
                                req = "delete from categorie_annonce where id_annonce = " + Request.QueryString["IdAnnonce"] + " and id_categorie = " + String.Format("{0}", dR[0]) + ")";
                                command.CommandText = req;
                                command.ExecuteNonQuery();
                            }
                            /* Il n'y a plus que des nouvelles catégories à ajouter */
                            for (int i = 0; i < categories_annonce.Count; i++)
                            {
                                req = "insert into categorie_annonce values (" + Request.QueryString["IdAnnonce"] + ", " + categories_annonce[i] + ")";
                                command.CommandText = req;
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        var st = new StackTrace(ex, true);
                        // Get the top stack frame
                        var frame = st.GetFrame(0);
                        // Get the line number from the stack frame
                        var line = frame.GetFileLineNumber();
                        transaction.Rollback();
                        connexion.Close();
                        Response.Redirect("Erreur.aspx?codeErreur=500&msgErreur="+frame.ToString()+"(l"+line.ToString()+")");
                    }
                    connexion.Close();
                }
            }
        }
    }
}