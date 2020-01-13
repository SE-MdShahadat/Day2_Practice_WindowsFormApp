using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWinFormsApp
{
    public partial class CoffeeShopUi : Form
    {
        private string customerName;
        private string contactNo;
        private string address;
        private string orderType;
        private int quantity;
        private double orderPrice;

        public CoffeeShopUi()
        {
            InitializeComponent();
            orderComboBox.Text = "-Select-";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerName = customerNameTextBox.Text;
            contactNo = contactNoTextBox.Text;
            address = addressTextBox.Text;


            orderType = orderComboBox.Text;
            quantity =Convert.ToInt32(quantityTextBox.Text);
            if (orderType == "Black")
            {
                orderPrice = quantity * 120;
            }
            else if (orderType == "Cold")
            {
                orderPrice = quantity * 100;
            }
            else if (orderType == "Hot")
            {
                orderPrice = quantity * 90;
            }
            else if (orderType == "Reguler")
            {
                orderPrice = quantity * 80;
            }
            else MessageBox.Show("Please select a order type!!");

            string displayMessage;
            displayMessage = "Purchase Information\n" +
                "-------------------------------------\n" +
                "\nCustomer name: " + customerName +
                "\nContact no: " + contactNo +
                "\nAddress: " + address +
                "\nOrder item: " + orderType +
                "\nTotal Price: " + orderPrice +" taka.";



            displayRichTextBox.Text = displayMessage;
        }
    }
}
