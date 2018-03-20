using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a3
{
    public partial class AddRecord : Form
    {
        public event EventHandler<String> RecordAdded;
        public AddRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Remove any comma's and create a csv string
            String o = textBox1.Text.Replace(",","") + "," + textBox2.Text.Replace(",", "") + "," + checkBox1.Checked + "," + textBox3.Text.Replace(",", "");
            //Add this to the end of our output file, and add a newline
            System.IO.File.AppendAllText("output.csv", o + System.Environment.NewLine);
            //Throw an event letting anyone who cares know that we have updated our file.
            RecordAdded?.Invoke(this,"");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
