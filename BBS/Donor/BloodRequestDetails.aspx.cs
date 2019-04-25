using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Donor
{
    public partial class BloodRequestDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.bloodrequest a JOIN bbs.hospital b ON a.reqhospitalid=b.hospitalid WHERE a.requestid='" + s + "' UNION SELECT * FROM bbs.bloodrequest a JOIN bbs.admin b ON a.reqhospitalid=b.adminid WHERE a.requestid='" + s + "';", myConn);
            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            hospitalname.Text = myReader.GetString("name");
            bloodtype.Text = myReader.GetString("type");
            bloodid.Text = myReader.GetString("bloodid");
            Session["bloodid"] = myReader.GetString("bloodid");
            Session["reqid"] = myReader.GetString("requestid");
            Label2.Text = myReader.GetString("address");
            Label3.Text = myReader.GetString("postcode");
            location.Text = myReader.GetString("location");
            phone.Text = myReader.GetString("phoneno");
            if (myReader.GetString("status") == "Approve")
            {
                DropDownList1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Blood Request Approved !";
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Font.Bold = true;
                Button1.Visible = false;
                txtDate.Visible = false;
                Label4.Visible = true;
                Label4.Text = myReader.GetString("donatedate");
                imgPopup.Visible = false;
            }
            else if (myReader.GetString("status") == "Reject")
            {
                DropDownList1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Blood Request Rejected !";
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Font.Bold = true;
                Button1.Visible = false;
                txtDate.Visible = false;
                Label4.Visible = true;
                Label4.Text = "No Date";
                imgPopup.Visible = false;
            }
            else if (myReader.GetString("status") == "Pending")
            {
                DropDownList1.Visible = true;
                Button1.Visible = true;
                Label1.Visible = false;
            }
        }

        protected void updatedata(object sender, EventArgs e)
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();
            if (DropDownList1.SelectedValue == "Approve")
            {
                MySqlCommand SelectCommand = new MySqlCommand("UPDATE bbs.bloodrequest SET status='" + DropDownList1.SelectedValue + "',donatedate='" + txtDate.Text + "' WHERE bloodid='" + Session["bloodid"] + "' AND requestid='" + Session["reqid"] + "';", myConn);
                MySqlDataReader myReader;
                myReader = SelectCommand.ExecuteReader();
                myReader.Read();
                Label1.Visible = false;
                Response.Write("<script type='text/javascript'>");
                Response.Write("alert('Request sucessfully Approved !');");
                Response.Write("</script>");
                Response.Redirect(Request.RawUrl); 
                myConn.Close();
                
            }
            else
            {
                MySqlCommand SelectCommand = new MySqlCommand("UPDATE bbs.bloodrequest SET status='" + DropDownList1.SelectedValue + "',donatedate='No Date' WHERE bloodid='" + Session["bloodid"] + "' AND requestid='" + Session["reqid"] + "';", myConn);
                MySqlDataReader myReader;
                myReader = SelectCommand.ExecuteReader();
                myReader.Read();
                Label1.Visible = false;
                Response.Write("<script type='text/javascript'>");
                Response.Write("alert('Request sucessfully rejected !');");
                Response.Write("</script>");
                Response.Redirect(Request.RawUrl);
                myConn.Close();
            }
        }

        protected void approval(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Approve")
            {
                txtDate.Visible = true;
                imgPopup.Visible = true;
                Label4.Visible = false;
                RequiredFieldValidator3.Enabled = true;
            }
            else
            {
                txtDate.Visible = false;
                imgPopup.Visible = false;
                Label4.Visible = true;
                Label4.Text = "Cannot select date";
                RequiredFieldValidator3.Enabled = false;
            }
        }

        
    }
}