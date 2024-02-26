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
    public partial class vaction : Form
    {
        public vaction()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into vaction(vact_id,emp_code,vactType_id,startDate,endDate,vac_is_year,approved) values('" + text_vact_id.Text + "', '" + text_emp_code.Text + "', '" + text_vactType_id.Text + "','" + text_start_date.Text + "', '" + text_end_date.Text + "', '" + text_vac_is_year.Text + "','"+text_approved.Text+"')"; 

            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            con.Close();
            text_vact_id.Text = "";
            text_emp_code.Text = "";
            text_vactType_id.Text = "";
            text_start_date.Text = "";
            text_end_date.Text = "";
            text_vac_is_year.Text = "";
            text_approved.Text = "";
            text_vact_id.Focus();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update vaction set emp_code ='" + text_emp_code.Text + "',vactType_id='" + text_vactType_id.Text + "',startDate='" + text_start_date.Text + "',endDate='" + text_end_date.Text + "',vac_is_year ='" + text_vac_is_year.Text + "' where vact_id='" + text_vact_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();
            text_vact_id.Text = "";
            text_emp_code.Text = "";
            text_vactType_id.Text = "";
            text_start_date.Text = "";
            text_end_date.Text = "";
            text_vac_is_year.Text = "";
            text_approved.Text = "";
            text_vact_id.Focus();

        }

        private void delete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from vaction  where vact_id='" + text_vact_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
            text_vact_id.Text = "";
            text_emp_code.Text = "";
            text_vactType_id.Text = "";
            text_start_date.Text = "";
            text_end_date.Text = "";
            text_vac_is_year.Text = "";
            text_approved.Text = "";
            text_vact_id.Focus();
        }
    }
}
