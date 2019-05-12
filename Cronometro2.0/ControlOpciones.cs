using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace Cronometro2._0
{
    public partial class ControlOpciones : UserControl
    {
        COnfiguracion config;
        public delegate void EventoMotor(int inter, EventArgs e);
        public event EventoMotor move;

        public delegate void EventoSave(COnfiguracion conf, EventArgs e);
        public event EventoSave save;
        public ControlOpciones()
        {
            InitializeComponent();
            config = new COnfiguracion();
            config = DeserializeJson("configuration.json");
            try {
                IpAddress.Text = config.ipaddress;
                Port.Text = config.port.ToString();
                LocalAddress.Text = config.localaddress;
                LocalPort.Text = config.localport.ToString();
            }
            catch(Exception ex)
            {

            }
            
        }



        private void Save_Click(object sender, EventArgs e)
        {
            int puerto;
            int localpuerto;
            string ip;
            string localip;

            ip = IpAddress.Text;
            System.Net.IPAddress ipAddress = null;
            bool isValidIp = System.Net.IPAddress.TryParse(ip, out ipAddress);
            if (!isValidIp)
            {
                MessageBox.Show("Error de ip");
                return;
               
            }

            localip = LocalAddress.Text;
            System.Net.IPAddress ipAddress2 = null;
            isValidIp = System.Net.IPAddress.TryParse(localip, out ipAddress2);
            if (!isValidIp)
            {
                MessageBox.Show("Error de ip");
                return;
            }

            try
            {
                puerto = Int32.Parse(Port.Text);
                localpuerto = Int32.Parse(LocalPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de puertos");
                return;
            }

            SerializeJson(ip, puerto, localip, localpuerto);
            save(config,null);
        }


        public COnfiguracion DeserializeJson(string configuracion)
        {
            try {
                JavaScriptSerializer json = new JavaScriptSerializer();
                StreamReader reader = new StreamReader(configuracion);
                string jsonString = reader.ReadToEnd();
                COnfiguracion configure = json.Deserialize<COnfiguracion>(jsonString);
                reader.Close();
                return configure;
            }

            catch (Exception ex)
            
            {
                MessageBox.Show("Error en lectura de archivo de configuracion");
                return null;
            }
           
        }


        private void SerializeJson(string ipaddress,int port,string localip,int localport)
        {

            try
            {
                JavaScriptSerializer json = new JavaScriptSerializer();
                config.ipaddress = ipaddress;
                config.port = port;
                config.localaddress = localip;
                config.localport = localport;
                string outputJSON = json.Serialize(config);
                File.WriteAllText("configuration.json", outputJSON);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }

        }


        public void back_Click_Down(object sender,EventArgs e) {
            move(1, null);
        }

        public void back_Click_Up(object sender, EventArgs e)
        {
            move(2, null);
        }

        public void forward_Click_Down(object sender, EventArgs e)
        {
            move(3, null);
        }

        public void forward_Click_Up(object sender, EventArgs e)
        {
            move(4, null);
        }

        
    }

}


