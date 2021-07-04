using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        static SerialPort serialPort;
        String asd = "";
        private Thread thread2 = null;
        Boolean pauseLogcatIs = false;

        public Form1()
        {
            InitializeComponent();

            initSport();
            initClicker();
        }

        private void initClicker()
        {
            button1.Click += new System.EventHandler(this.button1_Clicker);
        }

        private void button1_Clicker(object sender, EventArgs e)
        {
            asd = "";
            textBox1.Clear();
        }

        private void initSport()
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 115200; //115200
            serialPort.Open();
            serialPort.DtrEnable = true;
            serialPort.RtsEnable = true;

            //System.Timers.Timer t = new System.Timers.Timer(200); // 1 sec = 1000, 30 mins = 1800000 
            //t.AutoReset = true;
            //t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
            //t.Start();
            thread2 = new Thread(new ThreadStart(setText));
            thread2.Start();
        }
        int X = 0;
        int Y = 0;
        List<int> termsList = new List<int>();

        List<int> pressureValues1 = new List<int>();
        List<int> pressureValues2 = new List<int>();
        List<int> pressureValues3 = new List<int>();
        List<int> pressureValues4 = new List<int>();
        int TypeOfPressure = 1;


        public void setText() {
            while (true)
            {

                //serialPort.Write("1");
                
                //serialPort.Write(new byte[] { 0x74, 0x00 ,0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, 0, 10);

                

                //int bytes = serialPort.BytesToRead;
                //byte[] buffer = new byte[bytes];
                //serialPort.Read(buffer, 0, bytes);
               // System.Diagnostics.Debug.WriteLine("RCC:" + buffer );

                string msg = serialPort.ReadExisting();
                //int length = serialPort.BytesToRead;
                //byte[] buf = new byte[length];

                //serialPort.Read(buf, 0, length);
               // System.Diagnostics.Debug.WriteLine("Received Data:" + buf);
                //string msg = " " + buf;

                //labelSerialMessage.Invoke(this.showSerialPortDelegate, new object[] {
                //System.Text.Encoding.Default.GetString(buf, 0, buf.Length) });
                
                //System.Diagnostics.Debug.WriteLine("RCC:" + msg);





                

                //Console.WriteLine(msg);


                

                int length = serialPort.ReadByte();
                byte[] buf = new byte[length];
                int a = serialPort.Read(buf, 0, length);

                System.Console.WriteLine(a); // 17 - 16 size
                byte[] arrayThree = { 15,   0,   0, 128,  16,  39, 240, 216, 241, 255, 127 };

                
                try {

                    string s = System.Text.Encoding.UTF8.GetString(buf, 0, buf.Length);

                    X = (BitConverter.ToInt16(buf, 1));
                    Y = (BitConverter.ToInt16(buf, 1));
                    

                    System.Console.WriteLine(" ** " + BitConverter.ToInt16(buf,1));
                    System.Console.WriteLine(" // " + BitConverter.ToString(buf));
                    asd += Environment.NewLine + "\n \n ▶ " + BitConverter.ToString(buf);




                    if (a == 17) {

                        termsList.Add(BitConverter.ToInt16(buf, 1));
                        termsList.Add(BitConverter.ToInt16(buf, 2));
                        termsList.Add(BitConverter.ToInt16(buf, 3));
                        termsList.Add(BitConverter.ToInt16(buf, 4));
                        termsList.Add(BitConverter.ToInt16(buf, 5));
                        termsList.Add(BitConverter.ToInt16(buf, 6));
                        termsList.Add(BitConverter.ToInt16(buf, 7));

                        if (termsList.Count > 14) {

                            termsList.RemoveAt(0);
                            termsList.RemoveAt(1);
                            termsList.RemoveAt(2);
                            termsList.RemoveAt(3);
                            termsList.RemoveAt(4);
                            termsList.RemoveAt(5);

                        }
                    } else if (a == 15) {
                        if (TypeOfPressure > 3)
                        {
                            TypeOfPressure = 1;
                        }


                        switch (TypeOfPressure)
                        {
                            case 1:
                                pressureValues1.Add(BitConverter.ToInt16(buf, 1));
                                pressureValues1.Add(BitConverter.ToInt16(buf, 2));
                                pressureValues1.Add(BitConverter.ToInt16(buf, 3));
                                pressureValues1.Add(BitConverter.ToInt16(buf, 4));
                                pressureValues1.Add(BitConverter.ToInt16(buf, 5));
                                pressureValues1.Add(BitConverter.ToInt16(buf, 6));
                                pressureValues1.Add(BitConverter.ToInt16(buf, 7));

                                if (pressureValues1.Count > 64)
                                {

                                    pressureValues1.RemoveAt(0);
                                    pressureValues1.RemoveAt(1);
                                    pressureValues1.RemoveAt(2);
                                    pressureValues1.RemoveAt(3);
                                    pressureValues1.RemoveAt(4);
                                    pressureValues1.RemoveAt(5);

                                }
                                break;
                            case 2:
                                pressureValues2.Add(BitConverter.ToInt16(buf, 1));
                                pressureValues2.Add(BitConverter.ToInt16(buf, 2));
                                pressureValues2.Add(BitConverter.ToInt16(buf, 3));
                                pressureValues2.Add(BitConverter.ToInt16(buf, 4));
                                pressureValues2.Add(BitConverter.ToInt16(buf, 5));
                                pressureValues2.Add(BitConverter.ToInt16(buf, 6));
                                pressureValues2.Add(BitConverter.ToInt16(buf, 7));
                                if (pressureValues2.Count > 64)
                                {
                                    pressureValues2.RemoveAt(0);
                                    pressureValues2.RemoveAt(1);
                                    pressureValues2.RemoveAt(2);
                                    pressureValues2.RemoveAt(3);
                                    pressureValues2.RemoveAt(4);
                                    pressureValues2.RemoveAt(5);
                                }
                                break;
                            case 3:
                                pressureValues3.Add(BitConverter.ToInt16(buf, 1));
                                pressureValues3.Add(BitConverter.ToInt16(buf, 2));
                                pressureValues3.Add(BitConverter.ToInt16(buf, 3));
                                pressureValues3.Add(BitConverter.ToInt16(buf, 4));
                                pressureValues3.Add(BitConverter.ToInt16(buf, 5));
                                pressureValues3.Add(BitConverter.ToInt16(buf, 6));
                                pressureValues3.Add(BitConverter.ToInt16(buf, 7));
                                if (pressureValues3.Count > 64)
                                {
                                    pressureValues3.RemoveAt(0);
                                    pressureValues3.RemoveAt(1);
                                    pressureValues3.RemoveAt(2);
                                    pressureValues3.RemoveAt(3);
                                    pressureValues3.RemoveAt(4);
                                    pressureValues3.RemoveAt(5);
                                }
                                break;

                            case 4:
                                pressureValues4.Add(BitConverter.ToInt16(buf, 1));
                                pressureValues4.Add(BitConverter.ToInt16(buf, 2));
                                pressureValues4.Add(BitConverter.ToInt16(buf, 3));
                                pressureValues4.Add(BitConverter.ToInt16(buf, 4));
                                pressureValues4.Add(BitConverter.ToInt16(buf, 5));
                                pressureValues4.Add(BitConverter.ToInt16(buf, 6));
                                pressureValues4.Add(BitConverter.ToInt16(buf, 7));
                                if (pressureValues4.Count > 64)
                                {
                                    pressureValues4.RemoveAt(0);
                                    pressureValues4.RemoveAt(1);
                                    pressureValues4.RemoveAt(2);
                                    pressureValues4.RemoveAt(3);
                                    pressureValues4.RemoveAt(4);
                                    pressureValues4.RemoveAt(5);
                                }
                                break;

                            default:
                                Console.WriteLine("##########################Undefined!!##########################");
                                break;
                        }
                        

                        TypeOfPressure++;
                    }
                    //byte asd = buf[1];
                    

                    //System.Console.WriteLine(" // " + Convert.ToInt16(asd));
                } catch (Exception e) {
                    
                }
                if (pauseLogcatIs) {
                    WriteTextSafe("\n" + "###################" + asd);
                }
                


                //Thread.Sleep(1000);
            }
        }
        private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            //string msg = serialPort.ReadExisting();
            //asd += "new: "+msg;

           // Console.WriteLine("\n"+msg);


            //WriteTextSafe(asd);
            
            // do stuff every 30  minute
        }
        private void WriteTextSafe(string text)
        {
            if (textBox1.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                textBox1.Invoke(d, new object[] { text });
            }
            else
            {
                textBox1.AppendText("~~~~~~~~~~~~ \n \n"+text);
                //textBox1.AppendText(Environment.NewLine);

                //chart1.Series[0].Points.AddXY(X, Y);

                chart1.Series[0].Points.DataBindY(termsList);

                pressureChart2.Series[0].Points.DataBindY(pressureValues1);
                pressureChart3.Series[0].Points.DataBindY(pressureValues2);
                pressureChart4.Series[0].Points.DataBindY(pressureValues3);
                //pressureChart5.Series[0].Points.DataBindY(pressureValues1);

            }
        }

        
        private delegate void SafeCallDelegate(string text);

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pauseLogcatIs = !pauseLogcatIs;
        }
    }
}
