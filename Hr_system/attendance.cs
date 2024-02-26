using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hr_system
{
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void attendance_Load(object sender, EventArgs e)
        {
            
        }

        private void insert_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ins_attend";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@attendance_id", text_attendance_id.Text));
            cmd.Parameters.Add(new SqlParameter("@emp_code", text_emp_code.Text));
            cmd.Parameters.Add(new SqlParameter("@att_dateTime", text_att_dateTime.Text));
            cmd.Parameters.Add(new SqlParameter("@in_out", text_in_out.Text));
            cmd.Parameters.Add(new SqlParameter("@machine", text_machine.Text));
            cmd.Parameters.Add(new SqlParameter("@verify", text_verify.Text));
            cmd.Parameters.Add(new SqlParameter("@dateUpdate", text_dateUpdate.Text));

            cmd.Parameters.Add(new SqlParameter("@approved", text_approved.Text));
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("record saved");
            con.Close();
            text_attendance_id.Text = "";
           text_emp_code.Text = "";
            text_att_dateTime.Text = "";
            text_in_out.Text = "";
            text_machine.Text = "";
            text_verify.Text = "";
            text_dateUpdate.Text = "";
            text_approved.Text = "";
            text_attendance_id.Focus();

        }

        private void insert_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(attendance_id.Text))
            {
                SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from attendance where attendance_id =" + text_attendance_id.Text;
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {

                    text_attendance_id.Text = rdr["attendance_id"].ToString();
                    text_emp_code.Text = rdr["emp_code"].ToString();
                    text_att_dateTime.Text =rdr["att_dateTime"].ToString();
                    text_in_out.Text = rdr["in_out"].ToString();
                    text_machine.Text = rdr["machine"].ToString();
                    text_verify.Text = rdr["verify"].ToString();
                    text_dateUpdate.Text =rdr ["dateUpdate"].ToString();
                    text_approved.Text = rdr["approved"].ToString();

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

        private void delete_Click_1(object sender, EventArgs e)
        {
          
                SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from attendance where attendance_id= '"+text_attendance_id.Text+"'";
                MessageBox.Show("record delete");
                con.Close();
             
                text_attendance_id.Focus();
            }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update attendance set emp_code='" + text_emp_code.Text + "',att_dateTime='"+att_dateTime.Text+"',in_out='"+text_in_out.Text+ "',machine = '"+text_machine.Text+ "', verify='" + text_verify.Text+"',dateUpdate ='"+text_dateUpdate.Text+"',approved = '"+text_approved.Text+"'  where attendance_id= '" + text_attendance_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("update saved");
            con.Close();
            text_attendance_id.Text = "";
            text_emp_code.Text = "";
            text_att_dateTime.Text = "";
            text_in_out.Text = "";
            text_machine.Text = "";
            text_verify.Text = "";
            text_dateUpdate.Text = "";
            text_approved.Text = "";
            text_attendance_id.Focus();
        }
    }
}
