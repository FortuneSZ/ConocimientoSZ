using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Partida : Form
    {
        private Bienvenida bienvenida;
        private Image fondo;
        private int contadorScroll;
        private Pajaro pajaro;
        private List<Tuberia> tuberias;
        private static Random random = new Random();
        private bool teclaPulsada;
        private int gravedadActual;

        public Bienvenida Bienvenida
        {
            get { return bienvenida; }
            set { bienvenida = value; }
        }
        public Partida()
        {
            InitializeComponent();
            this.ClientSize = new Size(Configuracion.ANCHO_PANTALLA,
            Configuracion.ALTO_PANTALLA);
            fondo = Image.FromFile("imagenes/bg.jpeg");
            DoubleBuffered = true;
            contadorScroll = 0;
            timerScroll.Start();
            pajaro = new Pajaro();
            pajaro.Resetear();
            tuberias = new List<Tuberia>();
            timerTuberia.Start();
            teclaPulsada = false;
            gravedadActual = 0;
        }

        private void Partida_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(fondo, 0, 0, Configuracion.ANCHO_PANTALLA,
            Configuracion.ALTO_PANTALLA);
            scroll(e.Graphics);
            pajaro.Dibujar(e.Graphics);
            foreach (Tuberia tuberia in tuberias)
            {
                tuberia.Dibujar(e.Graphics);
            }
        }

        private void Partida_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerScroll.Stop();
            timerTuberia.Stop();
            bienvenida.Show();
        }

        private void timerScroll_Tick(object sender, System.EventArgs e)
        {
            contadorScroll += Configuracion.PASO_SCROLL;
            if (contadorScroll >= Configuracion.ANCHO_PANTALLA)
                contadorScroll = 0;
            Invalidate();
            pajaro.Animar(Pajaro.DERECHA);
            Invalidate();
            foreach (Tuberia tuberia in tuberias)
            {
                tuberia.Mover();
            }
            if (tuberias.Count > 0 && tuberias[0].Superado())
            {
                tuberias.RemoveAt(0);
            }
            Invalidate();
            gravedadActual -= Configuracion.GRAVEDAD;
            pajaro.Y -= gravedadActual;
            Invalidate();
        }

        private void scroll(Graphics g)
        {
            Rectangle rect = new Rectangle(contadorScroll, 0,
                Configuracion.ANCHO_PANTALLA - contadorScroll,
                Configuracion.ALTO_PANTALLA);
            // Dibujamos desde el punto de scroll actual
            g.DrawImage(fondo, 0, 0, rect, GraphicsUnit.Pixel);
            // Dibujamos el resto desde el principio
            if (contadorScroll > 0)
            {
                Rectangle rect2 = new Rectangle(0, 0, contadorScroll,
                    Configuracion.ALTO_PANTALLA);
                g.DrawImage(fondo,
                    Configuracion.ANCHO_PANTALLA - contadorScroll,
                    0, rect2, GraphicsUnit.Pixel);
            }
        }

        private void timerTuberia_Tick(object sender, System.EventArgs e)
        {
            bool crear = random.Next(0, 2) == 0;
            if (crear)
            {
                Tuberia t = new Tuberia();
                tuberias.Add(t);
            }
        }

        private void Partida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !teclaPulsada)
            {
                gravedadActual = Configuracion.FUERZA_SALTO;
                teclaPulsada = true;
            }
        }

        private void Partida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                teclaPulsada = false;
            }
        }
    }
}
