using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Admin
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.bloodrequest WHERE requestid='" + s + "';", myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();

            if (myReader.GetString("status") == "Reject")
            {
                myReader.Close();
                MySqlCommand SelectCommand2 = new MySqlCommand("DELETE FROM bbs.bloodrequest WHERE requestid='" + s + "';", myConn);
                MySqlDataReader myReader2;
                myReader2 = SelectCommand2.ExecuteReader();
                myReader2.Read();
            }
            else if (myReader.GetString("status") == "Pending")
            {
                int flag = 0;
                myReader.Close();
                MySqlCommand SelectCommand5 = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.bloodrequest WHERE requestid='" + s + "' AND bloodhospitalid IS NOT NULL;", myConn);
                MySqlDataReader myReader5;
                myReader5 = SelectCommand5.ExecuteReader();
                myReader5.Read();
                if (myReader5.GetInt32("a") > 0)
                {
                    flag = 1;
                }
                myReader5.Close();
                if (flag == 1)
                {
                    MySqlDataReader myReader6;
                    myReader6 = SelectCommand.ExecuteReader();
                    myReader6.Read();
                    int amtreq = myReader6.GetInt32("amountrequest");
                    string bloodid = myReader6.GetString("bloodid");
                    myReader6.Close();
                    MySqlCommand SelectCommand2 = new MySqlCommand("SELECT * FROM bbs.bloodbank WHERE bloodid='" + bloodid + "';", myConn);
                    MySqlDataReader myReader2;
                    myReader2 = SelectCommand2.ExecuteReader();
                    myReader2.Read();
                    int oldamnt = myReader2.GetInt32("amount");
                    int newamnt = oldamnt + amtreq;
                    myReader2.Close();

                    MySqlCommand SelectCommand3 = new MySqlCommand("UPDATE bbs.bloodbank SET amount='" + newamnt + "' WHERE bloodid='" + bloodid + "';", myConn);
                    MySqlDataReader myReader3;
                    myReader3 = SelectCommand3.ExecuteReader();
                    myReader3.Read();
                    myReader3.Close();

                    MySqlCommand SelectCommand4 = new MySqlCommand("DELETE FROM bbs.bloodrequest WHERE requestid='" + s + "';", myConn);
                    MySqlDataReader myReader4;
                    myReader4 = SelectCommand4.ExecuteReader();
                    myReader4.Read();
                }
                else
                {
                    myReader.Close();
                    MySqlCommand SelectCommand2 = new MySqlCommand("DELETE FROM bbs.bloodrequest WHERE requestid='" + s + "';", myConn);
                    MySqlDataReader myReader2;
                    myReader2 = SelectCommand2.ExecuteReader();
                    myReader2.Read();
                }

            }

            Response.Redirect(Request.UrlReferrer.AbsoluteUri);
        }
    }
}