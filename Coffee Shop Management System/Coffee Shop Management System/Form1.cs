using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GuestLabel_Click(object sender, EventArgs e)
        {

        }

        private void GuestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboaed ds = new Dashboaed("Guest");
            ds.Show();
            this.Hide();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UserNmaeTextBox.Text=="bdcoffee" && PasswordTextBox.Text=="pass")
            {
                Dashboaed ds = new Dashboaed("Owner");
                ds.Show();
                this.Hide();
            }
        }
    }
}
