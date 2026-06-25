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
    public partial class SearchPackage : Form
    {

        public void getpackage_record()
        {
            try
            {
                SqlDataAdapter adapter = SQLconnection.fetch_all_packages();
                DataTable d2 = new DataTable();
                adapter.Fill(d2);
                dataGridView_package.DataSource = d2;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }


        public void searchpackge_data()
        {
            //search package member
            Package_line p1 = new Package_line(textBox_searchpackage.Text);
            SqlDataAdapter adapter = SQLconnection.fetch_pkg_by_name(p1);
            try
            {
                DataTable d2 = new DataTable();
                adapter.Fill(d2);
                dataGridView_package.DataSource = d2;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }

        public void searchpackge_data_by_price()
        {

            //search package member
            Package_line p1 = new Package_line(double.Parse(textBox_min.Text), double.Parse(textBox_max.Text));
            SqlDataAdapter adapter = SQLconnection.fetch_pkg_by_price(p1);
            try
            {
                DataTable d2 = new DataTable();
                adapter.Fill(d2);
                dataGridView_package.DataSource = d2;
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }
        public void count_pakages_by_price()
        {
            //count all packages
            double Min = double.Parse(textBox_min.Text);
            double Max = double.Parse(textBox_max.Text);
            try
            {

                SqlDataReader read;
                Package_line p1 = new Package_line(double.Parse(textBox_min.Text), double.Parse(textBox_max.Text));
                read = SQLconnection.count_pakages_by_price(p1);
                while (read.Read())
                {
                    textBox_total_packages.Text = read.GetValue(0).ToString();

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
        }

        public SearchPackage()
        {
            InitializeComponent();
        }

        private void button_clear_Enter(object sender, EventArgs e)
        {
            label_clear.Visible = true;
        }

        private void button_clear_Leave(object sender, EventArgs e)
        {
            label_clear.Visible = false;
        }

        private void button_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.Visible = true;
        }

        private void button_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.Visible = false;
        }

        private void textBox_searchpackage_Enter(object sender, EventArgs e)
        {
            if (textBox_searchpackage.Text == "By Description")
            {
                textBox_searchpackage.Text = "";
            }
        }

        private void textBox_searchpackage_Leave(object sender, EventArgs e)
        {
            if (textBox_searchpackage.Text == "")
            {
                textBox_searchpackage.Text = "By Description";
            }
        }
        public void reset()
        {
                textBox_searchpackage.Text = "By Description";            
                textBox_min.Text = "";
                textBox_max.Text = "";
                comboBox_category.Text = "";
                comboBox_category.SelectedIndex = -1;
                countpkgs();
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            reset();
            getpackage_record();

        }

        public void countpkgs()
        {
            //count all packages
            SqlConnection connection = SQLconnection.Connection();
            string qry = "SELECT COUNT(PackageID) FROM PACKAGE_LINE";
            SqlCommand command = new SqlCommand(qry, connection);
            try
            {
                SqlDataReader read;
                read = command.ExecuteReader();
                command.CommandType = CommandType.Text;
                while (read.Read())
                {
                    textBox_total_packages.Text = read.GetValue(0).ToString();


                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Something went wrong!!!");
            }
            finally
            {
                connection.Close();
            }
        }

        private void SearchPackage_Activated(object sender, EventArgs e)
        {
            textBox_total_packages.TabStop = false;
            dataGridView_package.TabStop = false;
            getpackage_record();
            countpkgs();
        }

        private void textBox_searchpackage_TextChanged(object sender, EventArgs e)
        {
            if (textBox_searchpackage.Text == "By Description" || textBox_searchpackage.Text == "")
            {
                //show mpackage all data
                getpackage_record();
            }
            else if (textBox_searchpackage.Text != "By Description" || textBox_searchpackage.Text != "")
            {
                //search packages
                searchpackge_data();
            }
        }



        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_package.SelectedRows.Count > 0)
            {
                //package deletion
                string pkgname = (string)dataGridView_package.Rows[dataGridView_package.SelectedRows[0].Index].Cells["name"].Value;
                try
                {
                    Package_line p1 = new Package_line(pkgname);
                    SQLconnection.delete_packageline_record(p1);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Something went wrong!!!");
                }

                getpackage_record();
                MessageBox.Show("Package Deleted!!!");

            }
            else
            {
                MessageBox.Show("Select a Row first !!!");
            }
        }

        private void textBox_max_TextChanged(object sender, EventArgs e)
        {
            textBox_max.MaxLength = 15;
            if (textBox_min.Text == "" || textBox_max.Text == "")
            {
                getpackage_record();
            }
            else if (textBox_min.Text != "" && textBox_max.Text != "")
            {
                searchpackge_data_by_price();
                count_pakages_by_price();
            }
        }

        private void textBox_min_TextChanged(object sender, EventArgs e)
        {
            textBox_min.MaxLength = 15;
            if (textBox_min.Text == "" || textBox_max.Text == "")
            {
                getpackage_record();
            }
            else if (textBox_min.Text != "" && textBox_max.Text != "")
            {
                searchpackge_data_by_price();
                count_pakages_by_price();
            }
        }

        private void comboBox_category_TextChanged(object sender, EventArgs e)
        {
            //search by student 
            if (comboBox_category.Text != "" && comboBox_category.SelectedIndex != -1)
            {

                if (comboBox_category.SelectedIndex == 0)
                {
                    //show student pkgs
                    string std = "Student";
                    try
                    {
                        Package_line p1 = new Package_line(std, 1);
                        SqlDataAdapter adapter = SQLconnection.srch_pkg_by_category(p1);
                        DataTable d2 = new DataTable();
                        adapter.Fill(d2);
                        dataGridView_package.DataSource = d2;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Something went wrong!!!");
                    }
                    //count student pkgs
                    try
                    {
                        SqlDataReader read;
                        Package_line p2 = new Package_line(std, 1);
                        read = SQLconnection.count_student_pkg(p2);
                        while (read.Read())
                        {
                            textBox_total_packages.Text = read.GetValue(0).ToString();
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Something went wrong!!!");
                    }
                }
                    //search by non student
                    if (comboBox_category.SelectedIndex==1)
                    {
                        //show non student pkgs
                        string nstd = "Non Student";
                        try
                        {
                            Package_line p1 = new Package_line(nstd, 1);
                            SqlDataAdapter adapter = SQLconnection.srch_pkg_by_category(p1);
                            DataTable d2 = new DataTable();
                            adapter.Fill(d2);
                            dataGridView_package.DataSource = d2;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Something went wrong!!!");
                    }
                    //count non student pkgs
                    try
                        {
                            SqlDataReader read;
                            Package_line p2 = new Package_line(nstd, 1);
                            read = SQLconnection.count_student_pkg(p2);
                            while (read.Read())
                            {
                                textBox_total_packages.Text = read.GetValue(0).ToString();
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
}
