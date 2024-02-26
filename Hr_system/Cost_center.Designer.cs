namespace Hr_system
{
    partial class Cost_center
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
            this.text_cost_id = new System.Windows.Forms.TextBox();
            this.cost_id = new System.Windows.Forms.Label();
            this.text_cost_center_name = new System.Windows.Forms.TextBox();
            this.cost_center_name = new System.Windows.Forms.Label();
            this.text_dep_id = new System.Windows.Forms.TextBox();
            this.dep_id = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_cost_id
            // 
            this.text_cost_id.Location = new System.Drawing.Point(300, 57);
            this.text_cost_id.Name = "text_cost_id";
            this.text_cost_id.Size = new System.Drawing.Size(100, 20);
            this.text_cost_id.TabIndex = 0;
            // 
            // cost_id
            // 
            this.cost_id.AutoSize = true;
            this.cost_id.Location = new System.Drawing.Point(183, 60);
            this.cost_id.Name = "cost_id";
            this.cost_id.Size = new System.Drawing.Size(41, 13);
            this.cost_id.TabIndex = 1;
            this.cost_id.Text = "cost_id";
            // 
            // text_cost_center_name
            // 
            this.text_cost_center_name.Location = new System.Drawing.Point(300, 122);
            this.text_cost_center_name.Name = "text_cost_center_name";
            this.text_cost_center_name.Size = new System.Drawing.Size(100, 20);
            this.text_cost_center_name.TabIndex = 2;
            // 
            // cost_center_name
            // 
            this.cost_center_name.AutoSize = true;
            this.cost_center_name.Location = new System.Drawing.Point(183, 125);
            this.cost_center_name.Name = "cost_center_name";
            this.cost_center_name.Size = new System.Drawing.Size(96, 13);
            this.cost_center_name.TabIndex = 3;
            this.cost_center_name.Text = "cost_center_name";
            // 
            // text_dep_id
            // 
            this.text_dep_id.Location = new System.Drawing.Point(300, 191);
            this.text_dep_id.Name = "text_dep_id";
            this.text_dep_id.Size = new System.Drawing.Size(100, 20);
            this.text_dep_id.TabIndex = 4;
            // 
            // dep_id
            // 
            this.dep_id.AutoSize = true;
            this.dep_id.Location = new System.Drawing.Point(183, 194);
            this.dep_id.Name = "dep_id";
            this.dep_id.Size = new System.Drawing.Size(39, 13);
            this.dep_id.TabIndex = 5;
            this.dep_id.Text = "dep_id";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(652, 236);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 35;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(652, 160);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 34;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(652, 102);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 33;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Cost_center
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.dep_id);
            this.Controls.Add(this.text_dep_id);
            this.Controls.Add(this.cost_center_name);
            this.Controls.Add(this.text_cost_center_name);
            this.Controls.Add(this.cost_id);
            this.Controls.Add(this.text_cost_id);
            this.Name = "Cost_center";
            this.Text = "Cost_center";
            this.Load += new System.EventHandler(this.Cost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_cost_id;
        private System.Windows.Forms.Label cost_id;
        private System.Windows.Forms.TextBox text_cost_center_name;
        private System.Windows.Forms.Label cost_center_name;
        private System.Windows.Forms.TextBox text_dep_id;
        private System.Windows.Forms.Label dep_id;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}