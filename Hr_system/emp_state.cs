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
    public partial class emp_state : Form
    {
        public emp_state()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into emp_state (emp_stateId,emp_stateName) values   ('" + text_emp_state_id.Text + "', '" + text_emp_state_name.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();
            text_emp_state_id.Text = "";
            text_emp_state_name.Text = "";
            
           text_emp_state_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update emp_state set emp_stateName='" + text_emp_state_name.Text + "' where emp_stateId='" + text_emp_state_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();
            text_emp_state_id.Text = "";
            text_emp_state_name.Text = "";

            text_emp_state_id.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from  emp_state where emp_stateId='" + text_emp_state_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
        }
    }
}
