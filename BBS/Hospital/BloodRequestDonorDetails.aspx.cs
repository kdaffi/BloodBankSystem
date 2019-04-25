using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Hospital
{
    public partial class BloodRequestDonorDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.bloodrequest a JOIN bbs.donor b ON a.donorid=b.donorid WHERE requestid='" + s + "' AND reqhospitalid='" + Session["id"] + "';", myConn);
            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            bloodid.Text = myReader.GetString("bloodid");
            bloodtype.Text = myReader.GetString("type");
            donorname.Text = myReader.GetString("name");
            Label1.Text = myReader.GetString("gender");
            System.DateTime birthTime = Convert.ToDateTime(myReader.GetString("dob"));
            System.DateTime now = System.DateTime.Now;
            System.TimeSpan age = now - birthTime;
            double ageInDays = age.TotalDays;
            double ageInYears = Math.Truncate(ageInDays / 365);
            double ageInMonths = Math.Truncate((ageInDays % 365) / 30);
            Label2.Text = Convert.ToString(ageInYears + " years " + ageInMonths + " months");
            Label3.Text = myReader.GetString("Address");
            Label4.Text = myReader.GetString("postcode");
            location.Text = myReader.GetString("location");
            phone.Text = myReader.GetString("phoneno");
            status.Text = myReader.GetString("status");
            if (myReader.GetString("status") == "Approve")
            {
                status.ForeColor = System.Drawing.Color.Green;
                Label5.Text = myReader.GetString("donatedate");
            }
            else if (myReader.GetString("status") == "Pending")
            {
                status.ForeColor = System.Drawing.Color.Orange;
                Label5.Text = "No Date";
            }
            else
            {
                status.ForeColor = System.Drawing.Color.Red;
                Label5.Text = "No Date";
            }
        }
    }
}