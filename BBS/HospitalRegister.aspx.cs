using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS
{
    public partial class HospitalRegister : System.Web.UI.Page
    {
        public string alert;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (RadioButton1.Checked || RadioButton3.Checked)
                {
                    RadioButton2.Checked = false;
                    RadioButton4.Checked = false;
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                }
                else if (RadioButton2.Checked || RadioButton4.Checked)
                {
                    RadioButton1.Checked = false;
                    RadioButton3.Checked = false;
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                }
            }

        }

        protected void register_click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);

            MySqlCommand selectcmd = new MySqlCommand("SELECT * FROM bbs.hospital ORDER BY id desc LIMIT 1", myConn);
            MySqlDataReader myRead2;
            myConn.Open();
            myRead2 = selectcmd.ExecuteReader();
            myRead2.Read();
            var id = myRead2.GetInt16("id") + 1;
            string id2 = id.ToString();
            myRead2.Close();

            MySqlCommand SelectCommand = new MySqlCommand("INSERT INTO bbs.hospital (hospitalid,name,location,phoneno,address,postcode) VALUES ('H" + id2 + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "') ;", myConn);
            MySqlDataReader myReader;
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            myReader.Close();

            MySqlCommand selectcmd2 = new MySqlCommand("SELECT hospitalid FROM bbs.hospital WHERE name='" + TextBox1.Text + "' AND location='" + TextBox2.Text + "' LIMIT 1", myConn);
            MySqlDataReader myRead3;
            myRead3 = selectcmd2.ExecuteReader();
            myRead3.Read();

            MySqlCommand SelectCommand4 = new MySqlCommand("INSERT INTO bbs.login (username,password,role,parentid) VALUES ('" + TextBox6.Text + "','" + TextBox7.Text + "', 3 ,'" + myRead3.GetString("hospitalid") + "') ;", myConn);
            MySqlDataReader myReader4;
            myRead3.Close();
            myReader4 = SelectCommand4.ExecuteReader();
            myReader4.Read();
            myReader4.Close();
        }
    }
}