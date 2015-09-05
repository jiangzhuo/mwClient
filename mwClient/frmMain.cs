using log4net;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;
using SimpleJson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        private UserData userData;

        public frmMain()
        {
            InitializeComponent();
        }
        private static string locPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string dskPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private RichTextBoxAppender rba;
        private MessageBoxAppender mba;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMain(UserData userData)
        {
            this.userData = userData;
            InitializeComponent();

            //if (!Global.logger.Logger.Repository.Configured)
            //{
                rba = new RichTextBoxAppender(txtOutput);
                rba.Threshold = Level.All;
                rba.Layout = new PatternLayout("%date{dd-MM-yyyy HH:mm:ss.fff} %5level %message %n");
                LevelTextStyle ilts = new LevelTextStyle();
                ilts.Level = Level.Info;
                ilts.TextColor = Color.Yellow;
                ilts.PointSize = 10.0f;
                rba.AddMapping(ilts);
                LevelTextStyle dlts = new LevelTextStyle();
                dlts.Level = Level.Debug;
                dlts.TextColor = Color.LightBlue;
                dlts.PointSize = 10.0f;
                rba.AddMapping(dlts);
                LevelTextStyle wlts = new LevelTextStyle();
                wlts.Level = Level.Warn;
                wlts.TextColor = Color.Chartreuse;
                wlts.PointSize = 10.0f;
                rba.AddMapping(wlts);
                LevelTextStyle elts = new LevelTextStyle();
                elts.Level = Level.Error;
                elts.TextColor = Color.Crimson;
                elts.BackColor = Color.Cornsilk;
                elts.PointSize = 10.0f;
                rba.AddMapping(elts);
            
                BasicConfigurator.Configure(rba);
                rba.ActivateOptions();

            mba = new MessageBoxAppender();
            mba.Layout = new PatternLayout("%date{dd-MM-yyyy HH:mm:ss.fff} %5level %message %n");
            mba.Threshold = Level.Error;
            BasicConfigurator.Configure(mba);
            mba.ActivateOptions();

            RollingFileAppender fa = new RollingFileAppender();
                fa.AppendToFile = true;
                fa.Threshold = log4net.Core.Level.All;
                fa.RollingStyle = RollingFileAppender.RollingMode.Size;
                fa.MaxFileSize = 100000;
                fa.MaxSizeRollBackups = 3;
                fa.File = dskPath + @"\FgPleoraLog.txt";
                fa.Layout = new log4net.Layout.PatternLayout("%date{dd-MM-yyyy HH:mm:ss.fff} %5level %message (%logger{1}:%line)%n");
                log4net.Config.BasicConfigurator.Configure(fa);
                fa.ActivateOptions();
            //}
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            log.Debug("gameplay loaded");
            log.Debug(userData.ResultString);
            log.Debug("login success");
            var thread = new Thread(new ThreadStart(connectorEntry));
            thread.Start();
        }
        private void connectorEntry()
        {
            log.Debug("beginEntry connecting to connector");
            var client = userData.client;
            client.initClient(userData.Host, (int)userData.Port, () =>
            {
                log.Debug("client connecting");
                client.connect(null, data =>
                {
                    log.Debug("client connected");
                    log.Debug(data.ToString());
                    log.Debug("on data back" + data.ToString());
                    var msg = new JsonObject();
                    msg["token"] = userData.Token;
                    client.request("connector.entryHandler.entry", msg, OnEntry);
                });
            });
        }

        private void OnEntry(dynamic result)
        {
            log.Debug("onEntry");
            log.Debug(result);
            if (result.code != 200)
            {
                log.Debug("onEntry error:" + result.code);
                return;
            }
            userData.PlayerId = result.player.id;
            //            Console.WriteLine(userData.uid);
            userData.Uid = result.player.uid;
            userData.AreaId = (int)result.player.areaId;
            entryArea();
        }

        private void entryArea()
        {
            var msg = new JsonObject();
            userData.client.request("area.playerHandler.enterArea", msg, result =>
            {
                log.Debug("enterArea result");
                log.Debug(result);
                userData.ProcessenterAreaResult(result);
            });
        }

        public void Output(string output)
        {
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Console.WriteLine(111111);
            if (e.TabPageIndex == 1)
            {
                //this.gridContainerPanel.sc
            }
        }

        private void grid1_Load(object sender, EventArgs e)
        {
            using (Stream stream = new MemoryStream(Properties.Resources.mindway))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                grid1.mapArray = SimpleJson.SimpleJson.DeserializeObject(result);
            }
        }
    }
}
