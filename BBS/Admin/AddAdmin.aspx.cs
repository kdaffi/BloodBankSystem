using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Admin
{
    public partial class AddAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand selectcmd = new MySqlCommand("SELECT * FROM bbs.admin ORDER BY id desc LIMIT 1", myConn);
            MySqlDataReader myRead2;
            myConn.Open();
            myRead2 = selectcmd.ExecuteReader();
            myRead2.Read();
            var id = myRead2.GetInt16("id") + 1;
            string id2 = id.ToString();
            myRead2.Close();
      
            MySqlCommand SelectCommand = new MySqlCommand("INSERT INTO bbs.admin (adminid,name,adminname,location,phoneno,address,postcode) VALUES ('A" + id2 + "', 'Pusat Darah Negara' ,'" + name.Text + "','Kuala Lumpur','03-2693 3888','Jalan Tun Razak','50400')", myConn);
            MySqlDataReader myReader;
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            myReader.Close();

            MySqlCommand selectcmd2 = new MySqlCommand("SELECT * FROM bbs.admin ORDER BY id desc LIMIT 1", myConn);
            MySqlDataReader myRead3;
            myRead3 = selectcmd2.ExecuteReader();
            myRead3.Read();
            string adminid = myRead3.GetString("adminid");
            myRead3.Close();

            MySqlCommand SelectCommand2 = new MySqlCommand("INSERT INTO bbs.login (username,password,role,parentid) VALUES ('"+ usr.Text + "','" + pwd.Text + "','1','" + adminid + "');", myConn);
            MySqlDataReader myReader4;
            myReader4 = SelectCommand2.ExecuteReader();
            myReader4.Read();
            myReader4.Close();

            Response.Write("<script type='text/javascript'>");
            Response.Write("alert('New admin successfully added !');");
            Response.Write("document.location.href='AddAdmin.aspx';");
            Response.Write("</script>");

            myConn.Close();
        }
    }
}