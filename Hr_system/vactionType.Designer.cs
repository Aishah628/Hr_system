namespace Hr_system
{
    partial class vactionType
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
            this.vactType_id = new System.Windows.Forms.Label();
            this.vac_name = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.fact_dayFactroy = new System.Windows.Forms.Label();
            this.year_rest = new System.Windows.Forms.Label();
            this.text_vactType_id = new System.Windows.Forms.TextBox();
            this.text_vac_name = new System.Windows.Forms.TextBox();
            this.text_gender = new System.Windows.Forms.TextBox();
            this.text_fact_dayFactroy = new System.Windows.Forms.TextBox();
            this.text_year_rest = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vactType_id
            // 
            this.vactType_id.AutoSize = true;
            this.vactType_id.Location = new System.Drawing.Point(221, 69);
            this.vactType_id.Name = "vactType_id";
            this.vactType_id.Size = new System.Drawing.Size(66, 13);
            this.vactType_id.TabIndex = 0;
            this.vactType_id.Text = "vactType_id";
            // 
            // vac_name
            // 
            this.vac_name.AutoSize = true;
            this.vac_name.Location = new System.Drawing.Point(221, 123);
            this.vac_name.Name = "vac_name";
            this.vac_name.Size = new System.Drawing.Size(56, 13);
            this.vac_name.TabIndex = 1;
            this.vac_name.Text = "vac_name";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(221, 186);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(41, 13);
            this.gender.TabIndex = 2;
            this.gender.Text = "gender";
            // 
            // fact_dayFactroy
            // 
            this.fact_dayFactroy.AutoSize = true;
            this.fact_dayFactroy.Location = new System.Drawing.Point(221, 243);
            this.fact_dayFactroy.Name = "fact_dayFactroy";
            this.fact_dayFactroy.Size = new System.Drawing.Size(87, 13);
            this.fact_dayFactroy.TabIndex = 3;
            this.fact_dayFactroy.Text = "fact_dayFactroy";
            // 
            // year_rest
            // 
            this.year_rest.AutoSize = true;
            this.year_rest.Location = new System.Drawing.Point(221, 301);
            this.year_rest.Name = "year_rest";
            this.year_rest.Size = new System.Drawing.Size(54, 13);
            this.year_rest.TabIndex = 4;
            this.year_rest.Text = "year_rest";
            // 
            // text_vactType_id
            // 
            this.text_vactType_id.Location = new System.Drawing.Point(341, 66);
            this.text_vactType_id.Name = "text_vactType_id";
            this.text_vactType_id.Size = new System.Drawing.Size(100, 20);
            this.text_vactType_id.TabIndex = 5;
            // 
            // text_vac_name
            // 
            this.text_vac_name.Location = new System.Drawing.Point(341, 123);
            this.text_vac_name.Name = "text_vac_name";
            this.text_vac_name.Size = new System.Drawing.Size(100, 20);
            this.text_vac_name.TabIndex = 6;
            // 
            // text_gender
            // 
            this.text_gender.Location = new System.Drawing.Point(341, 183);
            this.text_gender.Name = "text_gender";
            this.text_gender.Size = new System.Drawing.Size(100, 20);
            this.text_gender.TabIndex = 7;
            this.text_gender.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // text_fact_dayFactroy
            // 
            this.text_fact_dayFactroy.Location = new System.Drawing.Point(341, 240);
            this.text_fact_dayFactroy.Name = "text_fact_dayFactroy";
            this.text_fact_dayFactroy.Size = new System.Drawing.Size(100, 20);
            this.text_fact_dayFactroy.TabIndex = 8;
            // 
            // text_year_rest
            // 
            this.text_year_rest.Location = new System.Drawing.Point(341, 298);
            this.text_year_rest.Name = "text_year_rest";
            this.text_year_rest.Size = new System.Drawing.Size(100, 20);
            this.text_year_rest.TabIndex = 9;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(641, 293);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 38;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(641, 217);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 37;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(641, 159);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 36;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // vactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.text_year_rest);
            this.Controls.Add(this.text_fact_dayFactroy);
            this.Controls.Add(this.text_gender);
            this.Controls.Add(this.text_vac_name);
            this.Controls.Add(this.text_vactType_id);
            this.Controls.Add(this.year_rest);
            this.Controls.Add(this.fact_dayFactroy);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.vac_name);
            this.Controls.Add(this.vactType_id);
            this.Name = "vactionType";
            this.Text = "vactionType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vactType_id;
        private System.Windows.Forms.Label vac_name;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label fact_dayFactroy;
        private System.Windows.Forms.Label year_rest;
        private System.Windows.Forms.TextBox text_vactType_id;
        private System.Windows.Forms.TextBox text_vac_name;
        private System.Windows.Forms.TextBox text_gender;
        private System.Windows.Forms.TextBox text_fact_dayFactroy;
        private System.Windows.Forms.TextBox text_year_rest;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}