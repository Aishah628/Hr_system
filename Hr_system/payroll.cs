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
    public partial class payroll : Form
    {
        public payroll()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            text_emp_code.Text = "";
            text_pay_month.Text = "";
            text_pay_year.Text = "";
            text_emp_salary.Text = "";
            text_dep_code.Text = "";
            text_overtime_amount.Text = "";
            text_bons_amount.Text = "";
            text_exp_amount.Text = "";
            text_loan_amount.Text = "";
            text_ded_amount.Text = "";
            text_rec_amount.Text = "";
            text_pay_date.Text = "";
            text_tax_amount.Text = "";
            text_income_tax.Text = "";
            text_net_pay.Text = "";

            text_emp_code.Focus();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into payroll (emp_code,pay_month,pay_year,emp_salary,dep_code,overtime_amount,bons_amount,exp_amount,loan_amount,ded_amount,rec_amount,pay_date,tax_amount,income_tax,net_pay) values   ('" + text_emp_code.Text + "', '" + text_pay_month.Text + "','" + text_pay_year.Text + "', '" + text_emp_salary.Text + "','" + text_dep_code.Text + "', '" + text_overtime_amount.Text + "', '" + text_bons_amount.Text + "','" + text_exp_amount.Text + "', '" + text_loan_amount.Text + "','" + text_ded_amount.Text + "', '" + text_rec_amount.Text + "','" + text_pay_date.Text + "', '" + text_tax_amount.Text + "','" + text_income_tax.Text + "','"+text_net_pay.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();
            text_emp_code.Text = "";
            text_pay_month.Text = "";
            text_pay_year.Text = "";
            text_emp_salary.Text = "";
            text_dep_code.Text = "";
            text_overtime_amount.Text = "";
           text_bons_amount.Text = "";
            text_exp_amount.Text = "";
            text_loan_amount.Text = "";
            text_ded_amount.Text = "";
            text_rec_amount.Text = "";
            text_pay_date.Text = "";
            text_tax_amount.Text = "";
            text_income_tax.Text = "";
            text_net_pay.Text = "";

            text_emp_code.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update payroll set emp_salary ='" + text_emp_salary.Text + "',dep_code='" + text_dep_code.Text + "',overtime_amount='" + text_overtime_amount.Text + "',bons_amount='" + text_bons_amount.Text + "',bons_amount ='" + text_bons_amount.Text + "',exp_amount ='" + text_exp_amount.Text + "', loan_amount='" + text_loan_amount.Text + "',ded_amount='" + text_ded_amount.Text + "',rec_amount ='" + text_rec_amount.Text + "',pay_date ='" + text_pay_date.Text + "',tax_amount ='" + text_tax_amount.Text + "',income_tax ='" + text_income_tax.Text + "',net_pay ='" + text_net_pay.Text + "'where emp_code='" + text_emp_code.Text + "',pay_month='" + text_pay_month.Text + "',pay_year='" + text_pay_year.Text + "'";          
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();
            text_emp_code.Text = "";
            text_pay_month.Text = "";
            text_pay_year.Text = "";
            text_emp_salary.Text = "";
            text_dep_code.Text = "";
            text_overtime_amount.Text = "";
            text_bons_amount.Text = "";
            text_exp_amount.Text = "";
            text_loan_amount.Text = "";
            text_ded_amount.Text = "";
            text_rec_amount.Text = "";
            text_pay_date.Text = "";
            text_tax_amount.Text = "";
            text_income_tax.Text = "";
            text_net_pay.Text = "";

            text_emp_code.Focus();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from payroll  where emp_code='" + text_emp_code.Text + "',pay_month='" + text_pay_month.Text + "',pay_year='" + text_pay_year.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
            text_emp_code.Text = "";
            text_pay_month.Text = "";
            text_pay_year.Text = "";
            text_emp_salary.Text = "";
            text_dep_code.Text = "";
            text_overtime_amount.Text = "";
            text_bons_amount.Text = "";
            text_exp_amount.Text = "";
            text_loan_amount.Text = "";
            text_ded_amount.Text = "";
            text_rec_amount.Text = "";
            text_pay_date.Text = "";
            text_tax_amount.Text = "";
            text_income_tax.Text = "";
            text_net_pay.Text = "";

            text_emp_code.Focus();
        }
    }
}
