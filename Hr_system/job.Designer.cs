namespace Hr_system
{
    partial class job
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
            this.text_job_code = new System.Windows.Forms.TextBox();
            this.text_job_name = new System.Windows.Forms.TextBox();
            this.job_code = new System.Windows.Forms.Label();
            this.job_name = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_job_code
            // 
            this.text_job_code.Location = new System.Drawing.Point(273, 78);
            this.text_job_code.Name = "text_job_code";
            this.text_job_code.Size = new System.Drawing.Size(100, 20);
            this.text_job_code.TabIndex = 0;
            this.text_job_code.Validating += new System.ComponentModel.CancelEventHandler(this.text_job_code_Validating);
            // 
            // text_job_name
            // 
            this.text_job_name.Location = new System.Drawing.Point(273, 173);
            this.text_job_name.Name = "text_job_name";
            this.text_job_name.Size = new System.Drawing.Size(100, 20);
            this.text_job_name.TabIndex = 1;
            // 
            // job_code
            // 
            this.job_code.AutoSize = true;
            this.job_code.Location = new System.Drawing.Point(167, 81);
            this.job_code.Name = "job_code";
            this.job_code.Size = new System.Drawing.Size(51, 13);
            this.job_code.TabIndex = 2;
            this.job_code.Text = "job_code";
            // 
            // job_name
            // 
            this.job_name.AutoSize = true;
            this.job_name.Location = new System.Drawing.Point(167, 176);
            this.job_name.Name = "job_name";
            this.job_name.Size = new System.Drawing.Size(54, 13);
            this.job_name.TabIndex = 3;
            this.job_name.Text = "job_name";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(632, 260);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(632, 184);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(632, 126);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.job_name);
            this.Controls.Add(this.job_code);
            this.Controls.Add(this.text_job_name);
            this.Controls.Add(this.text_job_code);
            this.Name = "job";
            this.Text = "job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_job_code;
        private System.Windows.Forms.TextBox text_job_name;
        private System.Windows.Forms.Label job_code;
        private System.Windows.Forms.Label job_name;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}