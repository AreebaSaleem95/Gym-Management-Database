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
    public partial class NewAdmission : Form
    {
        public NewAdmission()
        {
            InitializeComponent();
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

        private void textBox_reason_Enter(object sender, EventArgs e)
        {
            if (textBox_purpose.Text == "bulk | cut | fitness")
            {
                textBox_purpose.Text = "";
                textBox_purpose.ForeColor = Color.Black;
            }
        }

        private void textBox_reason_Leave(object sender, EventArgs e)
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

        private void button_submit_newadmission_Enter(object sender, EventArgs e)
        {
            button_submit_newadmission.ForeColor = Color.DarkOrange;
        }

        private void button_submit_newadmission_Leave(object sender, EventArgs e)
        {
            button_submit_newadmission.ForeColor = Color.White;
        }

        private void button_submit_newadmission_MouseEnter(object sender, EventArgs e)
        {
            button_submit_newadmission.ForeColor = Color.DarkOrange;
        }

        private void button_submit_newadmission_MouseLeave(object sender, EventArgs e)
        {
            button_submit_newadmission.ForeColor = Color.White;
        }

        private void button_clear_Enter(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.DarkOrange;
        }

        private void button_clear_Leave(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.White;
        }

        private void button_clear_MouseEnter(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.DarkOrange;
        }

        private void button_clear_MouseLeave(object sender, EventArgs e)
        {
            button_reset.ForeColor = Color.White;
        }


        private void button_submit_newadmission_Click(object sender, EventArgs e)
        {
            if (textBox_gymno.Text=="")
            {
                label_errorgymno.Visible=true;
                MessageBox.Show("Gym no is missing!");
            }
            if (textBox_name.Text == "")
            {
                label_errorname.Visible = true;
                MessageBox.Show("Name is missing!");
            }
            if (comboBox_category.SelectedIndex == -1|| comboBox_category.Text=="")
            {
                label_errorcategory.Visible = true;
                MessageBox.Show("Please select a category!");
            }
            if (comboBox_package.SelectedIndex==-1|| comboBox_package.Text== "comboBox_package")
            {
                label_errorpackage.Visible = true;
                MessageBox.Show("Please select a package!");
            }

            if (textBox_gymno.Text != "")
            {
                label_errorgymno.Visible = false;
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

            if (textBox_gymno.Text != "")
            {
                //gymno already exist check

                Member M1 = new Member(int.Parse(textBox_gymno.Text));
                object result;
                result = SQLconnection.Memberid_chk(M1);
                if (result != null)
                {
                    try { 
                        int memberid = (int)result;
                    if (memberid == int.Parse(textBox_gymno.Text))
                    {
                        label_errorgymno.Visible = true;
                        label_gym_no_exists.Visible = true;
                        MessageBox.Show("Gym.no already exists!!!");
                    }
                    }
                    catch (SqlException )
                    {
                        MessageBox.Show("Something went wrong!!!");
                    }
                    }

                    else
                    {
                        //all conditions true data insert               
                        if (textBox_name.Text != "")
                        {
                            if (comboBox_category.SelectedIndex != -1)
                            {
                                if (comboBox_package.SelectedIndex != -1)
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



                                //member save
                                try
                                {
                                    Member M = new Member(int.Parse(textBox_gymno.Text), comboBox_category.Text, textBox_name.Text, textBox_fathername.Text, textBox_contact.Text, textBox_address.Text, textBox_weight.Text, int.Parse(textBox_height_ft.Text), int.Parse(textBox_height_in.Text), textBox_purpose.Text, double.Parse(textBox_admissionfee.Text), dateTimePicker_dateofjoining.Text, comboBox_gender.Text);
                                    SQLconnection.Add_new_member(M);
                                }
                                catch (SqlException)
                                {
                                    MessageBox.Show("Something went wrong!!!");
                                }

                                //purchased package save
                                try
                                {
                                    Purchased_package p1 = new Purchased_package(int.Parse(textBox_gymno.Text), comboBox_package.Text);
                                    SQLconnection.Add_member_purchased_package(p1);
                                }
                                catch (SqlException)
                                {
                                    MessageBox.Show("Something went wrong!!!");
                                }

                                reset();
                                    MessageBox.Show("Record Added");


                                }
                            }
                        }
                    }
                

            }

            else if(textBox_gymno.Text != "")
            {
                label_errorgymno.Visible = false;
                label_gym_no_exists.Visible = false;
            }

  

        }
        public void reset()
        {
            textBox_gymno.Clear();
            comboBox_category.SelectedIndex = -1 ;
            textBox_name.Clear();
            textBox_fathername.Clear();
            textBox_contact.Clear();
            textBox_address.Clear();
            textBox_weight.Clear();
            textBox_height_ft.Clear();
            textBox_height_in.Clear();
            textBox_purpose.Clear();
            comboBox_gender.SelectedIndex = -1;
            label_gym_no_exists.Visible = false;
            comboBox_package.SelectedIndex = -1;
            textBox_admissionfee.Clear();
            comboBox_selecttrainer.SelectedIndex = -1;
            dateTimePicker_dateofjoining.ResetText();
            label_errorgymno.Visible = false;
            label_errorname.Visible = false;
            label_errorcategory.Visible = false;
            label_errorpackage.Visible = false;

            comboBox_category.Text = "                             Select Category";
            textBox_weight.Text = "kg";
            textBox_height_ft.Text = "ft";
            textBox_height_in.Text = "in";
            textBox_purpose.Text = "bulk | cut | fitness";
            comboBox_package.Text = "                             Select Package";
            comboBox_selecttrainer.Text = "                             Select Trainer";
            comboBox_gender.Text = "                             Select Gender";
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            reset();
            MessageBox.Show("Cleared!");
        }

        private void button_searchmember_Enter(object sender, EventArgs e)
        {
            button_searchmember.ForeColor = Color.DarkOrange;
        }

        private void button_searchmember_Leave(object sender, EventArgs e)
        {
            button_searchmember.ForeColor = Color.White;
        }

        private void button_searchmember_MouseEnter(object sender, EventArgs e)
        {
            button_searchmember.ForeColor = Color.DarkOrange;
        }

        private void button_searchmember_MouseLeave(object sender, EventArgs e)
        {
            button_searchmember.ForeColor = Color.White;
        }

        private void button_searchmember_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchMember s1 = new SearchMember();
            s1.ShowDialog();
            this.Show();
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
            if (comboBox_category.Text == "                             Select Category" || comboBox_category.Text == "")
            {
                comboBox_package.Items.Clear();
                comboBox_package.SelectedIndex = -1;
                comboBox_package.Text = "                             Select Package";
                comboBox_category.Text = "                             Select Category";
                comboBox_category.ForeColor = Color.Black;
            }

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
            

        }





        private void textBox_gymno_Leave(object sender, EventArgs e)
        {
            if (textBox_gymno.Text == "")
            {
                label_errorgymno.Visible = true;
            }
            else
            {
                label_errorgymno.Visible = false;
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

        private void textBox_gymno_TextChanged(object sender, EventArgs e)
        {
            textBox_gymno.MaxLength = 9;
            //chk gym no already exist
            if (textBox_gymno.Text != "")
            {
                Member M1 = new Member(int.Parse(textBox_gymno.Text));
                object result;
                result = SQLconnection.Memberid_chk(M1);
                if (result != null)
                {
                    try
                    {
                        int memberid = (int)result;
                        if (memberid == int.Parse(textBox_gymno.Text))
                        {
                            label_errorgymno.Visible = true;
                            label_gym_no_exists.Visible = true;
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Something went wrong!!!");
                    }
                }
                else
                    {
                        label_errorgymno.Visible = false;
                        label_gym_no_exists.Visible = false;
                    }   
            }

            else
            {
                label_errorgymno.Visible = false;
                label_gym_no_exists.Visible = false;
            }
        }
        private void textBox_gymno_KeyDown(object sender, KeyEventArgs e)
        {
            //start alphabets restriction            
            if (e.KeyCode==Keys.Q)
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
            if (e.KeyCode == Keys.OemBackslash)
            {
                e.SuppressKeyPress = true;
            }
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

        private void comboBox_package_Enter(object sender, EventArgs e)
        {
            if (comboBox_package.Text == "                             Select Package")
            {
                comboBox_package.Text = "";
            }
        }

        private void textBox_admissionfee_TextChanged(object sender, EventArgs e)
        {
            textBox_admissionfee.MaxLength = 15;
        }

        private void textBox_height_ft_TextChanged(object sender, EventArgs e)
        {
            textBox_height_ft.MaxLength = 9;
        }

        private void textBox_height_in_TextChanged(object sender, EventArgs e)
        {
            textBox_height_in.MaxLength = 9;
        }

        private void comboBox_category_TextChanged(object sender, EventArgs e)
        {
            //fill package combobox
            //student
            if (comboBox_category.Text == "Student")
            {
                comboBox_package.Items.Clear();
                comboBox_package.Text = "                             Select Package";
                comboBox_package.SelectedIndex = -1;
                try
                {
                    SqlDataReader read1 = SQLconnection.fetch_student_packsges();
                    if (read1.IsClosed)
                    {
                        MessageBox.Show("The reader is closed");
                    }
                    while (read1.Read())
                    {
                        string stdname = read1.GetValue(0).ToString();
                        comboBox_package.Items.Add(stdname);
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Something went wrong!!!");
                }
            }


            //non student
            if (comboBox_category.Text == "Non Student")
            {
                comboBox_package.Items.Clear();
                comboBox_package.Text = "                             Select Package";
                comboBox_package.SelectedIndex = -1;
                try
                {
                    SqlDataReader read = SQLconnection.fetch_nonstudent_packsges();
                    if (read.IsClosed)
                    {
                        MessageBox.Show("The reader is closed");
                    }
                    while (read.Read())
                    {
                        string stdname = read.GetValue(0).ToString();
                        comboBox_package.Items.Add(stdname);
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Something went wrong!!!");
                }

            }
        }
    }
}
