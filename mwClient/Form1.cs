using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mwClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "mwClient.mindway.json";
            //Console.WriteLine(assembly.GetManifestResourceNames());
            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    string result = reader.ReadToEnd();
            //    var mapArray = (int[,])SimpleJson.SimpleJson.DeserializeObject(result);
            //    Console.WriteLine(mapArray[0, 2]);
            //}

            //Stream stream = new MemoryStream( Properties.Resources.mindway);
            //StreamReader reader = new StreamReader(stream);
            //string result = reader.ReadToEnd();
            //dynamic mapArray = SimpleJson.SimpleJson.DeserializeObject(result);
            //Console.WriteLine(mapArray[0][1]);



            using (Stream stream = new MemoryStream(Properties.Resources.mindway))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                gridControl1.mapArray = SimpleJson.SimpleJson.DeserializeObject(result);
            }
        }
    }
}
