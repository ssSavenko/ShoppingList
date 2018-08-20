using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class ShopppingListView : Form
    {
        public ShopppingListView()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductsList.SelectedItem.ToString() == NewItemName.Text.Trim())
            {
                AddButton.Enabled = true;
            }
            ProductsList.Items.Remove(ProductsList.Items[ProductsList.SelectedIndex]);        
        }

        private void NewItemName_TextChanged(object sender, EventArgs e)
        {
            bool isItemInList = false;
            for (int i = 0; i < ProductsList.Items.Count; i++)
            {
                if (ProductsList.Items[i].Equals(NewItemName.Text.Trim()))
                {
                    isItemInList = true;
                }
            }
            AddButton.Enabled = (NewItemName.Text.Length > 0 && !isItemInList);
        }

        private void AddButton_Click(object sender, EventArgs e)
        { 
            ProductsList.Items.Add(NewItemName.Text.Trim());
            NewItemName.Text = "";
        }

        private void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteButton.Enabled = (ProductsList.SelectedIndex >= 0);
        }
    }
}