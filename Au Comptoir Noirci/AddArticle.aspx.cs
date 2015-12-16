using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Au_Comptoir_Noirci
{
    public partial class AddArticle : System.Web.UI.Page
    {
        /* Liste pour garder les id des catégories concernant l'annonce */
        List<int> categories_annonce = new List<int>();
        /* Liste pour garder les libellés des catégories concernant l'annonce */
        List<String> categories_annonce_lib = new List<String>();
        /* int pour garder le compte des catégories */
        int compteur_cat = 0;
        /* Variable pour garder le libellé des annonces pour l'utilisateur */
        String ca = "";
        protected void Page_Load(object sender, EventArgs e)
        {
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
                        /* On vérifie que la catégorie existe */
                        if (String.Format("{0}", dR[0]) == categories.Text)
                        {
                            test = true;
                            categories_annonce.Add(Int32.Parse(String.Format("{0}", dR[1])));
                            categories_annonce_lib.Add(String.Format("{0}", dR[0]));
                            ca = "<p><span>" + categories_annonce_lib[categories_annonce.Count-1] + "</span>" +
                                 "<asp:ImageButton runat='server' OnClick='supp_categorie()' CommandArgument='<%# Eval(\"" + categories_annonce[categories_annonce.Count - 1] + "\") + \";\" + Eval(\"" + categories_annonce_lib[categories_annonce.Count - 1] + "\") %>'  ImageUrl='Content\\img\\supp.png' BackColor='transparent' BorderWidth='0' CssClass='middle_state' /></p>";
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
            if (Request.QueryString["IdAnnonce"] == "")
            {
                string Argument = (string)(e.CommandArgument);
                string[] Args = Argument.Split(new string[] { ";" }, StringSplitOptions.None);
                categories_annonce.Remove(Int32.Parse(Args[0]));
                categories_annonce_lib.Remove(Args[1]);
                for(int i=0;i<categories_annonce.Count;i++){
                    ca = "<p><span>" + categories_annonce_lib[i] + "</span>" +
                         "<asp:ImageButton runat='server' OnClick='supp_categorie()' CommandArgument='<%# Eval(\"" + categories_annonce[i] + "\") + \";\" + Eval(\"" + categories_annonce_lib[i] + "\") %>'  ImageUrl='Content\\img\\supp.png' BackColor='transparent' BorderWidth='0' CssClass='middle_state' /></p>";
                }
            }
            else{

            }

        }
    }
}