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
    public partial class frmPreview : Form
    {
        public frmPreview()
        {
            InitializeComponent();
        }
        //Parameteres are special kind of variables that receives arguments when the method is called. 
        public void PreviewEmployeeData(
                int EmployeeID, string FirstName, string LastName, string Gender, string NationalInsurance, 
                string DateOfBirth, string MaritalStatus, bool IsMember, string Address, string City, string PostalCode, 
                string Country, string ContactNumber, string Email, string Notes
            )
        {
            _labelEmployeeID.Text = Convert.ToString(EmployeeID);
            _labelFirstName.Text = FirstName;
            _labelLastName.Text = LastName;
            _labelGender.Text = Gender;
            _labelNationalInsuranceNo.Text = NationalInsurance;
            _labelDateofBirth.Text = DateOfBirth;
            _labelMaritalStatus.Text = MaritalStatus;
            _labelUnionMembership.Text = IsMember.ToString();
            _labelAddress.Text = Address;
            _labelCity.Text = City;
            _labelPostalCode.Text = PostalCode;
            _labelCountry.Text = Country;
            _labelContactNumber.Text = ContactNumber;
            _labelEmailAddress.Text = Email;
            _labelNotes.Text = Notes;

        }

    }
}
