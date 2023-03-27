using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Informacionweb : Form
    {
        public Informacionweb()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            String url = txt_in.Text;
            IPAddress[] addresses = Dns.GetHostAddresses(url);

            Console.WriteLine($"GetHostAddresses({url}) returns:");

            foreach (IPAddress address in addresses)
            {
                txt_out.Text = "La direccion IP es: " + $"    {address}";
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_in.Text = "";
            txt_out.Text = "";
        }

        private void txt_url_Click(object sender, EventArgs e)
        {
            txt_in.Text = "";
            txt_in.ForeColor = Color.Black;
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            txt_out.Text = "";
            txt_out.AppendText("Cuando introduzca la direccion web, considere lo siguiente: \n Se escribe a partir del www. , aqui un ejemplo: www.google.com.mx" +
            "\nNo introduzca: https, http.\nTampoco tiene que tener espacios y tampoco comas\n.");
        }

    }
}
