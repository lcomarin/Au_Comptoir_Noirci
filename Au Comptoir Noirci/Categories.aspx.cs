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
            //string contenu = "";
            //string connectionString = .Properties.Settings.Default.ConnectionString;
            ////
            //// In a using statement, acquire the SqlConnection as a resource.
            ////
            //using (SqlConnection con = new SqlConnection(la_reserveConnectionString))
            //{
            //    //
            //    // Open the SqlConnection.
            //    //
            //    con.Open();
            //    //
            //    // The following code uses an SqlCommand based on the SqlConnection.
            //    //
            //    SqlCommand command = new SqlCommand("SELECT id, nom from categories", con);
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        contenu += "<div class=\"categorie\"><h2>" + reader.GetString(1) + "</h2>";
            //        command = new SqlCommand("SELECT id, titre, substring(contenu, 0, 250), statut, prix, note from article", con);
            //        contenu += "</div>";
            //    }
            //    con.Close();
            //}
        }
    }
}