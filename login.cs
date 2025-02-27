
using ResortManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Resort_Management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBox1.Items.Add ("Resort Owner");
          //  comboBox1.Items.Add("Resort Manager");
           // comboBox1.Items.Add("Restaurant Manager");
          //  comboBox1.Items.Add("Sports-Club Manager");

          //  comboBox1.Items.Clear();


        }
       
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == "Resort Owner")
            {
                if ((username.Text == "o") && (password.Text == "123"))
                {
                    MessageBox.Show("You logged as Resort Owner👨🏻 ");
                    staff st = new staff();
                    st.Show();
                    this.Hide();
                     
                }
                else
                {
                    MessageBox.Show("Incorrect Username And Password..", "Warning for username And Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password.Clear();
                    username.Clear();

                    username.Focus();
                    return;
                }
            }
            if (comboBox1.SelectedItem == "Resort Manager")
            {
                if ((username.Text == "m") && (password.Text == "123"))
                {
                    MessageBox.Show("You logged as Resort Manager👩🏻");
                    restortManager ow = new restortManager();
                    ow.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username And Password..", "Warning for username And Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password.Clear();
                    username.Clear();


                    username.Focus();
                    return;
                }
            }
            if (comboBox1.SelectedItem == "Restaurant Manager")
            {
                if ((username.Text == "resto") && (password.Text == "123"))
                {
                    MessageBox.Show("You logged in as Restaurant Manager 👨🏻‍🍳 ");
                    resto re = new resto();
                    re.Show();
                    
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username And Password..", "Warning for username And Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password.Clear();
                    username.Clear();


                    username.Focus();
                    return;
                }
            }
            if (comboBox1.SelectedItem == "Sports-Club Manager")
            {
                if ((username.Text == "s") && (password.Text == "123"))
                {
                    MessageBox.Show("u loged in as Sports-Club Manager👨🏻‍🎨");
                    sport s = new sport();
                    s.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username And Password..", "Warning for username And Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    password.Clear();
                    username.Clear();


                    username.Focus();
                    return;
                }
            }
        }

    }
    }
    

