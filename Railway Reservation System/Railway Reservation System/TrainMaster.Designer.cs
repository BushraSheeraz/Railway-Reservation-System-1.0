
namespace Railway_Reservation_System
{
    partial class TrainMaster
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tr = new System.Windows.Forms.Label();
            this.trnnametb = new System.Windows.Forms.TextBox();
            this.trncapacitytb = new System.Windows.Forms.TextBox();
            this.busyradiobutton = new System.Windows.Forms.RadioButton();
            this.Availableradiobutton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TrainDataGridView = new System.Windows.Forms.DataGridView();
            this.Resettravelmstrbtn = new System.Windows.Forms.Button();
            this.Deletetravelmstrbtn = new System.Windows.Forms.Button();
            this.EditTravelmstrbtn = new System.Windows.Forms.Button();
            this.Addtravelmstrbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 82);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(772, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(304, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pakistan Railways";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(274, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Train Master";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Railway_Reservation_System.Properties.Resources.download__2_;
            this.pictureBox1.Location = new System.Drawing.Point(398, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(122, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Train Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(306, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Train Capacity";
            // 
            // tr
            // 
            this.tr.AutoSize = true;
            this.tr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tr.Location = new System.Drawing.Point(494, 167);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(112, 22);
            this.tr.TabIndex = 5;
            this.tr.Text = "Train Status";
            // 
            // trnnametb
            // 
            this.trnnametb.Location = new System.Drawing.Point(126, 202);
            this.trnnametb.Name = "trnnametb";
            this.trnnametb.Size = new System.Drawing.Size(109, 20);
            this.trnnametb.TabIndex = 6;
            // 
            // trncapacitytb
            // 
            this.trncapacitytb.Location = new System.Drawing.Point(310, 202);
            this.trncapacitytb.Name = "trncapacitytb";
            this.trncapacitytb.Size = new System.Drawing.Size(140, 20);
            this.trncapacitytb.TabIndex = 7;
            this.trncapacitytb.TextChanged += new System.EventHandler(this.trncapacitytb_TextChanged);
            // 
            // busyradiobutton
            // 
            this.busyradiobutton.AutoSize = true;
            this.busyradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busyradiobutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.busyradiobutton.Location = new System.Drawing.Point(508, 204);
            this.busyradiobutton.Name = "busyradiobutton";
            this.busyradiobutton.Size = new System.Drawing.Size(51, 19);
            this.busyradiobutton.TabIndex = 8;
            this.busyradiobutton.TabStop = true;
            this.busyradiobutton.Text = "Busy";
            this.busyradiobutton.UseVisualStyleBackColor = true;
            // 
            // Availableradiobutton
            // 
            this.Availableradiobutton.AutoSize = true;
            this.Availableradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availableradiobutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Availableradiobutton.Location = new System.Drawing.Point(588, 203);
            this.Availableradiobutton.Name = "Availableradiobutton";
            this.Availableradiobutton.Size = new System.Drawing.Size(74, 19);
            this.Availableradiobutton.TabIndex = 9;
            this.Availableradiobutton.TabStop = true;
            this.Availableradiobutton.Text = "Available";
            this.Availableradiobutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(332, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Train List";
            // 
            // TrainDataGridView
            // 
            this.TrainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainDataGridView.Location = new System.Drawing.Point(96, 294);
            this.TrainDataGridView.Name = "TrainDataGridView";
            this.TrainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrainDataGridView.Size = new System.Drawing.Size(623, 147);
            this.TrainDataGridView.TabIndex = 11;
            this.TrainDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainDataGridView_CellContentClick);
            // 
            // Resettravelmstrbtn
            // 
            this.Resettravelmstrbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Resettravelmstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resettravelmstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resettravelmstrbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Resettravelmstrbtn.Location = new System.Drawing.Point(489, 240);
            this.Resettravelmstrbtn.Name = "Resettravelmstrbtn";
            this.Resettravelmstrbtn.Size = new System.Drawing.Size(88, 28);
            this.Resettravelmstrbtn.TabIndex = 35;
            this.Resettravelmstrbtn.Text = "Reset";
            this.Resettravelmstrbtn.UseVisualStyleBackColor = false;
            this.Resettravelmstrbtn.Click += new System.EventHandler(this.Resettravelmstrbtn_Click);
            // 
            // Deletetravelmstrbtn
            // 
            this.Deletetravelmstrbtn.BackColor = System.Drawing.Color.Red;
            this.Deletetravelmstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletetravelmstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletetravelmstrbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Deletetravelmstrbtn.Location = new System.Drawing.Point(398, 240);
            this.Deletetravelmstrbtn.Name = "Deletetravelmstrbtn";
            this.Deletetravelmstrbtn.Size = new System.Drawing.Size(88, 28);
            this.Deletetravelmstrbtn.TabIndex = 34;
            this.Deletetravelmstrbtn.Text = "Delete";
            this.Deletetravelmstrbtn.UseVisualStyleBackColor = false;
            this.Deletetravelmstrbtn.Click += new System.EventHandler(this.Deletetravelmstrbtn_Click);
            // 
            // EditTravelmstrbtn
            // 
            this.EditTravelmstrbtn.BackColor = System.Drawing.Color.Green;
            this.EditTravelmstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTravelmstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTravelmstrbtn.ForeColor = System.Drawing.Color.White;
            this.EditTravelmstrbtn.Location = new System.Drawing.Point(305, 240);
            this.EditTravelmstrbtn.Name = "EditTravelmstrbtn";
            this.EditTravelmstrbtn.Size = new System.Drawing.Size(88, 28);
            this.EditTravelmstrbtn.TabIndex = 33;
            this.EditTravelmstrbtn.Text = "Edit";
            this.EditTravelmstrbtn.UseVisualStyleBackColor = false;
            this.EditTravelmstrbtn.Click += new System.EventHandler(this.EditTravelmstrbtn_Click);
            // 
            // Addtravelmstrbtn
            // 
            this.Addtravelmstrbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Addtravelmstrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addtravelmstrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addtravelmstrbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Addtravelmstrbtn.Location = new System.Drawing.Point(215, 240);
            this.Addtravelmstrbtn.Name = "Addtravelmstrbtn";
            this.Addtravelmstrbtn.Size = new System.Drawing.Size(88, 28);
            this.Addtravelmstrbtn.TabIndex = 32;
            this.Addtravelmstrbtn.Text = "Add";
            this.Addtravelmstrbtn.UseVisualStyleBackColor = false;
            this.Addtravelmstrbtn.Click += new System.EventHandler(this.Addtravelmstrbtn_Click);
            // 
            // TrainMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resettravelmstrbtn);
            this.Controls.Add(this.Deletetravelmstrbtn);
            this.Controls.Add(this.EditTravelmstrbtn);
            this.Controls.Add(this.Addtravelmstrbtn);
            this.Controls.Add(this.TrainDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Availableradiobutton);
            this.Controls.Add(this.busyradiobutton);
            this.Controls.Add(this.trncapacitytb);
            this.Controls.Add(this.trnnametb);
            this.Controls.Add(this.tr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "TrainMaster";
            this.Text = "TrainMaster";
            this.Load += new System.EventHandler(this.TrainMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tr;
        private System.Windows.Forms.TextBox trnnametb;
        private System.Windows.Forms.TextBox trncapacitytb;
        private System.Windows.Forms.RadioButton busyradiobutton;
        private System.Windows.Forms.RadioButton Availableradiobutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TrainDataGridView;
        private System.Windows.Forms.Button Resettravelmstrbtn;
        private System.Windows.Forms.Button Deletetravelmstrbtn;
        private System.Windows.Forms.Button EditTravelmstrbtn;
        private System.Windows.Forms.Button Addtravelmstrbtn;
        private System.Windows.Forms.Label label5;
    }
}