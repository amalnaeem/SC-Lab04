using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.OleDb;
using System.Windows.Forms;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fname = TextBox1.Text;
            string lname = TextBox2.Text;
            string pass = TextBox6.Text;
            string city = TextBox3.Text;
            string province = TextBox4.Text;
            string type = "User";
            string country = TextBox5.Text;

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\OK\Documents\Database2.accdb";
            conn.Open();

            String sql = "insert into Users ([FirstName], [LastName], [City], [Province],[Country],[Type],[Password]) values ('" + fname + "','" + lname + "','" + city + "','" + province+ "','"+ country + "','"+type+"','"+pass+"')";
            System.Data.OleDb.OleDbCommand cmd1 = new System.Data.OleDb.OleDbCommand(sql, conn);

            var dr1 = cmd1.ExecuteNonQuery();

            MessageBox.Show("Successfully Entered Data");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm2.aspx");
        }
    }
}