using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Hospital
{
    public partial class BloodBank : System.Web.UI.Page
    {
        public string blooddata,blooddata2;
        public string usertype;
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.bloodbank a INNER JOIN bbs.hospital b ON a.hospitalid=b.hospitalid UNION SELECT * FROM bbs.bloodbank a INNER JOIN bbs.admin c ON a.hospitalid=c.adminid WHERE amount<>0;", myConn);
            MySqlDataReader myReader;
            if (RadioButton1.Checked)
            {
                blooddata = blooddata + @"<thead>";
                blooddata = blooddata + @"<tr class='header' style='height:40px;'>";
                blooddata = blooddata + @"<td style='color:White;'>Blood ID</td>";
                blooddata = blooddata + @"<td style='color:White;'>Hospital</td>";
                blooddata = blooddata + @"<td style='color:White;'>Type</td>";
                blooddata = blooddata + @"<td style='color:White;'>Location</td>";
                blooddata = blooddata + @"<td style='color:White;'>Availability</td>";
                blooddata = blooddata + @"<td style='color:White;'>Expired Date</td>";
                blooddata = blooddata + @"<td style='color:White;'>Details</td>";
                blooddata = blooddata + @"</tr>";
                blooddata = blooddata + @"</thead>";
                try
                {

                    myReader = SelectCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        
                        blooddata = blooddata + @"<tbody><tr>";
                        blooddata = blooddata + @"<td>" + myReader.GetString("bloodid") + @"</td>";
                        blooddata = blooddata + @"<td>" + myReader.GetString("name") + @"</td>";
                        blooddata = blooddata + @"<td>" + myReader.GetString("type") + @"</td>";
                        blooddata = blooddata + @"<td>" + myReader.GetString("location") + @"</td>";
                        blooddata = blooddata + @"<td>" + myReader.GetString("amount") + @"</td>";
                        blooddata = blooddata + @"<td>" + myReader.GetString("expireddate") + @"</td>";
                        blooddata = blooddata + @"<td><a href='ViewDetails.aspx?valuenum=" + myReader.GetString("bloodid") + @" '>View Details</a></td>";
                        blooddata = blooddata + @"</td>";
                        blooddata = blooddata + @"</tr></tbody>";
                    }

                }
                catch (Exception ex)
                {

                }
                
            }
            else if (RadioButton2.Checked)
            {
                blooddata = blooddata + @"<thead>";
                blooddata = blooddata + @"<tr class='header' style='height:40px;'>";
                blooddata = blooddata + @"<td style='color:White;'>Blood ID</td>";
                blooddata = blooddata + @"<td style='color:White;'>Name</td>";
                blooddata = blooddata + @"<td style='color:White;'>Type</td>";
                blooddata = blooddata + @"<td style='color:White;'>Location</td>";
                blooddata = blooddata + @"<td style='color:White;'>Details</td>";
                blooddata = blooddata + @"</tr>";
                blooddata = blooddata + @"</thead>";
                try
                {
                    MySqlCommand SelectCommand2 = new MySqlCommand("SELECT * FROM bbs.bloodbank a JOIN bbs.donor b ON a.donorid=b.donorid", myConn);

                    MySqlDataReader myReader2;
                    myReader2 = SelectCommand2.ExecuteReader();

                    while (myReader2.Read())
                    {
                        blooddata = blooddata + @"<TR>";
                        blooddata = blooddata + @"<TD>" + myReader2.GetString("bloodid") + @"</TD>";
                        blooddata = blooddata + @"<TD>" + myReader2.GetString("name") + @"</TD>";
                        blooddata = blooddata + @"<TD>" + myReader2.GetString("type") + @"</TD>";
                        blooddata = blooddata + @"<TD>" + myReader2.GetString("location") + @"</TD>";
                        blooddata = blooddata + @"<TD><a href='DonorDetails.aspx?valuenum=" + myReader2.GetString("bloodid") + @" '>View Details</a></TD>";
                        blooddata = blooddata + @"</TD>";
                        blooddata = blooddata + @"</TR>";
                    }

                }

                catch (Exception ex)
                {

                }
                   
            }   myConn.Close();
        }
    }
}