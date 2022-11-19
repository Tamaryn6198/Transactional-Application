namespace Transactional_Application
{
    partial class New_Transaction
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createTransButt = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.transTypeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a New Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comment (optional):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Transaction Type:";
            // 
            // createTransButt
            // 
            this.createTransButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.createTransButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(124)))), ((int)(((byte)(89)))));
            this.createTransButt.FlatAppearance.BorderSize = 3;
            this.createTransButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTransButt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTransButt.Location = new System.Drawing.Point(185, 291);
            this.createTransButt.Name = "createTransButt";
            this.createTransButt.Size = new System.Drawing.Size(119, 56);
            this.createTransButt.TabIndex = 5;
            this.createTransButt.Text = "Create";
            this.createTransButt.UseVisualStyleBackColor = false;
            this.createTransButt.Click += new System.EventHandler(this.createTransButt_Click);
            // 
            // idTxt
            // 
            this.idTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.idTxt.Location = new System.Drawing.Point(185, 87);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(219, 22);
            this.idTxt.TabIndex = 6;
            // 
            // amountTxt
            // 
            this.amountTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.amountTxt.Location = new System.Drawing.Point(185, 127);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(219, 22);
            this.amountTxt.TabIndex = 7;
            // 
            // commentTxt
            // 
            this.commentTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.commentTxt.Location = new System.Drawing.Point(185, 208);
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(219, 45);
            this.commentTxt.TabIndex = 8;
            // 
            // transTypeBox
            // 
            this.transTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(192)))), ((int)(((byte)(169)))));
            this.transTypeBox.FormattingEnabled = true;
            this.transTypeBox.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.transTypeBox.Location = new System.Drawing.Point(185, 166);
            this.transTypeBox.Name = "transTypeBox";
            this.transTypeBox.Size = new System.Drawing.Size(219, 24);
            this.transTypeBox.TabIndex = 9;
            // 
            // New_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(514, 393);
            this.Controls.Add(this.transTypeBox);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.amountTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.createTransButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Transaction";
            this.Text = "New_Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_Transaction_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createTransButt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox commentTxt;
        private System.Windows.Forms.ComboBox transTypeBox;
    }
}