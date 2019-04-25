using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITSP.Models;
using PetaPoco;
using MSXML2;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ITSP
{
    
    public partial class Login : System.Web.UI.Page
    {
        ITSPConnectionStringDB db = new ITSPConnectionStringDB();
        string formID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Login"] == "2")
                {
                    lblMessage.Text = "Session time out";
                }
                else if (Request.QueryString["Login"] == "9")
                {
                    lblMessage.Text = "Access Denied !!";
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            XMLHTTP40 http = new XMLHTTP40();

            http.open("POST", "http://iam.lottechem.com/CSR/ADAuthWebService.asmx/ADAuth", false);
            http.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            http.send("cn=" + txtUsername.Text.Trim() + "&pwd=" + txtPassword.Text.Trim());
            string value = http.responseText;
            //Response.Write(value.ToString());

            if (value.IndexOf(">T<") > 0)
            {
                //Response.Redirect("Default.aspx");

                if (AdminCheck.Checked)
                {
                    AdminLogin(txtUsername.Text.Trim());
                }
                else
                {
                    UserLogin(txtUsername.Text.Trim());
                }
                
                
            }
            else
            {
                if (value.IndexOf(">N<") > 0)
                {
                    lblMessage.Text = "Not a valid user.";
                }
                else if (value.IndexOf(">F<") > 0)
                {

                    //login system without pass
                    lblMessage.Text = "Password incorrect. Please try again.";

                }
                else
                {
                    lblMessage.Text = "Problem authetication to AD. Please check with ITS.";
                }
                //Response.Redirect("NotRegister.aspx");
            }
        }


        private void AdminLogin(string userID)
        {

            var Result = db.SingleOrDefault<ClsUser>("SELECT * FROM Users WHERE UserID=@0", userID);

            if (Result != null)
            {
                Session["ITSP"] = true;
                Session["UserID"] = Result.UserID;
                Session["Name"] = Result.Name;
                Session["Dept"] = Result.Dept_ID;
                Session["Roles"] = Result.Role;
                Session["Email"] = Result.Email;

                Response.Redirect("Admin/WebForm.aspx");
            }
            else
            {
                Session["ITSP"] = false;
                Session["UserID"] = "";
                Session["Name"] = "";
                Session["Dept"] = "";
                Session["Roles"] = "";
                Session["Email"] = "";

                lblMessage.Text = "You don't have Administrator access !!";
            }

        }

        private void UserLogin(string userID)
        {

            SqlConnection IAMConn = new SqlConnection(ConfigurationManager.ConnectionStrings["IAMConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("Select personid,name,email, orgcode From VIEW_LEGACY_USER Where companycode IN ('TPM', 'TTC', 'TTS') AND  personid = '" + userID + "' ", IAMConn);
            IAMConn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Session["ITSP"] = true;
                Session["UserID"] = dr["personid"].ToString();
                Session["Name"] = dr["name"].ToString();
                Session["Dept"] = dr["orgcode"].ToString();
                Session["Roles"] = "0";
                Session["Email"] = dr["email"].ToString();
                Response.Redirect("Default.aspx");
            }
            else
            {
                Session["ITSP"] = false;
                Session["UserID"] = "";
                Session["Name"] = "";
                Session["Dept"] = "";
                Session["Roles"] = "";
                Session["Email"] = "";

                lblMessage.Text = "Access Denied !!";
            }
            IAMConn.Close();
             

        }

    }
}