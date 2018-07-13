using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace EnvioWhatsaap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            string yourId = "";
            string yourMobile = "+";
            string mensaje = "Holaa"+Mensaje.Text;

            try {

                string url = "https://niceapi.net/API";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers.Add("X-APIID",yourId);
                request.Headers.Add("X-APIMobile", yourMobile);
                using (StreamWriter streamout = new StreamWriter(request.GetRequestStream())) {
                    streamout.Write(mensaje);
                }
                using (StreamReader streamIn = new StreamReader(request.GetResponse().GetResponseStream())) {
                    Console.WriteLine(streamIn.ReadToEnd());

                }
                Console.WriteLine("Finalizo");
                MessageBox.Show("Finalizo el envio");
                Mensaje.Text="";
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Termino con Exception");

            }
            Console.ReadLine();
        }
    }
}
