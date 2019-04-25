using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Donor
{
    public partial class RejBloodReqFrom : System.Web.UI.Page
    {
        public string blooddata;
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.bloodrequest c JOIN bbs.hospital b ON b.hospitalid=c.reqhospitalid AND c.donorid='" + Session["id"] + "' AND status='Reject' UNION SELECT * FROM bbs.bloodrequest c JOIN bbs.admin b ON b.adminid=c.reqhospitalid AND c.donorid='" + Session["id"] + "' AND status='Reject';", myConn);
            MySqlDataReader myReader;


            try
            {
                myReader = SelectCommand.ExecuteReader();
                while (myReader.Read())
                {
                    blooddata = blooddata + @"<TR>";
                    blooddata = blooddata + @"<TD>" + myReader.GetString("requestid") + @"</TD>";
                    blooddata = blooddata + @"<TD>" + myReader.GetString("bloodid") + @"</TD>";
                    blooddata = blooddata + @"<TD>" + myReader.GetString("name") + @"</TD>";
                    blooddata = blooddata + @"<TD>" + myReader.GetString("type") + @"</TD>";
                    blooddata = blooddata + @"<TD>" + myReader.GetString("location") + @"</TD>";
                    blooddata = blooddata + @"<TD style='color:Red;font-weight:bold;'>" + myReader.GetString("status") + @"</TD>";
                    blooddata = blooddata + @"<TD><a href='BloodRequestDetails.aspx?valuenum=" + myReader.GetString("requestid") + @" '>View Details</a></TD>";
                    blooddata = blooddata + @"</TR>";
                }
            }


            catch (Exception ex)
            {

            }
            myConn.Close();
        }
    }
}