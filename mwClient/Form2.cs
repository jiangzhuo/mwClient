using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mwClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
