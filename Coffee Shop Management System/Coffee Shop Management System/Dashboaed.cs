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
    public partial class Dashboaed : Form
    {
        public Dashboaed()
        {
            InitializeComponent();
        }
        public Dashboaed(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                AddItemsLabel.Hide();
                UpdateItemsLabel.Hide();
                RemoveItemsLabel.Hide();
            }
            else if (user == "Owner")
            {
                AddItemsLabel.Show();
                UpdateItemsLabel.Show();
                RemoveItemsLabel.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void AddItemsLabel_Click(object sender, EventArgs e)
        {
            ucAddItems1.Visible = true;
            ucAddItems1.BringToFront();
        }

        private void Dashboaed_Load(object sender, EventArgs e)
        {
            ucAddItems1.Visible = false;
            ucPlaceOrder1.Visible = false;
            ucRemoveItems1.Visible = false;
        }

        private void ucAddItems1_Load(object sender, EventArgs e)
        {

        }

        private void PlaceOrderLabel_Click(object sender, EventArgs e)
        {
            ucWelcome1.SendToBack();
            ucPlaceOrder1.Visible = true;
            ucPlaceOrder1.BringToFront();
        }

        private void ucPlaceOrder1_Load(object sender, EventArgs e)
        {

        }

        private void RemoveItemsLabel_Click(object sender, EventArgs e)
        {
            ucRemoveItems1.Visible = true;
            ucRemoveItems1.BringToFront();
        }
    }
}
