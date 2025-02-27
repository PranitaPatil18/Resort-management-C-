
namespace Resort_Management
{
    partial class owner
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
            this.components = new System.ComponentModel.Container();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.qty_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.resource_panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.srno = new System.Windows.Forms.Label();
            this.SrNo_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.resource_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(207, 140);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(204, 23);
            this.name_textbox.TabIndex = 11;
            this.name_textbox.TextChanged += new System.EventHandler(this.restextbox_name_TextChanged);
            // 
            // qty_textbox
            // 
            this.qty_textbox.Location = new System.Drawing.Point(207, 192);
            this.qty_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.qty_textbox.Multiline = true;
            this.qty_textbox.Name = "qty_textbox";
            this.qty_textbox.Size = new System.Drawing.Size(204, 23);
            this.qty_textbox.TabIndex = 12;
            this.qty_textbox.TextChanged += new System.EventHandler(this.qty_textbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(111, 140);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(79, 192);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 28);
            this.label12.TabIndex = 16;
            this.label12.Text = "Quantity";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(263, 282);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 32);
            this.button6.TabIndex = 17;
            this.button6.Text = "❌Delete";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(192, 339);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 32);
            this.button7.TabIndex = 18;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Save.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Save.Location = new System.Drawing.Point(111, 282);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(123, 32);
            this.Save.TabIndex = 20;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(640, 458);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(121, 32);
            this.button10.TabIndex = 21;
            this.button10.Text = "Show Pdf ";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(478, 95);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(332, 352);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(314, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 37);
            this.label13.TabIndex = 27;
            this.label13.Text = "Manage Resources";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // resource_panel
            // 
            this.resource_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resource_panel.Controls.Add(this.button2);
            this.resource_panel.Controls.Add(this.srno);
            this.resource_panel.Controls.Add(this.SrNo_textbox);
            this.resource_panel.Controls.Add(this.button1);
            this.resource_panel.Controls.Add(this.label13);
            this.resource_panel.Controls.Add(this.dataGridView2);
            this.resource_panel.Controls.Add(this.button10);
            this.resource_panel.Controls.Add(this.Save);
            this.resource_panel.Controls.Add(this.button7);
            this.resource_panel.Controls.Add(this.button6);
            this.resource_panel.Controls.Add(this.label12);
            this.resource_panel.Controls.Add(this.label9);
            this.resource_panel.Controls.Add(this.qty_textbox);
            this.resource_panel.Controls.Add(this.name_textbox);
            this.resource_panel.Location = new System.Drawing.Point(107, 8);
            this.resource_panel.Margin = new System.Windows.Forms.Padding(2);
            this.resource_panel.Name = "resource_panel";
            this.resource_panel.Size = new System.Drawing.Size(891, 529);
            this.resource_panel.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(478, 458);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 32);
            this.button2.TabIndex = 31;
            this.button2.Text = "Show Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // srno
            // 
            this.srno.AutoSize = true;
            this.srno.BackColor = System.Drawing.Color.Transparent;
            this.srno.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.srno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.srno.Location = new System.Drawing.Point(88, 95);
            this.srno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.srno.Name = "srno";
            this.srno.Size = new System.Drawing.Size(93, 28);
            this.srno.TabIndex = 30;
            this.srno.Text = "Item No";
            // 
            // SrNo_textbox
            // 
            this.SrNo_textbox.Location = new System.Drawing.Point(207, 95);
            this.SrNo_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.SrNo_textbox.Multiline = true;
            this.SrNo_textbox.Name = "SrNo_textbox";
            this.SrNo_textbox.Size = new System.Drawing.Size(204, 23);
            this.SrNo_textbox.TabIndex = 29;
            this.SrNo_textbox.TextChanged += new System.EventHandler(this.SrNo_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(192, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "⬅Go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ResortManagement.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(957, 640);
            this.Controls.Add(this.resource_panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "owner";
            this.Text = "owner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.owner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.resource_panel.ResumeLayout(false);
            this.resource_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox restextbox_quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel resource_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label srno;
        private System.Windows.Forms.TextBox SrNo_textbox;
        private System.Windows.Forms.TextBox qty_textbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
    }
}