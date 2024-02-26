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
    public partial class deduction : Form
    {
        public deduction()
        {
            InitializeComponent();
        }

        private void text_ded_amount_TextChanged(object sender, EventArgs e)
        {
            text_deduction_id.Text = "";
            text_emp_code.Text = "";
            text_ded_name.Text = "";
            text_ded_amount.Text = "";
            text_rec_name.Text = "";
            text_rec_amount.Text = "";
            text_deduction_id.Focus();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into deduction (deduction_id,emp_code,ded_name,ded_amount,rec_name,rec_amount) values   ('" + text_deduction_id.Text + "', '" + text_emp_code.Text + "', '" + text_ded_name.Text + "','" + text_ded_amount.Text + "', '" + text_rec_name.Text + "', '" + text_rec_amount.Text + "')";
          
            MessageBox.Show("record insert");
            con.Close();
            text_deduction_id.Text = "";
            text_emp_code.Text = "";
           text_ded_name.Text = "";
            text_ded_amount.Text = "";
            text_rec_name.Text = "";
            text_rec_amount.Text = "";
            text_deduction_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update deduction set emp_code='" + text_emp_code.Text + "',ded_name='" + text_ded_amount.Text + "',ded_amount = '"+text_ded_amount.Text+"',rec_name='"+text_rec_name.Text+"',rec_amount = '"+text_rec_amount.Text+ "' where deduction_id='" + text_deduction_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();

            text_deduction_id.Text = "";
            text_emp_code.Text = "";
            text_ded_name.Text = "";
            text_ded_amount.Text = "";
            text_rec_name.Text = "";
            text_rec_amount.Text = "";
            text_deduction_id.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from  deduction where deduction_id ='" + text_deduction_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
        }
    }
}
