using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Connect_Arduino
{

    public partial class Form1 : Form
    {

        ArduinoConnectSerial Arduino1 = new ArduinoConnectSerial();

        public Form1()
        {
            InitializeComponent();
            ButtonTrennen.Visible = false;
        }
        
        private void ButtonVerbinden_Click(object sender, EventArgs e)
        {
            Arduino1.Verbinden(textBoxPort.Text);
            ButtonVerbinden.Visible = false;
            ButtonTrennen.Visible = true;
        }

        private void ButtonTrennen_Click(object sender, EventArgs e)
        {
            Arduino1.Trennen();
            ButtonVerbinden.Visible = true;
            ButtonTrennen.Visible = false;
        }

        private void ButtonBlinken_Click(object sender, EventArgs e)
        {
            Arduino1.NachrichtSenden("blink");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Arduino1.Trennen();
        }
    }
}
