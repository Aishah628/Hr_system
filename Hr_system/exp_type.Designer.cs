namespace Hr_system
{
    partial class exp_type
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
            this.exp_type_id = new System.Windows.Forms.Label();
            this.exp_type_name = new System.Windows.Forms.Label();
            this.text_exp_type_id = new System.Windows.Forms.TextBox();
            this.text_exp_type_name = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exp_type_id
            // 
            this.exp_type_id.AutoSize = true;
            this.exp_type_id.Location = new System.Drawing.Point(210, 104);
            this.exp_type_id.Name = "exp_type_id";
            this.exp_type_id.Size = new System.Drawing.Size(67, 13);
            this.exp_type_id.TabIndex = 0;
            this.exp_type_id.Text = "exp_type_id";
            // 
            // exp_type_name
            // 
            this.exp_type_name.AutoSize = true;
            this.exp_type_name.Location = new System.Drawing.Point(210, 200);
            this.exp_type_name.Name = "exp_type_name";
            this.exp_type_name.Size = new System.Drawing.Size(85, 13);
            this.exp_type_name.TabIndex = 1;
            this.exp_type_name.Text = "exp_type_name";
            // 
            // text_exp_type_id
            // 
            this.text_exp_type_id.Location = new System.Drawing.Point(330, 101);
            this.text_exp_type_id.Name = "text_exp_type_id";
            this.text_exp_type_id.Size = new System.Drawing.Size(100, 20);
            this.text_exp_type_id.TabIndex = 2;
            // 
            // text_exp_type_name
            // 
            this.text_exp_type_name.Location = new System.Drawing.Point(330, 197);
            this.text_exp_type_name.Name = "text_exp_type_name";
            this.text_exp_type_name.Size = new System.Drawing.Size(100, 20);
            this.text_exp_type_name.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(620, 251);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(620, 175);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(620, 117);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // exp_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_exp_type_name);
            this.Controls.Add(this.text_exp_type_id);
            this.Controls.Add(this.exp_type_name);
            this.Controls.Add(this.exp_type_id);
            this.Name = "exp_type";
            this.Text = "exp_type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exp_type_id;
        private System.Windows.Forms.Label exp_type_name;
        private System.Windows.Forms.TextBox text_exp_type_id;
        private System.Windows.Forms.TextBox text_exp_type_name;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}