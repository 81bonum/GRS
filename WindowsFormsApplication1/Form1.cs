using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        static SerialPort serialPort1;
        

        public Form1()
        {
            InitializeComponent();
            GetAvilablePorts();
            serialPort1 = new SerialPort();
           
        }
        void GetAvilablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            try
            {
                if(comboBox2.Text==""||comboBox1.Text=="")
                {
                    textBox1.Text = "Настройте порт";
                     
                }
                else
                {
                   
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    button93.Enabled = true;
       
                    textBox1.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = true;
                }

            }
            catch(UnauthorizedAccessException)
            {
                textBox1.Text = "Порт занят";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            button93.Enabled = false;
      
            button1.Enabled  = true;
            button2.Enabled  = false;
            textBox1.Enabled = false;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox1.Text);
            textBox1.Text = "";
        }

        private void button94_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] toSend = new byte[] { 0xE7, 0x01, 0x01, 0x01 };
            serialPort1.Write(toSend, 0, 3);
        }
    }
}
