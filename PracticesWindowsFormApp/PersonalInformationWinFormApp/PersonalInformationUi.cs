using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationWinFormApp
{
    public partial class PersonalInformationUi : Form
    {
        private string firstName;
        private string lastName;
        private string fatherName;
        private string motherName;
        private string address;
        
        public PersonalInformationUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Getting information from form
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            address = addressTextBox.Text;

            MessageBox.Show("Information saved successfully!");

            // Reset From
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
            addressTextBox.Clear();

            
        }

        private void ShowAllinformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your full name is " + firstName + " " + lastName +
                "\nFather's name: " + fatherName + "\nMother's name: " + motherName +
                "\nAddress: " + address);
        }

        private void FullNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your full name is " + firstName + " " + lastName);
        }

        private void ParentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your father's name " + fatherName + " and your mother's name " + motherName);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your address is " + address);
        }
    }
}
