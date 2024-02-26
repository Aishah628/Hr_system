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
    public partial class job : Form
    {
        public job()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into job(job_code,job_name) values   ('" + text_job_code.Text + "', '" + text_job_name.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();
           
            text_job_code.Text = "";
           text_job_name.Text = "";
           
            text_job_code.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update job set job_name='" + text_job_name.Text + "' where job_code= '" + text_job_code.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("update saved");
            con.Close();

            text_job_code.Text = "";
            text_job_name.Text = "";
            text_job_code.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from  job where job_code ='" + text_job_code.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
            text_job_code.Text = "";
            text_job_name.Text = "";
            text_job_code.Focus();
        }

        private void text_job_code_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(text_job_code.Text))
            {
                SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from job where job_code ='" + text_job_code.Text + "'";
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {

                    text_job_code.Text = rdr["job_code"].ToString();
                    text_job_name.Text = rdr["job_name"].ToString();


                    insert.Enabled = false;
                    delete.Enabled = true;
                    update.Enabled = true;


                }
                else
                {
                    insert.Enabled = true;
                    delete.Enabled = false;
                    update.Enabled = false;

                }

            }
        }
    }
}
