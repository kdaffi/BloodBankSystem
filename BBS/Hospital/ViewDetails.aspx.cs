using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Hospital
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        int amount;
        public string blooddata;
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

            string MyString = Session["bhid"].ToString();
            string OtherString = Session["id"].ToString();
            int MyInt = MyString.CompareTo(OtherString);
            if (MyInt == 1)
            {
                Button1.Visible = true;
                amnt.Visible = true;
            }
            else
            {
                Button1.Visible = false;
                amnt.Visible = false;
                RequiredFieldValidator1.Enabled = false;
                Label1.Visible = true;
                Label1.Text = "You cannot request blood to your own hospital";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime dispDt = DateTime.Now;
            string dtString;
            dtString = dispDt.ToString(datePatt);

            
                string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand selectcmd = new MySqlCommand("SELECT * FROM bbs.bloodrequest ORDER BY id desc LIMIT 1", myConn);
                MySqlDataReader myRead2;
                myConn.Open();
                myRead2 = selectcmd.ExecuteReader();
                myRead2.Read();
                var id = myRead2.GetInt16("id") + 1;
                string id2 = id.ToString();
                myRead2.Close();

                MySqlCommand selectcmd2 = new MySqlCommand("SELECT *, COUNT(*) AS 'a' FROM bbs.bloodrequest WHERE reqhospitalid='" + Session["id"].ToString() + "' AND bloodhospitalid='" + Session["bhid"].ToString() + "' AND daterequest='" + dtString + "' AND status='Pending'", myConn);
                MySqlDataReader myRead3;
                myRead3 = selectcmd2.ExecuteReader();
                myRead3.Read();
                if (myRead3.GetInt16("a") >= 1)
                {
                    int amntreq = myRead3.GetInt32("amountrequest");
                    int newamntreq = amntreq + Convert.ToInt32(amnt.Text);
                    MySqlCommand SelectCommand = new MySqlCommand("UPDATE bbs.bloodrequest SET amountrequest=" + newamntreq + " WHERE reqhospitalid='" + Session["id"].ToString() + "' AND bloodhospitalid='" + Session["bhid"].ToString() + "' AND daterequest='" + dtString + "' AND status='Pending'", myConn);
                    myRead3.Close();
                    MySqlDataReader myReader;
                    int a;
                    int.TryParse(Convert.ToString(Session["amt"]), out a);
                    int b;
                    int.TryParse(amnt.Text, out b);
                    if (b > a)
                    {
                        Response.Write("<script type='text/javascript'>");
                        Response.Write("alert('Your enter value that exceed amount of blood available !');");
                        Response.Write("location.reload();");
                        Response.Write("</script>");
                    }
                    if (b <= a)
                    {
                        Response.Write("<script type='text/javascript'>");
                        Response.Write("alert('Success !');");
                        Response.Write("location.reload();");
                        Response.Write("</script>");
                        update();
                        myReader = SelectCommand.ExecuteReader();
                        while (myReader.Read())
                        {

                        }
                    }
                }

                else
                {
                    myRead3.Close();
                    MySqlCommand SelectCommand = new MySqlCommand("INSERT INTO bbs.bloodrequest (requestid,reqhospitalid,bloodhospitalid,bloodid,daterequest,amountrequest,type) VALUES ('R" + id2 + "','" + Session["id"].ToString() + "','" + Session["bhid"].ToString() + "','" + Session["bloodid"].ToString() + "','" + dtString + "'," + Convert.ToInt32(amnt.Text) + ",'" + Session["btype"].ToString() + "')", myConn);
                    MySqlDataReader myReader;
                    int a;
                    int.TryParse(Session["amt"].ToString(), out a);
                    int b;
                    int.TryParse(amnt.Text, out b);
                    if (b > a)
                    {
                        Response.Write("<script type='text/javascript'>");
                        Response.Write("alert('Your enter value that exceed amount of blood available !');");
                        Response.Write("location.reload();");
                        Response.Write("</script>");
                    }
                    if (b <= a)
                    {
                        Response.Write("<script type='text/javascript'>");
                        Response.Write("alert('Success !');");
                        Response.Write("location.reload();");
                        Response.Write("</script>");
                        update();
                        myReader = SelectCommand.ExecuteReader();
                        while (myReader.Read())
                        {

                        }
                    }
                }myConn.Close();
            
            
            
        }

        protected void update()
        {
            amount = Convert.ToInt32(Session["amt"]) - Convert.ToInt32(amnt.Text);
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand selectcmd = new MySqlCommand("UPDATE bbs.bloodbank SET amount=" + amount + " WHERE bloodid='" + Session["bloodid"] + "'", myConn);
            MySqlDataReader myRead2;
            myConn.Open();
            myRead2 = selectcmd.ExecuteReader();
            myRead2.Read();
            myConn.Close();
        }
    }
}