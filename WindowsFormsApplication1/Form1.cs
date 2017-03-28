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
        byte[] toSend = new byte[] { 0x7E, 0x00, 0x00, 0x00 };

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
/* ----------------------------------------Краны основного шкафа---------------------------------------------------- */


        private void button3_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x00;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x00;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x01;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x01;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x02;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x02;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x03;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x03;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x04;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x04;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x05;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x05;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x06;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x06;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x07;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x07;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x08;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x08;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x09;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x09;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0A;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0A;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0B;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0B;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0C;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0C;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0D;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0D;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0E;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x00;
            toSend[2] = 0x0E;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

 /* ----------------------------------------Краны дополнительного шкафа Доп_1---------------------------------------------------- */
        private void button52_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x00;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button51_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x00;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button50_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x01;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button49_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x01;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button48_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x02;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button47_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x02;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button46_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x03;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button45_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x03;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button44_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x04;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button43_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x04;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button42_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x05;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button41_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x05;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button40_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x06;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button39_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x06;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button38_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x07;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button37_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x07;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x08;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x08;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x09;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button33_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x01;
            toSend[2] = 0x09;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        /* ----------------------------------------Краны дополнительного шкафа Доп_2---------------------------------------------------- */
        private void button72_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x00;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button71_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x00;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button70_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x01;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button69_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x01;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button68_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x02;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button67_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x02;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button66_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x03;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button65_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x03;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button64_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x04;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button63_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x04;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button62_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x05;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button61_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x05;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button60_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x06;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button59_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x06;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button58_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x07;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button57_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x07;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button56_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x08;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button55_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x08;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button54_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x09;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button53_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x02;
            toSend[2] = 0x09;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }

        /* ----------------------------------------Краны дополнительного шкафа Доп_3---------------------------------------------------- */
        private void button73_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x00;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button74_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x00;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button75_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x01;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button76_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x01;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button77_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x02;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button78_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x02;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button79_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x03;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button80_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x03;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button81_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x04;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button82_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x04;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button83_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x05;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button84_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x05;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button85_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x06;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button86_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x06;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button87_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x07;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button88_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x07;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button89_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x08;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button90_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x08;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button91_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x09;
            toSend[3] = 0x00;
            serialPort1.Write(toSend, 0, 4);
        }
        private void button92_Click(object sender, EventArgs e)
        {
            toSend[1] = 0x03;
            toSend[2] = 0x09;
            toSend[3] = 0x01;
            serialPort1.Write(toSend, 0, 4);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
