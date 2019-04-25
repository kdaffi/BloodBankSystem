using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Donor
{
    public partial class EditInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.donor WHERE donorid='" + Session["id"].ToString() + "';", myConn);
                MySqlDataReader myReader;

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                myReader.Read();
                Label5.Text = myReader.GetString("name");
                Label9.Text = myReader.GetString("icnumber");
                Label7.Text = myReader.GetString("gender");
                System.DateTime birthTime = Convert.ToDateTime(myReader.GetString("dob"));
                System.DateTime now = System.DateTime.Now;
                System.TimeSpan age = now - birthTime;
                double ageInDays = age.TotalDays;
                double ageInYears = Math.Truncate(ageInDays / 365);
                double ageInMonths = Math.Truncate((ageInDays % 365) / 30);
                Label4.Text = Convert.ToString(ageInYears + " years " + ageInMonths + " months");
                Label11.Text = myReader.GetString("type");
                TextBox4.Text = myReader.GetString("address");
                TextBox5.Text = myReader.GetString("postcode");
                DropDownList1.SelectedValue = myReader.GetString("location");
                TextBox3.Text = myReader.GetString("phoneno");
                myConn.Close();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("UPDATE bbs.donor SET address='" + TextBox4.Text + "', postcode='" + TextBox5.Text + "', location='" + DropDownList1.SelectedValue + "',phoneno='" + TextBox3.Text + "' WHERE donorid='" + Session["id"].ToString() + "';", myConn);
            MySqlDataReader myReader;

            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            Response.Write("<script type='text/javascript'>");
            Response.Write("alert('Data successfully updated !');");
            Response.Write("document.location.href='EditInformation.aspx';");
            Response.Write("</script>");
            myConn.Close();
        }
    }
}