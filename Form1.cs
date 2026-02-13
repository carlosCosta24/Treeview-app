using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            for (int i = 1; i <= 10; i++) {

                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(800);
                    progressBar1.Value += 10;
                    label1.Text = (((float)progressBar1.Value / progressBar1.Maximum) * 100) + "%";

                    progressBar1.Refresh();
                    label1.Refresh();
                }
                else { 
                    button1.Enabled = false;
                }
            
            
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ListView = new Form2();
            ListView.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form TrackBar = new Form3();
            TrackBar.ShowDialog();  
        }
    }
}
