using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hr_system
{
    public partial class Cost_center : Form
    {
        public Cost_center()
        {
            InitializeComponent();
        }

        private void Cost_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into cost_center (cost_id,cost_center_name ,dep_id) values   ('" + text_cost_id.Text + "', '" + text_cost_center_name.Text + "', '" + text_dep_id.Text + "')";
            MessageBox.Show("record insert",cmd.CommandText);
            con.Close();
            text_cost_id.Text = "";
            text_cost_center_name.Text = "";
            text_dep_id.Text = "";
            text_cost_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update cost_center set cost_center_name='" + text_cost_center_name.Text + "',dep_id='" + text_dep_id.Text + "' where cost_id='" + text_cost_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();
            text_cost_id.Text = "";
            text_cost_center_name.Text = "";
            text_dep_id.Text = "";
            text_cost_id.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from cost_center where cost_id ='" + text_cost_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
            text_cost_id.Text = "";
            text_cost_center_name.Text = "";
            text_dep_id.Text = "";
            text_cost_id.Focus();
        }
    }
}
