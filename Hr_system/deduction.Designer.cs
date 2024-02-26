namespace Hr_system
{
    partial class deduction
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
            this.deduction_id = new System.Windows.Forms.Label();
            this.ded_name = new System.Windows.Forms.Label();
            this.ded_amount = new System.Windows.Forms.Label();
            this.text_deduction_id = new System.Windows.Forms.TextBox();
            this.text_ded_name = new System.Windows.Forms.TextBox();
            this.text_emp_code = new System.Windows.Forms.TextBox();
            this.text_ded_amount = new System.Windows.Forms.TextBox();
            this.emp_code = new System.Windows.Forms.Label();
            this.text_rec_name = new System.Windows.Forms.TextBox();
            this.text_rec_amount = new System.Windows.Forms.TextBox();
            this.rec_name = new System.Windows.Forms.Label();
            this.rec_amount = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deduction_id
            // 
            this.deduction_id.AutoSize = true;
            this.deduction_id.Location = new System.Drawing.Point(254, 46);
            this.deduction_id.Name = "deduction_id";
            this.deduction_id.Size = new System.Drawing.Size(68, 13);
            this.deduction_id.TabIndex = 0;
            this.deduction_id.Text = "deduction_id";
            // 
            // ded_name
            // 
            this.ded_name.AutoSize = true;
            this.ded_name.Location = new System.Drawing.Point(253, 156);
            this.ded_name.Name = "ded_name";
            this.ded_name.Size = new System.Drawing.Size(57, 13);
            this.ded_name.TabIndex = 1;
            this.ded_name.Text = "ded_name";
            // 
            // ded_amount
            // 
            this.ded_amount.AutoSize = true;
            this.ded_amount.Location = new System.Drawing.Point(245, 214);
            this.ded_amount.Name = "ded_amount";
            this.ded_amount.Size = new System.Drawing.Size(67, 13);
            this.ded_amount.TabIndex = 3;
            this.ded_amount.Text = "ded_amount";
            // 
            // text_deduction_id
            // 
            this.text_deduction_id.Location = new System.Drawing.Point(365, 46);
            this.text_deduction_id.Name = "text_deduction_id";
            this.text_deduction_id.Size = new System.Drawing.Size(100, 20);
            this.text_deduction_id.TabIndex = 4;
            // 
            // text_ded_name
            // 
            this.text_ded_name.Location = new System.Drawing.Point(365, 153);
            this.text_ded_name.Name = "text_ded_name";
            this.text_ded_name.Size = new System.Drawing.Size(100, 20);
            this.text_ded_name.TabIndex = 5;
            // 
            // text_emp_code
            // 
            this.text_emp_code.Location = new System.Drawing.Point(365, 91);
            this.text_emp_code.Name = "text_emp_code";
            this.text_emp_code.Size = new System.Drawing.Size(100, 20);
            this.text_emp_code.TabIndex = 6;
            // 
            // text_ded_amount
            // 
            this.text_ded_amount.Location = new System.Drawing.Point(365, 211);
            this.text_ded_amount.Name = "text_ded_amount";
            this.text_ded_amount.Size = new System.Drawing.Size(100, 20);
            this.text_ded_amount.TabIndex = 7;
            this.text_ded_amount.TextChanged += new System.EventHandler(this.text_ded_amount_TextChanged);
            // 
            // emp_code
            // 
            this.emp_code.AutoSize = true;
            this.emp_code.Location = new System.Drawing.Point(254, 98);
            this.emp_code.Name = "emp_code";
            this.emp_code.Size = new System.Drawing.Size(56, 13);
            this.emp_code.TabIndex = 2;
            this.emp_code.Text = "emp_code";
            // 
            // text_rec_name
            // 
            this.text_rec_name.Location = new System.Drawing.Point(365, 256);
            this.text_rec_name.Name = "text_rec_name";
            this.text_rec_name.Size = new System.Drawing.Size(100, 20);
            this.text_rec_name.TabIndex = 27;
            // 
            // text_rec_amount
            // 
            this.text_rec_amount.Location = new System.Drawing.Point(365, 305);
            this.text_rec_amount.Name = "text_rec_amount";
            this.text_rec_amount.Size = new System.Drawing.Size(100, 20);
            this.text_rec_amount.TabIndex = 28;
            // 
            // rec_name
            // 
            this.rec_name.AutoSize = true;
            this.rec_name.Location = new System.Drawing.Point(254, 259);
            this.rec_name.Name = "rec_name";
            this.rec_name.Size = new System.Drawing.Size(57, 13);
            this.rec_name.TabIndex = 29;
            this.rec_name.Text = "rec_name ";
            // 
            // rec_amount
            // 
            this.rec_amount.AutoSize = true;
            this.rec_amount.Location = new System.Drawing.Point(255, 308);
            this.rec_amount.Name = "rec_amount";
            this.rec_amount.Size = new System.Drawing.Size(67, 13);
            this.rec_amount.TabIndex = 30;
            this.rec_amount.Text = "abd_amount";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(627, 253);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(627, 177);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(627, 119);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // deduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.rec_amount);
            this.Controls.Add(this.rec_name);
            this.Controls.Add(this.text_rec_amount);
            this.Controls.Add(this.text_rec_name);
            this.Controls.Add(this.text_ded_amount);
            this.Controls.Add(this.text_emp_code);
            this.Controls.Add(this.text_ded_name);
            this.Controls.Add(this.text_deduction_id);
            this.Controls.Add(this.ded_amount);
            this.Controls.Add(this.emp_code);
            this.Controls.Add(this.ded_name);
            this.Controls.Add(this.deduction_id);
            this.Name = "deduction";
            this.Text = "deduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deduction_id;
        private System.Windows.Forms.Label ded_name;
        private System.Windows.Forms.Label ded_amount;
        private System.Windows.Forms.TextBox text_deduction_id;
        private System.Windows.Forms.TextBox text_ded_name;
        private System.Windows.Forms.TextBox text_emp_code;
        private System.Windows.Forms.TextBox text_ded_amount;
        private System.Windows.Forms.Label emp_code;
        private System.Windows.Forms.TextBox text_rec_name;
        private System.Windows.Forms.TextBox text_rec_amount;
        private System.Windows.Forms.Label rec_name;
        private System.Windows.Forms.Label rec_amount;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}