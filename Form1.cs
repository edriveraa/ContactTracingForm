using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactTracingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btsub_Click(object sender, EventArgs e)
        {
            submit(tbname.Text, (tbadd.Text), int.Parse(tbtemp.Text), int.Parse(tbage.Text));
        }
        private void submit(String name, string address, int temp, int age)
        {
            StreamWriter sw = File.AppendText("data.txt");
            sw.WriteLine(name);
            sw.WriteLine(address);
            sw.WriteLine(temp.ToString());
            sw.WriteLine(age.ToString());
            sw.Close();
            MessageBox.Show("Information successfully submitted.");
        }

    }
}

