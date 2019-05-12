using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Timers;

namespace Cronometro2._0
{
    public partial class Form1 : Form
    {
        Crono tiempo;
        int miliseconds = 0;
        int seconds = 0;
        int minutes = 0;
        ControlRegresivo regresivo;
        ControlPogresivo progresivo;
        ControlOpciones opciones;
        COnfiguracion config;

        //banderas de progresivo y regresivo
        bool flagregresivo = false;
        bool flagProgresivo = false;
        bool flagStart = false;
        bool flagpause = false;
        bool flagstop = false;

        string TiempoTotal = null;
        //cuenta de motor a pasos
        int cuentaStepper = 0;
        private DateTime _inicio;
        System.Net.IPEndPoint ServerEndPoint;
        System.Net.IPEndPoint RemoteEndPoint;
        UdpClient socket;
        volatile Boolean activateRight = false;
        volatile Boolean activateLeft = true;
        //comando y dato de retorno
        string CommandEcho = null;
        string DataEcho = null;
        System.Timers.Timer checkingDevice;
        public Form1()
        {
            checkingDevice = new System.Timers.Timer();
            tiempo = new Crono();   
            tiempo.pulso += tic;
            
            //eventos para movimiento de motor            
            regresivo = new ControlRegresivo();
            regresivo.enter += GetRegressiveTime;
            progresivo = new ControlPogresivo();
            progresivo.enter += GetProgressiveTime;
            opciones = new ControlOpciones();
            opciones.move += MoveMotor;
            opciones.save += SaveConfig;
            config = opciones.DeserializeJson("configuration.json");
            ServerEndPoint = new System.Net.IPEndPoint(System.Net.IPAddress.Any, config.localport);
            RemoteEndPoint = new System.Net.IPEndPoint(System.Net.IPAddress.Parse(config.ipaddress), config.port);
            socket = new UdpClient(config.localport);
            socket.BeginReceive(new AsyncCallback(Receive), null);
            InitializeComponent();
            PingHost(config.ipaddress);
            checkingDevice.Interval = 10000;
            checkingDevice.Elapsed += Checking;
            checkingDevice.Start();
           
        }

        private void SaveConfig(COnfiguracion conf, EventArgs e)
        {
            config = conf;
        }

        private void Checking(object sender, ElapsedEventArgs e)
        {
            PingHost(config.ipaddress);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            tiempo.Start();
            this._inicio = DateTime.Now;
            flagStart = SendData("S", "01");

            if (flagStart)
            {
                this.Stop.Enabled = true;
                this.Start.Enabled = false;
                this.Invoke((MethodInvoker)delegate
                {
                    ESTADO.Text = "ACTIVO";
                });
            }
            else {
                this.Invoke((MethodInvoker)delegate
                {
                    ESTADO.Text = "ERROR";
                });
            }

           
            //enviar a arduino
        }

        private void tic(int sender, EventArgs e) {
            TimeSpan transcurrio = DateTime.Now - this._inicio;
            Console.WriteLine(transcurrio.ToString());
            Console.WriteLine("time ");
            cuentaStepper += 1;
            
            miliseconds += sender;

            if (miliseconds > 999) {
                seconds += 1;
                miliseconds = 0;
            }

            if (seconds > 59) {
                minutes += 1;
                seconds = 0;
            }

            if (minutes > 59) {
                
            }

            this.Invoke((MethodInvoker)delegate {
                milisegundos.Text = miliseconds.ToString();
                segundos.Text = seconds.ToString();
                minutos.Text = minutes.ToString();
            });
        }

        private void valores_Scroll(object sender, EventArgs e)
        {
            
            //tiempo.SetInterval(valores.Value);
        }

        private void Opciones_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(opciones);
            }
            catch (Exception ex)
            {

            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ///enviar motor a posicion inicial
            cuentaStepper = 0;

            try
            {
                string welcome = "H|01";
                byte[] dato = Encoding.ASCII.GetBytes(welcome);
                socket.Send(dato, dato.Length, RemoteEndPoint);

            }
            catch (Exception ex)
            {
                
            }
        }

