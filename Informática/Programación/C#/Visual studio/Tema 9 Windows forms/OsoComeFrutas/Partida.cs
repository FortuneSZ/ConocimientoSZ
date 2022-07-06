using NAudio.Wave;
using System.Drawing;
using System.Windows.Forms;

namespace OsoComeFrutas
{
    public partial class Partida : Form
    {
        private const string SONIDO_FONDO = "recursos/sonidos/musica_fondo.wav";
        private const string EFECTO_FRUTA = "recursos/sonidos/salto.wav";
        private Bienvenida bienvenida;
        private Image fondo;
        private Oso oso;
        private Fruta fruta;
        private WaveStream streamFondo;
        private WaveStream streamEfecto;
        private WaveOut playerFondo;
        private WaveOut playerEfecto;


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
            fondo = Image.FromFile(@"recursos/imagenes/fondo.png");
            oso = new Oso();
            oso.Resetear();
            timerJuego.Start();
            DoubleBuffered = true;
            streamFondo = new WaveFileReader(SONIDO_FONDO);
            playerFondo = new WaveOut();
            playerFondo.Init(streamFondo);
            playerFondo.Play();
            streamEfecto = new WaveFileReader(EFECTO_FRUTA);
            playerEfecto = new WaveOut();
            playerEfecto.Init(streamEfecto);
        }
        private void Partida_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(fondo, 0, 0, Configuracion.ANCHO_PANTALLA,
            Configuracion.ALTO_PANTALLA);
            oso.Dibujar(e.Graphics);
            if (fruta != null)
                fruta.Dibujar(e.Graphics);
            actualizarHUD(e.Graphics);
        }
        private void actualizarHUD(Graphics g)
        {
            Font fuente = new Font("Arial", 16);
            SolidBrush colorPuntos = new SolidBrush(Color.Green);
            SolidBrush colorVidas = new SolidBrush(Color.Yellow);
            g.DrawString("Puntos: " + oso.Puntos, fuente, colorPuntos, 5, 5);
            g.DrawString("Vidas: " + oso.Vidas, fuente, colorVidas,
                Configuracion.ANCHO_PANTALLA - 100, 5);
        }
        private void Partida_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerJuego.Stop();
            bienvenida.Show();
            playerFondo.Stop();
        }

        private void Partida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                oso.Izquierda = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                oso.Derecha = true;
            }
        }

        private void Partida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                oso.Izquierda = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                oso.Derecha = false;
            }
        }

        private void timerJuego_Tick(object sender, System.EventArgs e)
        {
            // Para redibujar la pantalla
            Invalidate();
            oso.Mover();
            if (fruta == null)
            {
                fruta = new Fruta();
            }
            else
            {
                fruta.Mover();
                if (fruta.ColisionaCon(oso))
                {
                    oso.Puntos += Configuracion.PUNTOS_FRUTA;
                    streamEfecto.Position = 0;
                    playerEfecto.Play();
                    fruta = null;
                }
                else if (fruta.Y > Configuracion.ALTO_PANTALLA)
                {
                    oso.Vidas--;
                    oso.Resetear();
                    fruta = null;
                }
            }

            if (oso.Vidas == 0)
            {
                playerFondo.Stop();
                Close();
            }
            if (streamFondo.Position == streamFondo.Length)
            {
                streamFondo.Position = 0;
                playerFondo.Play();
            }
        }
    }
}