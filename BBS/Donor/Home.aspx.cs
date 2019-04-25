using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Donor
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE donorid='" + Session["id"].ToString() + "' AND status='Approve';", myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            Label1.Text = myReader.GetInt16("a").ToString();
            
            if (myReader.GetInt16("a") == 0)
            {
                Label7.Visible = false;
                Label5.Visible = true;
            }
            else
            {
                Label5.Visible = false;
            }myReader.Close();

            MySqlCommand SelectCommand2 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE donorid='" + Session["id"].ToString() + "' AND status='Reject';", myConn);
            MySqlDataReader myReader2;
            myReader2 = SelectCommand2.ExecuteReader();
            myReader2.Read();
            Label2.Text = myReader2.GetInt16("a").ToString();
            
            if (myReader2.GetInt16("a") == 0)
            {
                Label8.Visible = false;
                Label4.Visible = true;
            }
            else
            {
                Label4.Visible = false;
            }myReader2.Close();

            MySqlCommand SelectCommand3 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE donorid='" + Session["id"].ToString() + "' AND status='Pending';", myConn);
            MySqlDataReader myReader3;
            myReader3 = SelectCommand3.ExecuteReader();
            myReader3.Read();
            Label3.Text = myReader3.GetInt16("a").ToString();
            
            if (myReader3.GetInt16("a") == 0)
            {
                Label9.Visible = false;
                Label6.Visible = true;
            }
            else
            {
                Label6.Visible = false;
            }myReader3.Close();

            myConn.Close();
        }
    }
}