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

        private bool isControlIsDataValid() 
        {
            // EmployeeID Validation
            if (Convert.ToInt32(txtEmployeeID.Text.Length) < 1)
            {
                MessageBox.Show("Please, Enter Employee ID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            } else
            {
                txtEmployeeID.BackColor = Color.White;
            }

            // First Name Validation
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please, Enter First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                txtFirstName.BackColor = Color.Silver;
                return false;
            } else
            {
                txtFirstName.BackColor = Color.White;
            }

            // Last Name Validation
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please, Enter Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                return false;
            } else
            {
                txtLastName.BackColor = Color.Silver;
            }

            // Gender Validation
            if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                MessageBox.Show("Please, Checked Male or Female", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBoxGender.Focus();
                radioButtonMale.BackColor = Color.Silver;
                radioButtonFemale.BackColor = Color.Silver;
                return false;
            } else
            {
                radioButtonMale.BackColor = Color.CornflowerBlue;
                radioButtonFemale.BackColor = Color.CornflowerBlue;
            }

            // National Insurance Validation
            if (txtNationalInsuranceNo.Text == "")
            {
                MessageBox.Show("Please, Enter National Insurance Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalInsuranceNo.Focus();
                txtNationalInsuranceNo.BackColor = Color.Silver;
                return false;
            } else
            {
                txtNationalInsuranceNo.BackColor = Color.White;
            }
            // Marital Status Validation
            if (radioButtonMarried.Checked == false && radioButtonSingle.Checked == false)
            {
                groupBoxMaritalStatus.Focus();
                radioButtonMarried.BackColor = Color.CornflowerBlue;
                radioButtonSingle.BackColor = Color.CornflowerBlue;
                return false;
            } else
            {
                radioButtonMarried.BackColor = Color.White;
                radioButtonSingle.BackColor = Color.White;
            }

            // Address Validation
            if (textBoxAddress.Text == "")
            {
                MessageBox.Show("Please, Enter Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                textBoxAddress.BackColor = Color.Silver;
                return false;
            } else
            {
                textBoxAddress.BackColor = Color.White;
            }

            // City Validation
            if (textBoxCity.Text == "")
            {
                MessageBox.Show("Please, Enter City Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCity.Focus();
                textBoxCity.BackColor = Color.Silver;
                return false;
            }
            else
            {
                textBoxCity.BackColor = Color.White;
            }

            // Postal Code Validation
            if (textBoxPostalCode.Text == "")
            {
                MessageBox.Show("Please, Enter Postal Code", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPostalCode.Focus();
                textBoxPostalCode.BackColor = Color.Silver;
                return false;
            }
            else
            {
                textBoxPostalCode.BackColor = Color.White;
            }

            // Country Validation
            if (comboBoxCountry.SelectedIndex == 0 || comboBoxCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please, Select a Country from the list", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCountry.Focus();
                comboBoxCountry.BackColor = Color.Silver;
                return false;
            }
            else
            {
                comboBoxCountry.BackColor = Color.White;
            }

            // Contact Number Validation
            if (textBoxContactNumber.Text == "")
            {
                MessageBox.Show("Please, Enter Contact Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContactNumber.Focus();
                textBoxContactNumber.BackColor = Color.Silver;
                return false;
            }
            else
            {
                textBoxContactNumber.BackColor = Color.White;
            }

            // Email Validation
            if (textBoxEmailAddress.Text == "")
            {
                MessageBox.Show("Please, Enter email address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmailAddress.Focus();
                textBoxEmailAddress.BackColor = Color.Silver;
                return false;
            }
            else
            {
                textBoxEmailAddress.BackColor = Color.White;
            }

            // Notes Validation
            if (textBoxNotes.Text.Length > 30)
            {
                MessageBox.Show("Too much text! Please, enter fewer text", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNotes.Focus();
                textBoxNotes.BackColor = Color.Silver;
                return false;
            } else
            {
                textBoxNotes.BackColor = Color.White;

            }

            return true;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            if (isControlIsDataValid()) // To check if the form is already filled.
            {
                MessageBox.Show("Employee Added!");
            }
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

        #region Keypress Event Validation
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
        #endregion
    }
}
