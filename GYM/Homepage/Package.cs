using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Step 1
using System.Data.SqlClient;

namespace Homepage
{
    public partial class Package : Form
    {
        public Package()
        {
            InitializeComponent();
        }




        private void textBox_decription_Leave(object sender, EventArgs e)
        {
            {
                if (textBox_decription.Text == "")
                {
                    label_error_descrip.Visible = true;
                }
                else
                {
                    label_error_descrip.Visible = false;
                }
            }
        }



        private void textBox_price_Leave(object sender, EventArgs e)
        {
            if (textBox_price.Text == "")
            {
                label_error_price.Visible = true;
            }
            else
            {
                label_error_price.Visible = false;
            }
        }

        private void textBox_price_KeyDown(object sender, KeyEventArgs e)
        {
            //start alphabets restriction
            if (e.KeyCode == Keys.Q)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.W)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.E)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.R)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.T)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Y)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.U)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.I)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.O)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.P)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.D)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.G)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.H)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.J)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.K)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.L)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Z)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.X)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.C)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.B)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.N)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.M)
            {
                e.SuppressKeyPress = true;
            }
            //end alphabets restriction

            //start special keys restriction

            if (e.KeyCode == Keys.OemMinus)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Subtract)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Add)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Divide)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.OemBackslash)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.OemSemicolon)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.OemQuotes)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void comboBox_duration_Leave(object sender, EventArgs e)
        {
            if (comboBox_duration.SelectedIndex == -1)
            {
                label_error_duration.Visible = true;
            }
            if (comboBox_duration.SelectedIndex != -1)
            {
                label_error_duration.Visible = false;
            }

            if (comboBox_duration.Text == "")
            {
                comboBox_duration.Text = "                                   Select Duration";
                comboBox_duration.ForeColor = Color.Black;
            }

        }

        private void comboBox_duration_Enter(object sender, EventArgs e)
        {
            if (comboBox_duration.Text == "                                   Select Duration")
            {
                comboBox_duration.Text = "";
                comboBox_duration.ForeColor = Color.Black;
            }
        }

        private void button_save_Enter(object sender, EventArgs e)
        {
            button_save.ForeColor = Color.DarkOrange;
        }

        private void button_save_Leave(object sender, EventArgs e)
        {
            button_save.ForeColor = Color.White;
        }

        private void button_save_MouseEnter(object sender, EventArgs e)
        {
            button_save.ForeColor = Color.DarkOrange;
        }

        private void button_save_MouseLeave(object sender, EventArgs e)
        {
            button_save.ForeColor = Color.White;
        }

        private void button_reset_Enter(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.DarkOrange;
        }

        private void button_reset_Leave(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.White;
        }

        private void button_reset_MouseEnter(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.DarkOrange;
        }

        private void button_reset_MouseLeave(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.White;
        }

        private void button_search_package_Enter(object sender, EventArgs e)
        {
            button_search_package.ForeColor = Color.DarkOrange;
        }

        private void button_search_package_Leave(object sender, EventArgs e)
        {
            button_search_package.ForeColor = Color.White;
        }

        private void button_search_package_MouseEnter(object sender, EventArgs e)
        {
            button_search_package.ForeColor = Color.DarkOrange;
        }

        private void button_search_package_MouseLeave(object sender, EventArgs e)
        {
            button_search_package.ForeColor = Color.White;
        }

        public void reset()
        {
            textBox_decription.Clear();
            comboBox_duration.Text = string.Empty;
            textBox_price.Clear();
            comboBox_category.Text = string.Empty;
            comboBox_duration.Text = "                                   Select Duration";
            comboBox_category.Text = "                                   Select Category";
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            if (textBox_decription.Text == "")
            {
                label_error_descrip.Visible = true;
                MessageBox.Show("Enter Package Description !!!");
            }
            if (comboBox_duration.SelectedIndex == -1)
            {
                label_error_duration.Visible = true;
                MessageBox.Show("Please select Duration !!!");
            }
            if (textBox_price.Text == "")
            {
                label_error_price.Visible = true;
                MessageBox.Show("Enter Package Price !!!");
            }
            if (comboBox_category.SelectedIndex == -1)
            {
                label_error_category.Visible = true;
                MessageBox.Show("Please select Category !!!");
            }


            //all conditions true data enter

            if (textBox_decription.Text != "")
            {
                if (comboBox_duration.SelectedIndex != -1)
                {
                    if (textBox_price.Text != "")
                    {
                        if (comboBox_category.SelectedIndex != -1)
                        {
                            //packageline record save
                            try
                            {
                                Package_line p1 = new Package_line(textBox_decription.Text, comboBox_duration.Text, double.Parse(textBox_price.Text), comboBox_category.Text);
                                SQLconnection.save_package_line_record(p1);
                                MessageBox.Show("Record Added");
                                reset();
                            }
                            catch (SqlException)
                            {
                                MessageBox.Show("Something went wrong!!!");
                            }

                        }
                    }
                }
            }
        }
                            



        private void comboBox_category_Enter(object sender, EventArgs e)
        {
            if (comboBox_category.Text == "                                   Select Category")
            {
                comboBox_category.Text = "";
                comboBox_category.ForeColor = Color.Black;
            }
        }

        private void comboBox_category_Leave(object sender, EventArgs e)
        {
            if (comboBox_category.Text == "")
            {
                comboBox_category.Text = "                                   Select Category";
                comboBox_category.ForeColor = Color.Black;
            }
            if (comboBox_category.SelectedIndex == -1)
            {
                label_error_category.Visible = true;
            }
            if (comboBox_category.SelectedIndex != -1)
            {
                label_error_category.Visible = false;
            }
        }

        private void button_search_package_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchPackage s1 = new SearchPackage();
            s1.ShowDialog();
            this.Show();
        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {
            textBox_price.MaxLength = 15;
        }
    }
    }
