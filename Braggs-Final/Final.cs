using ShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braggs_Final
{
    public partial class Final : Form
    {

        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();

        public Final()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            Itemslistbox.DataSource = itemsBinding;
            Itemslistbox.DisplayMember = "Display";
            Itemslistbox.ValueMember = "Display";
            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;
            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

        }

        private void SetupData()
        {


            store.Vendors.Add(new Vendor { FirstName = "Morgan", LastName = "Kaemmerling" });
            store.Vendors.Add(new Vendor { FirstName = "Briann", LastName = "Billups" });
            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "Old book about a whale",
                Price = 8.50M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "NASB Bible",
                Description = "The History of Christianity",
                Price = 28.25M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Life's Golden Ticket",
                Description = "crap",
                Price = 5.50M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Win friends and influence people",
                Description = @"How to Win Friends and Influence People is one
                                of the first best-selling self-help books ever published.",
                Price = 4.10M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "The Girls of Mischief Bay",
                Description = "From New York Times bestselling author Susan Mallery comes a brand-new Mischief Bay series",
                Price = 18.45M,
                Owner = store.Vendors[1]
            });

            store.Name = "Good and Bad Books";

        }

        private void addtocart_Click(object sender, EventArgs e)
        {
            /*Figure out what item is selected from items list
             * Copy that item to the shopping cart
             * Should it remove the item from the item list? - No */

            Item selectedItem = (Item)Itemslistbox.SelectedItem;
            MessageBox.Show(selectedItem.Title);
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            /* Mark each item in the cart as sold
             *Clear the Cart */
             foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
            }
            shoppingCartData.Clear();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);

        }
    }



}
