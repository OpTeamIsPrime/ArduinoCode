using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using Iot.Device.Arduino;

namespace IsPrimeAppV4
{
    
    public partial class ManualForm : Form
    {
        public bool Red;
        public bool Green;
        public bool Blue;
        public Keys Forward = Keys.Z;
        public Keys Back = Keys.S;
        public Keys Right = Keys.D;
        public Keys Left = Keys.Q;
        public Keys Grab = Keys.Space;



        public ManualForm()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public IFirmataProtocol Session = null;
        public ArduinoSession cession = null;
        private Color GetCol()
        {
            Color acc = Color.Orange;
            if (Green)
            {
                acc = Color.Green;
            }
            else if (Blue)
            {
                acc = Color.Blue;
            }
            return acc;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();//sem filtro
            Bitmap video1 = (Bitmap)eventArgs.Frame.Clone();// imagem com filtro

            BlobCounter bc = new BlobCounter
            {
                MinWidth = 5,
                MinHeight = 5,
                FilterBlobs = true,
                ObjectsOrder = ObjectsOrder.Size
            };

            EuclideanColorFiltering filter = new EuclideanColorFiltering
            {
                CenterColor = new RGB(GetCol()),
                Radius = 100
            };

            filter.ApplyInPlace(video1);//aplicando o filtro


            bc.ProcessImage(video1);// processando a imagem que ja foi filtrada para identificar objetos
            Rectangle[] rects = bc.GetObjectsRectangles();
            foreach (Rectangle recs in rects)
                if (rects.Length > 0)
                {
                    Rectangle objectRect = rects[0];
                    Graphics g = Graphics.FromImage(video);//identificar objetos a partir da imagem com filtro
                    Graphics h = Graphics.FromImage(video1);
                    using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
                    {
                        g.DrawRectangle(pen, objectRect);
                        h.DrawRectangle(pen, objectRect);
                    }
                    g.Dispose();
                    h.Dispose();
                }
            pic.Image = video;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboCamera.Items.Add(filterInfo.Name);
            }
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        public void activationservo(ArduinoSession session)
        {
            session.ConfigureServo(8, 0, 360);
            session.SetDigitalPin(8, true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            ISerialConnection connection = GetConnection();

            if (connection == null)
            {
                lbArduino.Text = "No connection found. Make shure your Arduino board is attached to a USB port.";
            }

            else
            {
                lbArduino.Text = ($"Connected to port {connection.PortName} at {connection.BaudRate} baud.");
                Session = new ArduinoSession(connection);
                cession = new ArduinoSession(connection);
            }
            ArduinoInit(Session);
        }
      
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(e.KeyCode==Keys.Z)
        }
        private static ISerialConnection GetConnection()
        {
            ISerialConnection connection = EnhancedSerialConnection.Find();
            return connection;
        }
       
        private static void ArduinoInit(IFirmataProtocol session)//initialisateion of all pins
        {
            session.SetDigitalPinMode(7, PinMode.DigitalOutput);
            session.SetDigitalPinMode(6, PinMode.DigitalOutput);
            session.SetDigitalPinMode(5, PinMode.DigitalOutput);
            session.SetDigitalPinMode(4, PinMode.DigitalOutput);
            session.SetDigitalPinMode(13,PinMode.DigitalOutput);
        }
        private static void ArduinoMovementsForward(IFirmataProtocol session)//function to start the movements of the robot
        {
            

            session.SetDigitalPin(4, false);
            session.SetDigitalPin(5, true);
            session.SetDigitalPin(6, false);
            session.SetDigitalPin(7, true);

        }
        private static void ArduinoMovementsBack(IFirmataProtocol session)//function to start the movements of the robot
        {
            session.SetDigitalPin(4, true);
            session.SetDigitalPin(5, false);
            session.SetDigitalPin(6, true);
            session.SetDigitalPin(7, false);

        }
        private static void ArduinoMovementsRight(IFirmataProtocol session)//function to start the movements of the robot
        {
            session.SetDigitalPin(4, true);
            session.SetDigitalPin(5, false);
            session.SetDigitalPin(6, false);
            session.SetDigitalPin(7, true);

        }
        private static void ArduinoMovementsLeft(IFirmataProtocol session)//function to start the movements of the robot
        {
            session.SetDigitalPin(4, false);
            session.SetDigitalPin(5, true);
            session.SetDigitalPin(6, true);
            session.SetDigitalPin(7, false);

        }
        private static void ArduinoMovementsStop(IFirmataProtocol session)//function to stop the movements of the robot
        {
            session.SetDigitalPin(4, false);
            session.SetDigitalPin(5, false);
            session.SetDigitalPin(6, false);
            session.SetDigitalPin(7, false);
        }

        private static void ArduinoServo(IFirmataProtocol session)//function to stop the movements of the robot
        {
            session.SetDigitalPin(4, false);
            session.SetDigitalPin(5, false);
            session.SetDigitalPin(6, false);
            session.SetDigitalPin(7, false);
        }
        private void Attraper_pince(ArduinoSession session)
        {
            session.SetDigitalPinMode(10, PinMode.DigitalOutput);
            session.ConfigureServo(10, 0, 360);
            session.SetDigitalPinMode(11, PinMode.DigitalOutput);
            session.ConfigureServo(11, 0, 360);
            session.SetDigitalPinMode(12, PinMode.DigitalOutput);
            session.ConfigureServo(12, 0, 360);

            session.SetDigitalPin(12, 140);
            Thread.Sleep(2000);

            session.SetDigitalPin(10, 0);
            Thread.Sleep(2000);
            session.SetDigitalPin(11, 0);
            Thread.Sleep(2000);
            session.SetDigitalPin(12, 140);
            Thread.Sleep(2000);


            session.SetDigitalPin(12, 180);
            Thread.Sleep(2000);
            session.SetDigitalPin(11, 180);
            Thread.Sleep(2000);
            session.SetDigitalPin(10, 180);
            Thread.Sleep(2000);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Blue = true;
            Red = false;
            Green = false;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Green = true;
            Red = false;
            Blue = false;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            Red = true;
            Green = false;
            Blue = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                ArduinoMovementsForward(Session);
            }
            if (e.KeyCode == Keys.A)
            {
                ArduinoMovementsStop(Session);
            }
            if (e.KeyCode == Keys.S)
            {
                ArduinoMovementsBack(Session);
            }
            if (e.KeyCode == Keys.D)
            {
                ArduinoMovementsRight(Session);
            }
            if (e.KeyCode == Keys.Q)
            {
                ArduinoMovementsLeft(Session);
            }
            if (e.KeyCode == Keys.Space)
            {
                Attraper_pince(cession);
            }
        }

    }
}
