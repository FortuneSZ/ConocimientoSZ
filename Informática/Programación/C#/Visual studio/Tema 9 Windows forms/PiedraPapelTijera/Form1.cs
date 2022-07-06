using System;
using System.Windows.Forms;

namespace PiedraPapelTijera
{
    public partial class Form1 : Form
    {
        int puntosHumano;
        int puntosMaquina;
        int opcion;
        int opcionM;
        Random rand = new Random();
        int[,] resultados =
        {
            { 0, -1, 1 },
            { 1, 0, -1 },
            {-1, 1, 0 }
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            imgH.Image = null;
            imgM.Image = null;
            opcion = 2;
            imgH.Image = pap.Image;
            random();
            cambiarresultado();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tij_Click(object sender, EventArgs e)
        {
            imgH.Image = null;
            imgM.Image = null;
            opcion = 0;
            imgH.Image = tij.Image;
            random();
            cambiarresultado();
        }

        private void initPartida(object sender, EventArgs e)
        {
            puntosHumano = 0;
            puntosMaquina = 0;
            actualizarmarcador();
            infor.Text = "";
            imgH.Image = null;
            imgM.Image = null;
        }
        private void actualizarmarcador()
        {
            puntosH.Text = puntosHumano.ToString();
            puntosM.Text = puntosMaquina.ToString();
        }

        private void pie_Click(object sender, EventArgs e)
        {
            imgH.Image = null;
            imgM.Image = null;
            opcion = 1;
            imgH.Image = pie.Image;
            random();
            cambiarresultado();
        }
        private void random()
        {
            int randomm = rand.Next(1, 4);

            if (randomm == 1)
            {
                opcionM = 0;
                imgM.Image = tij.Image;
            }
            else if (randomm == 2)
            {
                opcionM = 1;
                imgM.Image = pie.Image;
            }
            else if (randomm == 3)
            {
                opcion = 2;
                imgM.Image = pap.Image;
            }
        }
        private void cambiarresultado()
        {
            if (resultados[(int)opcion, (int)opcionM] == -1)
            {
                puntosHumano++;
                actualizarmarcador();
                infor.Text = "Ganas";
            }
            else if (resultados[(int)opcion, (int)opcionM] == 1)
            {
                puntosMaquina++;
                actualizarmarcador();
                infor.Text = "Pierdes";
            }
            else if (resultados[(int)opcion, (int)opcionM] == 0)
            {
                infor.Text = "Empate";
            }
        }
    }
}
