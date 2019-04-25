using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Hospital
{
    public partial class BloodRequestToDonor : System.Web.UI.Page
    {
        public string blooddata;
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            try
                {
                    MySqlCommand SelectCommand2 = new MySqlCommand("SELECT * FROM bbs.bloodrequest a INNER JOIN bbs.donor b ON a.donorid=b.donorid WHERE reqhospitalid='" + Session["id"] + "';", myConn);

                    MySqlDataReader myReader2;
                    myReader2 = SelectCommand2.ExecuteReader();

                    while (myReader2.Read())
                    {
                            Session["donorid"] = myReader2.GetString("donorid");
                            blooddata = blooddata + @"<TR>";
                            blooddata = blooddata + @"<TD>" + myReader2.GetString("requestid") + @"</TD>";
                            blooddata = blooddata + @"<TD>" + myReader2.GetString("bloodid") + @"</TD>";
                            blooddata = blooddata + @"<TD>" + myReader2.GetString("name") + @"</TD>";
                            blooddata = blooddata + @"<TD>" + myReader2.GetString("type") + @"</TD>";
                            blooddata = blooddata + @"<TD>" + myReader2.GetString("location") + @"</TD>";
                            if (myReader2.GetString("status") == "Approve")
                            {
                                blooddata = blooddata + @"<TD style='color:Green;font-weight:bold;'>" + myReader2.GetString("status") + @"</TD>";
                            }
                            else if (myReader2.GetString("status") == "Pending")
                            {
                                blooddata = blooddata + @"<TD style='color:Orange;font-weight:bold;'>" + myReader2.GetString("status") + @"</TD>";
                            }
                            else
                            {
                                blooddata = blooddata + @"<TD style='color:Red;font-weight:bold;'>" + myReader2.GetString("status") + @"</TD>";
                            }
                            blooddata = blooddata + @"<TD><a href='BloodRequestDonorDetails.aspx?valuenum=" + myReader2.GetString("requestid") + @" '>View Details</a></TD>";
                            if (myReader2.GetString("status") == "Approve")
                            {
                                blooddata = blooddata + @"<TD>-</TD>";
                            }
                            else
                            {
                                blooddata = blooddata + @"<TD><a href='Delete.aspx?valuenum=" + myReader2.GetString("requestid") + @" '>Delete</a></TD>";
                            }
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