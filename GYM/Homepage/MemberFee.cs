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
    public partial class MemberFee : Form
    {
        public MemberFee()
        {
            InitializeComponent();
        }

        private void button_submit_fees_Enter(object sender, EventArgs e)
        {
            button_submit_fees.ForeColor = Color.DarkOrange;
        }

        private void button_submit_fees_MouseEnter(object sender, EventArgs e)
        {
            button_submit_fees.ForeColor = Color.DarkOrange;
        }

        private void button_submit_fees_Leave(object sender, EventArgs e)
        {
            button_submit_fees.ForeColor = Color.White;
        }

        private void button_submit_fees_MouseLeave(object sender, EventArgs e)
        {
            button_submit_fees.ForeColor = Color.White;
        }


        private void textBox_gymno_Leave(object sender, EventArgs e)
        {

            if (textBox_gymno.Text == "")
            {
                label_errorgymno.Visible = true;
            }
            if (textBox_gymno.Text != "")
            {
                label_errorgymno.Visible = false;
            }
        }



        public void taborder_deactivate()
        {
            textBox_package.TabStop = false;
            textBox_total_amount.TabStop = false;
            textBox_member.TabStop = false;
            textBox_remaining_dues.TabStop = false;
            textBox_father_name.TabStop = false;
            textBox_price.TabStop = false;
        }


        public void reset()
        {
            textBox_gymno.Text = "";
            textBox_package.Text = "";
            textBox_total_amount.Text = "";
            textBox_amount_paid.Text = "";
            textBox_served_by.Text = "ADMIN";
            textBox_member.Text = "";
            textBox_price.Text = "";
            dateTimePicker_paid_date.ResetText();
            textBox_father_name.Text = "";
            textBox_remaining_dues.Text = "";
            label_errorgymno.Visible = false;
            label_error_amount_paid.Visible = false;
        }


        public void calculate_total_amount()
        {
            //calculating total amount

            if (textBox_remaining_dues.Text == "" || textBox_remaining_dues.Text == "NULL")
            {
                textBox_remaining_dues.Text = "0";
            }
            if (textBox_price.Text == ""|| textBox_price.Text == "NULL")
            {
                textBox_price.Text = "0";
            }
            if (textBox_price.Text != "" || textBox_remaining_dues.Text != "" || textBox_remaining_dues.Text != "NULL")
            {
                double dues;
                double price;
                price = double.Parse(textBox_price.Text);
                dues = double.Parse(textBox_remaining_dues.Text);
                double total;
                total = price + dues;
                textBox_total_amount.Text = total.ToString();
            }
        }

        public int feeid;
        public int pkgid;
        public string pkgduration;
        private void textBox_gymno_TextChanged(object sender, EventArgs e)
        {
            textBox_gymno.MaxLength = 9;
            if (textBox_gymno.Text == "Enter Gym no" || textBox_gymno.Text == "")
            {
                //show member all data
                reset();
            }
            else if (textBox_gymno.Text != "Enter Gym no" || textBox_gymno.Text != "")
            {

                //search a member data

                searchmemberrecord_gymno();

                //fetch remaining details of paying member id
                try
                {
                    SqlDataReader read;
                    Member m1 = new Member(int.Parse(textBox_gymno.Text));
                    read = SQLconnection.fetch_old_fee_record_of_gym(m1);
                    while (read.Read())
                    {
                        feeid = (int)read.GetValue(0);
                        pkgid = (int)read.GetValue(1);
                        pkgduration = read.GetValue(2).ToString();
                        textBox_remaining_dues.Text = read.GetValue(4).ToString();
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Something went wrong!!!");
                }

                calculate_total_amount();

            }
        }

        public void searchmemberrecord_gymno()
        {
            //chk gym no already exist
            if (textBox_gymno.Text != "")
            {
                Member M1 = new Member(int.Parse(textBox_gymno.Text));
                object result;
                result = SQLconnection.Memberid_chk(M1); 
                    if (result != null)
                    {
                        int ftch_memberid = (int)result;
                        if (ftch_memberid == int.Parse(textBox_gymno.Text))
                        {
                        //search gym member by gym no
                        try
                            {
                            Member m1 = new Member(ftch_memberid);
                            SqlDataReader read;
                            read = SQLconnection.fetch_unique_member_n_purchased_package(m1);
                            while (read.Read())
                                {
                                    textBox_price.Text = read.GetValue(14).ToString();
                                    textBox_package.Text = read.GetValue(13).ToString();
                                    textBox_member.Text = read.GetValue(2).ToString();
                                    textBox_father_name.Text = read.GetValue(3).ToString();

                                    
                                }
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Something went wrong!!!");
                        }

                    }
                    }
                    if (result == null)
                    {
                        textBox_member.Text = "";
                        textBox_father_name.Text = "";
                        textBox_package.Text = "";
                        textBox_remaining_dues.Text = "";
                        textBox_total_amount.Text = "";
                        textBox_price.Text = "";
                        textBox_remaining_dues.Text = "";
                        textBox_price.Text = "";
                }
            }



            
                
        }

        private void textBox_amount_paid_TextChanged(object sender, EventArgs e)
        {
            textBox_amount_paid.MaxLength = 15;
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


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Project GYM", new Font("Calibri", 17, FontStyle.Bold), Brushes.Black, new Point(80, 20));
            e.Graphics.DrawString("NTU", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(120, 48));
            e.Graphics.DrawString("FEE Recipt", new Font("Calibri", 13, FontStyle.Bold), Brushes.Black, new Point(99, 70));

            e.Graphics.DrawString("FEE.NO", new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(5, 120));
            e.Graphics.DrawString(feeid.ToString(), new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(110, 120));
            e.Graphics.DrawString("Member Name", new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(5, 140));
            e.Graphics.DrawString(textBox_member.Text, new Font("Calibri", 9, FontStyle.Regular), Brushes.Black, new Point(110, 143));
            e.Graphics.DrawString("Gym No", new Font("Calibri", 11, FontStyle.Bold), Brushes.Black, new Point(5, 160));
            e.Graphics.DrawString(textBox_gymno.Text, new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(110, 160));

            e.Graphics.DrawString("-----------------------------------------------", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(1, 170));
            e.Graphics.DrawString("Package.NO", new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(5, 188));
            e.Graphics.DrawString("Duration", new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(105, 188));
            e.Graphics.DrawString("Price", new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(170, 188));
            e.Graphics.DrawString("Paid", new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(240, 188));
            e.Graphics.DrawString("-----------------------------------------------", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(1, 200));

            e.Graphics.DrawString(pkgid.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(5, 220));
            e.Graphics.DrawString(pkgduration, new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(107, 220));
            e.Graphics.DrawString(textBox_price.Text.ToString(), new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(170, 220));
            e.Graphics.DrawString(textBox_amount_paid.Text, new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(240, 220));


            e.Graphics.DrawString("-----------------------------------------------", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(1, 250));

            e.Graphics.DrawString("Remaining Dues", new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(5, 275));
            e.Graphics.DrawString(textBox_remaining_dues.Text, new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(241, 275));

            e.Graphics.DrawString("-----------------------------------------------", new Font("Calibri", 14, FontStyle.Bold), Brushes.Black, new Point(1, 290));

            e.Graphics.DrawString("Total", new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(5, 310));
            e.Graphics.DrawString(textBox_total_amount.Text, new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(240, 310));
            e.Graphics.DrawString("Cashier", new Font("Calibri", 11, FontStyle.Regular), Brushes.Black, new Point(5, 330));
            e.Graphics.DrawString(textBox_served_by.Text, new Font("Calibri", 10, FontStyle.Regular), Brushes.Black, new Point(222, 330));

            e.Graphics.DrawString("Thankyou for Joining us!", new Font("Calibri", 13, FontStyle.Bold), Brushes.Black, new Point(50, 370));

        }

        private void button_submit_fees_Click(object sender, EventArgs e)
        {
            if (textBox_gymno.Text == "")
            {
                MessageBox.Show("Enter Gym No!!!");
                label_errorgymno.Visible = true;

            }
            if (textBox_gymno.Text != "")
            {
                label_errorgymno.Visible = false;

            }
            if (textBox_amount_paid.Text == "")
            {
                label_error_amount_paid.Visible = true;
                MessageBox.Show("Enter amount paid!!!");
            }
            if (textBox_amount_paid.Text != "")
            {
                label_error_amount_paid.Visible = false;
            }

            //all conditions true data insert
            if (textBox_gymno.Text != "")
            {
                if (textBox_amount_paid.Text != "")
                {
                    if (textBox_gymno.Text != "")
                    {
                        //assigning null to empty boxes
                        if (textBox_served_by.Text=="")
                        {
                            textBox_served_by.Text = "Null";
                        }
                        if (textBox_amount_paid.Text == "")
                        {
                            textBox_amount_paid.Text = "0";
                        }

                        //gymno already exist check
                        try
                        {
                            Member m1 = new Member(int.Parse(textBox_gymno.Text));
                            object result = SQLconnection.Memberid_chk(m1);
                            if (result != null)
                            {
                                int memberid = (int)result;
                                if (memberid == int.Parse(textBox_gymno.Text))
                                {
                                    //formula to keep due fee updated
                                    double remaining_due = double.Parse(textBox_remaining_dues.Text);
                                    double pkg_price = double.Parse(textBox_price.Text);
                                    double amount_paid = double.Parse(textBox_amount_paid.Text);
                                    double updtd_amnt_due;
                                    updtd_amnt_due = (remaining_due+pkg_price)-amount_paid;
                                    if (updtd_amnt_due<0)
                                    {
                                        updtd_amnt_due = 0;
                                    }
                                    //all conditions true fee transaction
                                    try
                                    {
                                        Fee f1 = new Fee(int.Parse(textBox_gymno.Text), dateTimePicker_paid_date.Text, textBox_amount_paid.Text, textBox_served_by.Text,Convert.ToString(updtd_amnt_due));
                                        SQLconnection.fee_transaction(f1);
                                        printPreviewDialog1.Document = printDocument1;
                                        printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm",285,450);
                                        printPreviewDialog1.ShowDialog();
                                        reset();
                                    }
                                    catch (SqlException)
                                    {
                                        MessageBox.Show("Something went wrong!!!");
                                    }
                                }
                            }
                            if (result == null)
                            {
                                MessageBox.Show("Gym.no doesn't Exist!!!");
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

        private void textBox_amount_paid_Leave(object sender, EventArgs e)
        {
                if (textBox_amount_paid.Text == "")
                {
                    label_error_amount_paid.Visible = true;
                }
                else
                {

                    label_error_amount_paid.Visible = false;
                }
        }



        private void textBox_amount_paid_KeyDown(object sender, KeyEventArgs e)
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

        private void MemberFee_Activated(object sender, EventArgs e)
        {
            taborder_deactivate();
        }

  
    }
}
