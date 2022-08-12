using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class People : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        if (!IsPostBack)
        {
            Response.Write("<center><h1>CRUD Operations for People Table</h1></center><hr/>");
            Response.Write("<br/>");
            string s = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            string sqlString = "select * from people";
            SqlCommand cmd = new SqlCommand(sqlString, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();

            string sqlStringDropDownList = "select Name from people";
            SqlCommand cmd2 = new SqlCommand(sqlStringDropDownList, con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read() == true
            )
            {
                DropDownList1.Items.Add(new ListItem(dr2["Name"].ToString(),
                dr2["Name"].ToString()));


                DropDownList2.Items.Add(new ListItem(dr2["Name"].ToString(),
                dr2["Name"].ToString()));

            }
            dr2.Close();
            con.Close();

        }
    }
   /* protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<center><h1>Read data from a database </ h1 ></ center >< hr /> ");
        Response.Write("<br/>");
        String txtValue = TextBox1.Text;
        string s = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
        SqlConnection con = new SqlConnection(s);
        string sqlString = "select * from people where Name=@Name";
        SqlCommand cmd = new SqlCommand(sqlString, con);
        //to prevent sql injection
        cmd.Parameters.AddWithValue("@Name", txtValue);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        dr.Close();
        con.Close();
    }
   */

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {


        if (IsPostBack)
        {
            Response.Write("<br/>");
            String txtValue = DropDownList1.SelectedValue.ToString();
            string s = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            string sqlString = "select * from people where Name=@Name";
            SqlCommand cmd = new SqlCommand(sqlString, con);
            cmd.Parameters.AddWithValue("@Name", txtValue);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            con.Close();
        }
    }
    protected void UpdatePerson(object sender, EventArgs e)
    {
        Response.Write("<br/>");
        String txtValue = DropDownList2.SelectedValue.ToString();
        String nameValue = NameBox0.Text;
        int ageValue = Convert.ToInt32(AgeBox0.Text);
        string s = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
        SqlConnection con = new SqlConnection(s);
        string sqlString = "update people set Name = @newName, Age = @newAge where Name=@Name, Age=@Age";
        SqlCommand cmd = new SqlCommand(sqlString, con);
        cmd.Parameters.AddWithValue("@Name", txtValue);
        cmd.Parameters.AddWithValue("@Age", txtValue);
        cmd.Parameters.AddWithValue("@newName", NameBox0.Text);
        cmd.Parameters.AddWithValue("@newAge", AgeBox0.Text);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        dr.Close();
        con.Close();
    }
    protected void CreatePerson(object sender, EventArgs e)
    {
        String nameValue = NameBox.Text.ToString();
        int ageValue = Convert.ToInt32(AgeBox.Text);
        string s = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
        SqlConnection con = new SqlConnection(s);
        string sqlString = "insert into people (Name, Age) VALUES (@Name, @Age)";
        SqlCommand cmd = new SqlCommand(sqlString, con);
        cmd.Parameters.AddWithValue("@Name", nameValue);
        cmd.Parameters.AddWithValue("@Age", ageValue);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        dr.Close();
        con.Close();
    }

    protected void DeletePerson(object sender, EventArgs e)
    {
        String nameValue = DropDownList1.SelectedValue.ToString();
        int ageValue = Convert.ToInt32(AgeBox.Text);
        string s = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
        SqlConnection con = new SqlConnection(s);
        string sqlString = "delete from people  where (@Name)";
        SqlCommand cmd = new SqlCommand(sqlString, con);
        cmd.Parameters.AddWithValue("@Name", nameValue);
        cmd.Parameters.AddWithValue("@Age", ageValue);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
        dr.Close();
        con.Close();
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            Response.Write("<br/>");
            String txtValue = DropDownList2.SelectedValue.ToString();
            String nameValue = NameBox0.Text;
            int ageValue = Convert.ToInt32(AgeBox0.Text);
            string s = ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            string sqlString = "update people set Name = @ where Name=@Name, Age=@Age";
            SqlCommand cmd = new SqlCommand(sqlString, con);
            cmd.Parameters.AddWithValue("@Name", txtValue);
            cmd.Parameters.AddWithValue("@Age", txtValue);
            cmd.Parameters.AddWithValue("@newName", NameBox0.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            con.Close();
        }
    }


}



