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
    public partial class regoin : Form
    {
        public regoin()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into region(region_code,region_name) values   ('" + text_regoin_code.Text + "', '" + text_regoin_name.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();

            text_regoin_code.Text = "";
            text_regoin_name.Text = "";

            text_regoin_code.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update region set region_name='" + text_regoin_name.Text + "' where  region_code= '" + text_regoin_code.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("update saved");
            con.Close();

            text_regoin_code.Text = "";
            text_regoin_name.Text = "";

            text_regoin_code.Focus();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from  region where region_code ='" + text_regoin_code.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
        }
    }
}
