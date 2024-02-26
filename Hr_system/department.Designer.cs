namespace Hr_system
{
    partial class department
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
            this.dep_id = new System.Windows.Forms.Label();
            this.dep_name = new System.Windows.Forms.Label();
            this.text_dep_id = new System.Windows.Forms.TextBox();
            this.text_dep_name = new System.Windows.Forms.TextBox();
            this.dep_email = new System.Windows.Forms.Label();
            this.text_dep_email = new System.Windows.Forms.TextBox();
            this.dep_phone = new System.Windows.Forms.Label();
            this.text_dep_phone = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dep_id
            // 
            this.dep_id.AutoSize = true;
            this.dep_id.Location = new System.Drawing.Point(265, 71);
            this.dep_id.Name = "dep_id";
            this.dep_id.Size = new System.Drawing.Size(39, 13);
            this.dep_id.TabIndex = 0;
            this.dep_id.Text = "dep_id";
            // 
            // dep_name
            // 
            this.dep_name.AutoSize = true;
            this.dep_name.Location = new System.Drawing.Point(263, 117);
            this.dep_name.Name = "dep_name";
            this.dep_name.Size = new System.Drawing.Size(57, 13);
            this.dep_name.TabIndex = 1;
            this.dep_name.Text = "dep_name";
            // 
            // text_dep_id
            // 
            this.text_dep_id.Location = new System.Drawing.Point(360, 64);
            this.text_dep_id.Name = "text_dep_id";
            this.text_dep_id.Size = new System.Drawing.Size(100, 20);
            this.text_dep_id.TabIndex = 2;
            // 
            // text_dep_name
            // 
            this.text_dep_name.Location = new System.Drawing.Point(360, 114);
            this.text_dep_name.Name = "text_dep_name";
            this.text_dep_name.Size = new System.Drawing.Size(100, 20);
            this.text_dep_name.TabIndex = 3;
            // 
            // dep_email
            // 
            this.dep_email.AutoSize = true;
            this.dep_email.Location = new System.Drawing.Point(265, 172);
            this.dep_email.Name = "dep_email";
            this.dep_email.Size = new System.Drawing.Size(55, 13);
            this.dep_email.TabIndex = 4;
            this.dep_email.Text = "dep_email";
            // 
            // text_dep_email
            // 
            this.text_dep_email.Location = new System.Drawing.Point(360, 165);
            this.text_dep_email.Name = "text_dep_email";
            this.text_dep_email.Size = new System.Drawing.Size(100, 20);
            this.text_dep_email.TabIndex = 5;
            // 
            // dep_phone
            // 
            this.dep_phone.AutoSize = true;
            this.dep_phone.Location = new System.Drawing.Point(259, 222);
            this.dep_phone.Name = "dep_phone";
            this.dep_phone.Size = new System.Drawing.Size(61, 13);
            this.dep_phone.TabIndex = 6;
            this.dep_phone.Text = "dep_phone";
            // 
            // text_dep_phone
            // 
            this.text_dep_phone.Location = new System.Drawing.Point(360, 219);
            this.text_dep_phone.Name = "text_dep_phone";
            this.text_dep_phone.Size = new System.Drawing.Size(100, 20);
            this.text_dep_phone.TabIndex = 7;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(643, 241);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(643, 165);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(643, 107);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            this.insert.Validating += new System.ComponentModel.CancelEventHandler(this.insert_Validating);
            // 
            // department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_dep_phone);
            this.Controls.Add(this.dep_phone);
            this.Controls.Add(this.text_dep_email);
            this.Controls.Add(this.dep_email);
            this.Controls.Add(this.text_dep_name);
            this.Controls.Add(this.text_dep_id);
            this.Controls.Add(this.dep_name);
            this.Controls.Add(this.dep_id);
            this.MaximizeBox = false;
            this.Name = "department";
            this.Text = "department";
            this.Load += new System.EventHandler(this.department_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dep_id;
        private System.Windows.Forms.Label dep_name;
        private System.Windows.Forms.TextBox text_dep_id;
        private System.Windows.Forms.TextBox text_dep_name;
        private System.Windows.Forms.Label dep_email;
        private System.Windows.Forms.TextBox text_dep_email;
        private System.Windows.Forms.Label dep_phone;
        private System.Windows.Forms.TextBox text_dep_phone;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}