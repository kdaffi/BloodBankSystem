using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Hospital
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
                Label14.Visible = false;
                Label15.Visible = true;
            }
            else
            {
                Label15.Visible = false;
            }
            Label1.Text = myReader.GetInt16("a").ToString();
            myReader.Close();

            MySqlCommand SelectCommand2 = new MySqlCommand("SELECT COUNT(*) AS 'a' FROM bbs.bloodrequest WHERE bloodhospitalid='" + Session["id"].ToString() + "' AND status='Reject';", myConn);
            MySqlDataReader myReader2;
            myReader2 = SelectCommand2.ExecuteReader();
            myReader2.Read();
            if (myReader2.GetInt16("a") == 0)
            {
                Label10.Visible = false;
                Label11.Visible = true;
            }
            else
            {
                Label11.Visible = false;
            }
            Label2.Text = myReader2.GetInt16("a").ToString();
            myReader2.Close();

            MySqlCommand SelectCommand3 = new MySqlCommand("SELECT COUNT(*) AS 'a' FROM bbs.bloodrequest WHERE bloodhospitalid='" + Session["id"].ToString() + "' AND status='Pending';", myConn);
            MySqlDataReader myReader3;
            myReader3 = SelectCommand3.ExecuteReader();
            myReader3.Read();
            if (myReader3.GetInt16("a") == 0)
            {
                Label12.Visible = false;
                Label13.Visible = true;
            }
            else
            {
                Label13.Visible = false;
            }
            Label3.Text = myReader3.GetInt16("a").ToString();
            myReader3.Close();

            MySqlCommand SelectCommand4 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Approve' AND bloodhospitalid IS NOT NULL;", myConn);
            MySqlDataReader myReader4;
            myReader4 = SelectCommand4.ExecuteReader();
            myReader4.Read();
            if (myReader4.GetInt16("a") == 0)
            {
                Label16.Visible = false;
                Label17.Visible = true;
            }
            else
            {
                Label17.Visible = false;
            }
            Label4.Text = myReader4.GetInt16("a").ToString();
            myReader4.Close();

            MySqlCommand SelectCommand5 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Reject' AND bloodhospitalid IS NOT NULL;", myConn);
            MySqlDataReader myReader5;
            myReader5 = SelectCommand5.ExecuteReader();
            myReader5.Read();
            if (myReader5.GetInt16("a") == 0)
            {
                Label18.Visible = false;
                Label19.Visible = true;
            }
            else
            {
                Label19.Visible = false;
            }
            Label5.Text = myReader5.GetInt16("a").ToString();
            myReader5.Close();

            MySqlCommand SelectCommand6 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Pending' AND bloodhospitalid IS NOT NULL;", myConn);
            MySqlDataReader myReader6;
            myReader6 = SelectCommand6.ExecuteReader();
            myReader6.Read();
            if (myReader6.GetInt16("a") == 0)
            {
                Label20.Visible = false;
                Label21.Visible = true;
            }
            else
            {
                Label21.Visible = false;
            }
            Label6.Text = myReader6.GetInt16("a").ToString();
            myReader6.Close();

            MySqlCommand SelectCommand7 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Approve' AND donorid IS NOT NULL;", myConn);
            MySqlDataReader myReader7;
            myReader7 = SelectCommand7.ExecuteReader();
            myReader7.Read();
            if (myReader7.GetInt16("a") == 0)
            {
                Label22.Visible = false;
                Label23.Visible = true;
            }
            else
            {
                Label23.Visible = false;
            }
            Label7.Text = myReader7.GetInt16("a").ToString();
            myReader7.Close();

            MySqlCommand SelectCommand8 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Reject' AND donorid IS NOT NULL;", myConn);
            MySqlDataReader myReader8;
            myReader8 = SelectCommand8.ExecuteReader();
            myReader8.Read();
            if (myReader8.GetInt16("a") == 0)
            {
                Label24.Visible = false;
                Label25.Visible = true;
            }
            else
            {
                Label25.Visible = false;
            }
            Label8.Text = myReader8.GetInt16("a").ToString();
            myReader8.Close();

            MySqlCommand SelectCommand9 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND status='Pending' AND donorid IS NOT NULL;", myConn);
            MySqlDataReader myReader9;
            myReader9 = SelectCommand9.ExecuteReader();
            myReader9.Read();
            if (myReader9.GetInt16("a") == 0)
            {
                Label26.Visible = false;
                Label27.Visible = true;
            }
            else
            {
                Label27.Visible = false;
            }
            Label9.Text = myReader9.GetInt16("a").ToString();
            myReader9.Close();

            myConn.Close();
        }
    }
}