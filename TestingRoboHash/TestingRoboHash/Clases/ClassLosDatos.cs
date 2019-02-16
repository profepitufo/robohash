using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestingRoboHash.Clases
{
    /* Clase que va a permitir crear
     * los datos a desplegar en el
     * control DataGridView.
    */
    class ClassLosDatos
    {
        private string fieldNombre;
        private string fieldURL;
        private Image fieldImage;

        public string FieldNombre
        {
            get { return fieldNombre; }
            set { fieldNombre = value; }
        }

        public string FieldURL
        {
            get
            {
                return fieldURL;
            }
            set
            {
                fieldURL = value;
            }
        }

        public Image FieldImage
        {
            get
            {
                return fieldImage;
            }
            set
            {
                fieldImage = value;
            }
        }

        public ClassLosDatos()
        {
            
        }
    }
}
