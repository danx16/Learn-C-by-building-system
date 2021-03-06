﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Regular Expression is a pattern that could be matched against an input text
using System.Net.Mail; //using System.Net.Mail.MailAddress;
using System.Configuration; 
using System.Data.SqlClient;

namespace PayrollApplication
{
    public partial class frmEmployee : Form
    {
        string gender;
        string maritalStatus;
        bool isMember;

        public frmEmployee()
        {
            InitializeComponent();
        }

        // User Input Validation
        private bool isControlIsDataValid() 
        {
            // Regular Expression Validation
            Regex objEmployeeID = new Regex("^[0-9]{3,4}$");
            Regex objFirstName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objLastName = new Regex("^[A-Z][a-zA-Z]*$");
            Regex objNI = new Regex(@"^[A-CEGHJ-PR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[A-D\s]$");
            Regex objEmailAddress = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"); // Sample20@gmail.com

            #region // EmployeeID Validation
            if (Convert.ToInt32(txtEmployeeID.Text.Length) < 1)
            {
                MessageBox.Show("Please, Enter Employee ID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            } else if (!objEmployeeID.IsMatch(txtEmployeeID.Text))  // Regular Expression Validation Applied
            {
                MessageBox.Show("Please, Enter a Valid Employee ID", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmployeeID.Focus();
                txtEmployeeID.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txtEmployeeID.BackColor = Color.White;
            }
            #endregion

            #region // First Name Validation
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please, Enter First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                txtFirstName.BackColor = Color.Silver;
                return false;
            } else if (!objFirstName.IsMatch(txtFirstName.Text))
            {
                MessageBox.Show("Please, Enter a Valid First Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                txtFirstName.BackColor = Color.Silver;
                return false;
            } 
            
            else
            {
                txtFirstName.BackColor = Color.White;
            }
            #endregion

            #region // Last Name Validation
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Please, Enter Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                return false;
            } else if (!objLastName.IsMatch(txtLastName.Text))
            {
                MessageBox.Show("Please, a valid Enter Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                txtLastName.BackColor = Color.Silver;
                return false;
            }
            
            else
            {
                txtLastName.BackColor = Color.Silver;
            }
            #endregion

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

            #region // National Insurance Validation
            if (txtNationalInsuranceNo.Text == "")
            {
                MessageBox.Show("Please, Enter National Insurance Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalInsuranceNo.Focus();
                txtNationalInsuranceNo.BackColor = Color.Silver;
                return false;
            } else if (!objNI.IsMatch(txtNationalInsuranceNo.Text))
            {
                MessageBox.Show("Please, a valid Enter National Insurance Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNationalInsuranceNo.Focus();
                txtNationalInsuranceNo.BackColor = Color.Silver;
                return false;
            } 
            
            else
            {
                txtNationalInsuranceNo.BackColor = Color.White;
            }
            #endregion

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

            #region// Email Validation
            if (textBoxEmailAddress.Text == "")
            {
                MessageBox.Show("Please, Enter email address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmailAddress.Focus();
                textBoxEmailAddress.BackColor = Color.Silver;
                return false;
            }

            //else if (!objEmailAddress.IsMatch(textBoxEmailAddress.Text))
            //{
            //    MessageBox.Show("Please, Enter a valid email address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBoxEmailAddress.Focus();
            //    textBoxEmailAddress.BackColor = Color.Silver;
            //    return false;
            //}

            // OTHER WAY TO VALIDATE EMAIL ON .NET
            else if (textBoxEmailAddress.Text.Length >= 1)
            {
                try
                {
                    MailAddress objMail = new MailAddress(textBoxEmailAddress.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEmailAddress.Focus();
                    textBoxEmailAddress.BackColor = Color.Silver;
                    return false;
                }
            }
            else
            {
                textBoxEmailAddress.BackColor = Color.White;
            }
            #endregion

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


        // Checked Items Controls Method
        private void CheckedItems()
        {
            // Checked Gender
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            } else
            {
                gender = "Female";
            }

            // Checked Marital Status
            if (radioButtonMarried.Checked)
            {
                maritalStatus = "Married";
            }
            else
            {
                maritalStatus = "Single";

            }

            // Checked Union Member
            if (checkBoxIsMember.Checked)
            {
                isMember = true;
            }
            else
            {
                isMember = false;

            }
        }

        // Add Employee functionality
        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

            if (isControlIsDataValid()) // To check if the form is already filled.
            {
                CheckedItems();
                // Connection String
                // Need to add on references to access this
                string cs = ConfigurationManager.ConnectionStrings["dbPayrollSystemConnectionString"].ConnectionString;

                // Instantiate the Sql Connection
                SqlConnection objSqlCon = new SqlConnection(cs);

                try
                {
                    // Open Connection
                    objSqlCon.Open();

                    // Prepare Insert Command
                    string insertCmd = "INSERT INTO tblEmployee VALUES("+Convert.ToInt32(txtEmployeeID.Text)+", '"
                        +txtFirstName.Text+"','"+txtLastName.Text+"','"+gender+ "','"+txtNationalInsuranceNo.Text+ "','"
                        +dtpDateOfBirth.Value.ToString("MM/dd/yyyy")+ "', '"+maritalStatus+ "','"+isMember+ "', '"+textBoxAddress.Text+ "', '"
                        +textBoxCity.Text+ "', '"+textBoxPostalCode.Text+ "','"+comboBoxCountry.SelectedIndex.ToString()+ "', '"
                        +textBoxContactNumber.Text+ "','"+textBoxEmailAddress.Text+ "','"+textBoxNotes.Text+"')";

                    // Instantiate SQLCommand and Pass in CommandText and Connection Object
                    SqlCommand objSqlCommand = new SqlCommand(insertCmd, objSqlCon);

                    // Execute the query identified within our command object
                    objSqlCommand.ExecuteNonQuery();

                    // TODO: This line of code loads data into the 'dbPayrollSystemDataSet.tblEmployee' table. You can move, or remove it, as needed.
                    this.tblEmployeeTableAdapter.Fill(this.dbPayrollSystemDataSet.tblEmployee); 

                    // Display success message
                    MessageBox.Show("Employee with ID :" + txtEmployeeID.Text + " " + "has been added successfully!", "Insert Succesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occured :" + ex.Message, "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close connection
                    objSqlCon.Close();
                }

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
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            txtNationalInsuranceNo.Text = "";
            dtpDateOfBirth.Value = new DateTime(1990, 12, 30);
            radioButtonMarried.Checked = false;
            radioButtonSingle.Checked = false;
            checkBoxIsMember.Checked = false;
            textBoxAddress.Text = string.Empty;
            textBoxCity.Text = null;
            textBoxPostalCode.Text = "";
            comboBoxCountry.SelectedIndex = 0;
            textBoxContactNumber.Text = "";
            textBoxEmailAddress.Text = "";
            textBoxNotes.Text = "";
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            // Arguments are values or stream of data that is passed into a method via the calling method. 

            frmPreview objFormPreview = new frmPreview();
            CheckedItems(); // To view marital status
            objFormPreview.PreviewEmployeeData(Convert.ToInt32(txtEmployeeID.Text), txtFirstName.Text, txtLastName.Text, gender, 
                txtNationalInsuranceNo.Text, dtpDateOfBirth.Text,maritalStatus,isMember, textBoxAddress.Text, 
                textBoxCity.Text, textBoxPostalCode.Text, comboBoxCountry.Text, textBoxContactNumber.Text, 
                textBoxEmailAddress.Text, textBoxNotes.Text);
            objFormPreview.ShowDialog();

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

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPayrollSystemDataSet.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.dbPayrollSystemDataSet.tblEmployee);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtNationalInsuranceNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            dtpDateOfBirth.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            maritalStatus = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            isMember = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
            textBoxCity.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
            textBoxPostalCode.Text = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
            comboBoxCountry.Text = dataGridView1.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
            textBoxContactNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();
            textBoxEmailAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[13].FormattedValue.ToString();
            textBoxNotes.Text = dataGridView1.Rows[e.RowIndex].Cells[14].FormattedValue.ToString();


            // Gender
            if (gender == "Male")
            {
                radioButtonMale.Checked = true;
                radioButtonFemale.Checked = false;
            }
            else
            {
                radioButtonMale.Checked = false;
                radioButtonFemale.Checked = true;
            }

            // Marital Status
            if (maritalStatus == "Married")
            {
                radioButtonMarried.Checked = true;
                radioButtonSingle.Checked = false;
            }
            else
            {
                radioButtonMarried.Checked = false;
                radioButtonSingle.Checked = true;
            }

            // Union Member
            if (isMember == true)
            {
                checkBoxIsMember.Checked = true;
            }
            else
            {
                checkBoxIsMember.Checked = false;

            }
        }
    }
}
