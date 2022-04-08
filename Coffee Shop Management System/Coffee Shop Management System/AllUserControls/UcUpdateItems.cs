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
    public partial class UcUpdateItems : UserControl
    {
        Function fn = new Function();
        String query;
        public UcUpdateItems()
        {
            InitializeComponent();
        }

        private void UcUpdateItems_Load(object sender, EventArgs e)
        {
            
            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where Name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int Price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = Category;
            txtName.Text = Name;
            txtPrice.Text = Price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set Name '" + txtName.Text + "', Category='" + txtCategory.Text + "',Price=" + txtPrice.Text + " where iid=" + id + "";
            fn.setData(query);
            loadData();

            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
