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
    public partial class expense : Form
    {
        public expense()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Expense (exp_id,emp_code,exp_code,exp_date,exp_amount,approved) values   ('" + text_exp_id.Text + "', '" + text_emp_code.Text + "','" + text_exp_code.Text + "', '" + text_exp_date.Text + "','" + text_exp_amount.Text + "', '" + text_approved.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();
            text_exp_id.Text = "";
            text_emp_code.Text = "";
            text_exp_code.Text = "";
            text_exp_date.Text = "";
            text_exp_amount.Text = "";
            text_approved.Text = "";
           text_exp_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update Expense set emp_code='" + text_emp_code.Text + "',exp_code='" + text_exp_code.Text + "', exp_date='" + text_exp_date.Text + "',exp_amount='" + text_exp_amount.Text + "', approved='" + text_approved.Text + "'where exp_id ='" + text_exp_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("update saved");
            con.Close();
            text_exp_id.Text = "";
            text_emp_code.Text = "";
            text_exp_code.Text = "";
            text_exp_date.Text = "";
            text_exp_amount.Text = "";
            text_approved.Text = "";
            text_exp_id.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from  Expense where exp_id ='" + text_exp_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
            text_exp_id.Text = "";
            text_emp_code.Text = "";
            text_exp_code.Text = "";
            text_exp_date.Text = "";
            text_exp_amount.Text = "";
            text_approved.Text = "";
            text_exp_id.Focus();
        }
    }
}
