using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Transactional_Application
{
    public partial class New_Transaction : Form
    {
        DataHandler dataHandler = new DataHandler();
        public Form RefToMainForm { get; set; }
        public int RefToClientID { get; set; }

        public New_Transaction()
        {
            InitializeComponent();
        }

        private void New_Transaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to discard this transaction and return to main?";
            string title = "Discard Transaction";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                this.RefToMainForm.Show();
                e.Cancel = false;
            }
            else if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void createTransButt_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string typeStr = transTypeBox.Text;
            string amountStr = "";
            decimal amount = 0;
            int type = 0;
            if (typeStr == "Debit")
            {
                type = 1;
                amountStr = amountTxt.Text;
                amount = Convert.ToDecimal(amountStr);
            }
            else if (typeStr == "Credit")
            {
                type = 2;
                amountStr = "-" + amountTxt.Text;
                amount = Convert.ToDecimal(amountStr);
            }
            string comment = commentTxt.Text;

            // Message to confirm creation of transaction
            string message = "Are you sure you want to create a new transaction for Client ID: " + this.RefToClientID + "?";
            string title = "Confirm Transaction Creation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                dataHandler.AddTransaction(id, amount, type, this.RefToClientID, comment);
                MessageBox.Show("Transaction successfully added for Client ID: " + this.RefToClientID);
                this.RefToMainForm.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
