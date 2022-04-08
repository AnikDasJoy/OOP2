using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop_Management_System.AllUserControls
{
    public partial class UcRemoveItems : UserControl
    {
        Function fn = new Function();
        String query;
        public UcRemoveItems()
        {
            InitializeComponent();
        }

        private void UcRemoveItems_Load(object sender, EventArgs e)
        {
            //DelLabel.Text = "DELETE item";
            //loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where Nmae like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void UcRemoveItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
