using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transactional_Application
{
    public partial class Main : Form
    {
        DataHandler dataHandler = new DataHandler();
        public string selectedID = "";

        public Main()
        {
            InitializeComponent();
        }

        public void DisplayClientsDGV()
        {
            DataSet ds = dataHandler.GetClients();
            dgvClients.DataSource = ds.Tables["Clients"].DefaultView;
        }

        public void DisplayTransactionsDGV(string selectedID)
        {
            DataSet ds = dataHandler.GetTransactions(selectedID);
            dgvTransactions.DataSource = ds.Tables["Transactions"].DefaultView;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DisplayClientsDGV();
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];
                selectedID = row.Cells[0].Value.ToString();
            }

            DisplayTransactionsDGV(selectedID);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing && MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes);
        }

        private void filterClientsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Take value and send to search/filter datahandler method (CLients, filterbybox value, valueTxt value)
        }

        private void orderClientsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Take value and send to order by datahandler method
        }

        private void filterTransactionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Take value and send to search/filter datahandler method
        }

        private void orderTransactionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Take value and send to order by datahandler method
        }

        private void createButt_Click(object sender, EventArgs e)
        {
            try
            {
                New_Transaction transForm = new New_Transaction();
                transForm.RefToMainForm = this;
                transForm.RefToClientID = Convert.ToInt32(selectedID);
                this.Visible = false;
                transForm.ShowDialog();
            }
            catch (FormatException err)
            {
                MessageBox.Show("You need to select a Client first to add a Transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            DisplayClientsDGV();
            DisplayTransactionsDGV(selectedID);
        }
    }
}
