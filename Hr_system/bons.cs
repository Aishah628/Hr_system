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
    public partial class bons : Form
    {
        public bons()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into bons (bon_id,emp_code,bon_date,bon_amount,name_bon) values   ('" + text_bon_id.Text + "', '" + text_emp_code.Text + "', '" + text_bon_date.Text + "', '" + text_bon_amount.Text + "', '" + text_name_bon.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert" );
            con.Close();
            text_bon_id.Text = "";
            text_emp_code.Text = "";
           text_bon_date.Text = "";
            text_bon_amount.Text = "";
            text_name_bon.Text = "";
            text_bon_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update bons set emp_code='" + text_emp_code.Text + "',bon_date='" + text_bon_date.Text + "',bon_amount='" + text_bon_amount.Text + "',name_bon='" + text_name_bon.Text + "'where bon_id='" + text_bon_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();
            text_bon_id.Text = "";
            text_emp_code.Text = "";
            text_bon_date.Text = "";
            text_bon_amount.Text = "";
            text_name_bon.Text = "";
            text_bon_id.Focus();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from  bons where bon_id ='" + text_bon_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
        }
    }
}
