using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Admin
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        public static string datePatt = @"dd/MM/yyyy";
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.bloodbank a INNER JOIN bbs.hospital b ON a.hospitalid=b.hospitalid WHERE bloodid='" + s + "' UNION SELECT * FROM bbs.bloodbank a INNER JOIN bbs.admin c ON a.hospitalid=c.adminid WHERE bloodid='" + s + "';", myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            hospitalname.Text = myReader.GetString("name");
            Label2.Text = myReader.GetString("address");
            Label3.Text = myReader.GetString("postcode");
            Label4.Text = myReader.GetString("location");
            phone.Text = myReader.GetString("phoneno");
            Session["bhid"] = myReader.GetString("hospitalid");
            bloodtype.Text = myReader.GetString("type");
            Session["btype"] = myReader.GetString("type");
            bloodid.Text = myReader.GetString("bloodid");
            Session["bloodid"] = myReader.GetString("bloodid");
            ed.Text = myReader.GetString("expireddate");
            amt.Text = Convert.ToString(myReader.GetInt32("amount"));
            Session["amt"] = myReader.GetInt32("amount");

            string dat = Convert.ToString(DateTime.Now.Date);
            Session["date"] = dat;
            myConn.Close();
        }

    }
}