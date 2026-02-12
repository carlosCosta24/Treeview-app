namespace Treeview_app
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.small = new System.Windows.Forms.ImageList(this.components);
            this.larg = new System.Windows.Forms.ImageList(this.components);
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.gbView = new System.Windows.Forms.GroupBox();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbDetails = new System.Windows.Forms.RadioButton();
            this.rdbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdbLargIcon = new System.Windows.Forms.RadioButton();
            this.rdbList = new System.Windows.Forms.RadioButton();
            this.rdbTile = new System.Windows.Forms.RadioButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbView.SuspendLayout();
            this.gbSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.larg;
            this.listView1.Location = new System.Drawing.Point(34, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(535, 258);
            this.listView1.SmallImageList = this.small;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(316, 23);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(109, 23);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Get Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(217, 70);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // small
            // 
            this.small.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("small.ImageStream")));
            this.small.TransparentColor = System.Drawing.Color.Transparent;
            this.small.Images.SetKeyName(0, "boy-3d.png");
            this.small.Images.SetKeyName(1, "girl-3d.png");
            // 
            // larg
            // 
            this.larg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("larg.ImageStream")));
            this.larg.TransparentColor = System.Drawing.Color.Transparent;
            this.larg.Images.SetKeyName(0, "boy-3d.png");
            this.larg.Images.SetKeyName(1, "girl-3d.png");
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(31, 23);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 20);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(31, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(92, 23);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 22);
            this.txbID.TabIndex = 7;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(92, 67);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 22);
            this.txbName.TabIndex = 8;
            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.rdbTile);
            this.gbView.Controls.Add(this.rdbList);
            this.gbView.Controls.Add(this.rdbLargIcon);
            this.gbView.Controls.Add(this.rdbSmallIcon);
            this.gbView.Controls.Add(this.rdbDetails);
            this.gbView.Location = new System.Drawing.Point(591, 136);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(175, 285);
            this.gbView.TabIndex = 9;
            this.gbView.TabStop = false;
            this.gbView.Text = "View";
            // 
            // gbSex
            // 
            this.gbSex.Controls.Add(this.rdbF);
            this.gbSex.Controls.Add(this.rdbM);
            this.gbSex.Location = new System.Drawing.Point(316, 70);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(275, 60);
            this.gbSex.TabIndex = 10;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Sex";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Checked = true;
            this.rdbM.Location = new System.Drawing.Point(0, 21);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(39, 20);
            this.rdbM.TabIndex = 11;
            this.rdbM.TabStop = true;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            this.rdbM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(150, 21);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(36, 20);
            this.rdbF.TabIndex = 12;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            this.rdbF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbDetails
            // 
            this.rdbDetails.AutoSize = true;
            this.rdbDetails.Checked = true;
            this.rdbDetails.Location = new System.Drawing.Point(36, 47);
            this.rdbDetails.Name = "rdbDetails";
            this.rdbDetails.Size = new System.Drawing.Size(88, 25);
            this.rdbDetails.TabIndex = 12;
            this.rdbDetails.TabStop = true;
            this.rdbDetails.Text = "Details";
            this.rdbDetails.UseVisualStyleBackColor = true;
            this.rdbDetails.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbSmallIcon
            // 
            this.rdbSmallIcon.AutoSize = true;
            this.rdbSmallIcon.Location = new System.Drawing.Point(36, 104);
            this.rdbSmallIcon.Name = "rdbSmallIcon";
            this.rdbSmallIcon.Size = new System.Drawing.Size(121, 25);
            this.rdbSmallIcon.TabIndex = 13;
            this.rdbSmallIcon.Text = "Small Icons";
            this.rdbSmallIcon.UseVisualStyleBackColor = true;
            this.rdbSmallIcon.CheckedChanged += new System.EventHandler(this.rdbSmallIcon_CheckedChanged);
            // 
            // rdbLargIcon
            // 
            this.rdbLargIcon.AutoSize = true;
            this.rdbLargIcon.Location = new System.Drawing.Point(36, 154);
            this.rdbLargIcon.Name = "rdbLargIcon";
            this.rdbLargIcon.Size = new System.Drawing.Size(113, 25);
            this.rdbLargIcon.TabIndex = 14;
            this.rdbLargIcon.Text = "Larg Icons";
            this.rdbLargIcon.UseVisualStyleBackColor = true;
            this.rdbLargIcon.CheckedChanged += new System.EventHandler(this.rdbLargIcon_CheckedChanged);
            // 
            // rdbList
            // 
            this.rdbList.AutoSize = true;
            this.rdbList.Location = new System.Drawing.Point(36, 201);
            this.rdbList.Name = "rdbList";
            this.rdbList.Size = new System.Drawing.Size(60, 25);
            this.rdbList.TabIndex = 15;
            this.rdbList.Text = "List";
            this.rdbList.UseVisualStyleBackColor = true;
            this.rdbList.CheckedChanged += new System.EventHandler(this.rdbList_CheckedChanged);
            // 
            // rdbTile
            // 
            this.rdbTile.AutoSize = true;
            this.rdbTile.Location = new System.Drawing.Point(36, 246);
            this.rdbTile.Name = "rdbTile";
            this.rdbTile.Size = new System.Drawing.Size(64, 25);
            this.rdbTile.TabIndex = 16;
            this.rdbTile.Text = "Tile";
            this.rdbTile.UseVisualStyleBackColor = true;
            this.rdbTile.CheckedChanged += new System.EventHandler(this.rdbTile_CheckedChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            // 
            // Form2
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.gbView);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbView.ResumeLayout(false);
            this.gbView.PerformLayout();
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ImageList small;
        private System.Windows.Forms.ImageList larg;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbTile;
        private System.Windows.Forms.RadioButton rdbList;
        private System.Windows.Forms.RadioButton rdbLargIcon;
        private System.Windows.Forms.RadioButton rdbSmallIcon;
        private System.Windows.Forms.RadioButton rdbDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}