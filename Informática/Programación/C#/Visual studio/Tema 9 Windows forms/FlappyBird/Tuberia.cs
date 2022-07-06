using System;
using System.Drawing;

namespace FlappyBird
{
    internal class Tuberia
    {
        private const int MAX_SEGMENTOS = 7;
        private const int ESPACIO_HUECO = 3;
        private Segmento[] segmentos;
        private static Random random = new Random();

        public Tuberia()
        {
            segmentos = new Segmento[MAX_SEGMENTOS - ESPACIO_HUECO];
            // Hueco de 3 segmentos evitando la posición más baja
            int hueco = random.Next(0, 4);
            int contador = 0;
            for (int i = 0; i < MAX_SEGMENTOS; i++)
            {
                if (i < hueco || i >= hueco + ESPACIO_HUECO)
                {
                    segmentos[contador] = new Segmento();
                    segmentos[contador].X = Configuracion.ANCHO_PANTALLA;
                    segmentos[contador].Y = i * Segmento.ALTURA;
                    contador++;
                }
            }
        }

        public void Mover()
        {
            for (int i = 0; i < segmentos.Length; i++)
            {
                segmentos[i].X -= Configuracion.PASO_TUBERIA;
            }
        }

        public bool Superado()
        {
            return segmentos[0].X + Segmento.ANCHURA <= 0;
        }

        public void Dibujar(Graphics g)
        {
            for (int i = 0; i < segmentos.Length; i++)
            {
                segmentos[i].Dibujar(g);
            }
        }
    }
}
