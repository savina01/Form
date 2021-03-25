using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class FormOrders : Form
    {
        private AllOrders _allOrder = new AllOrders();

        public FormOrders()
        {
            InitializeComponent();
            _allOrder.OnChangeName += AllOrderChange;
        }
        private void AllOrderChange()
        {
            RefreshListBoxOrder();
        }
        private void RefreshListBoxOrder()
        {
            listBoxOrders.Items.Clear();
            listBoxOrders.Items.AddRange(
                _allOrder.FindByName(textBoxNameSearch.Text));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var fo = new FormNewOrder();
            fo.Order = new Order();

            if (fo.ShowDialog() == DialogResult.OK)
            {
                _allOrder.Add(fo.Order);    
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void listBoxOrders_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedItem == null)
                return;

            var fo = new FormNewOrder();
            fo.Order = (Order)listBoxOrders.SelectedItem;       
            
            fo.ShowDialog();

        }
        private void Delete()
        {
            if (listBoxOrders.SelectedItem == null)
                return;

            if (MessageBox.Show(
                "Are you sure?",
                "Confirm delete",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _allOrder.Remove((Order)
                    listBoxOrders.SelectedItem);
            }
        }
        private void listBoxOrders_KeyDown(object sender, KeyEventArgs e)
        {
            Delete();
        }

        private void textBoxNameSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshListBoxOrder();
        }

        private void ButtonDelivery_Click(object sender, EventArgs e)
        {
            var fd = new FormDelivery();

            fd.ShowDialog();
        }
    }
}
