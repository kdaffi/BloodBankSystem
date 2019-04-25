using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS
{
    public partial class Login : System.Web.UI.Page
    {
        public string value;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showpwd_Click(object sender, EventArgs e)
        {
            value = txtPassword.Text;
            txtPassword.Attributes.Add("value", value);
            txtPassword.TextMode = TextBoxMode.SingleLine;
            Button1.Visible = true;
            ImageButton1.Visible = false;
        }

        protected void showpwd2_Click(object sender, EventArgs e)
        {
            value = txtPassword.Text;
            txtPassword.Attributes.Add("value", value);
            txtPassword.TextMode = TextBoxMode.Password;
            Button1.Visible = false;
            ImageButton1.Visible = true;
        }

        protected void loginclick(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92;pooling='true'";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.login a WHERE a.username='" + txtUsername.Text + "' AND a.password='" + txtPassword.Text + "';", myConn); 
                MySqlDataReader myReader;

                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

                int count = 0;
                while (myReader.Read())
                {
                    count += 1;
                }
               
                if (count == 1)
                {
                    if (myReader.GetInt16("role") == 1)
                    {
                        Session["id"] = myReader.GetString("parentid");
                        Response.Redirect("Admin/Home.aspx");
                    }
                    else if (myReader.GetInt16("role") == 2)
                    {
                        Session["id"] = myReader.GetString("parentid");
                        Response.Redirect("Donor/Home.aspx");
                    }
                    else if (myReader.GetInt16("role") == 3)
                    {
                        Session["id"] = myReader.GetString("parentid");
                        Response.Redirect("Hospital/Home.aspx");
                    }
                   
                }
                else if (count > 1)
                {
                    //duplicate
                    lblMessage.Text = "Duplicate Username or Password";
                }

                else
                {
                    lblMessage.Text = "Wrong Username or Password";
                }
            }

            catch (Exception ex)
            {
                lblMessage.Text = (ex.Message);
            }
        }
    }
}