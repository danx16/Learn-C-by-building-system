using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollApplication
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Added!");
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Updated");
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Deleted");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Control Reset");
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reset");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Set the EmployeeID to number and backspace only
        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsNumberOrBackspace;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackspace = true;
            } else
            {
                e.Handled = true;
            }
        }

        private void textBoxContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsNumberOrBackspace;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                IsNumberOrBackspace = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
