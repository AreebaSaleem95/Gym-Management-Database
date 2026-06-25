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
    public partial class SearchMember : Form
    {

        private void getmemberrecord()
        {


            SqlDataAdapter adapter = SQLconnection.fetch_all_member_n_purchased_package();
            try
            {
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
                dataGridView_members.DataSource = d1;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }

        }


        public SearchMember()
        {
            InitializeComponent();
        }


        private void button_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.Visible = true;
        }

        private void button_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.Visible = false;
        }


        private void textBox_searchmember_Enter(object sender, EventArgs e)
        {
            if (textBox_searchmember_name.Text == "Enter Name")
            {
                textBox_searchmember_name.Text = "";
            }
          
        }

        private void textBox_searchmember_Leave(object sender, EventArgs e)
        {
            if (textBox_searchmember_name.Text == "")
            {
                textBox_searchmember_name.Text = "Enter Name";
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_searchmember_name.Clear();
            textBox_searchmember_gymno.Clear();
            textBox_searchmember_name.Text = "Enter Name";
            textBox_searchmember_gymno.Text = "Enter Gym no";
            getmemberrecord();

        }


        private void SearchMember_Activated(object sender, EventArgs e)
        {
            getmemberrecord();
            dataGridView_members.TabStop = false;
        }
        public void searchmemberrecord_name()
        {
            //search gym member by name

            try
            {
                Member m1 = new Member(textBox_searchmember_name.Text);
                SqlDataAdapter adapter = SQLconnection.serch_member_all_data_byName(m1);
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
                dataGridView_members.DataSource = d1;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }
        public void searchmemberrecord_gymno()
        {
            //search gym member by gym no
            try
            {
                Member m1 = new Member(int.Parse(textBox_searchmember_gymno.Text));
                SqlDataAdapter adapter = SQLconnection.serch_member_all_data_byGymno(m1);
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
                dataGridView_members.DataSource = d1;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }



        private void textBox_searchmember_TextChanged(object sender, EventArgs e)
        {
            if (textBox_searchmember_name.Text == "Enter Name" || textBox_searchmember_name.Text == "")
            {
                //show member all data
                getmemberrecord();
            }
            else if (textBox_searchmember_name.Text != "Enter Name" || textBox_searchmember_name.Text != "")
            {

                //search a member data
                searchmemberrecord_name();
            }
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
                if (dataGridView_members.SelectedRows.Count > 0)
                {
                //member package deletion
                try
                {
                    int id = (int)dataGridView_members.Rows[dataGridView_members.SelectedRows[0].Index].Cells["memberid"].Value;
                    Member m1 = new Member(id);
                    SQLconnection.del_member_pkg(m1);


                    //member deletion
                    Member m2 = new Member(id);
                    SQLconnection.del_member_record(m2);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Something went wrong!!!");
                }

                getmemberrecord();
                MessageBox.Show("Record Deleted!!!");

            }
            else
            {
                MessageBox.Show("Select a Row first !!!");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView_members.SelectedRows.Count > 0)
            {
                this.Hide();
                UpdateMember u1 = new UpdateMember();

                //fetch data to update form
                int id = (int)dataGridView_members.Rows[dataGridView_members.SelectedRows[0].Index].Cells["memberid"].Value;
                try
                {
                    Member m1 = new Member(id);
                    SqlDataReader read;
                    read = SQLconnection.fetch_unique_member_n_purchased_package(m1);
                    while (read.Read())
                    {
                        u1.textBox_gymno.Text = read.GetValue(0).ToString();
                        u1.textBox_name.Text = read.GetValue(2).ToString();
                        u1.textBox_fathername.Text = read.GetValue(3).ToString();
                        u1.textBox_contact.Text = read.GetValue(4).ToString();
                        u1.textBox_address.Text = read.GetValue(5).ToString();
                        u1.textBox_weight.Text = read.GetValue(10).ToString();
                        u1.textBox_height_ft.Text = read.GetValue(11).ToString();
                        u1.textBox_height_in.Text = read.GetValue(12).ToString();
                        u1.textBox_purpose.Text = read.GetValue(9).ToString();
                        u1.textBox_admissionfee.Text = read.GetValue(8).ToString();
                        DateTime datefromdatabase = read.GetDateTime(6);
                        u1.dateTimePicker_dateofjoining.Value = datefromdatabase;
                        u1.comboBox_gender.Text = read.GetValue(7).ToString();
                        u1.comboBox_category.Text = read.GetValue(1).ToString();
                        u1.comboBox_package.Text = read.GetValue(13).ToString();


                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Something went wrong!!!");
                }

                u1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Select a Row first !!!");
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

        private void button_delete_Enter(object sender, EventArgs e)
        {
            button_delete.ForeColor = Color.DarkOrange;
        }

        private void button_delete_Leave(object sender, EventArgs e)
        {
            button_delete.ForeColor = Color.White;
        }

        private void button_delete_MouseEnter(object sender, EventArgs e)
        {
            button_delete.ForeColor = Color.DarkOrange;
        }

        private void button_delete_MouseLeave(object sender, EventArgs e)
        {
            button_delete.ForeColor = Color.White;
        }

        private void textBox_searchmember_gymno_TextChanged(object sender, EventArgs e)
        {
            textBox_searchmember_gymno.MaxLength = 9;
            if (textBox_searchmember_gymno.Text == "Enter Gym no" || textBox_searchmember_gymno.Text == "")
            {
                //show member all data
                getmemberrecord();
            }
            else if (textBox_searchmember_gymno.Text != "Enter Gym no" || textBox_searchmember_gymno.Text != "")
            {

                //search a member data
                searchmemberrecord_gymno();
            }

        }

        private void textBox_searchmember_gymno_Enter(object sender, EventArgs e)
        {
            if (textBox_searchmember_gymno.Text == "Enter Gym no")
            {
                textBox_searchmember_gymno.Text = "";
            }
        }

        private void textBox_searchmember_gymno_Leave(object sender, EventArgs e)
        {
            if (textBox_searchmember_gymno.Text == "")
            {
                textBox_searchmember_gymno.Text = "Enter Gym no";
            }
        }

        private void textBox_searchmember_gymno_KeyDown(object sender, KeyEventArgs e)
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
    }
}
