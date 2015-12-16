using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace Au_Comptoir_Noirci
{
    /// <summary>
    /// Description résumée de WebServiceAutoComplete
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    [System.Web.Script.Services.ScriptService]
    public class WebServiceAutoComplete : System.Web.Services.WebService
    {

         [WebMethod]
        public string[] getCategories(string prefixText, int count)
        {
            List<string> ajaxDataCollection = new List<string>();
            String[] _objdt = ListeCategories(prefixText);
            if (_objdt.Length > 0)
            {
                for (int i = 0; i < _objdt.Length; i++)
                {
                    ajaxDataCollection.Add(_objdt[i]);
                }
            }
            return ajaxDataCollection.ToArray();
        }

         [WebMethod]
         public String[] ListeCategories(string prefixText)
         {
             String[] categories;
             using (SqlConnection connexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NomBdd"].ConnectionString))
             {
                 DataTable _objdt = new DataTable();
                 String req = "SELECT count(*) FROM categories";
                 SqlCommand command = new SqlCommand(req, connexion);
                 connexion.Open();
                 SqlDataReader dR = command.ExecuteReader();
                 dR.Read();
                 categories = new String[Int32.Parse(String.Format("{0}", dR[0]))];
                 dR.Close();
                 req = "SELECT libelles from categories";
                 command = new SqlCommand(req, connexion);
                 dR = command.ExecuteReader();
                 int i = 0;
                 while (dR.Read())
                 {
                     categories[i] = String.Format("{0}", dR[0]);
                     i++;

                 }
                 dR.Close();
                 connexion.Close();
             }
             return categories;
         }

    }
}
