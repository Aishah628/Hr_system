namespace Hr_system
{
    partial class expense
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
            this.exp_id = new System.Windows.Forms.Label();
            this.emp_code = new System.Windows.Forms.Label();
            this.exp_code = new System.Windows.Forms.Label();
            this.exp_amount = new System.Windows.Forms.Label();
            this.exp_date = new System.Windows.Forms.Label();
            this.approved = new System.Windows.Forms.Label();
            this.text_exp_id = new System.Windows.Forms.TextBox();
            this.text_emp_code = new System.Windows.Forms.TextBox();
            this.text_exp_code = new System.Windows.Forms.TextBox();
            this.text_exp_amount = new System.Windows.Forms.TextBox();
            this.text_exp_date = new System.Windows.Forms.TextBox();
            this.text_approved = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exp_id
            // 
            this.exp_id.AutoSize = true;
            this.exp_id.Location = new System.Drawing.Point(145, 64);
            this.exp_id.Name = "exp_id";
            this.exp_id.Size = new System.Drawing.Size(39, 13);
            this.exp_id.TabIndex = 0;
            this.exp_id.Text = "exp_id";
            // 
            // emp_code
            // 
            this.emp_code.AutoSize = true;
            this.emp_code.Location = new System.Drawing.Point(145, 106);
            this.emp_code.Name = "emp_code";
            this.emp_code.Size = new System.Drawing.Size(56, 13);
            this.emp_code.TabIndex = 1;
            this.emp_code.Text = "emp_code";
            // 
            // exp_code
            // 
            this.exp_code.AutoSize = true;
            this.exp_code.Location = new System.Drawing.Point(145, 157);
            this.exp_code.Name = "exp_code";
            this.exp_code.Size = new System.Drawing.Size(54, 13);
            this.exp_code.TabIndex = 2;
            this.exp_code.Text = "exp_code";
            // 
            // exp_amount
            // 
            this.exp_amount.AutoSize = true;
            this.exp_amount.Location = new System.Drawing.Point(145, 215);
            this.exp_amount.Name = "exp_amount";
            this.exp_amount.Size = new System.Drawing.Size(67, 13);
            this.exp_amount.TabIndex = 3;
            this.exp_amount.Text = "exp_amount";
            // 
            // exp_date
            // 
            this.exp_date.AutoSize = true;
            this.exp_date.Location = new System.Drawing.Point(145, 260);
            this.exp_date.Name = "exp_date";
            this.exp_date.Size = new System.Drawing.Size(53, 13);
            this.exp_date.TabIndex = 4;
            this.exp_date.Text = "exp_date";
            // 
            // approved
            // 
            this.approved.AutoSize = true;
            this.approved.Location = new System.Drawing.Point(145, 306);
            this.approved.Name = "approved";
            this.approved.Size = new System.Drawing.Size(53, 13);
            this.approved.TabIndex = 5;
            this.approved.Text = "approved";
            // 
            // text_exp_id
            // 
            this.text_exp_id.Location = new System.Drawing.Point(272, 61);
            this.text_exp_id.Name = "text_exp_id";
            this.text_exp_id.Size = new System.Drawing.Size(100, 20);
            this.text_exp_id.TabIndex = 6;
            // 
            // text_emp_code
            // 
            this.text_emp_code.Location = new System.Drawing.Point(272, 106);
            this.text_emp_code.Name = "text_emp_code";
            this.text_emp_code.Size = new System.Drawing.Size(100, 20);
            this.text_emp_code.TabIndex = 7;
            // 
            // text_exp_code
            // 
            this.text_exp_code.Location = new System.Drawing.Point(272, 157);
            this.text_exp_code.Name = "text_exp_code";
            this.text_exp_code.Size = new System.Drawing.Size(100, 20);
            this.text_exp_code.TabIndex = 8;
            // 
            // text_exp_amount
            // 
            this.text_exp_amount.Location = new System.Drawing.Point(272, 208);
            this.text_exp_amount.Name = "text_exp_amount";
            this.text_exp_amount.Size = new System.Drawing.Size(100, 20);
            this.text_exp_amount.TabIndex = 9;
            // 
            // text_exp_date
            // 
            this.text_exp_date.Location = new System.Drawing.Point(272, 260);
            this.text_exp_date.Name = "text_exp_date";
            this.text_exp_date.Size = new System.Drawing.Size(100, 20);
            this.text_exp_date.TabIndex = 10;
            // 
            // text_approved
            // 
            this.text_approved.Location = new System.Drawing.Point(272, 306);
            this.text_approved.Name = "text_approved";
            this.text_approved.Size = new System.Drawing.Size(100, 20);
            this.text_approved.TabIndex = 11;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(629, 255);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(629, 179);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(629, 121);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_approved);
            this.Controls.Add(this.text_exp_date);
            this.Controls.Add(this.text_exp_amount);
            this.Controls.Add(this.text_exp_code);
            this.Controls.Add(this.text_emp_code);
            this.Controls.Add(this.text_exp_id);
            this.Controls.Add(this.approved);
            this.Controls.Add(this.exp_date);
            this.Controls.Add(this.exp_amount);
            this.Controls.Add(this.exp_code);
            this.Controls.Add(this.emp_code);
            this.Controls.Add(this.exp_id);
            this.Name = "expense";
            this.Text = "expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exp_id;
        private System.Windows.Forms.Label emp_code;
        private System.Windows.Forms.Label exp_code;
        private System.Windows.Forms.Label exp_amount;
        private System.Windows.Forms.Label exp_date;
        private System.Windows.Forms.Label approved;
        private System.Windows.Forms.TextBox text_exp_id;
        private System.Windows.Forms.TextBox text_emp_code;
        private System.Windows.Forms.TextBox text_exp_code;
        private System.Windows.Forms.TextBox text_exp_amount;
        private System.Windows.Forms.TextBox text_exp_date;
        private System.Windows.Forms.TextBox text_approved;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}