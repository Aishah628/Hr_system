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
    public partial class over_time : Form
    {
        public over_time()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into over_time (over_time_id,emp_code,over_date,hours_over,over_amount,approved) values   ('" + text_over_id.Text + "', '" + text_emp_code.Text + "','" + text_over_date.Text + "', '" + text_hour_over.Text + "','" + text_over_amount.Text + "', '" + text_approved.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();
            text_over_id.Text = "";
            text_emp_code.Text = "";
            text_over_date.Text = "";
            text_hour_over.Text = "";
            text_over_amount.Text = "";
            text_approved.Text = "";
            text_over_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update over_time set emp_code ='" + text_emp_code.Text + "',over_date='" + text_over_date.Text + "',hours_over='" + text_hour_over.Text + "',over_amount='" + text_over_amount.Text + "' ,approved='"+text_approved.Text+ "'where over_time_id='" + text_over_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();
            text_over_id.Text = "";
            text_emp_code.Text = "";
            text_over_date.Text = "";
            text_hour_over.Text = "";
            text_over_amount.Text = "";
            text_approved.Text = "";
            text_over_id.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from over_time  where over_time_id='" + text_over_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
            text_over_id.Text = "";
            text_emp_code.Text = "";
            text_over_date.Text = "";
            text_hour_over.Text = "";
            text_over_amount.Text = "";
            text_approved.Text = "";
            text_over_id.Focus();
        }
    }
}
