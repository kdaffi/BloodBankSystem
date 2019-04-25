using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                hospitalpanel.Visible = true;
                donorpanel.Visible = false;
            }
            else if (RadioButton2.Checked)
            {
                hospitalpanel.Visible = false;
                donorpanel.Visible = true;
            }
        }

        //protected void TextBoxBirth_TextChanged(object sender, EventArgs e)
        //{
        //    System.DateTime birthTime = Convert.ToDateTime(txtDate.Text);
        //    System.DateTime now = System.DateTime.Now;
        //    System.TimeSpan age = now - birthTime;
        //    double ageInDays = age.TotalDays;
        //    double ageInYears = Math.Truncate(ageInDays / 365);
        //    double ageInMonths = Math.Truncate((ageInDays % 365) / 30);
        //    Label1.Text = Convert.ToString(ageInYears + " years " + ageInMonths + " months");
        //}

        protected void getgender(object sender, EventArgs e)
        {
            string temp = TextBox9.Text;

            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();
            MySqlCommand SelectCommands = new MySqlCommand("SELECT COUNT(*) AS a FROM bbs.donor WHERE icnumber='" + temp + "'", myConn);
            MySqlDataReader myReaders;
            myReaders = SelectCommands.ExecuteReader();
            myReaders.Read();
            if (myReaders.GetInt16("a") > 0)
            {
                Response.Write("<script type='text/javascript'>");
                Response.Write("if(confirm('You are already registered, do you want to go to login page ?')){document.location.href='Login.aspx'}else{document.location.href='Registration.aspx'};");
                Response.Write("</script>");
                myReaders.Close();
            }
            else
            {
                string output = temp.Substring(temp.Length - 1, 1);
                int output2 = Convert.ToInt16(output) % 2;
                if (output2 != 0)
                {
                    Label2.Text = "Male";
                }
                else
                {
                    Label2.Text = "Female";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();
            
            if (CheckBox1.Checked || CheckBox2.Checked || CheckBox3.Checked || CheckBox4.Checked || CheckBox5.Checked)
            {
                string list = "";
                if (CheckBox1.Checked)
                {
                    list += CheckBox1.Text + "\r\n";
                }
                if (CheckBox2.Checked)
                {
                    list += CheckBox2.Text + "\r\n";
                }
                if (CheckBox3.Checked)
                {
                    list += CheckBox3.Text + "\r\n";
                }
                if (CheckBox4.Checked)
                {
                    list += CheckBox4.Text + "\r\n";
                }
                if (CheckBox5.Checked)
                {
                    list += CheckBox5.Text + "\r\n";
                }
                MySqlCommand SelectCommand2 = new MySqlCommand("INSERT INTO bbs.donor(icnumber,name,gender,medicalhistory) VALUES ('" + TextBox9.Text + "','" + TextBox5.Text + "','" + Label2.Text + "','" + list + "');", myConn);
                MySqlDataReader myReader2;
                myReader2 = SelectCommand2.ExecuteReader();
                myReader2.Read();
                myReader2.Close();
                Response.Write("<script type='text/javascript'>");
                Response.Write("alert('Sorry, you are not allowed to register as blood donor, please contact Pusat Darah Negara for more details !');");
                Response.Write("document.location.href='Login.aspx';");
                Response.Write("</script>");
            }
            else
            {
                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.donor ORDER BY id desc LIMIT 1", myConn);
                MySqlDataReader myReader;
                myReader = SelectCommand.ExecuteReader();
                myReader.Read();
                var id = myReader.GetInt16("id") + 1;
                myReader.Close();
                string id2 = id.ToString();
                DateTime now = DateTime.Now;

                MySqlCommand SelectCommand2 = new MySqlCommand("INSERT INTO bbs.donor(donorid,name,icnumber,gender,dob,address,postcode,location,phoneno,type,dateregister) VALUES ('D" + id + "','" + TextBox5.Text + "','" + TextBox9.Text + "','" + Label2.Text + "','" + txtDate.Text + "','" + TextBox6.Text + "','" + Convert.ToInt32(TextBox7.Text) + "','" + DropDownList2.SelectedValue + "','" + TextBox8.Text + "','" + DropDownList4.Text + "','" + now.ToString() + "');", myConn);
                MySqlDataReader myReader2;
                myReader2 = SelectCommand2.ExecuteReader();
                myReader2.Read();
                myReader2.Close();

                MySqlCommand SelectCommand3 = new MySqlCommand("SELECT * FROM bbs.donor ORDER BY id desc LIMIT 1", myConn);
                MySqlDataReader myReader3;
                myReader3 = SelectCommand3.ExecuteReader();
                myReader3.Read();
                string donorid = myReader3.GetString("donorid");
                myReader3.Close();

                MySqlCommand SelectCommand4 = new MySqlCommand("INSERT INTO bbs.login(parentid,role,password,username) VALUES ('" + donorid + "','2','" + TextBox11.Text + "','" + TextBox10.Text + "');", myConn);
                MySqlDataReader myReader4;
                myReader4 = SelectCommand4.ExecuteReader();
                myReader4.Read();
                myReader4.Close();

                MySqlCommand SelectCommand5 = new MySqlCommand("SELECT * FROM bbs.bloodbank ORDER BY id desc LIMIT 1", myConn);
                MySqlDataReader myReader5;
                myReader5 = SelectCommand5.ExecuteReader();
                myReader5.Read();
                var id3 = myReader5.GetInt16("id") + 1;
                string id4 = id.ToString();
                myReader5.Close();

                MySqlCommand SelectCommand6 = new MySqlCommand("INSERT INTO bbs.bloodbank(bloodid,donorid,type,amount,expireddate) VALUES ('B" + id4 + "','" + donorid + "','" + DropDownList4.Text + "','1','NULL');", myConn);
                MySqlDataReader myReader6;
                myReader6 = SelectCommand6.ExecuteReader();
                myReader6.Read();
                myReader6.Close();

                Response.Write("<script type='text/javascript'>");
                Response.Write("alert('Successfully registered !');");
                Response.Write("document.location.href='Login.aspx';");
                Response.Write("</script>");
            }
       }
            

        protected void Button1_Click(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.hospital ORDER BY id desc LIMIT 1", myConn);
            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            myReader.Read();
            var id = myReader.GetInt16("id") + 1;
            string id2 = id.ToString();
            myReader.Close();
            DateTime now = DateTime.Now;
            MySqlCommand SelectCommand2 = new MySqlCommand("INSERT INTO bbs.hospital(hospitalid,name,address,postcode,location,phoneno,dateregister) VALUES ('H" + id + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DropDownList1.SelectedValue + "','" + TextBox4.Text + "','" + now.ToString() + "');", myConn);
            MySqlDataReader myReader2;
            myReader2 = SelectCommand2.ExecuteReader();
            myReader2.Read();
            myReader2.Close();

            MySqlCommand SelectCommand3 = new MySqlCommand("SELECT * FROM bbs.hospital ORDER BY id desc LIMIT 1", myConn);
            MySqlDataReader myReader3;
            myReader3 = SelectCommand3.ExecuteReader();
            myReader3.Read();
            string hid = myReader3.GetString("hospitalid");
            myReader3.Close();

            MySqlCommand SelectCommand4 = new MySqlCommand("INSERT INTO bbs.login(parentid,role,password,username) VALUES ('" + hid + "','3','" + TextBox13.Text + "','" + TextBox12.Text + "');", myConn);
            MySqlDataReader myReader4;
            myReader4 = SelectCommand4.ExecuteReader();
            myReader4.Read();
            myReader4.Close();

            Response.Write("<script type='text/javascript'>");
            Response.Write("alert('Successfully registered !');");
            Response.Write("document.location.href='Login.aspx';");
            Response.Write("</script>");
        }

        protected void back(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}