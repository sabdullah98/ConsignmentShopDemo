using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;
            itemsListBox.DisplayMember = "Display";
            itemsListBox.DisplayMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorsBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Satya", LastName = "Nadella" });
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Gates" });

            store.Items.Add(new Item { Title = "Moby Dick", Description = "A book on Whale", Price = 4.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Like a Virgin", Description = "Sir, Richard Branson's Book", Price = 5.50M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "A Tale of Two Cities", Description = "A book on Whale", Price = 3.80M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Harry Potter", Description = "A book on Whale", Price = 2.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Intro to C#", Description = "A book by Abdullah", Price = 7.50M, Owner = store.Vendors[1] });

            store.Name = "Seconds are better";
        }

        private void ConsignmentShop_Load(object sender, EventArgs e)
        {

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            //find what is selected
            //copy that to cart
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            //mark the product as sold
            //clear cart
            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("Rs {0}",storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
