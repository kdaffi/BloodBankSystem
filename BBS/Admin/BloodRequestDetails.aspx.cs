using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Admin
{
    public partial class BloodRequestDetails : System.Web.UI.Page
    {
        int bloodamount,amount,amn;
        public string butt, butt2;
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.bloodrequest a JOIN bbs.hospital b ON a.reqhospitalid=b.hospitalid WHERE requestid='" + s + "';", myConn);
            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            hospitalname.Text = myReader.GetString("name");
            Session["bhid"] = myReader.GetString("hospitalid");
            bloodtype.Text = myReader.GetString("type");
            Session["btype"] = myReader.GetString("type");
            bloodid.Text = myReader.GetString("bloodid");
            Session["bloodid"] = myReader.GetString("bloodid");

            MySqlConnection myConn2 = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand2 = new MySqlCommand("SELECT * FROM bbs.bloodbank WHERE bloodid='" + Session["bloodid"] + "';", myConn2);
            MySqlDataReader myReader2;
            myConn2.Open();
            myReader2 = SelectCommand2.ExecuteReader();
            myReader2.Read();
            ed.Text = myReader2.GetString("expireddate");
            Label4.Text = myReader2.GetString("amount");
            amount = Convert.ToInt32(myReader2.GetString("amount"));
            amt.Text = myReader.GetString("amountrequest");
            Session["amt"] = myReader.GetString("amountrequest");
            
            phone.Text = myReader.GetString("phoneno");
            string dat = Convert.ToString(DateTime.Now.Date);
            Session["date"] = dat;
            if (myReader.GetString("status") == "Approve")
            {
                amnt.ReadOnly = true;
                amnt.Text = myReader.GetString("amountapprove");
                amnt.BackColor = System.Drawing.Color.Gray;
                DropDownList1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Blood Request Already Approved !";
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Font.Bold = true;
                Button1.Visible = false;
            }
            else if (myReader.GetString("status") == "Reject")
            {
                amnt.ReadOnly = true;
                amnt.Text = myReader.GetString("amountapprove");
                amnt.BackColor = System.Drawing.Color.Gray;
                DropDownList1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Blood Request Already Rejected !";
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Font.Bold = true;
                amnt.Text = "0";
                Button1.Visible = false;
            }
            else if (myReader.GetString("status") == "Pending")
            {
                Button1.Visible = true;
                butt = butt + @"<TR><td style='background:#800000;color:white;' colspan='2'>";
                butt2 = butt2 + @"</td></TR>";
                Label1.Visible = false;
                DropDownList1.Visible = true;
                amnt.ReadOnly = false;
            }
        }

        protected void check(object sender, EventArgs e)
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            MySqlCommand SelectCommand2 = new MySqlCommand("SELECT * FROM bbs.bloodbank WHERE bloodid='" + Session["bloodid"] + "';", myConn);
            MySqlDataReader myReader2;
            myConn.Open();
            myReader2 = SelectCommand2.ExecuteReader();
            myReader2.Read();
            if (DropDownList1.SelectedValue == "Approve")
            {
                if (myReader2.GetInt32("amount") >= Convert.ToInt32(amnt.Text))
                {
                    updatedata();
                }
                else
                {
                    Response.Write("<script type='text/javascript'>");
                    Response.Write("alert('Your enter value that exceed amount of blood available !');");
                    Response.Write("location.reload();");
                    Response.Write("</script>");
                }
            }
            else
            {
                updatedata();
            }
        }

        protected void updatedata()
        {
            string s = Request.QueryString["valuenum"];
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            MySqlCommand SelectCommand2 = new MySqlCommand("SELECT * FROM bbs.bloodrequest WHERE bloodid='" + Session["bloodid"] + "';", myConn);
            MySqlDataReader myReader2;
            myConn.Open();
            myReader2 = SelectCommand2.ExecuteReader();
            myReader2.Read();

            if (DropDownList1.SelectedValue == "Approve")
            {
                if (Convert.ToInt32(amnt.Text) > Convert.ToInt32(amt.Text))
                {
                    Response.Write("<script type='text/javascript'>");
                    Response.Write("alert('You cannot approve more than requested amount !');");
                    Response.Write("location.reload();");
                    Response.Write("</script>");
                }
                else
                {
                    bloodamount = Convert.ToInt32(amnt.Text) - Convert.ToInt16(Label4.Text);
                    
                    myReader2.Close();

                    if (Convert.ToInt32(amnt.Text) == Convert.ToInt32(amt.Text))
                    {
                        MySqlCommand SelectCommand = new MySqlCommand("UPDATE bbs.bloodrequest SET status='" + DropDownList1.SelectedValue + "',amountapprove=" + Convert.ToInt32(amnt.Text) + " WHERE bloodid='" + Session["bloodid"] + "';", myConn);
                        MySqlDataReader myReader;
                        myReader = SelectCommand.ExecuteReader();
                        myReader.Read(); myReader.Close();
                    }
                    else
                    {
                       int val = amount + (Convert.ToInt32(amt.Text) - Convert.ToInt32(amnt.Text));
                       MySqlCommand SelectCommand = new MySqlCommand("UPDATE bbs.bloodrequest SET status='" + DropDownList1.SelectedValue + "',amountapprove=" + Convert.ToInt32(amnt.Text) + " WHERE bloodid='" + Session["bloodid"] + "';", myConn);
                       MySqlDataReader myReader;
                       myReader = SelectCommand.ExecuteReader();
                       myReader.Read(); myReader.Close();

                       MySqlCommand SelectCommand3 = new MySqlCommand("UPDATE bbs.bloodbank SET amount=" + val + " WHERE bloodid='" + Session["bloodid"] + "';", myConn);
                       MySqlDataReader myReader3;
                       myReader3 = SelectCommand3.ExecuteReader();
                       myReader3.Read();
                    }
                   
                    Response.Write("<script type='text/javascript'>");
                    Response.Write("alert('Blood request successfully Approve !');");
                    Response.Write("location.reload();");
                    Response.Write("</script>");

                }
                myConn.Close();
            }
            else
            {
                myReader2.Close();
                MySqlCommand SelectCommand = new MySqlCommand("UPDATE bbs.bloodrequest SET status='" + DropDownList1.SelectedValue + "',amountapprove=0 WHERE bloodid='" + Session["bloodid"] + "';", myConn);
                MySqlDataReader myReader;
                myReader = SelectCommand.ExecuteReader();
                myReader.Read(); myReader.Close();
                int amn = Int32.Parse(amt.Text);
                int latestamt = amn + amount;
                MySqlCommand SelectCommand3 = new MySqlCommand("UPDATE bbs.bloodbank SET amount=" + latestamt + " WHERE bloodid='" + Session["bloodid"] + "';", myConn);
                MySqlDataReader myReader3;
                myReader3 = SelectCommand3.ExecuteReader();
                myReader3.Read();

                Response.Write("<script type='text/javascript'>");
                Response.Write("alert('Blood request successfully Rejected !');");
                Response.Write("location.reload();");
                Response.Write("</script>");
                myConn.Close();
            }
        }

        protected void change(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Approve")
            {
                amnt.Visible = true;
                Label2.Visible = false;
            }
            else
            {
                amnt.Visible = false;
                Label2.Visible = true;
                Label3.Visible = false;
                Label2.Text = "Cannot input amount";
            }
            
        }
    }
}