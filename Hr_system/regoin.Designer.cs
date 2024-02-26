namespace Hr_system
{
    partial class regoin
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
            this.regoin_code = new System.Windows.Forms.Label();
            this.regoin_name = new System.Windows.Forms.Label();
            this.text_regoin_code = new System.Windows.Forms.TextBox();
            this.text_regoin_name = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regoin_code
            // 
            this.regoin_code.AutoSize = true;
            this.regoin_code.Location = new System.Drawing.Point(198, 80);
            this.regoin_code.Name = "regoin_code";
            this.regoin_code.Size = new System.Drawing.Size(66, 13);
            this.regoin_code.TabIndex = 0;
            this.regoin_code.Text = "regoin_code";
            // 
            // regoin_name
            // 
            this.regoin_name.AutoSize = true;
            this.regoin_name.Location = new System.Drawing.Point(198, 180);
            this.regoin_name.Name = "regoin_name";
            this.regoin_name.Size = new System.Drawing.Size(69, 13);
            this.regoin_name.TabIndex = 1;
            this.regoin_name.Text = "regoin_name";
            // 
            // text_regoin_code
            // 
            this.text_regoin_code.Location = new System.Drawing.Point(329, 77);
            this.text_regoin_code.Name = "text_regoin_code";
            this.text_regoin_code.Size = new System.Drawing.Size(100, 20);
            this.text_regoin_code.TabIndex = 2;
            // 
            // text_regoin_name
            // 
            this.text_regoin_name.Location = new System.Drawing.Point(329, 180);
            this.text_regoin_name.Name = "text_regoin_name";
            this.text_regoin_name.Size = new System.Drawing.Size(100, 20);
            this.text_regoin_name.TabIndex = 3;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(628, 304);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 38;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(628, 228);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 37;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(628, 170);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 36;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // regoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_regoin_name);
            this.Controls.Add(this.text_regoin_code);
            this.Controls.Add(this.regoin_name);
            this.Controls.Add(this.regoin_code);
            this.Name = "regoin";
            this.Text = "regoin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regoin_code;
        private System.Windows.Forms.Label regoin_name;
        private System.Windows.Forms.TextBox text_regoin_code;
        private System.Windows.Forms.TextBox text_regoin_name;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}