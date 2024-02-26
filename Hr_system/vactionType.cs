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
    public partial class vactionType : Form
    {
        public vactionType()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into vactionType (vactType_id,vac_name,gender,vac_dayFactory,year_rest) values ('" + text_vactType_id.Text + "','" + text_vac_name.Text + "','" + text_gender.Text + "','" + text_fact_dayFactroy.Text + "','" + text_year_rest.Text + "')";


            cmd.ExecuteNonQuery();
            MessageBox.Show("record insert");
            
            con.Close();
            text_vactType_id.Text = "";
            text_vac_name.Text = "";
            text_gender.Text = "";
            text_fact_dayFactroy.Text = "";
            text_year_rest.Text = "";
            text_vactType_id.Focus();

        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update vactionType set vac_name ='" + text_vac_name.Text + "',gender='" + text_gender.Text + "',vac_dayFactory='" + text_fact_dayFactroy.Text + "',year_rest='" + text_year_rest.Text + "' where vactType_id='" + text_vactType_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update");
            con.Close();
            text_vactType_id.Text = "";
            text_vac_name.Text = "";
            text_gender.Text = "";
            text_fact_dayFactroy.Text = "";
            text_year_rest.Text = "";
            text_vactType_id.Focus();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from vactionType  where vactType_id='" + text_vactType_id.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete");
            con.Close();
            text_vactType_id.Text = "";
            text_vac_name.Text = "";
            text_gender.Text = "";
            text_fact_dayFactroy.Text = "";
            text_year_rest.Text = "";
            text_vactType_id.Focus();
        }
    }
}
