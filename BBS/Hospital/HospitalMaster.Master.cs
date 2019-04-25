using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Hospital
{
    public partial class HospitalMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.hospital WHERE hospitalid='" + Session["id"].ToString() + "' LIMIT 1", myConn);
                MySqlDataReader myReader;

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                myReader.Read();
                lblName.Text = myReader.GetString("name");
                myConn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}