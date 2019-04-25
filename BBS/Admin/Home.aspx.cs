using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Admin
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT COUNT(*) AS 'a' FROM bbs.bloodrequest WHERE bloodhospitalid='" + Session["id"].ToString() + "' AND status='Approve';", myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            if (myReader.GetInt16("a") == 0)
            {
                Label4.Visible = false;
                Label5.Visible = true;
            }
            else
            {
                Label5.Visible = false;
            }
            Label1.Text = myReader.GetInt16("a").ToString();
            myReader.Close();

            MySqlCommand SelectCommand2 = new MySqlCommand("SELECT COUNT(*) AS 'a' FROM bbs.bloodrequest WHERE bloodhospitalid='" + Session["id"].ToString() + "' AND status='Reject';", myConn);
            MySqlDataReader myReader2;
            myReader2 = SelectCommand2.ExecuteReader();
            myReader2.Read();
            if (myReader2.GetInt16("a") == 0)
            {
                Label6.Visible = false;
                Label10.Visible = true;
            }
            else
            {
                Label10.Visible = false;
            }
            Label2.Text = myReader2.GetInt16("a").ToString();
            myReader2.Close();

            MySqlCommand SelectCommand3 = new MySqlCommand("SELECT COUNT(*) AS 'a' FROM bbs.bloodrequest WHERE bloodhospitalid='" + Session["id"].ToString() + "' AND status='Pending';", myConn);
            MySqlDataReader myReader3;
            myReader3 = SelectCommand3.ExecuteReader();
            myReader3.Read();
            if (myReader3.GetInt16("a") == 0)
            {
                Label11.Visible = false;
                Label12.Visible = true;
            }
            else
            {
                Label12.Visible = false;
            }
            Label3.Text = myReader3.GetInt16("a").ToString();
            myReader3.Close();

            MySqlCommand SelectCommand7 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Approve' AND donorid IS NOT NULL;", myConn);
            MySqlDataReader myReader7;
            myReader7 = SelectCommand7.ExecuteReader();
            myReader7.Read();
            if (myReader7.GetInt16("a") == 0)
            {
                Label13.Visible = false;
                Label14.Visible = true;
            }
            else
            {
                Label14.Visible = false;
            }
            Label7.Text = myReader7.GetInt16("a").ToString();
            myReader7.Close();

            MySqlCommand SelectCommand8 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Reject' AND donorid IS NOT NULL;", myConn);
            MySqlDataReader myReader8;
            myReader8 = SelectCommand8.ExecuteReader();
            myReader8.Read();
            if (myReader8.GetInt16("a") == 0)
            {
                Label15.Visible = false;
                Label16.Visible = true;
            }
            else
            {
                Label16.Visible = false;
            }
            Label8.Text = myReader8.GetInt16("a").ToString();
            myReader8.Close();

            MySqlCommand SelectCommand9 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Pending' AND donorid IS NOT NULL;", myConn);
            MySqlDataReader myReader9;
            myReader9 = SelectCommand9.ExecuteReader();
            myReader9.Read();
            if (myReader9.GetInt16("a") == 0)
            {
                Label17.Visible = false;
                Label18.Visible = true;
            }
            else
            {
                Label18.Visible = false;
            }
            Label9.Text = myReader9.GetInt16("a").ToString();
            myReader9.Close();

            myConn.Close();
        }
    }
}