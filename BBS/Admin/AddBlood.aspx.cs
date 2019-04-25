using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Admin
{
    public partial class AddBlood : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.SelectedDate = DateTime.Now;
        }

        protected void add_click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand selectcmd = new MySqlCommand("SELECT * FROM bbs.bloodbank ORDER BY id desc LIMIT 1", myConn);
            MySqlDataReader myRead2;
            myConn.Open();
            myRead2 = selectcmd.ExecuteReader();
            myRead2.Read();
            var id = myRead2.GetInt16("id") + 1;
            Calendar1.SelectedDate = DateTime.Now.Date;
            string id2 = id.ToString();
            myRead2.Close();
            MySqlCommand datecmd = new MySqlCommand("SELECT *, COUNT(*) AS 'a' FROM bbs.bloodbank WHERE expireddate='" + txtDate.Text + "' AND hospitalid='" + Session["id"].ToString() + "' AND type='" + DropDownList1.SelectedValue + "'", myConn);
            MySqlDataReader readdata;
            
            readdata = datecmd.ExecuteReader();
            readdata.Read();
            if (readdata.GetInt16("a") >= 1)
            {
                int am = readdata.GetInt32("amount");
                am += Convert.ToInt32(availability.Text);
                MySqlCommand SelectCommand = new MySqlCommand("UPDATE bbs.bloodbank SET amount = " + am + " WHERE expireddate='" + txtDate.Text + "' AND hospitalid='" + Session["id"].ToString() + "' AND type='" + DropDownList1.SelectedValue + "'", myConn);
                readdata.Close();
                MySqlDataReader myReader;

                Response.Write("<script type='text/javascript'>");
                Response.Write("alert('New blood successfully added !');");
                Response.Write("document.location.href='AddBlood.aspx';");
                Response.Write("</script>");
                
                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {

                }

            }
            else
            {
                MySqlCommand SelectCommand = new MySqlCommand("INSERT INTO bbs.bloodbank (bloodid,hospitalid,type,amount,expireddate) VALUES ('B" + id2 + "','" + Session["id"].ToString() + "','" + DropDownList1.SelectedValue + "','" + Convert.ToInt32(availability.Text) + "','" + txtDate.Text + "')", myConn);
                readdata.Close();
                MySqlDataReader myReader;

                Response.Write("<script type='text/javascript'>");
                Response.Write("alert('New blood successfully added !');");
                Response.Write("document.location.href='AddBlood.aspx';");
                Response.Write("</script>");

                myReader = SelectCommand.ExecuteReader();

                while (myReader.Read())
                {

                }
            }
            myConn.Close();
        }
    }
}