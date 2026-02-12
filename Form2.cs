using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treeview_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbID.Text) || string.IsNullOrEmpty(txbName.Text))
            {
                return;
            }
            ListViewItem Item = new ListViewItem(txbID.Text.Trim());
            if (rdbM.Checked) { 
                Item.ImageIndex = 0;
            }
            else
            {
                Item.ImageIndex = 1;
            }
            Item.SubItems.Add(txbName.Text.Trim());
            listView1.Items.Add(Item);

            txbName.Clear();
            txbID.Clear();  
            txbID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0 && listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ListViewItem Item;
            
            for (byte i = 0; i <= 10; i++)
            {
                string Id = $"{i}";
                string Name = $"Person {i}";
                Item = new ListViewItem(Id);
                if(i % 2 == 0)
                {
                    Item.ImageIndex = 0;
                }
                else
                {
                    Item.ImageIndex = 1;
                }

                Item.SubItems.Add(Name);
                listView1.Items.Add(Item);
            }
        }

        private void rdbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rdbLargIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rdbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rdbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}
