namespace Hr_system
{
    partial class emp_state
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
            this.emp_state_id = new System.Windows.Forms.Label();
            this.emp_state_name = new System.Windows.Forms.Label();
            this.text_emp_state_id = new System.Windows.Forms.TextBox();
            this.text_emp_state_name = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emp_state_id
            // 
            this.emp_state_id.AutoSize = true;
            this.emp_state_id.Location = new System.Drawing.Point(205, 87);
            this.emp_state_id.Name = "emp_state_id";
            this.emp_state_id.Size = new System.Drawing.Size(72, 13);
            this.emp_state_id.TabIndex = 0;
            this.emp_state_id.Text = "emp_state_id";
            // 
            // emp_state_name
            // 
            this.emp_state_name.AutoSize = true;
            this.emp_state_name.Location = new System.Drawing.Point(205, 175);
            this.emp_state_name.Name = "emp_state_name";
            this.emp_state_name.Size = new System.Drawing.Size(90, 13);
            this.emp_state_name.TabIndex = 1;
            this.emp_state_name.Text = "emp_state_name";
            // 
            // text_emp_state_id
            // 
            this.text_emp_state_id.Location = new System.Drawing.Point(353, 87);
            this.text_emp_state_id.Name = "text_emp_state_id";
            this.text_emp_state_id.Size = new System.Drawing.Size(100, 20);
            this.text_emp_state_id.TabIndex = 2;
            // 
            // text_emp_state_name
            // 
            this.text_emp_state_name.Location = new System.Drawing.Point(353, 175);
            this.text_emp_state_name.Name = "text_emp_state_name";
            this.text_emp_state_name.Size = new System.Drawing.Size(100, 20);
            this.text_emp_state_name.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(653, 245);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(653, 169);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(653, 111);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // emp_state
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_emp_state_name);
            this.Controls.Add(this.text_emp_state_id);
            this.Controls.Add(this.emp_state_name);
            this.Controls.Add(this.emp_state_id);
            this.Name = "emp_state";
            this.Text = "emp_state";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emp_state_id;
        private System.Windows.Forms.Label emp_state_name;
        private System.Windows.Forms.TextBox text_emp_state_id;
        private System.Windows.Forms.TextBox text_emp_state_name;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}