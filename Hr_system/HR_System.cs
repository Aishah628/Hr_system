using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hr_system
{
    public partial class HR_System : Form
    {
        public HR_System()
        {
            InitializeComponent();
        }

     
  

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            employee f = new employee();
            f.ShowDialog();
        }

        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           department f = new department();
            f.ShowDialog();
        }

        private void nationalityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nationality f = new nationality();
            f.ShowDialog();
        }

        private void merstateToolStripMenuItem1_Click(object sender, EventArgs e)
        {vactionType f = new vactionType();
            f.ShowDialog();
        }

        private void exptypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           exp_type f = new exp_type();
            f.ShowDialog();
        }

        private void jobToolStripMenuItem1_Click(object sender, EventArgs e)
        {job f = new job();
            f.ShowDialog();
        }

        private void costcenterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Cost_center f = new Cost_center();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void loanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loan f = new loan();
            f.ShowDialog();
        }

        private void payrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          payroll f = new payroll();
            f.ShowDialog();
        }

        private void attToolStripMenuItem_Click(object sender, EventArgs e)
        {
           attendance f = new attendance();
            f.ShowDialog();
        }

        private void bonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bons f = new bons();
            f.ShowDialog();
        }

        private void expenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           expense f = new expense();
            f.ShowDialog();
        }

        private void vactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           vaction f = new vaction();
            f.ShowDialog();
        }

        private void overtimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            over_time f = new over_time();
            f.ShowDialog();
        }

        private void merstateToolStripMenuItem_Click(object sender, EventArgs e)
        {
           mer_state f = new mer_state();
            f.ShowDialog();
        }

        private void empstateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emp_state f = new emp_state();
            f.ShowDialog();
        }

        private void regoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
           regoin f = new regoin();
            f.ShowDialog();
        }

        private void deductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deduction f = new deduction();
            f.ShowDialog();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           loan f = new loan();
            f.ShowDialog();
        }

        private void overtimeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           over_time f = new over_time();
            f.ShowDialog();
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
          expense f = new expense();
            f.ShowDialog();
        }

        private void vactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           vaction f = new vaction();
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HR_System f = new HR_System();
            f.Close();
        }
    }
}
