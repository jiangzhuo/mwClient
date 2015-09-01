namespace mwClient
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitRight = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitLeft = new System.Windows.Forms.Splitter();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitBottom = new System.Windows.Forms.Splitter();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.splitTop = new System.Windows.Forms.Splitter();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.splitPanelTop = new mwClient.Controls.SplitPanel();
            this.pnlTopCollapsed = new System.Windows.Forms.Panel();
            this.btnTopShow = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlTopCollapsed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlMain);
            this.panel1.Controls.Add(this.splitRight);
            this.panel1.Controls.Add(this.pnlRight);
            this.panel1.Controls.Add(this.splitLeft);
            this.panel1.Controls.Add(this.pnlLeft);
            this.panel1.Controls.Add(this.splitBottom);
            this.panel1.Controls.Add(this.pnlBottom);
            this.panel1.Controls.Add(this.splitTop);
            this.panel1.Controls.Add(this.pnlTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 1109);
            this.panel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(203, 207);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(980, 799);
            this.pnlMain.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 799);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 767);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 777);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitRight
            // 
            this.splitRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitRight.Location = new System.Drawing.Point(1183, 207);
            this.splitRight.Name = "splitRight";
            this.splitRight.Size = new System.Drawing.Size(3, 799);
            this.splitRight.TabIndex = 3;
            this.splitRight.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.propertyGrid1);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1186, 207);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(200, 799);
            this.pnlRight.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(200, 799);
            this.propertyGrid1.TabIndex = 0;
            // 
            // splitLeft
            // 
            this.splitLeft.Location = new System.Drawing.Point(200, 207);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Size = new System.Drawing.Size(3, 799);
            this.splitLeft.TabIndex = 2;
            this.splitLeft.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.treeView1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 207);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 799);
            this.pnlLeft.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 799);
            this.treeView1.TabIndex = 0;
            // 
            // splitBottom
            // 
            this.splitBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitBottom.Location = new System.Drawing.Point(0, 1006);
            this.splitBottom.Name = "splitBottom";
            this.splitBottom.Size = new System.Drawing.Size(1386, 3);
            this.splitBottom.TabIndex = 0;
            this.splitBottom.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.txtOutput);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 1009);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1386, 100);
            this.pnlBottom.TabIndex = 5;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1386, 100);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Text = "";
            // 
            // splitTop
            // 
            this.splitTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitTop.Location = new System.Drawing.Point(0, 204);
            this.splitTop.Name = "splitTop";
            this.splitTop.Size = new System.Drawing.Size(1386, 3);
            this.splitTop.TabIndex = 1;
            this.splitTop.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.flowLayoutPanel1);
            this.pnlTop.Controls.Add(this.splitPanelTop);
            this.pnlTop.Controls.Add(this.pnlTopCollapsed);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1386, 204);
            this.pnlTop.TabIndex = 6;
            // 
            // splitPanelTop
            // 
            this.splitPanelTop.Caption = null;
            this.splitPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitPanelTop.Location = new System.Drawing.Point(0, 28);
            this.splitPanelTop.Name = "splitPanelTop";
            this.splitPanelTop.Size = new System.Drawing.Size(1386, 25);
            this.splitPanelTop.TabIndex = 1;
            this.splitPanelTop.Close += new System.Action<object, System.EventArgs>(this.splitPanelTop_Close);
            this.splitPanelTop.Minimize += new System.Action<object, System.EventArgs>(this.splitPanelTop_Minimize);
            // 
            // pnlTopCollapsed
            // 
            this.pnlTopCollapsed.Controls.Add(this.btnTopShow);
            this.pnlTopCollapsed.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopCollapsed.Location = new System.Drawing.Point(0, 0);
            this.pnlTopCollapsed.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTopCollapsed.Name = "pnlTopCollapsed";
            this.pnlTopCollapsed.Padding = new System.Windows.Forms.Padding(2);
            this.pnlTopCollapsed.Size = new System.Drawing.Size(1386, 28);
            this.pnlTopCollapsed.TabIndex = 12;
            this.pnlTopCollapsed.Visible = false;
            // 
            // btnTopShow
            // 
            this.btnTopShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTopShow.FlatAppearance.BorderSize = 0;
            this.btnTopShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopShow.Image = global::mwClient.Properties.Resources.imgFolder;
            this.btnTopShow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTopShow.Location = new System.Drawing.Point(2, 2);
            this.btnTopShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnTopShow.Name = "btnTopShow";
            this.btnTopShow.Size = new System.Drawing.Size(102, 24);
            this.btnTopShow.TabIndex = 0;
            this.btnTopShow.Text = "Top Panel";
            this.btnTopShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTopShow.UseVisualStyleBackColor = true;
            this.btnTopShow.Click += new System.EventHandler(this.btnTopShow_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1386, 151);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 1119);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTopCollapsed.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Splitter splitRight;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Splitter splitLeft;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Splitter splitBottom;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Splitter splitTop;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.RichTextBox txtOutput;
        private Controls.SplitPanel splitPanelTop;
        private System.Windows.Forms.Panel pnlTopCollapsed;
        private System.Windows.Forms.Button btnTopShow;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}