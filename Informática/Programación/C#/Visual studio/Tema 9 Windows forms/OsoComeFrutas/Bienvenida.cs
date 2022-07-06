using System;
using System.Drawing;
using System.Windows.Forms;

namespace OsoComeFrutas
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
            this.ClientSize = new Size(Configuracion.ANCHO_PANTALLA,
            Configuracion.ALTO_PANTALLA);
            // Borde para no poder redimensionar la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Textos centrados
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = this.Height / 2 - lblTitulo.Height;
            lblSubtitulo.Left = (this.Width - lblSubtitulo.Width) / 2;
            lblSubtitulo.Top = this.Height / 2 + lblSubtitulo.Height / 2;
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {
            IniciarPartida();
        }

        private void lblTitulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                IniciarPartida();
        }
        private void IniciarPartida()
        {
            Partida p = new Partida();
            p.Bienvenida = this;
            p.Show();
            this.Hide();
        }
    }
}
