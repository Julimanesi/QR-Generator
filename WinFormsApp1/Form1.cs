using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BotonGenerador_Click(object sender, EventArgs e)
        {
            await Generar();
        }

        private async Task Generar()
        {
            if (CuadroTexto.Text != null && CuadroTexto.Text != "")
            {
                Generador g = new Generador(CuadroTexto.Text);
                await g.GenerarQR();
                if (g.QRBarcode != null)
                    ImagenQR.Image = g.QRBarcode;
                else
                    AdvertenciaText.Text= g.advertencia;
            }
        }

        
    }
}
