using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Au_Comptoir_Noirci
{
    public partial class SuppAnnonce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            titre_annonce.InnerText += Request.QueryString["TitreAnnonce"];
        }

        protected void retour_Annonce(object sender, EventArgs e)
        {
            Response.Redirect("Detail_Annonce.aspx?IdAnnonce=" + Request.QueryString["IdAnnonce"]);
        }


        protected void supp_Annonce(object sender, EventArgs e)
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
                    String req = "select id_categorie from categorie_annonce where id_annonce = " + Request.QueryString["IdAnnonce"];
                    command.CommandText = req;
                    SqlDataReader dR = command.ExecuteReader();
                    /* Suppression des liens entre les différentes catégories et l'annonce supprimée */
    
                    if (dR.HasRows)
                    {
                        while (dR.Read())
                        {
                            req = "delete from categorie_annonce where id_annonce = " + Request.QueryString["IdAnnonce"] + " and id_categorie = " + String.Format("{0}", dR[0]) + ")";
                            command.CommandText = req;
                            command.ExecuteNonQuery();
                        }
                    }
                    req = "delete from annonce where id_annonce = " + Request.QueryString["IdAnnonce"];
                    command.CommandText = req;
                    command.ExecuteNonQuery();
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