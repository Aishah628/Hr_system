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
    public partial class loan : Form
    {
        public loan()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into loan (loan_id,emp_code,loan_amount,loan_Dates,loan_balance,loan_initalAmount) values   ('" + text_loan_id.Text + "', '" + text_emp_code.Text + "', '" + text_loan_amount.Text + "','" + text_loan_date.Text + "', '" + text_loan_balance.Text + "', '" + text_loan_initalAmount.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();
           text_loan_id.Text = "";
            text_emp_code.Text = "";
            text_loan_amount.Text = "";
            text_loan_date.Text = "";
            text_loan_balance.Text = "";
            text_loan_initalAmount.Text = "";
            text_loan_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update loan set emp_code='" + text_emp_code.Text + "',loan_amount='" + text_loan_amount.Text + "',loan_Dates='" + text_loan_date.Text + "',loan_balance='" + text_loan_balance.Text + "' ,loan_initalAmount='" + text_loan_initalAmount.Text + "'where loan_id= '" + text_loan_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("update saved");
            con.Close();
            text_loan_id.Text = "";
            text_emp_code.Text = "";
            text_loan_amount.Text = "";
            text_loan_date.Text = "";
            text_loan_balance.Text = "";
            text_loan_initalAmount.Text = "";
            text_loan_id.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from loan  where loan_id= '" + text_loan_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete saved");
            con.Close();
            text_loan_id.Text = "";
            text_emp_code.Text = "";
            text_loan_amount.Text = "";
            text_loan_date.Text = "";
            text_loan_balance.Text = "";
            text_loan_initalAmount.Text = "";
            text_loan_id.Focus();
        }
    }
    }

