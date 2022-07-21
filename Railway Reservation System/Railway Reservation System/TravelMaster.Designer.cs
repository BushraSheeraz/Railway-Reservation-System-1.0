
namespace Railway_Reservation_System
{
    partial class TravelMaster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Source = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Destination = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TravelCost = new System.Windows.Forms.TextBox();
            this.Addtravelmstrbtn = new System.Windows.Forms.Button();
            this.EditTravelmstrbtn = new System.Windows.Forms.Button();
            this.Deletetravelmstrbtn = new System.Windows.Forms.Button();
            this.Resettravelmstrbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.backtravelbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TCode = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(374, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pakistan Railways";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Travel Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(221, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Train Code";
            // 
            // Source
            // 
            this.Source.FormattingEnabled = true;
            this.Source.Items.AddRange(new object[] {
            "Karachi",
            "Sukkur",
            "Hyderabad ",
            "Larkana",
            "Multan",
            "Dera Ghazi Khan",
            "Bhawalpur",
            "Lahore",
            "Quetta ",
            "Islamabad",
            "Rawalpindi"});
            this.Source.Location = new System.Drawing.Point(362, 156);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(101, 21);
            this.Source.TabIndex = 21;
            this.Source.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(358, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Source";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(494, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Destination";
            // 
            // Destination
            // 
            this.Destination.FormattingEnabled = true;
            this.Destination.Items.AddRange(new object[] {
            "Karachi",
            "Sukkur",
            "Hyderabad ",
            "Larkana",
            "Multan",
            "Dera Ghazi Khan",
            "Bhawalpur",
            "Lahore",
            "Quetta ",
            "Islamabad",
            "Rawalpindi"});
            this.Destination.Location = new System.Drawing.Point(498, 156);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(114, 21);
            this.Destination.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(653, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Travel Cost";
            // 
            // TravelCost
            // 
            this.TravelCost.Location = new System.Drawing.Point(657, 158);
            this.TravelCost.Name = "TravelCost";
            this.TravelCost.Size = new System.Drawing.Size(119, 20);
            this.TravelCost.TabIndex = 27;
            // 
            // Addtravelmstrbtn
            // 
            this.Addtravelmstrbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Addtravelmstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addtravelmstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addtravelmstrbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Addtravelmstrbtn.Location = new System.Drawing.Point(245, 204);
            this.Addtravelmstrbtn.Name = "Addtravelmstrbtn";
            this.Addtravelmstrbtn.Size = new System.Drawing.Size(75, 28);
            this.Addtravelmstrbtn.TabIndex = 28;
            this.Addtravelmstrbtn.Text = "Add";
            this.Addtravelmstrbtn.UseVisualStyleBackColor = false;
            this.Addtravelmstrbtn.Click += new System.EventHandler(this.Addtravelmstrbtn_Click);
            // 
            // EditTravelmstrbtn
            // 
            this.EditTravelmstrbtn.BackColor = System.Drawing.Color.Green;
            this.EditTravelmstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTravelmstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTravelmstrbtn.ForeColor = System.Drawing.Color.White;
            this.EditTravelmstrbtn.Location = new System.Drawing.Point(335, 204);
            this.EditTravelmstrbtn.Name = "EditTravelmstrbtn";
            this.EditTravelmstrbtn.Size = new System.Drawing.Size(75, 28);
            this.EditTravelmstrbtn.TabIndex = 29;
            this.EditTravelmstrbtn.Text = "Edit";
            this.EditTravelmstrbtn.UseVisualStyleBackColor = false;
            this.EditTravelmstrbtn.Click += new System.EventHandler(this.EditTravelmstrbtn_Click);
            // 
            // Deletetravelmstrbtn
            // 
            this.Deletetravelmstrbtn.BackColor = System.Drawing.Color.Red;
            this.Deletetravelmstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletetravelmstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletetravelmstrbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Deletetravelmstrbtn.Location = new System.Drawing.Point(428, 204);
            this.Deletetravelmstrbtn.Name = "Deletetravelmstrbtn";
            this.Deletetravelmstrbtn.Size = new System.Drawing.Size(75, 28);
            this.Deletetravelmstrbtn.TabIndex = 30;
            this.Deletetravelmstrbtn.Text = "Delete";
            this.Deletetravelmstrbtn.UseVisualStyleBackColor = false;
            // 
            // Resettravelmstrbtn
            // 
            this.Resettravelmstrbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Resettravelmstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resettravelmstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resettravelmstrbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Resettravelmstrbtn.Location = new System.Drawing.Point(519, 204);
            this.Resettravelmstrbtn.Name = "Resettravelmstrbtn";
            this.Resettravelmstrbtn.Size = new System.Drawing.Size(75, 28);
            this.Resettravelmstrbtn.TabIndex = 31;
            this.Resettravelmstrbtn.Text = "Reset";
            this.Resettravelmstrbtn.UseVisualStyleBackColor = false;
            this.Resettravelmstrbtn.Click += new System.EventHandler(this.Resettravelmstrbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(384, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Travel";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // backtravelbtn
            // 
            this.backtravelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.backtravelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backtravelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtravelbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backtravelbtn.Location = new System.Drawing.Point(388, 454);
            this.backtravelbtn.Name = "backtravelbtn";
            this.backtravelbtn.Size = new System.Drawing.Size(75, 29);
            this.backtravelbtn.TabIndex = 34;
            this.backtravelbtn.Text = "Back";
            this.backtravelbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Railway_Reservation_System.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(437, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 150);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // TCode
            // 
            this.TCode.FormattingEnabled = true;
            this.TCode.Items.AddRange(new object[] {
            "Karachi",
            "Sukkur",
            "Hyderabad ",
            "Larkana",
            "Multan",
            "Dera Ghazi Khan",
            "Bhawalpur",
            "Lahore",
            "Quetta ",
            "Islamabad",
            "Rawalpindi"});
            this.TCode.Location = new System.Drawing.Point(225, 156);
            this.TCode.Name = "TCode";
            this.TCode.Size = new System.Drawing.Size(101, 21);
            this.TCode.TabIndex = 37;
            // 
            // TravelMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 549);
            this.Controls.Add(this.TCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backtravelbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Resettravelmstrbtn);
            this.Controls.Add(this.Deletetravelmstrbtn);
            this.Controls.Add(this.EditTravelmstrbtn);
            this.Controls.Add(this.Addtravelmstrbtn);
            this.Controls.Add(this.TravelCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "TravelMaster";
            this.Text = "TravelMaster";
            this.Load += new System.EventHandler(this.TravelMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Source;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Destination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TravelCost;
        private System.Windows.Forms.Button Addtravelmstrbtn;
        private System.Windows.Forms.Button EditTravelmstrbtn;
        private System.Windows.Forms.Button Deletetravelmstrbtn;
        private System.Windows.Forms.Button Resettravelmstrbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backtravelbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TCode;
    }
}