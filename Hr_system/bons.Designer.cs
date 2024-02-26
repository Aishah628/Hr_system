namespace Hr_system
{
    partial class bons
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
            this.bon_id = new System.Windows.Forms.Label();
            this.emp_code = new System.Windows.Forms.Label();
            this.bon_date = new System.Windows.Forms.Label();
            this.bon_amount = new System.Windows.Forms.Label();
            this.name_bon = new System.Windows.Forms.Label();
            this.text_bon_id = new System.Windows.Forms.TextBox();
            this.text_emp_code = new System.Windows.Forms.TextBox();
            this.text_bon_date = new System.Windows.Forms.TextBox();
            this.text_bon_amount = new System.Windows.Forms.TextBox();
            this.text_name_bon = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bon_id
            // 
            this.bon_id.AutoSize = true;
            this.bon_id.Location = new System.Drawing.Point(217, 40);
            this.bon_id.Name = "bon_id";
            this.bon_id.Size = new System.Drawing.Size(39, 13);
            this.bon_id.TabIndex = 0;
            this.bon_id.Text = "bon_id";
            // 
            // emp_code
            // 
            this.emp_code.AutoSize = true;
            this.emp_code.Location = new System.Drawing.Point(217, 107);
            this.emp_code.Name = "emp_code";
            this.emp_code.Size = new System.Drawing.Size(56, 13);
            this.emp_code.TabIndex = 1;
            this.emp_code.Text = "emp_code";
            // 
            // bon_date
            // 
            this.bon_date.AutoSize = true;
            this.bon_date.Location = new System.Drawing.Point(217, 185);
            this.bon_date.Name = "bon_date";
            this.bon_date.Size = new System.Drawing.Size(53, 13);
            this.bon_date.TabIndex = 2;
            this.bon_date.Text = "bon_date";
            // 
            // bon_amount
            // 
            this.bon_amount.AutoSize = true;
            this.bon_amount.Location = new System.Drawing.Point(217, 248);
            this.bon_amount.Name = "bon_amount";
            this.bon_amount.Size = new System.Drawing.Size(67, 13);
            this.bon_amount.TabIndex = 3;
            this.bon_amount.Text = "bon_amount";
            // 
            // name_bon
            // 
            this.name_bon.AutoSize = true;
            this.name_bon.Location = new System.Drawing.Point(217, 320);
            this.name_bon.Name = "name_bon";
            this.name_bon.Size = new System.Drawing.Size(57, 13);
            this.name_bon.TabIndex = 4;
            this.name_bon.Text = "name_bon";
            // 
            // text_bon_id
            // 
            this.text_bon_id.Location = new System.Drawing.Point(326, 40);
            this.text_bon_id.Name = "text_bon_id";
            this.text_bon_id.Size = new System.Drawing.Size(100, 20);
            this.text_bon_id.TabIndex = 5;
            this.text_bon_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_emp_code
            // 
            this.text_emp_code.Location = new System.Drawing.Point(326, 104);
            this.text_emp_code.Name = "text_emp_code";
            this.text_emp_code.Size = new System.Drawing.Size(100, 20);
            this.text_emp_code.TabIndex = 6;
            // 
            // text_bon_date
            // 
            this.text_bon_date.Location = new System.Drawing.Point(326, 182);
            this.text_bon_date.Name = "text_bon_date";
            this.text_bon_date.Size = new System.Drawing.Size(100, 20);
            this.text_bon_date.TabIndex = 7;
            // 
            // text_bon_amount
            // 
            this.text_bon_amount.Location = new System.Drawing.Point(326, 248);
            this.text_bon_amount.Name = "text_bon_amount";
            this.text_bon_amount.Size = new System.Drawing.Size(100, 20);
            this.text_bon_amount.TabIndex = 8;
            // 
            // text_name_bon
            // 
            this.text_name_bon.Location = new System.Drawing.Point(326, 317);
            this.text_name_bon.Name = "text_name_bon";
            this.text_name_bon.Size = new System.Drawing.Size(100, 20);
            this.text_name_bon.TabIndex = 9;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(623, 250);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(623, 174);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(623, 116);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // bons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_name_bon);
            this.Controls.Add(this.text_bon_amount);
            this.Controls.Add(this.text_bon_date);
            this.Controls.Add(this.text_emp_code);
            this.Controls.Add(this.text_bon_id);
            this.Controls.Add(this.name_bon);
            this.Controls.Add(this.bon_amount);
            this.Controls.Add(this.bon_date);
            this.Controls.Add(this.emp_code);
            this.Controls.Add(this.bon_id);
            this.Name = "bons";
            this.Text = "bons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bon_id;
        private System.Windows.Forms.Label emp_code;
        private System.Windows.Forms.Label bon_date;
        private System.Windows.Forms.Label bon_amount;
        private System.Windows.Forms.Label name_bon;
        private System.Windows.Forms.TextBox text_bon_id;
        private System.Windows.Forms.TextBox text_emp_code;
        private System.Windows.Forms.TextBox text_bon_date;
        private System.Windows.Forms.TextBox text_bon_amount;
        private System.Windows.Forms.TextBox text_name_bon;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}