/* Formulario principal donde mostraremos todos los hoteles con los filtros
 * pertinentes si procede, donde guardaremos la lista de hoteles principal
 * y desde donde lanzaremos la opción de nuevo hotel.
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
    public partial class FormPrincipal : Form
    {

        private List<Hotel> hoteles;
        private NuevoHotel nuevo;

        public FormPrincipal()
        {
            InitializeComponent();
            hoteles = Hotel.LeerHoteles();
            TodosHoteles();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string provincia="";
            float precio=0;
            int estrellas=0;

            provincia=cmbProv.Text;
            if (textPrecio.Text!="")
                precio = Convert.ToSingle(textPrecio.Text);

            if (cmbEstrellas.Text != "")
                estrellas = Convert.ToInt16(cmbEstrellas.Text);

            listHoteles.Items.Clear();

            foreach (Hotel hotel in hoteles)
            {
                if ((hotel.Provincia == provincia || provincia == "") &&
                    (hotel.Precio <= precio || precio == 0) &&
                    (hotel.Estrellas >= estrellas))
                {
                    listHoteles.Items.Add(hotel);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
            TodosHoteles();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo = new NuevoHotel(hoteles);
            nuevo.ShowDialog();
            LimpiarEntradas();
            TodosHoteles();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hotel.GuardarHoteles(hoteles);
        }

        private void TodosHoteles()
        {
            listHoteles.Items.Clear();
            hoteles.Sort();
            foreach (Hotel hotel in hoteles)
                listHoteles.Items.Add(hotel.ToString());
        }

        private void LimpiarEntradas()
        {
            cmbProv.Text = "";
            textPrecio.Text = "";
            cmbEstrellas.Text = null;
        }
    }
}
