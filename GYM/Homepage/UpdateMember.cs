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
    public partial class UpdateMember : Form
    {
        public UpdateMember()
        {
            InitializeComponent();
        }





        private void textBox_gymno_KeyDown(object sender, KeyEventArgs e)
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

        private void comboBox_category_Enter(object sender, EventArgs e)
        {
            if (comboBox_category.Text == "                             Select Category")
            {
                comboBox_category.Text = "";
                comboBox_category.ForeColor = Color.Black;
            }
        }

        private void comboBox_category_Leave(object sender, EventArgs e)
        {

            if (comboBox_category.Text == "                             Select Category"|| comboBox_category.Text == "")
            {
                label_errorcategory.Visible = true;
            }
            else
            {
                label_errorcategory.Visible = false;
            }

            if (comboBox_category.SelectedIndex == -1)
            {
                label_errorcategory.Visible = true;
            }
            if (comboBox_category.SelectedIndex != -1)
            {
                label_errorcategory.Visible = false;
            }

            if (comboBox_category.Text == "")
            {
                comboBox_package.Items.Clear();
                comboBox_package.SelectedIndex = -1;
                comboBox_package.Text = "                             Select Package";
                comboBox_category.Text = "                             Select Category";
                comboBox_category.ForeColor = Color.Black;
            }

            //fill package combobox
            //student
            if (comboBox_category.Text == "Student")
            {
                comboBox_package.Items.Clear();
                comboBox_package.SelectedIndex = -1;
                SqlConnection connection = SQLconnection.Connection();
                string qryfillstd = "SELECT PackageName FROM PACKAGE_LINE WHERE kategory = 'Student'";
                SqlCommand command = new SqlCommand(qryfillstd, connection);
                try
                {
                 
                    SqlDataReader read;
                    read = command.ExecuteReader();
                    command.CommandType = CommandType.Text;
                    while (read.Read())
                    {
                        string stdname = read.GetValue(0).ToString();
                        comboBox_package.Items.Add(stdname);
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }


            //non student
            if (comboBox_category.Text == "Non Student")
            {
                comboBox_package.Items.Clear();
                comboBox_package.SelectedIndex = -1;
                SqlConnection connection = SQLconnection.Connection();
                string qryfillstd = "SELECT PackageName FROM PACKAGE_LINE WHERE kategory = 'Non Student'";
                SqlCommand command = new SqlCommand(qryfillstd, connection);
                try
                {

                    SqlDataReader read;
                    read = command.ExecuteReader();
                    command.CommandType = CommandType.Text;
                    while (read.Read())
                    {
                        string stdname = read.GetValue(0).ToString();
                        comboBox_package.Items.Add(stdname);
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }

            }




        }


        private void textBox_name_Leave(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                label_errorname.Visible = true;
            }
            else
            {
                label_errorname.Visible = false;
            }
        }

        private void textBox_contact_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox_weight_Enter(object sender, EventArgs e)
        {
            if (textBox_weight.Text == "kg")
            {
                textBox_weight.Text = "";
                textBox_weight.ForeColor = Color.Black;
            }
        }

        private void textBox_weight_Leave(object sender, EventArgs e)
        {
            if (textBox_weight.Text == "")
            {
                textBox_weight.Text = "kg";
                textBox_weight.ForeColor = Color.Black;
            }
        }

        private void textBox_height_ft_Enter(object sender, EventArgs e)
        {
            if (textBox_height_ft.Text == "ft")
            {
                textBox_height_ft.Text = "";
                textBox_height_ft.ForeColor = Color.Black;
            }
        }

        private void textBox_height_ft_Leave(object sender, EventArgs e)
        {
            if (textBox_height_ft.Text == "")
            {
                textBox_height_ft.Text = "ft";
                textBox_height_ft.ForeColor = Color.Black;
            }
        }

        private void textBox_height_ft_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox_height_in_Enter(object sender, EventArgs e)
        {
            if (textBox_height_in.Text == "in")
            {
                textBox_height_in.Text = "";
                textBox_height_in.ForeColor = Color.Black;
            }
        }

        private void textBox_height_in_Leave(object sender, EventArgs e)
        {
            if (textBox_height_in.Text == "")
            {
                textBox_height_in.Text = "in";
                textBox_height_in.ForeColor = Color.Black;
            }
        }

        private void textBox_height_in_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox_purpose_Enter(object sender, EventArgs e)
        {
            if (textBox_purpose.Text == "bulk | cut | fitness")
            {
                textBox_purpose.Text = "";
                textBox_purpose.ForeColor = Color.Black;
            }
        }

        private void textBox_purpose_Leave(object sender, EventArgs e)
        {
            if (textBox_purpose.Text == "")
            {
                textBox_purpose.Text = "bulk | cut | fitness";
                textBox_purpose.ForeColor = Color.Black;
            }
        }



        private void comboBox_package_Leave(object sender, EventArgs e)
        {

            if (comboBox_package.SelectedIndex == -1)
            {
                label_errorpackage.Visible = true;
            }
            if (comboBox_package.SelectedIndex != -1)
            {
                label_errorpackage.Visible = false;
            }

            if (comboBox_package.Text == "")
            {
                comboBox_package.Text = "                             Select Package";
                comboBox_package.ForeColor = Color.Black;
            }
        }

        private void textBox_admissionfee_KeyDown(object sender, KeyEventArgs e)
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

        private void comboBox_selecttrainer_Enter(object sender, EventArgs e)
        {
            if (comboBox_selecttrainer.Text == "                             Select Trainer")
            {
                comboBox_selecttrainer.Text = "";
                comboBox_selecttrainer.ForeColor = Color.Black;
            }
        }

        private void comboBox_selecttrainer_Leave(object sender, EventArgs e)
        {
            if (comboBox_selecttrainer.Text == "")
            {
                comboBox_selecttrainer.Text = "                             Select Trainer";
                comboBox_selecttrainer.ForeColor = Color.Black;
            }
        }

        private void comboBox_gender_Enter(object sender, EventArgs e)
        {
            if (comboBox_gender.Text == "                             Select Gender")
            {
                comboBox_gender.Text = "";
                comboBox_gender.ForeColor = Color.Black;
            }
        }

        private void comboBox_gender_Leave(object sender, EventArgs e)
        {
            if (comboBox_gender.Text == "")
            {
                comboBox_gender.Text = "                             Select Gender";
                comboBox_gender.ForeColor = Color.Black;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {

            if (textBox_name.Text == "")
            {
                label_errorname.Visible = true;
                MessageBox.Show("Name is missing!");
            }
            if (comboBox_category.SelectedIndex == -1 || comboBox_category.Text == "")
            {
                label_errorcategory.Visible = true;
                MessageBox.Show("Please select a category!");
            }
            if (comboBox_package.Text=="")
            {
                label_errorpackage.Visible = true;
                MessageBox.Show("Please select a package!");
            }

            if (comboBox_package.Text != "")
            {
                label_errorpackage.Visible = false;
            }
            if (textBox_name.Text != "")
            {
                label_errorname.Visible = false;
            }
            if (comboBox_category.SelectedIndex != -1)
            {
                label_errorcategory.Visible = false;
            }
            if (comboBox_package.SelectedIndex != -1)
            {
                label_errorpackage.Visible = false;
            }


            //all conditions true data insert

                if (comboBox_category.SelectedIndex != -1)
                {
                    if (textBox_gymno.Text != "" && textBox_name.Text != "" && comboBox_package.SelectedIndex != -1)
                    {
                        if (textBox_fathername.Text == "")
                        {
                            textBox_fathername.Text = "Null";
                        }
                        if (textBox_contact.Text == "")
                        {
                            textBox_contact.Text = "Null";
                        }
                        if (textBox_address.Text == "")
                        {
                            textBox_address.Text = "Null";
                        }
                        if (textBox_weight.Text == "kg")
                        {
                            textBox_weight.Text = "Null";
                        }
                        if (textBox_height_ft.Text == "ft")
                        {
                            textBox_height_ft.Text = "0";
                        }
                        if (textBox_height_in.Text == "in")
                        {
                            textBox_height_in.Text = "0";
                        }
                        if (textBox_purpose.Text == "bulk | cut | fitness")
                        {
                            textBox_purpose.Text = "Null";
                        }
                        if (textBox_admissionfee.Text == "")
                        {
                            textBox_admissionfee.Text = "0";
                        }
                        if (comboBox_gender.Text == "                             Select Gender")
                        {
                            comboBox_gender.Text = "Null";
                        }

                        //
                    SqlConnection connection = SQLconnection.Connection();
                    //
                    string qry1 = "UPDATE MEMBER SET MemberName = '" + textBox_name.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command1 = new SqlCommand(qry1, connection);
                    command1.CommandType = CommandType.Text;

                    try
                    {
                        command1.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    string qry2 = "UPDATE MEMBER SET FatherName = '" + textBox_fathername.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command2 = new SqlCommand(qry2, connection);
                    command2.CommandType = CommandType.Text;

                    try
                    {
                        command2.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    string qry3 = "UPDATE MEMBER SET Contactno = '" + textBox_contact.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command3 = new SqlCommand(qry3, connection);
                    command3.CommandType = CommandType.Text;

                    try
                    {
                        command3.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    string qry4 = "UPDATE MEMBER SET Add_ress = '" + textBox_address.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command4 = new SqlCommand(qry4, connection);
                    command4.CommandType = CommandType.Text;

                    try
                    {
                        command4.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    string qry5 = "UPDATE MEMBER SET Weigh = '" + textBox_weight.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command5 = new SqlCommand(qry5, connection);
                    command5.CommandType = CommandType.Text;

                    try
                    {
                        command5.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    string qry6 = "UPDATE MEMBER SET HeightFT = '" + int.Parse(textBox_height_ft.Text) + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command6 = new SqlCommand(qry6, connection);
                    command6.CommandType = CommandType.Text;

                    try
                    {
                        command6.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    string qry7 = "UPDATE MEMBER SET HeightIN = '" + int.Parse(textBox_height_in.Text) + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command7 = new SqlCommand(qry7, connection);
                    command7.CommandType = CommandType.Text;

                    try
                    {
                        command7.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    string qry8 = "UPDATE MEMBER SET Purpose = '" + textBox_purpose.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command8 = new SqlCommand(qry8, connection);
                    command8.CommandType = CommandType.Text;

                    try
                    {
                        command8.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //                    
                    string qryfillstd = "SELECT PackageID FROM PACKAGE_LINE WHERE PackageName = '" + comboBox_package.Text + "'";
                    SqlCommand command90 = new SqlCommand(qryfillstd, connection);
                    try
                    {
                        SqlDataReader read1;
                        read1 = command90.ExecuteReader();
                        command90.CommandType = CommandType.Text;
                        while (read1.Read())
                        {
                            int packageselected = (int)read1.GetValue(0);
                            SqlConnection Connection = SQLconnection.Connection();
                            string qry9 = "UPDATE PACKAGE SET PackageID = '"+ packageselected + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "' ";
                            SqlCommand command9 = new SqlCommand(qry9, Connection);
                            command9.CommandType = CommandType.Text;
                            try
                            {
                                command9.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Record can not be Updated!!!");
                                MessageBox.Show(ex.ToString());
                            }
                            finally
                            {
                                Connection.Close();
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        connection.Close();
                    }
                    //
                    SqlConnection connection1 = SQLconnection.Connection();
                    string qry10 = "UPDATE MEMBER SET Admissionfee = '" + float.Parse(textBox_admissionfee.Text) + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command10= new SqlCommand(qry10, connection1);
                    command10.CommandType = CommandType.Text;

                    try
                    {
                        command10.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    //under consideration                   //string qry11 = "UPDATE TRAINER SET TrainerName = '" + comboBox_selecttrainer.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    //SqlCommand command11 = new SqlCommand(qry11, connection1);
                    //command11.CommandType = CommandType.Text;

                    //try
                    //{
                    //    command11.ExecuteNonQuery();
                    //    MessageBox.Show("Record Updated");
                    //}
                    //catch (SqlException ex)
                    //{
                    //    MessageBox.Show("Record can not be Updated!!!");
                    //    MessageBox.Show(ex.ToString());
                    //}
                    //
                    string qry12 = "UPDATE MEMBER SET DateOfJoining = '" + dateTimePicker_dateofjoining.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command12 = new SqlCommand(qry12, connection1);
                    command12.CommandType = CommandType.Text;

                    try
                    {
                        command12.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    //
                    string qry13 = "UPDATE MEMBER SET Gender = '" + comboBox_gender.Text + "' WHERE MemberID = '" + int.Parse(textBox_gymno.Text) + "'";
                    SqlCommand command13 = new SqlCommand(qry13, connection1);
                    command13.CommandType = CommandType.Text;

                    try
                    {
                        command13.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Record can not be Updated!!!");
                        MessageBox.Show(ex.ToString());
                    }
                    MessageBox.Show("Record Updated");
                    connection1.Close();
                    }
                }
            
        }

        private void button_update_Enter(object sender, EventArgs e)
        {
            button_update.ForeColor = Color.DarkOrange;
        }

        private void button_update_Leave(object sender, EventArgs e)
        {
            button_update.ForeColor = Color.White;
        }

        private void button_update_MouseEnter(object sender, EventArgs e)
        {
            button_update.ForeColor = Color.DarkOrange;
        }

        private void button_update_MouseLeave(object sender, EventArgs e)
        {
            button_update.ForeColor = Color.White;
        }

        private void textBox_gymno_TextChanged(object sender, EventArgs e)
        {
            textBox_gymno.MaxLength = 9;
        }

        private void textBox_admissionfee_TextChanged(object sender, EventArgs e)
        {
            textBox_admissionfee.MaxLength = 7;
        }

        private void textBox_height_ft_TextChanged(object sender, EventArgs e)
        {
            textBox_height_ft.MaxLength = 9;
        }

        private void textBox_height_in_TextChanged(object sender, EventArgs e)
        {
            textBox_height_in.MaxLength = 9;
        }

        private void UpdateMember_Activated(object sender, EventArgs e)
        {
            textBox_gymno.TabStop = false;
        }
    }
}
