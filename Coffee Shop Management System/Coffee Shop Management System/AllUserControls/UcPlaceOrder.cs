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
    public partial class UcPlaceOrder : UserControl
    {
        Function fn = new Function();
        string query;
        public UcPlaceOrder()
        {
            InitializeComponent();
        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {           
            String Category = ComboCategory.Text;
            query = "select name from items where Category = '"+ Category +"'";
            ShowItemList(query);
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {           
            String Category = ComboCategory.Text;
            query = "select name from items where Category = '" + Category + "' and name like'"+ TextSearch.Text+"%'";
            ShowItemList(query);
        }
        private void ShowItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantity.ResetText();
            txtTotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemNmae.Text = text;
            query = "select Price from items where Name = '" + text + "'";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }

        }

        private void txtQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantity.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }

        protected int n, total = 0;


        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            labelTotalAmnt.Text = "TK." + total;

        }

        private void UcPlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)       
        {
            if(txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtItemNmae.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuantity.Text;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "TK." + total;
            }
            else
            {
                MessageBox.Show("Minimum quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
