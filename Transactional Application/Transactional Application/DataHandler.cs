using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transactional_Application
{
    internal class DataHandler
    {
        // details for connection string
        static string host = "TAMMYLAPTOP\\SQLEXPRESS";
        static string database = "TransactionDb";
        public static string connString = @"Data Source = " + host + "; Initial Catalog=" + database + ";Integrated Security=SSPI";

        // variables for connection and commands
        SqlConnection conn;
        SqlCommand cmd;
        SqlCommand cmd2;

        public DataHandler()
        {
            // Constructor
        }

        //Get Clients from database
        public DataSet GetClients()
        {
            string sqlCmd = @"SELECT * FROM Clients";

            conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd, conn);
                DataSet ds = new DataSet();

                da.Fill(ds, "Clients");
                return ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }

            return null;
        }

        // Search method
        public DataSet GetTransactions(string selectedID)
        {
            string sqlCmd = @"SELECT TransactionID, Amount, Transactions.TransactionTypeID, TransactionTypes.TransactionTypeName, Comment FROM Transactions INNER JOIN TransactionTypes ON Transactions.TransactionTypeID = TransactionTypes.TransactionTypeID WHERE ClientID = '" + selectedID + "'";
            conn = new SqlConnection(connString);

            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd, conn);
                DataSet ds = new DataSet();

                da.Fill(ds, "Transactions");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                conn.Close();
            }

            return null;
        }

        // Add method
        public void AddTransaction(string id, decimal amount, int type, int clientID, string comment)
        {
            string sqlCmd = @"INSERT INTO Transactions VALUES ('" + id + "', '" + amount + "', '" + type + "', '" + clientID + "', '" + comment + "')";
            string amountCmd = @"UPDATE Clients SET ClientBalance += '" + amount + "' WHERE ClientID = '" + clientID + "'";

            conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlCmd, conn);
                cmd.ExecuteNonQuery();

                cmd2 = new SqlCommand(amountCmd, conn);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
