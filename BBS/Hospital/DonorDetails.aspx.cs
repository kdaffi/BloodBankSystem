using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Hospital
{
    public partial class DonorDetails : System.Web.UI.Page
    {
        public static string datePatt = @"dd/MM/yyyy";
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.bloodbank a JOIN bbs.donor b ON a.donorid=b.donorid WHERE bloodid='" + s + "';", myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            hospitalname.Text = myReader.GetString("name");
            gender.Text = myReader.GetString("gender");

            System.DateTime birthTime = Convert.ToDateTime(myReader.GetString("dob"));
            System.DateTime now = System.DateTime.Now;
            System.TimeSpan age = now - birthTime;
            double ageInDays = age.TotalDays;
            double ageInYears = Math.Truncate(ageInDays / 365);
            double ageInMonths = Math.Truncate((ageInDays % 365) / 30);
            Label1.Text = Convert.ToString(ageInYears + " years " + ageInMonths + " months");
            Label2.Text = myReader.GetString("address");
            Label3.Text = myReader.GetString("postcode");
            Label4.Text = myReader.GetString("location");
            Label5.Text = myReader.GetString("phoneno");
            Session["bhid"] = myReader.GetString("donorid");
            bloodtype.Text = myReader.GetString("type");
            Session["btype"] = myReader.GetString("type");
            bloodid.Text = myReader.GetString("bloodid");
            Session["bloodid"] = myReader.GetString("bloodid");
            string dat = Convert.ToString(DateTime.Now.Date);
            Session["date"] = dat;
            myReader.Close();

            MySqlCommand SelectCommand2 = new MySqlCommand("SELECT * FROM bbs.bloodrequest a WHERE a.bloodid='" + s + "'", myConn);
            MySqlDataReader myReader2;
            myReader2 = SelectCommand2.ExecuteReader();
            myReader2.Read();

            if (myReader2.GetString("reqhospitalid") == Session["id"].ToString() && myReader2.GetString("status") == "Approve")
            {
                Button1.Visible = false;
                Label6.Visible = true;
                Label6.Text = "Blood Request Already Approved !";
            }
            else if (myReader2.GetString("reqhospitalid") == Session["id"].ToString() && myReader2.GetString("status") == "Pending")
            {
                Button1.Visible = false;
                Label6.Visible = true;
                Label6.Text = "Waiting Approval !";
            }
            else
            {
                Button1.Visible = true;
                Label6.Visible = false;
            }

            myConn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime dispDt = DateTime.Now;
            string dtString;
            dtString = dispDt.ToString(datePatt);
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand selectcmd = new MySqlCommand("SELECT * FROM bbs.bloodrequest ORDER BY id desc LIMIT 1",myConn);
            MySqlDataReader myRead2;
            myConn.Open();
            myRead2 = selectcmd.ExecuteReader();
            myRead2.Read();
            var id = myRead2.GetInt16("id")+1;
            string id2 = id.ToString();
            myRead2.Close();

       
            MySqlCommand SelectCommand = new MySqlCommand("INSERT INTO bbs.bloodrequest (requestid,reqhospitalid,donorid,bloodid,daterequest,type) VALUES ('R" + id2 + "','" + Session["id"].ToString() + "','" + Session["bhid"].ToString() + "','" + Session["bloodid"].ToString() + "','" + dtString + "','" + Session["btype"].ToString() + "')", myConn);
            MySqlDataReader myReader;
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            myConn.Close();

            Response.Write("<script type='text/javascript'>");
            Response.Write("alert('Blood request successfull !');");
            Response.Write("location.reload();");
            Response.Write("</script>");
        }
    }
}