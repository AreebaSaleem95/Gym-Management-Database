using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homepage
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void button_members_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage_Gymmember h1 = new Homepage_Gymmember();
            h1.ShowDialog();
            this.Show();
        }

        private void button_members_MouseEnter(object sender, EventArgs e)
        {
            button_members.ForeColor = Color.DarkOrange;
        }

        private void button_members_MouseLeave(object sender, EventArgs e)
        {
            button_members.ForeColor = Color.White;
        }




        private void button_contact_MouseEnter(object sender, EventArgs e)
        {
            button_contact.ForeColor = Color.DarkOrange;
        }

        private void button_contact_MouseLeave(object sender, EventArgs e)
        {
            button_contact.ForeColor = Color.White;
        }

        private void button_contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs c1 = new ContactUs();
            c1.ShowDialog();
            this.Show();
        }
    }
}
