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
            this.splitBottom = new System.Windows.Forms.Splitter();
            this.splitTop = new System.Windows.Forms.Splitter();
            this.splitLeft = new System.Windows.Forms.Splitter();
            this.splitRight = new System.Windows.Forms.Splitter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 683);
            this.panel1.TabIndex = 0;
            // 
            // splitBottom
            // 
            this.splitBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitBottom.Location = new System.Drawing.Point(0, 580);
            this.splitBottom.Name = "splitBottom";
            this.splitBottom.Size = new System.Drawing.Size(846, 3);
            this.splitBottom.TabIndex = 0;
            this.splitBottom.TabStop = false;
            // 
            // splitTop
            // 
            this.splitTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitTop.Location = new System.Drawing.Point(0, 100);
            this.splitTop.Name = "splitTop";
            this.splitTop.Size = new System.Drawing.Size(846, 3);
            this.splitTop.TabIndex = 1;
            this.splitTop.TabStop = false;
            // 
            // splitLeft
            // 
            this.splitLeft.Location = new System.Drawing.Point(200, 103);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Size = new System.Drawing.Size(3, 477);
            this.splitLeft.TabIndex = 2;
            this.splitLeft.TabStop = false;
            // 
            // splitRight
            // 
            this.splitRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitRight.Location = new System.Drawing.Point(643, 103);
            this.splitRight.Name = "splitRight";
            this.splitRight.Size = new System.Drawing.Size(3, 477);
            this.splitRight.TabIndex = 3;
            this.splitRight.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(203, 103);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(440, 477);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(646, 103);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(200, 477);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 103);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 477);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.txtOutput);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 583);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(846, 100);
            this.pnlBottom.TabIndex = 5;
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(846, 100);
            this.pnlTop.TabIndex = 6;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(846, 100);
            this.txtOutput.TabIndex = 7;
            this.txtOutput.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 683);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
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
    }
}