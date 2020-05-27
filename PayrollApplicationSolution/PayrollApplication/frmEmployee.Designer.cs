namespace PayrollApplication
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.grpBxEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.checkBoxIsMember = new System.Windows.Forms.CheckBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxMaritalStatus = new System.Windows.Forms.GroupBox();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.radioButtonMarried = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNationalInsuranceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.grpBxEmployeeContactDetails = new System.Windows.Forms.GroupBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.grpBxEmployeeInformation.SuspendLayout();
            this.groupBoxMaritalStatus.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.grpBxEmployeeContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxEmployeeInformation
            // 
            this.grpBxEmployeeInformation.Controls.Add(this.checkBoxIsMember);
            this.grpBxEmployeeInformation.Controls.Add(this.dtpDateOfBirth);
            this.grpBxEmployeeInformation.Controls.Add(this.label3);
            this.grpBxEmployeeInformation.Controls.Add(this.groupBoxMaritalStatus);
            this.grpBxEmployeeInformation.Controls.Add(this.label2);
            this.grpBxEmployeeInformation.Controls.Add(this.txtNationalInsuranceNo);
            this.grpBxEmployeeInformation.Controls.Add(this.label1);
            this.grpBxEmployeeInformation.Controls.Add(this.groupBoxGender);
            this.grpBxEmployeeInformation.Controls.Add(this.txtFirstName);
            this.grpBxEmployeeInformation.Controls.Add(this.lblFirstName);
            this.grpBxEmployeeInformation.Controls.Add(this.txtLastName);
            this.grpBxEmployeeInformation.Controls.Add(this.lblLastName);
            this.grpBxEmployeeInformation.Controls.Add(this.txtEmployeeID);
            this.grpBxEmployeeInformation.Controls.Add(this.lblEmployeeID);
            this.grpBxEmployeeInformation.Location = new System.Drawing.Point(52, 31);
            this.grpBxEmployeeInformation.Name = "grpBxEmployeeInformation";
            this.grpBxEmployeeInformation.Size = new System.Drawing.Size(282, 327);
            this.grpBxEmployeeInformation.TabIndex = 0;
            this.grpBxEmployeeInformation.TabStop = false;
            this.grpBxEmployeeInformation.Text = "Employee Information";
            // 
            // checkBoxIsMember
            // 
            this.checkBoxIsMember.AutoSize = true;
            this.checkBoxIsMember.Location = new System.Drawing.Point(186, 253);
            this.checkBoxIsMember.Name = "checkBoxIsMember";
            this.checkBoxIsMember.Size = new System.Drawing.Size(71, 17);
            this.checkBoxIsMember.TabIndex = 9;
            this.checkBoxIsMember.Text = "isMember";
            this.checkBoxIsMember.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(157, 174);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dtpDateOfBirth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Union Membership : ";
            // 
            // groupBoxMaritalStatus
            // 
            this.groupBoxMaritalStatus.Controls.Add(this.radioButtonSingle);
            this.groupBoxMaritalStatus.Controls.Add(this.radioButtonMarried);
            this.groupBoxMaritalStatus.Location = new System.Drawing.Point(18, 200);
            this.groupBoxMaritalStatus.Name = "groupBoxMaritalStatus";
            this.groupBoxMaritalStatus.Size = new System.Drawing.Size(204, 41);
            this.groupBoxMaritalStatus.TabIndex = 7;
            this.groupBoxMaritalStatus.TabStop = false;
            this.groupBoxMaritalStatus.Text = "Marital Status";
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(125, 16);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSingle.TabIndex = 8;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarried
            // 
            this.radioButtonMarried.AutoSize = true;
            this.radioButtonMarried.Location = new System.Drawing.Point(18, 16);
            this.radioButtonMarried.Name = "radioButtonMarried";
            this.radioButtonMarried.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMarried.TabIndex = 7;
            this.radioButtonMarried.TabStop = true;
            this.radioButtonMarried.Text = "Married";
            this.radioButtonMarried.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date of Birth : ";
            // 
            // txtNationalInsuranceNo
            // 
            this.txtNationalInsuranceNo.Location = new System.Drawing.Point(157, 149);
            this.txtNationalInsuranceNo.Name = "txtNationalInsuranceNo";
            this.txtNationalInsuranceNo.Size = new System.Drawing.Size(100, 20);
            this.txtNationalInsuranceNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "National Insurance No : ";
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(18, 100);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(204, 43);
            this.groupBoxGender.TabIndex = 6;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(124, 15);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(17, 15);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 3;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(157, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 51);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(63, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(157, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name : ";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(157, 22);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(15, 25);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "EmployeeID:";
            // 
            // grpBxEmployeeContactDetails
            // 
            this.grpBxEmployeeContactDetails.Controls.Add(this.comboBoxCountry);
            this.grpBxEmployeeContactDetails.Controls.Add(this.textBoxNotes);
            this.grpBxEmployeeContactDetails.Controls.Add(this.textBoxEmailAddress);
            this.grpBxEmployeeContactDetails.Controls.Add(this.label10);
            this.grpBxEmployeeContactDetails.Controls.Add(this.label9);
            this.grpBxEmployeeContactDetails.Controls.Add(this.textBoxPostalCode);
            this.grpBxEmployeeContactDetails.Controls.Add(this.label8);
            this.grpBxEmployeeContactDetails.Controls.Add(this.label7);
            this.grpBxEmployeeContactDetails.Controls.Add(this.textBoxContactNumber);
            this.grpBxEmployeeContactDetails.Controls.Add(this.label6);
            this.grpBxEmployeeContactDetails.Controls.Add(this.textBoxCity);
            this.grpBxEmployeeContactDetails.Controls.Add(this.label5);
            this.grpBxEmployeeContactDetails.Controls.Add(this.textBoxAddress);
            this.grpBxEmployeeContactDetails.Controls.Add(this.lblAddress);
            this.grpBxEmployeeContactDetails.Location = new System.Drawing.Point(395, 31);
            this.grpBxEmployeeContactDetails.Name = "grpBxEmployeeContactDetails";
            this.grpBxEmployeeContactDetails.Size = new System.Drawing.Size(282, 327);
            this.grpBxEmployeeContactDetails.TabIndex = 1;
            this.grpBxEmployeeContactDetails.TabStop = false;
            this.grpBxEmployeeContactDetails.Text = "Employee Contact Details";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Please enter a country...",
            "Philippines",
            "India",
            "Indonesia",
            "Pakistan",
            "Bangladesh"});
            this.comboBoxCountry.Location = new System.Drawing.Point(114, 144);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 13;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(115, 248);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(146, 55);
            this.textBoxNotes.TabIndex = 16;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(114, 212);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmailAddress.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Notes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Email Address:";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(115, 99);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostalCode.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Postal Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Country :";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(115, 175);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxContactNumber.TabIndex = 14;
            this.textBoxContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContactNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contact Number:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(115, 62);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "City:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(115, 25);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(19, 29);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(453, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonAddEmployee.Location = new System.Drawing.Point(119, 364);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(115, 23);
            this.buttonAddEmployee.TabIndex = 17;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(119, 393);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(115, 23);
            this.buttonUpdateEmployee.TabIndex = 18;
            this.buttonUpdateEmployee.Text = "Update Employee";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = false;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(274, 364);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(138, 23);
            this.buttonDeleteEmployee.TabIndex = 19;
            this.buttonDeleteEmployee.Text = "Delete Employee";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = false;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(310, 393);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 20;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPreview.ForeColor = System.Drawing.Color.White;
            this.buttonPreview.Location = new System.Drawing.Point(453, 364);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 21;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonUpdateEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBxEmployeeContactDetails);
            this.Controls.Add(this.grpBxEmployeeInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee";
            this.grpBxEmployeeInformation.ResumeLayout(false);
            this.grpBxEmployeeInformation.PerformLayout();
            this.groupBoxMaritalStatus.ResumeLayout(false);
            this.groupBoxMaritalStatus.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.grpBxEmployeeContactDetails.ResumeLayout(false);
            this.grpBxEmployeeContactDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxEmployeeInformation;
        private System.Windows.Forms.GroupBox grpBxEmployeeContactDetails;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxMaritalStatus;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.RadioButton radioButtonMarried;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNationalInsuranceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.CheckBox checkBoxIsMember;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonUpdateEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonPreview;
    }
}

