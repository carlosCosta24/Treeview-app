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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckAll(e.Node, e.Node.Checked);
        }
        private void CheckAll(TreeNode Node, Boolean IsChecked) {

            foreach (TreeNode Child in Node.Nodes) { 
                Child.Checked = IsChecked;
                if (Child.Nodes.Count > 0) { 
                    this.CheckAll(Child, IsChecked);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode Family = new TreeNode("Family");

            Family.Nodes.Add("koda");
            Family.Nodes.Add("lua");
            treeView1.Nodes.Add(Family);

        }
    }
}
