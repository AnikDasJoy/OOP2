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
    public partial class UcAddItems : UserControl
    {
        Function fn = new Function();
        String query;
        public UcAddItems()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            query = "insert into items(Name, Cetegory, Price) values('"+ ItemNameTextBox.Text+"','"+ CategoryComboBox.Text+"',"+ PriceTextBox.Text+ ")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            CategoryComboBox.SelectedIndex = -1;
            ItemNameTextBox.Clear();
            PriceTextBox.Clear();
        }

        private void UcAddItems_Load(object sender, EventArgs e)
        {

        }

        private void UcAddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
