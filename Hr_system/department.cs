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
    public partial class department : Form
    {
        public department()
        {
            InitializeComponent();
        }

        private void department_Load(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ins_depart";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@dep_id", text_dep_id.Text));
            cmd.Parameters.Add(new SqlParameter("@dep_name", text_dep_name.Text));
            cmd.Parameters.Add(new SqlParameter("@dep_phone", text_dep_phone.Text));
            cmd.Parameters.Add(new SqlParameter("@dep_email", text_dep_email.Text));
            var i = cmd.ExecuteNonQuery();
            MessageBox.Show("record saved");
            con.Close();
            text_dep_id.Text = "";
            text_dep_name.Text = "";
            text_dep_phone.Text = "";
            text_dep_email.Text = "";
            text_dep_id.Focus();

        }

        private void insert_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(text_dep_id.Text))
            {
                SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from department where dep_id =" + text_dep_id.Text;
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {

                    text_dep_id.Text = rdr["dep_id"].ToString();
                    text_dep_name.Text = rdr["dep_name"].ToString();
                    text_dep_phone.Text = rdr["dep_phone"].ToString();
                    text_dep_email.Text = rdr["dep_email"].ToString();

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

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update department set dep_name='" + text_dep_name.Text + "',dep_phone='" + text_dep_phone.Text + "',dep_email='"+text_dep_email.Text+"' where dep_id='" + text_dep_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();
            text_dep_id.Text = "";
            text_dep_name.Text = "";
            text_dep_phone.Text = "";
            text_dep_email.Text = "";
            text_dep_id.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from department  where dep_id='" + text_dep_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
            text_dep_id.Text = "";
            text_dep_name.Text = "";
            text_dep_phone.Text = "";
            text_dep_email.Text = "";
            text_dep_id.Focus();
        }
    }
}
