namespace Hr_system
{
    partial class attendance
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
            this.attendance_id = new System.Windows.Forms.Label();
            this.emp_code = new System.Windows.Forms.Label();
            this.att_dateTime = new System.Windows.Forms.Label();
            this.in_out = new System.Windows.Forms.Label();
            this.machine = new System.Windows.Forms.Label();
            this.verify = new System.Windows.Forms.Label();
            this.dateUpdate = new System.Windows.Forms.Label();
            this.approved = new System.Windows.Forms.Label();
            this.text_attendance_id = new System.Windows.Forms.TextBox();
            this.text_emp_code = new System.Windows.Forms.TextBox();
            this.text_att_dateTime = new System.Windows.Forms.TextBox();
            this.text_in_out = new System.Windows.Forms.TextBox();
            this.text_machine = new System.Windows.Forms.TextBox();
            this.text_verify = new System.Windows.Forms.TextBox();
            this.text_dateUpdate = new System.Windows.Forms.TextBox();
            this.text_approved = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attendance_id
            // 
            this.attendance_id.AutoSize = true;
            this.attendance_id.Location = new System.Drawing.Point(218, 67);
            this.attendance_id.Name = "attendance_id";
            this.attendance_id.Size = new System.Drawing.Size(76, 13);
            this.attendance_id.TabIndex = 0;
            this.attendance_id.Text = "attendance_id";
            // 
            // emp_code
            // 
            this.emp_code.AutoSize = true;
            this.emp_code.Location = new System.Drawing.Point(218, 123);
            this.emp_code.Name = "emp_code";
            this.emp_code.Size = new System.Drawing.Size(59, 13);
            this.emp_code.TabIndex = 1;
            this.emp_code.Text = " emp_code";
            // 
            // att_dateTime
            // 
            this.att_dateTime.AutoSize = true;
            this.att_dateTime.Location = new System.Drawing.Point(218, 182);
            this.att_dateTime.Name = "att_dateTime";
            this.att_dateTime.Size = new System.Drawing.Size(71, 13);
            this.att_dateTime.TabIndex = 2;
            this.att_dateTime.Text = "att_dateTime";
            // 
            // in_out
            // 
            this.in_out.AutoSize = true;
            this.in_out.Location = new System.Drawing.Point(218, 243);
            this.in_out.Name = "in_out";
            this.in_out.Size = new System.Drawing.Size(37, 13);
            this.in_out.TabIndex = 3;
            this.in_out.Text = "in_out";
            this.in_out.Click += new System.EventHandler(this.label4_Click);
            // 
            // machine
            // 
            this.machine.AutoSize = true;
            this.machine.Location = new System.Drawing.Point(510, 67);
            this.machine.Name = "machine";
            this.machine.Size = new System.Drawing.Size(46, 13);
            this.machine.TabIndex = 4;
            this.machine.Text = "machine";
            // 
            // verify
            // 
            this.verify.AutoSize = true;
            this.verify.Location = new System.Drawing.Point(510, 123);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(35, 13);
            this.verify.TabIndex = 5;
            this.verify.Text = "verify";
            // 
            // dateUpdate
            // 
            this.dateUpdate.AutoSize = true;
            this.dateUpdate.Location = new System.Drawing.Point(510, 182);
            this.dateUpdate.Name = "dateUpdate";
            this.dateUpdate.Size = new System.Drawing.Size(64, 13);
            this.dateUpdate.TabIndex = 6;
            this.dateUpdate.Text = "dateUpdate";
            // 
            // approved
            // 
            this.approved.AutoSize = true;
            this.approved.Location = new System.Drawing.Point(510, 243);
            this.approved.Name = "approved";
            this.approved.Size = new System.Drawing.Size(53, 13);
            this.approved.TabIndex = 7;
            this.approved.Text = "approved";
            // 
            // text_attendance_id
            // 
            this.text_attendance_id.Location = new System.Drawing.Point(295, 60);
            this.text_attendance_id.Name = "text_attendance_id";
            this.text_attendance_id.Size = new System.Drawing.Size(100, 20);
            this.text_attendance_id.TabIndex = 8;
            // 
            // text_emp_code
            // 
            this.text_emp_code.Location = new System.Drawing.Point(295, 120);
            this.text_emp_code.Name = "text_emp_code";
            this.text_emp_code.Size = new System.Drawing.Size(100, 20);
            this.text_emp_code.TabIndex = 9;
            this.text_emp_code.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // text_att_dateTime
            // 
            this.text_att_dateTime.Location = new System.Drawing.Point(295, 179);
            this.text_att_dateTime.Name = "text_att_dateTime";
            this.text_att_dateTime.Size = new System.Drawing.Size(100, 20);
            this.text_att_dateTime.TabIndex = 10;
            // 
            // text_in_out
            // 
            this.text_in_out.Location = new System.Drawing.Point(295, 240);
            this.text_in_out.Name = "text_in_out";
            this.text_in_out.Size = new System.Drawing.Size(100, 20);
            this.text_in_out.TabIndex = 11;
            // 
            // text_machine
            // 
            this.text_machine.Location = new System.Drawing.Point(580, 60);
            this.text_machine.Name = "text_machine";
            this.text_machine.Size = new System.Drawing.Size(100, 20);
            this.text_machine.TabIndex = 12;
            // 
            // text_verify
            // 
            this.text_verify.Location = new System.Drawing.Point(580, 123);
            this.text_verify.Name = "text_verify";
            this.text_verify.Size = new System.Drawing.Size(100, 20);
            this.text_verify.TabIndex = 13;
            // 
            // text_dateUpdate
            // 
            this.text_dateUpdate.Location = new System.Drawing.Point(580, 182);
            this.text_dateUpdate.Name = "text_dateUpdate";
            this.text_dateUpdate.Size = new System.Drawing.Size(100, 20);
            this.text_dateUpdate.TabIndex = 14;
            // 
            // text_approved
            // 
            this.text_approved.Location = new System.Drawing.Point(580, 243);
            this.text_approved.Name = "text_approved";
            this.text_approved.Size = new System.Drawing.Size(100, 20);
            this.text_approved.TabIndex = 15;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(531, 281);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(360, 281);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(180, 281);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            this.insert.Validating += new System.ComponentModel.CancelEventHandler(this.insert_Validating);
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_approved);
            this.Controls.Add(this.text_dateUpdate);
            this.Controls.Add(this.text_verify);
            this.Controls.Add(this.text_machine);
            this.Controls.Add(this.text_in_out);
            this.Controls.Add(this.text_att_dateTime);
            this.Controls.Add(this.text_emp_code);
            this.Controls.Add(this.text_attendance_id);
            this.Controls.Add(this.approved);
            this.Controls.Add(this.dateUpdate);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.machine);
            this.Controls.Add(this.in_out);
            this.Controls.Add(this.att_dateTime);
            this.Controls.Add(this.emp_code);
            this.Controls.Add(this.attendance_id);
            this.Name = "attendance";
            this.Text = "attendance";
            this.Load += new System.EventHandler(this.attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label attendance_id;
        private System.Windows.Forms.Label emp_code;
        private System.Windows.Forms.Label att_dateTime;
        private System.Windows.Forms.Label in_out;
        private System.Windows.Forms.Label machine;
        private System.Windows.Forms.Label verify;
        private System.Windows.Forms.Label dateUpdate;
        private System.Windows.Forms.Label approved;
        private System.Windows.Forms.TextBox text_attendance_id;
        private System.Windows.Forms.TextBox text_emp_code;
        private System.Windows.Forms.TextBox text_att_dateTime;
        private System.Windows.Forms.TextBox text_in_out;
        private System.Windows.Forms.TextBox text_machine;
        private System.Windows.Forms.TextBox text_verify;
        private System.Windows.Forms.TextBox text_dateUpdate;
        private System.Windows.Forms.TextBox text_approved;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}