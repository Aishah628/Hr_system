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
    public partial class nationality : Form
    {
        public nationality()
        {
            InitializeComponent();
        }



        private void insert_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ins_nation";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@net_code", text_net_code.Text));
            cmd.Parameters.Add(new SqlParameter("@net_name", text_net_name.Text));
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("record saved");
            con.Close();
            text_net_code.Text = "";
            text_net_name.Text = "";
            text_net_code.Focus();

        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;           
           
            cmd.CommandText = "update Nationality set net_name='" + text_net_name.Text+ "' where net_code= '" + text_net_code.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("update saved");
            con.Close();

            text_net_code.Text = "";
            text_net_name.Text = "";
            text_net_code.Focus();
        }

        private void insert_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(text_net_code.Text))
            {
                SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from nationality where net_code ='" + text_net_code.Text+"'";
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {

                    text_net_code.Text = rdr["net_code"].ToString();
                    text_net_name.Text = rdr["net_name"].ToString();
                 

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

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from  nationality where net_code ='" + text_net_code.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
        }
    }
}
