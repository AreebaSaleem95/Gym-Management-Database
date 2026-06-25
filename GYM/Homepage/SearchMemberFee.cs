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
    public partial class SearchMemberFee : Form
    {
        public SearchMemberFee()
        {
            InitializeComponent();
        }

        private void textBox_gymno_Enter(object sender, EventArgs e)
        {
            if(textBox_gymno.Text=="Enter Gym no")
            {
                textBox_gymno.Text = "";
            }
        }

        private void textBox_gymno_Leave(object sender, EventArgs e)
        {
            if (textBox_gymno.Text == "")
            {
                textBox_gymno.Text = "Enter Gym no";
            }
        }

        private void getFEErecord()
        {
            try
            {
                SqlDataAdapter adapter = SQLconnection.fetch_fee_record();
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
                dataGridView_fee.DataSource = d1;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }

        }
        public void search_fee_record()
        {
            //search fee record by gym no
            Fee f1 = new Fee(int.Parse(textBox_gymno.Text));
            SqlDataAdapter adapter = SQLconnection.fetch_fee_record_by_gymno(f1);

            try
            {
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
                dataGridView_fee.DataSource = d1;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }
        public void getnet_income()
        {
            //count net income
            try
            {
                SqlDataReader read=SQLconnection.calculate_Netincome();
                while (read.Read())
                {
                    textBox_net_income.Text = read.GetValue(0).ToString();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }
        public void getpending_fee_total()
        {
            //count net due fee
            try
            {
                SqlDataReader read = SQLconnection.net_remaining_dues();
                while (read.Read())
                {
                    textBox_pending_fee.Text = read.GetValue(0).ToString();


                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }

        private void textBox_gymno_TextChanged(object sender, EventArgs e)
        {
            if (textBox_gymno.Text == "Enter Gym no" || textBox_gymno.Text == "")
            {
                //show fee all data
                getFEErecord();
            }
            else if (textBox_gymno.Text != "Enter Gym no" || textBox_gymno.Text != "")
            {

                //search a member data
                search_fee_record();
            }
        }
        public void get_fee_by_date()
        {
            //search fee record by date
            Fee f1 = new Fee(dateTimePicker_first.Text, dateTimePicker_second.Text);
            SqlDataAdapter adapter =SQLconnection.search_fee_record_by_date(f1);
            try
            {
                DataTable d1 = new DataTable();
                adapter.Fill(d1);
                dataGridView_fee.DataSource = d1;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }
        private void dateTimePicker_second_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_second.Text!="")
            {
                get_fee_by_date();
            }
        }

        private void dateTimePicker_first_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker_first.Text != "")
            {
                get_fee_by_date();
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

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView_fee.SelectedRows.Count > 0)
            {
                //member package deletion
                try
                {
                    int id = (int)dataGridView_fee.Rows[dataGridView_fee.SelectedRows[0].Index].Cells["memberid"].Value;
                    Fee f1 = new Fee(id);
                    SQLconnection.delete_fee_record(f1);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Something went wrong!!!");
                }
                getFEErecord();
                MessageBox.Show("Record Deleted!!!");

            }
            else
            {
                MessageBox.Show("Select a Row first !!!");
            }
        }

        private void SearchMemberFee_Activated(object sender, EventArgs e)
        {
            getFEErecord();
            getnet_income();
            getpending_fee_total();
        }
    }
}
