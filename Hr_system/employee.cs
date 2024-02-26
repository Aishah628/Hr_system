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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void emp_vac_bal_Click(object sender, EventArgs e)
        {

        }

        private void emp_ATMnumber_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into employee (emp_code,first_name,second_name,third_name,last_name,empId_card,email,phone,adderss,brith_date,gender,joinDate,endDate,emp_vac_openBal,emp_vac_bal,emp_ATMnumber,salary,dep_id,cost_id,region_code,job_code,net_code,mer_state,emp_state,TypeOfJob) values('" + text_emp_code.Text + "','" + text_first_name.Text + "','" + text_second_name.Text + "','" + text_third_name.Text + "','" + text_last_name.Text + "','" + text_empId_card.Text + "','" + text_email.Text + "','" + text_phone.Text + "','" + text_address.Text + "','" + text_brith_date.Text + "','" + text_gender.Text + "','" + text_join_date.Text + "','" + text_end_date.Text + "','" + empVac_openBal.Text+ "','" + text_emp_vac_bal.Text + "','" + text_emp_ATMnumber.Text + "','" + text_salary.Text + "','" + text_dep_id.Text + "','" + text_cost_id.Text + "','" + text_regoin_code.Text + "','" + text_job_code.Text + "','" + text_net_code.Text + "','" + text_emp_state_code.Text + "','" + text_mer_state_id.Text + "','" + text_typeOf_job.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("record saved");
            con.Close();
            text_emp_code.Text = "";
            text_first_name.Text = "";
            text_second_name.Text = "";
            text_third_name.Text = "";
            text_last_name.Text = "";
            text_empId_card.Text = "";
            text_email.Text = "";
            text_phone.Text = "";
            text_address.Text = ""; 
            text_brith_date.Text = "";
            text_gender.Text = "";
            text_join_date.Text = "";
            text_end_date.Text = "";
            text_empVac_openBal.Text = "";
            text_emp_vac_bal.Text = "";
            text_emp_ATMnumber.Text = "";
            text_salary.Text = "";
            text_dep_id.Text = "";
            text_cost_id.Text = "";
            text_regoin_code.Text = "";
            text_job_code.Text = "";
            text_net_code.Text = "";
            text_emp_state_code.Text = "";
            text_mer_state_id.Text = "";
            text_typeOf_job.Text = "";
            text_emp_code.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from Employee where emp_code =" + text_emp_code.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("record delete" + text_emp_code.Text);
            con.Close();

            text_emp_code.Text = "";
            text_first_name.Text = "";
            text_second_name.Text = "";
            text_third_name.Text = "";
            text_last_name.Text = "";
            text_gender.Text = "";
            text_email.Text = "";
            text_phone.Text = "";
            text_address.Text = "";
            text_empId_card.Text = "";
            text_brith_date.Text = "";
            text_join_date.Text = "";
            text_end_date.Text = "";
            text_salary.Text = "";
            text_empVac_openBal.Text = "";
            text_emp_vac_bal.Text = "";
            text_emp_ATMnumber.Text = "";
            text_typeOf_job.Text = "";
            text_cost_id.Text = "";
            text_regoin_code.Text = "";
            text_job_code.Text = "";
            text_dep_id.Text = "";
            text_net_code.Text = "";
            text_emp_state_code.Text = "";
            text_mer_state_id.Text = "";
            
            text_emp_code.Focus();
       

        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Employee set first_name= '" + text_first_name.Text + "', second_name = '" + text_second_name.Text + "',third_name= '" + text_third_name.Text + "',last_name= '" + text_last_name.Text + "',empId_card= '" + text_empId_card.Text + "',email= '" + text_email.Text + "',phone= '" + text_phone.Text + "',adderss= '" + text_address.Text + "',brith_date= '" + text_brith_date.Text + "',gender= '" + text_gender.Text + "',joinDate= '" + text_join_date.Text + "' ,endDate= '" + text_end_date.Text + "',emp_vac_openBal= '" + text_empVac_openBal.Text + "',emp_vac_bal= '" + text_emp_vac_bal.Text + "',emp_ATMnumber= '" + text_emp_ATMnumber.Text + "',salary= '" + text_salary.Text + "',dep_id= '" + text_dep_id.Text + "',cost_id= '" + text_cost_id.Text + "',region_code= '" + text_regoin_code.Text + "',job_code= '" + text_job_code.Text + "',net_code= '" + text_net_code.Text + "',emp_state= '" + text_emp_state_code.Text + "',mer_state= '" + text_mer_state_id.Text + "',typeOfJob= '" + text_typeOf_job.Text + "' where emp_code = '" + text_emp_code.Text + "'";
       
            cmd.ExecuteNonQuery();
            MessageBox.Show("record update" + text_emp_code.Text);
            con.Close();

            text_emp_code.Text = "";
            text_first_name.Text = "";
            text_second_name.Text = "";
            text_third_name.Text = "";
            text_last_name.Text = "";
            text_gender.Text = "";
            text_email.Text = "";
            text_phone.Text = "";
            text_address.Text = "";
            text_empId_card.Text = "";
            text_brith_date.Text = "";
            text_join_date.Text = "";
            text_end_date.Text = "";
            text_salary.Text = "";
            text_empVac_openBal.Text = "";
            text_emp_vac_bal.Text = "";
            text_emp_ATMnumber.Text = "";
            text_typeOf_job.Text = "";
            text_cost_id.Text = "";
            text_regoin_code.Text = "";
            text_job_code.Text = "";
            text_dep_id.Text = "";
            text_net_code.Text = "";
            text_emp_state_code.Text = "";
            text_mer_state_id.Text = "";

            text_emp_code.Focus();

        }

        private void text_emp_code_TextChanged(object sender, EventArgs e)
        {
            text_emp_code.Text = "";
            text_first_name.Text = "";
            text_second_name.Text = "";
            text_third_name.Text = "";
            text_last_name.Text = "";
            text_gender.Text = "";
            text_email.Text = "";
            text_phone.Text = "";
            text_address.Text = "";
            text_empId_card.Text = "";
            text_brith_date.Text = "";
            text_join_date.Text = "";
            text_end_date.Text = "";
            text_salary.Text = "";
            text_empVac_openBal.Text = "";
            text_emp_vac_bal.Text = "";
            text_emp_ATMnumber.Text = "";
            text_typeOf_job.Text = "";
            text_cost_id.Text = "";
            text_regoin_code.Text = "";
            text_job_code.Text = "";
            text_dep_id.Text = "";
            text_net_code.Text = "";
            text_emp_state_code.Text = "";
            text_mer_state_id.Text = "";

            text_emp_code.Focus();
        }
      

        private void text_emp_code_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(text_emp_code.Text))
            {
                SqlConnection con = new SqlConnection("Server=.;Database=HR_SystemA;user=Admin1;password=Admin100");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Employee where emp_code =" + text_emp_code.Text;
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {

                    text_first_name.Text = rdr["first_name"].ToString();
                    text_second_name.Text = rdr["second_name"].ToString();
                    text_third_name.Text = rdr["third_name"].ToString();
                    text_last_name.Text = rdr["last_name"].ToString();
                    text_gender.Text = rdr["gender"].ToString();
                    text_email.Text = rdr["email"].ToString();
                    text_phone.Text = rdr["phone"].ToString();
                    text_address.Text = rdr["address"].ToString();
                    text_empId_card.Text = rdr["empId_card"].ToString();
                    text_brith_date.Text = rdr["brith_date"].ToString();
                    text_join_date.Text = rdr["join_date"].ToString();
                    text_end_date.Text = rdr["end_date"].ToString();
                    text_salary.Text = rdr["salary"].ToString();
                    text_empVac_openBal.Text = rdr["empVac_openBal"].ToString();
                    text_emp_vac_bal.Text = rdr["emp_vac_bal"].ToString();
                    text_emp_ATMnumber.Text = rdr["emp_ATMnumber"].ToString();
                    text_typeOf_job.Text = rdr["typyOf_job"].ToString();
                    text_cost_id.Text = rdr["cost_id"].ToString();
                    text_regoin_code.Text = rdr["regoin_code"].ToString();
                    text_job_code.Text = rdr["job_code"].ToString();
                    text_dep_id.Text = rdr["dep_id"].ToString();
                    text_net_code.Text = rdr["net_code"].ToString();
                    text_emp_state_code.Text = rdr["emp_state"].ToString();
                    text_mer_state_id.Text = rdr["mer_state"].ToString();
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
