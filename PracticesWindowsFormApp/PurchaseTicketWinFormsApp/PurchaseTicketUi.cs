using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseTicketWinFormsApp
{
    public partial class PurchaseTicketUi : Form
    {
        private string customerName;
        private int numberOfTickets;
        private double unitPrice = 100;
        private double totalPrice = 0;
        public PurchaseTicketUi()
        {
            InitializeComponent();
        }

        private void TotalPriceButton_Click(object sender, EventArgs e)
        {
            customerName = customerNameTextBox.Text;
            numberOfTickets = Convert.ToInt32(numberOfTicketTextBox.Text);
            totalPrice = unitPrice * numberOfTickets;
            MessageBox.Show("Hello, "+customerName+", please pay "+totalPrice +" taka only");
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            customerName = customerNameTextBox.Text;
            numberOfTickets = Convert.ToInt32(numberOfTicketTextBox.Text);
            MessageBox.Show("Customer name    : "+customerName +
                          "\nNumber of tickets: "+numberOfTickets+
                          "\nUnit price       : "+unitPrice+" taka" +
                          "\nTotal Price      : "+totalPrice+" taka");
        }
    }
}
