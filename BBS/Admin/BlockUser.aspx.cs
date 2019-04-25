using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace BBS.Admin
{
    public partial class Block_User : System.Web.UI.Page
    {
        public string blooddata;
        int count = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=mohd92";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            myConn.Open();

            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM bbs.donor WHERE donorid='Block';", myConn);
            MySqlDataReader myReader;
            myReader = SelectCommand.ExecuteReader();
            while (myReader.Read())
            {
                blooddata = blooddata + @"<TR>";
                blooddata = blooddata + @"<TD>" + count + @"</TD>";
                blooddata = blooddata + @"<TD>" + myReader.GetString("name") + @"</TD>";
                blooddata = blooddata + @"<TD>" + myReader.GetString("icnumber") + @"</TD>";
                blooddata = blooddata + @"<TD>" + myReader.GetString("gender") + @"</TD>";
                blooddata = blooddata + @"<TD>" + myReader.GetString("medicalhistory") + @"</TD>";
                blooddata = blooddata + @"<TD style='color:Red;font-weight:bold;'>BLOCK</TD>";
                blooddata = blooddata + @"</TD>";
                blooddata = blooddata + @"</TR>";
                count++;
            }
        }
    }
}