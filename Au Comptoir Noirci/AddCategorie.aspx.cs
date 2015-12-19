using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Au_Comptoir_Noirci
{
    public partial class AddCategorie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["IdCategorie"] != null)
            {
                //using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
                //{
                //    /*Mise en page de l'annonce */
                //    String req = " select libelle, description from categorie where id = " + Request.QueryString["IdCategorie"];
                //    SqlCommand command = new SqlCommand(req, connexion);
                //    connexion.Open();
                //    SqlDataReader dR = command.ExecuteReader();
                //    if (dR.HasRows)
                //    {
                //        while (dR.Read())
                //        {
                //            libelle_categorie.Value = String.Format("{0}", dR[0]);
                //            description_categorie.InnerText = String.Format("{0}", dR[1]);
                //        }
                //    }
                //    connexion.Close();
                //}
                //bouton_add.Text = "Modifier l'annonce";
                MessageBox.Show("Prout");
            }
        }

        protected void Add_Categorie(object sender, EventArgs e)
        {
            /* Vérification des champs vides */
            if (libelle_categorie.Value == "")
            {
                MessageBox.Show("Vous n'avez entré aucun libellé pour cette catégorie.");
            }
            else if (description_categorie.Value == "")
            {
                MessageBox.Show("Vous n'avez entré aucune description pour cette catégorie.");
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
                    try
                    {
                        if (Request.QueryString["IdCategorie"] == "")
                        {
                            String req = " insert into categories values (" + libelle_categorie.Value + "," + description_categorie.Value + "); SELECT SCOPE_IDENTITY()";
                            command.CommandText = req;
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            /* Mise à jour de l'annonce */
                            String req = " update categories set libelle = " + libelle_categorie.Value + ", description = " + description_categorie.Value + " )";
                            command.CommandText = req;
                            command.ExecuteNonQuery();
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
                        Response.Redirect("Erreur.aspx?codeErreur=500&msgErreur=" + frame.ToString() + "(l" + line.ToString() + ")");
                    }
                    connexion.Close();
                }
            }
        }
    }
}