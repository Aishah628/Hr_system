namespace Hr_system
{
    partial class loan
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
            this.loan_id = new System.Windows.Forms.Label();
            this.emp_code = new System.Windows.Forms.Label();
            this.loan_amount = new System.Windows.Forms.Label();
            this.loan_date = new System.Windows.Forms.Label();
            this.loan_balance = new System.Windows.Forms.Label();
            this.loan_initalAmount = new System.Windows.Forms.Label();
            this.text_loan_id = new System.Windows.Forms.TextBox();
            this.text_emp_code = new System.Windows.Forms.TextBox();
            this.text_loan_amount = new System.Windows.Forms.TextBox();
            this.text_loan_date = new System.Windows.Forms.TextBox();
            this.text_loan_balance = new System.Windows.Forms.TextBox();
            this.text_loan_initalAmount = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loan_id
            // 
            this.loan_id.AutoSize = true;
            this.loan_id.Location = new System.Drawing.Point(194, 41);
            this.loan_id.Name = "loan_id";
            this.loan_id.Size = new System.Drawing.Size(41, 13);
            this.loan_id.TabIndex = 0;
            this.loan_id.Text = "loan_id";
            // 
            // emp_code
            // 
            this.emp_code.AutoSize = true;
            this.emp_code.Location = new System.Drawing.Point(194, 89);
            this.emp_code.Name = "emp_code";
            this.emp_code.Size = new System.Drawing.Size(56, 13);
            this.emp_code.TabIndex = 1;
            this.emp_code.Text = "emp_code";
            // 
            // loan_amount
            // 
            this.loan_amount.AutoSize = true;
            this.loan_amount.Location = new System.Drawing.Point(194, 145);
            this.loan_amount.Name = "loan_amount";
            this.loan_amount.Size = new System.Drawing.Size(69, 13);
            this.loan_amount.TabIndex = 2;
            this.loan_amount.Text = "loan_amount";
            // 
            // loan_date
            // 
            this.loan_date.AutoSize = true;
            this.loan_date.Location = new System.Drawing.Point(194, 203);
            this.loan_date.Name = "loan_date";
            this.loan_date.Size = new System.Drawing.Size(55, 13);
            this.loan_date.TabIndex = 3;
            this.loan_date.Text = "loan_date";
            // 
            // loan_balance
            // 
            this.loan_balance.AutoSize = true;
            this.loan_balance.Location = new System.Drawing.Point(194, 254);
            this.loan_balance.Name = "loan_balance";
            this.loan_balance.Size = new System.Drawing.Size(70, 13);
            this.loan_balance.TabIndex = 4;
            this.loan_balance.Text = "loan_balance";
            // 
            // loan_initalAmount
            // 
            this.loan_initalAmount.AutoSize = true;
            this.loan_initalAmount.Location = new System.Drawing.Point(194, 313);
            this.loan_initalAmount.Name = "loan_initalAmount";
            this.loan_initalAmount.Size = new System.Drawing.Size(92, 13);
            this.loan_initalAmount.TabIndex = 5;
            this.loan_initalAmount.Text = "loan_initalAmount";
            // 
            // text_loan_id
            // 
            this.text_loan_id.Location = new System.Drawing.Point(296, 38);
            this.text_loan_id.Name = "text_loan_id";
            this.text_loan_id.Size = new System.Drawing.Size(100, 20);
            this.text_loan_id.TabIndex = 6;
            // 
            // text_emp_code
            // 
            this.text_emp_code.Location = new System.Drawing.Point(296, 89);
            this.text_emp_code.Name = "text_emp_code";
            this.text_emp_code.Size = new System.Drawing.Size(100, 20);
            this.text_emp_code.TabIndex = 7;
            // 
            // text_loan_amount
            // 
            this.text_loan_amount.Location = new System.Drawing.Point(296, 142);
            this.text_loan_amount.Name = "text_loan_amount";
            this.text_loan_amount.Size = new System.Drawing.Size(100, 20);
            this.text_loan_amount.TabIndex = 8;
            // 
            // text_loan_date
            // 
            this.text_loan_date.Location = new System.Drawing.Point(296, 196);
            this.text_loan_date.Name = "text_loan_date";
            this.text_loan_date.Size = new System.Drawing.Size(100, 20);
            this.text_loan_date.TabIndex = 9;
            // 
            // text_loan_balance
            // 
            this.text_loan_balance.Location = new System.Drawing.Point(296, 254);
            this.text_loan_balance.Name = "text_loan_balance";
            this.text_loan_balance.Size = new System.Drawing.Size(100, 20);
            this.text_loan_balance.TabIndex = 10;
            // 
            // text_loan_initalAmount
            // 
            this.text_loan_initalAmount.Location = new System.Drawing.Point(296, 306);
            this.text_loan_initalAmount.Name = "text_loan_initalAmount";
            this.text_loan_initalAmount.Size = new System.Drawing.Size(100, 20);
            this.text_loan_initalAmount.TabIndex = 11;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(638, 247);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(638, 171);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(638, 113);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_loan_initalAmount);
            this.Controls.Add(this.text_loan_balance);
            this.Controls.Add(this.text_loan_date);
            this.Controls.Add(this.text_loan_amount);
            this.Controls.Add(this.text_emp_code);
            this.Controls.Add(this.text_loan_id);
            this.Controls.Add(this.loan_initalAmount);
            this.Controls.Add(this.loan_balance);
            this.Controls.Add(this.loan_date);
            this.Controls.Add(this.loan_amount);
            this.Controls.Add(this.emp_code);
            this.Controls.Add(this.loan_id);
            this.Name = "loan";
            this.Text = "loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loan_id;
        private System.Windows.Forms.Label emp_code;
        private System.Windows.Forms.Label loan_amount;
        private System.Windows.Forms.Label loan_date;
        private System.Windows.Forms.Label loan_balance;
        private System.Windows.Forms.Label loan_initalAmount;
        private System.Windows.Forms.TextBox text_loan_id;
        private System.Windows.Forms.TextBox text_emp_code;
        private System.Windows.Forms.TextBox text_loan_amount;
        private System.Windows.Forms.TextBox text_loan_date;
        private System.Windows.Forms.TextBox text_loan_balance;
        private System.Windows.Forms.TextBox text_loan_initalAmount;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}