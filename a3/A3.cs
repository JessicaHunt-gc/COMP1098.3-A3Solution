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
    public partial class A3 : Form
    {
        public A3()
        {
            InitializeComponent();
            Load += Form1_Load; //When the form is loaded run Form1_Load method
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //We are now ready to go, so we should update the count on the form
            //so that it isnt blank when the program starts.
            A_RecordAdded(null, null);
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //The button to add a record was clicked... what should we do?
            //Lets start with a new AddRecord Form.
            AddRecord a = new AddRecord();
            //Subscribe to the record added event, and call A_RecordAdded when that happens
            a.RecordAdded += A_RecordAdded;

            //Make the form visible
            a.Show();
            
        }

        private void A_RecordAdded(object sender, string e)
        {
            //Cound the lines in our output file and put that in the textbox.
            txtRecordCount.Text = System.IO.File.ReadLines("output.csv").Count().ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Terminate the application
            Application.Exit();
        }
    }
}
