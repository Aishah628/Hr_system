namespace Hr_system
{
    partial class nationality
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
            this.net_code = new System.Windows.Forms.Label();
            this.net_name = new System.Windows.Forms.Label();
            this.text_net_code = new System.Windows.Forms.TextBox();
            this.text_net_name = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // net_code
            // 
            this.net_code.AutoSize = true;
            this.net_code.Location = new System.Drawing.Point(261, 104);
            this.net_code.Name = "net_code";
            this.net_code.Size = new System.Drawing.Size(52, 13);
            this.net_code.TabIndex = 0;
            this.net_code.Text = "net_code";
            // 
            // net_name
            // 
            this.net_name.AutoSize = true;
            this.net_name.Location = new System.Drawing.Point(261, 172);
            this.net_name.Name = "net_name";
            this.net_name.Size = new System.Drawing.Size(55, 13);
            this.net_name.TabIndex = 1;
            this.net_name.Text = "net_name";
            // 
            // text_net_code
            // 
            this.text_net_code.Location = new System.Drawing.Point(344, 101);
            this.text_net_code.Name = "text_net_code";
            this.text_net_code.Size = new System.Drawing.Size(100, 20);
            this.text_net_code.TabIndex = 2;
            // 
            // text_net_name
            // 
            this.text_net_name.Location = new System.Drawing.Point(344, 172);
            this.text_net_name.Name = "text_net_name";
            this.text_net_name.Size = new System.Drawing.Size(100, 20);
            this.text_net_name.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(625, 253);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(625, 177);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(625, 119);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click_1);
            this.insert.Validating += new System.ComponentModel.CancelEventHandler(this.insert_Validating);
            // 
            // nationality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_net_name);
            this.Controls.Add(this.text_net_code);
            this.Controls.Add(this.net_name);
            this.Controls.Add(this.net_code);
            this.Name = "nationality";
            this.Text = "nationality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label net_code;
        private System.Windows.Forms.Label net_name;
        private System.Windows.Forms.TextBox text_net_code;
        private System.Windows.Forms.TextBox text_net_name;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}