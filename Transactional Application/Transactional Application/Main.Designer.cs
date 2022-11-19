namespace Transactional_Application
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createButt = new System.Windows.Forms.Button();
            this.editButt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filterClientsBox = new System.Windows.Forms.ComboBox();
            this.clientValTxt = new System.Windows.Forms.TextBox();
            this.orderClientsBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.orderTransactionsBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.transactionValTxt = new System.Windows.Forms.TextBox();
            this.filterTransactionsBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clients";
            // 
            // dgvClients
            // 
            this.dgvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(176)))), ((int)(((byte)(171)))));
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(176)))), ((int)(((byte)(171)))));
            this.dgvClients.Location = new System.Drawing.Point(12, 58);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(826, 135);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(176)))), ((int)(((byte)(171)))));
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(176)))), ((int)(((byte)(171)))));
            this.dgvTransactions.Location = new System.Drawing.Point(12, 249);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.RowHeadersWidth = 51;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.Size = new System.Drawing.Size(826, 135);
            this.dgvTransactions.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select a Client to create a new Transaction.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select a Client to edit a Transaction\'s Comment.\r\n";
            // 
            // createButt
            // 
            this.createButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.createButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(124)))), ((int)(((byte)(89)))));
            this.createButt.FlatAppearance.BorderSize = 3;
            this.createButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButt.Location = new System.Drawing.Point(670, 392);
            this.createButt.Name = "createButt";
            this.createButt.Size = new System.Drawing.Size(141, 63);
            this.createButt.TabIndex = 6;
            this.createButt.Text = "Create Transaction";
            this.createButt.UseVisualStyleBackColor = false;
            this.createButt.Click += new System.EventHandler(this.createButt_Click);
            // 
            // editButt
            // 
            this.editButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.editButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(124)))), ((int)(((byte)(89)))));
            this.editButt.FlatAppearance.BorderSize = 3;
            this.editButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButt.Location = new System.Drawing.Point(670, 485);
            this.editButt.Name = "editButt";
            this.editButt.Size = new System.Drawing.Size(141, 47);
            this.editButt.TabIndex = 7;
            this.editButt.Text = "Edit Comment";
            this.editButt.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Filter by:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Value:";
            // 
            // filterClientsBox
            // 
            this.filterClientsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.filterClientsBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterClientsBox.FormattingEnabled = true;
            this.filterClientsBox.Location = new System.Drawing.Point(242, 23);
            this.filterClientsBox.Name = "filterClientsBox";
            this.filterClientsBox.Size = new System.Drawing.Size(118, 23);
            this.filterClientsBox.TabIndex = 10;
            this.filterClientsBox.SelectedIndexChanged += new System.EventHandler(this.filterClientsBox_SelectedIndexChanged);
            // 
            // clientValTxt
            // 
            this.clientValTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.clientValTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientValTxt.Location = new System.Drawing.Point(424, 25);
            this.clientValTxt.Name = "clientValTxt";
            this.clientValTxt.Size = new System.Drawing.Size(150, 22);
            this.clientValTxt.TabIndex = 11;
            // 
            // orderClientsBox
            // 
            this.orderClientsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.orderClientsBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderClientsBox.FormattingEnabled = true;
            this.orderClientsBox.Location = new System.Drawing.Point(720, 23);
            this.orderClientsBox.Name = "orderClientsBox";
            this.orderClientsBox.Size = new System.Drawing.Size(118, 23);
            this.orderClientsBox.TabIndex = 13;
            this.orderClientsBox.SelectedIndexChanged += new System.EventHandler(this.orderClientsBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(636, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Order by:";
            // 
            // orderTransactionsBox
            // 
            this.orderTransactionsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.orderTransactionsBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTransactionsBox.FormattingEnabled = true;
            this.orderTransactionsBox.Location = new System.Drawing.Point(720, 211);
            this.orderTransactionsBox.Name = "orderTransactionsBox";
            this.orderTransactionsBox.Size = new System.Drawing.Size(118, 23);
            this.orderTransactionsBox.TabIndex = 19;
            this.orderTransactionsBox.SelectedIndexChanged += new System.EventHandler(this.orderTransactionsBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(636, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Order by:";
            // 
            // transactionValTxt
            // 
            this.transactionValTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.transactionValTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionValTxt.Location = new System.Drawing.Point(424, 213);
            this.transactionValTxt.Name = "transactionValTxt";
            this.transactionValTxt.Size = new System.Drawing.Size(150, 22);
            this.transactionValTxt.TabIndex = 17;
            // 
            // filterTransactionsBox
            // 
            this.filterTransactionsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.filterTransactionsBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTransactionsBox.FormattingEnabled = true;
            this.filterTransactionsBox.Location = new System.Drawing.Point(242, 211);
            this.filterTransactionsBox.Name = "filterTransactionsBox";
            this.filterTransactionsBox.Size = new System.Drawing.Size(118, 23);
            this.filterTransactionsBox.TabIndex = 16;
            this.filterTransactionsBox.SelectedIndexChanged += new System.EventHandler(this.filterTransactionsBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(366, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Value:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(163, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Filter by:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(863, 542);
            this.Controls.Add(this.orderTransactionsBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.transactionValTxt);
            this.Controls.Add(this.filterTransactionsBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.orderClientsBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clientValTxt);
            this.Controls.Add(this.filterClientsBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editButt);
            this.Controls.Add(this.createButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.VisibleChanged += new System.EventHandler(this.Main_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createButt;
        private System.Windows.Forms.Button editButt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox filterClientsBox;
        private System.Windows.Forms.TextBox clientValTxt;
        private System.Windows.Forms.ComboBox orderClientsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox orderTransactionsBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox transactionValTxt;
        private System.Windows.Forms.ComboBox filterTransactionsBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

