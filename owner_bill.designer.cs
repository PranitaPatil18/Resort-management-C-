
namespace Resort_Management
{
    partial class owner_report
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
            this.individual_report = new System.Windows.Forms.Panel();
            this.group_report = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.individual_report.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.individual_report);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(82, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 475);
            this.panel1.TabIndex = 32;
            // 
            // individual_report
            // 
            this.individual_report.BackColor = System.Drawing.Color.PaleTurquoise;
            this.individual_report.Controls.Add(this.group_report);
            this.individual_report.Controls.Add(this.button2);
            this.individual_report.Controls.Add(this.Name_textbox);
            this.individual_report.Controls.Add(this.label2);
            this.individual_report.Location = new System.Drawing.Point(66, 66);
            this.individual_report.Margin = new System.Windows.Forms.Padding(2);
            this.individual_report.Name = "individual_report";
            this.individual_report.Size = new System.Drawing.Size(685, 283);
            this.individual_report.TabIndex = 0;
            // 
            // group_report
            // 
            this.group_report.Location = new System.Drawing.Point(0, 0);
            this.group_report.Margin = new System.Windows.Forms.Padding(2);
            this.group_report.Name = "group_report";
            this.group_report.Size = new System.Drawing.Size(41, 279);
            this.group_report.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(253, 150);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 48);
            this.button2.TabIndex = 35;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(342, 45);
            this.Name_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Name_textbox.Multiline = true;
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(204, 23);
            this.Name_textbox.TabIndex = 21;
          //  this.Name_textbox.TextChanged += new System.EventHandler(this.Name_textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(253, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(339, 433);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "⬅Go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(457, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 37);
            this.label14.TabIndex = 28;
            this.label14.Text = "Group";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(295, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 37);
            this.label10.TabIndex = 27;
            this.label10.Text = "Individual";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // owner_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 487);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "owner_report";
            this.Text = "owner_bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.owner_report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.individual_report.ResumeLayout(false);
            this.individual_report.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel group_report;
       // private System.Windows.Forms.Panel individual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel individual_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Name_textbox;
    }
}