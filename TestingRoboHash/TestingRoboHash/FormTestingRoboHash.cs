using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingRoboHash.Clases;
using System.Media;
using System.Net;
using System.IO;

namespace TestingRoboHash
{
    public partial class FormTestingRoboHash : Form
    {
        public FormTestingRoboHash()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            // Creacion del Objeto con la URL deseada.
            ClassLosDatos unDato = new ClassLosDatos
            {

                // para buscar la imagen y manejarla como un Stream.
                FieldURL = "https://robohash.org/Treacher.png?size=300x300"
            };
            // Cliente de Internet y Descarga de Imagen.
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(unDato.FieldURL);
            // Reserva un Stream de Memoria.
            MemoryStream ms = new MemoryStream(bytes);
            // Llena los datos del Objeto.
            unDato.FieldNombre = "Elka";
            unDato.FieldImage = Image.FromStream(ms);
            // Despliega el Registro.
            ImageGridView.RowTemplate.Height = 200;
            ImageGridView.Rows.Add(unDato.FieldNombre, unDato.FieldURL, unDato.FieldImage);
        }
    }
}
