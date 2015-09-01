using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mwClient
{
    public enum PanelPosition
    {
        Top,
        Bottom,
        Left,
        Right
    }

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnTopShow_Click(object sender, EventArgs e)
        {
            splitPanelTop.Visible = true;

            pnlTopCollapsed.Visible = false;

            pnlTop.Height = Properties.Settings.Default.TopPanelHeight;

            splitTop.Visible = true;
        }

        private void splitPanelTop_Minimize(object sender, EventArgs e)
        {
            splitPanelTop.Visible = false;

            pnlTopCollapsed.Visible = true;
            //pnlTopCollapsed.Dock = DockStyle.Top;

            pnlTop.Height = 32;

            splitTop.Visible = false;
        }

        private void splitPanelTop_Close(object sender, EventArgs e)
        {
            CollapsePanel(PanelPosition.Top);
        }

        public void CollapsePanel(PanelPosition position)
        {
            switch (position)
            {
                case PanelPosition.Top:
                    pnlTop.Visible = false;
                    splitTop.Visible = false;
                    Properties.Settings.Default.TopPanelVisible = false;
                    break;
                case PanelPosition.Bottom:
                    pnlBottom.Visible = false;
                    splitBottom.Visible = false;
                    Properties.Settings.Default.BottomPanelVisible = false;
                    break;
                case PanelPosition.Left:
                    pnlLeft.Visible = false;
                    splitLeft.Visible = false;
                    Properties.Settings.Default.LeftPanelVisible = false;
                    break;
                case PanelPosition.Right:
                    pnlRight.Visible = false;
                    splitRight.Visible = false;
                    Properties.Settings.Default.RightPanelVisible = false;
                    break;
            }

            Properties.Settings.Default.Save();
        }

    }
}
