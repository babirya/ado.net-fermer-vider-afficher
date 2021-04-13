using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 
namespace DevTechTuto
{
    class ado
    {  
        // declaration des objects sql >>> mode connecte  

        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader rd;
        public DataTable dt = new DataTable(); 

        // declaration de la methode connecte 
           public void connecter()
        {
            if(con.State==ConnectionState.Closed ||con.State==ConnectionState.Broken)
            {
                con.ConnectionString = @"Data Source=DESKTOP-3GHSQJ4\SQLEXPRESS;Initial Catalog=adonet;Integrated Security=True";
                con.Open();
            }

        }
        // declaration de la metode  deconnecter  

        public void deconnecter ()
           {

            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
           }

    }
}
