/* Clase parcial NuevoHotel que se encarga de gestionar todos los datos para
 * introducir nuevos hoteles a la lista de hoteles, comprobando que estos datos
 * son correctos.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiaHoteles
{
    public partial class NuevoHotel : Form
    {
        private Hotel nuevo;
        private List<Hotel> hoteles;
        public NuevoHotel(List<Hotel> hoteles)
        {
            InitializeComponent();
            this.hoteles = hoteles;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            string nombre = NuevoNom.Text;
            string provincia = NuevoProv.Text;
            float precio;
            int estrellas;

            try
            {
                precio = Convert.ToSingle(NuevoPrecio.Text);
                estrellas = Convert.ToInt32(NuevoEst.Text);
                if (nombre != "" && provincia != "" && precio > 0 &&
                    estrellas <= 5 && estrellas >= 1)
                {
                    nuevo = new Hotel(nombre, provincia, precio, estrellas);
                    hoteles.Add(nuevo);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            } catch (Exception) 
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void NuevoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}