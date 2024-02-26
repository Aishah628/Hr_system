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
    public partial class mer_state : Form
    {
        public mer_state()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Mer_state (mer_stateId,mer_stateName) values   ('" + text_mer_state_id.Text + "', '" + text_mer_state_name.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();
            text_mer_state_id.Text = "";
            text_mer_state_name.Text = "";
            
           text_mer_state_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update mer_state set mer_stateName='" + text_mer_state_name.Text + "' where mer_stateId= '" + text_mer_state_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("update saved");
            con.Close();
            text_mer_state_id.Text = "";
            text_mer_state_name.Text = "";

            text_mer_state_id.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from mer_state  where mer_stateId= '" + text_mer_state_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete saved");
            con.Close();
            text_mer_state_id.Text = "";
            text_mer_state_name.Text = "";

            text_mer_state_id.Focus();
        }
    }
}
