using Pomelo.DotNetClient;
using SimpleJson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mwClient
{
    public partial class GateLogin : Form
    {
        public static UserData userData = new UserData();
        public GateLogin()
        {
            InitializeComponent();
            statusLbl.Text = "ready to connect!";
            //            {
            //  "_id" : ObjectId("5492a20239ace4bb7fa49beb"),
            //  "sequence" : 1072,
            //  "platform" : "android_tencent",
            //  "bindId" : "533982726851F3D65AE2310EEB68EA5F",
            //  "createTime" : 1418895874380.0,
            //  "client" : "",
            //  "status" : 1,
            //  "password" : "792968c1-869a-11e4-abe7-27b787430bb0",
            //  "name" : "792968c0-869a-11e4-abe7-27b787430bb0",
            //  "__v" : 0
            //}
            usernameTb.Text = "792968c0-869a-11e4-abe7-27b787430bb0";
            passwordTb.Text = "792968c1-869a-11e4-abe7-27b787430bb0";

            resultStringLb.DataBindings.Add("Text",
                                      userData, "ResultString");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var client = new PomeloClient();
            userData.client = client;
            client.NetWorkStateChangedEvent += (state) =>
            {
                statusLbl.Text = "network state change:" + state;
            };

            statusLbl.Text = "client initating";

            var newThread = new Thread(new ThreadStart(() =>
            {
                statusLbl.Text = "Begin login";
                var baseUrl = "http://" + serverHostCb.SelectedItem.ToString() + ":3003/";
                var requestUrl = "";
                var requestBody = "";
                if (tabControl1.SelectedIndex == 0)
                {
                    requestUrl = baseUrl + "login";
                    requestBody = "{" + String.Format("\"username\":\"{0}\",\"password\":\"{1}\"", usernameTb.Text, passwordTb.Text) + "}";
                }
                else
                {
                    requestUrl = baseUrl + "bindLogin";
                    requestBody = "{" + String.Format("\"platform\":\"{0}\",\"bindId\":\"{1}\"", platformCb.SelectedItem.ToString(), bindidTb.Text) + "}";
                }

                var request = (HttpWebRequest)HttpWebRequest.Create(requestUrl);
                request.ContentType = "application/json; charset=utf-8";
                request.Accept = "application/json, text/javascript, */*";
                request.Method = "POST";
                try
                {
                    using (var writer = new StreamWriter(request.GetRequestStream()))
                    {
                        writer.Write(requestBody);
                    }
                }
                catch (Exception)
                {
                    statusLbl.Text = "no internet";
                    return;
                }

                var response = request.GetResponse();
                var stream = response.GetResponseStream();
                string json = "";

                using (var reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        json += reader.ReadLine();
                    }
                }

                dynamic loginResult = SimpleJson.SimpleJson.DeserializeObject(json);
                userData.ResultString = loginResult.ToString();
                if (loginResult.code != 200)
                {
                    statusLbl.Text = "login error:" + Convert.ToInt32(loginResult["code"]);
                    return;
                }
                else
                {
                    userData.uid = loginResult.uid;
                    userData.token = loginResult.token;
                }

                client.initClient(serverHostCb.SelectedItem.ToString(), Convert.ToInt32(portTb.Text),
                    () =>
                    {
                        statusLbl.Text = "client connecting";
                        client.connect(null, data =>
                        {
                            statusLbl.Text = "client connected";
                            statusLbl.Text += data.ToString();
                            Console.WriteLine("on data back" + data.ToString());
                            var msg = new JsonObject();
                            msg["uid"] = userData.uid;
                            client.request("gate.gateHandler.queryEntry", msg, OnQuery);
                        });
                    });
            }));
            newThread.Start();
        }


        public void OnQuery(dynamic result)
        {
            Console.WriteLine("onQuery");
            Console.WriteLine(result);
            if (result.code != 200)
            {
                statusLbl.Text = "queryEntry error:" + result.code;
                return;
            }
            userData.ResultString = result.ToString();
            userData.host = result.host;
            userData.port = Convert.ToInt32(result.port);
            //            var newWindowThread = new Thread(new
            //                                                 ThreadStart(() =>
            //                                                 {
            //                                                 }));
            var gamePlay = new frmMain(userData);
            //            newWindowThread.Start();
            Hide();
            gamePlay.Show();
            Application.Run();

            //            this.Hide();
            //            if(Convert. result["code"])
        }

        private void GateLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
