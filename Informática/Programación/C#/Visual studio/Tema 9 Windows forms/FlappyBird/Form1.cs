using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bienvenida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Partida p = new Partida();
                p.Bienvenida = this;
                p.Show();
                this.Hide();
            }
        }
    }
}