        private void TypeRegresivo_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(regresivo);
            }
            catch (Exception ex) {

            }
            
        }

        private void GetRegressiveTime(string sender, EventArgs e) {
            TiempoTotal = sender;
            sendRegressiveData("SP",TiempoTotal);
            this.Invoke((MethodInvoker)delegate {
                MENSAJE.Text = "MODO REGRESIVO";
            });

        }

        private void Progresivo_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(progresivo);
            }
            catch (Exception ex)
            {

            }
        }

        private void GetProgressiveTime(string sender, EventArgs e)
        {
            TiempoTotal = sender;
            sendProgressiveData("T", TiempoTotal);
            this.Invoke((MethodInvoker)delegate {
                MENSAJE.Text = "MODO PROGRESIVO";
            });
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            tiempo.Stop();
            miliseconds = 0;
            seconds = 0;
            minutes = 0;
            flagstop = SendData("ST", "01");

            this.Start.Enabled = true;
            this.Stop.Enabled = false;
            this.Invoke((MethodInvoker)delegate {
                ESTADO.Text = "EN REPOSO";
            });
        }
    
        //envio regresivo a arduino
        private void sendRegressiveData(string command, string data) {
            int nuevoValor = 0;
            try
            {

                try
                {
                    int valor = Int32.Parse(data);

                    if (valor > 60) {
                        MessageBox.Show("rango mayor al establecidos");
                        return;
                    }

                    float fValue = 34.33f;
                    nuevoValor = Convert.ToInt32(valor * fValue);

                }
                catch (Exception ex)
                {
                    
                    return;

                }

                string welcome = command + "|" + nuevoValor;
                byte[] dato = Encoding.ASCII.GetBytes(welcome);
                socket.Send(dato, dato.Length, RemoteEndPoint);

            }
            catch (Exception ex)
            {
                
            }
        }


        //envio progresivo a arduino
        private void sendProgressiveData(string command, string data) {
            int valor = 0;
            try
            {
                valor = Int32.Parse(data);

                if (valor>61) {
                    MessageBox.Show("rango arriba del establecido");
                    return;
                }

                float fValue = 34.33f;
                valor = Convert.ToInt32(valor * fValue);

            }
            catch (Exception ex)
            {
                MessageBox.Show("numeros incorrectos");
                return;
                
            }

            try
            {
                string welcome = "T|" + valor.ToString();
                byte[] dato = Encoding.ASCII.GetBytes(welcome);
                socket.Send(dato, dato.Length, RemoteEndPoint);

            }
            catch (Exception ex)
            {
                
            }
        }

        private void MoveMotor(int sender, EventArgs e) {
            if (sender == 1)
            {
                Thread thread1 = new Thread(() => MotorDireccionLeft("Left", "5"));
                activateLeft = true;
                thread1.Start();
            }

            if (sender == 2)
            {
                activateLeft = false;
            }

            if (sender == 3)
            {
                Thread thread1 = new Thread(() => MotorDireccionRight("Right", "5"));
                activateRight = true;
                thread1.Start();
            }

            if (sender == 4)
            {
                activateRight = false;
            }
        }

        private bool SendData(string command, string data)
        {

            try
            {
                int valor = Int32.Parse(data);

            }
            catch (Exception ex)
            {
                return false;
            }

            try
            {
                string welcome = command + "|" + data;
                byte[] dato = Encoding.ASCII.GetBytes(welcome);
                socket.Send(dato, dato.Length, RemoteEndPoint);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void MotorDireccionRight(String cmd, String data)
        {

            while (activateRight)
            {
                Thread.Sleep(50);
                SendData(cmd, data);
            }
        }

        private void MotorDireccionLeft(String cmd, String data)
        {
            while (activateLeft)
            {
                Thread.Sleep(50);
                SendData(cmd, data);

            }

        }

        private void Receive(IAsyncResult res)
        {

            byte[] received = socket.EndReceive(res, ref ServerEndPoint);
            String data = Encoding.UTF8.GetString(received);

            string[] Alldata = data.Split('|');
            CommandEcho = Alldata[0];
            DataEcho = Alldata[1];

            if (CommandEcho == "Stopped") {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.Start.Enabled = true;
                    this.Stop.Enabled = false;
                    this.ESTADO.Text = "EN REPOSO";
                }

                ));
                
            }
            ///enviar a formulario

            this.Invoke(new MethodInvoker(delegate
            {
                statusmessage.Text = CommandEcho;
            }

                ));

            socket.BeginReceive(new AsyncCallback(Receive), null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Console.WriteLine("Closing");
        // Then assume that X has been clicked and act accordingly.
        }

        public  void PingHost(object nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;
            string address = (string)nameOrAddress;
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(address);
                pingable = reply.Status == IPStatus.Success;

                
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
                
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }


            try
            {
                if (pingable)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        pictureBox1.Image = Properties.Resources.Circle_Green;
                    }

                    ));
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        pictureBox1.Image = Properties.Resources.circle_red;
                    }

                    ));
                }
            }
            catch (Exception ex) {

            }

            

            

        }


    }
}
