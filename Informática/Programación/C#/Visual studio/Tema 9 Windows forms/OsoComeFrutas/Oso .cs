using System;
using System.Drawing;

namespace OsoComeFrutas
{
    internal class Oso : SpriteAnimado
    {
        // Posibles movimientos del oso
        public const byte DERECHA = 0;
        public const byte IZQUIERDA = 1;

        // Tamaño de cada sprite
        public const int ANCHURA = 96;
        public const int ALTURA = 96;

        private const string FICHERO = "recursos/imagenes/oso.png";
        // Cuántos píxeles avanza con cada paso
        private const byte PASO = 4;

        // Indicadores de movimiento a uno u otro lado
        private bool izquierda, derecha;
        private int vidas, puntos;

        public bool Izquierda
        {
            get { return izquierda; }
            set { izquierda = value; }
        }

        public bool Derecha
        {
            get { return derecha; }
            set { derecha = value; }
        }

        public int Vidas
        {
            get { return vidas; }
            set { vidas = value; }
        }

        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        public Oso() : base(ANCHURA, ALTURA, 2)
        {
            imagen = Image.FromFile(FICHERO);
            // Coordenadas X,Y de cada sprite para cada dirección en la imagen del oso
            coordenadasX[DERECHA] = new int[] { 480, 576, 672, 576 };
            coordenadasY[DERECHA] = new int[] { 0, 0, 0, 0 };
            coordenadasX[IZQUIERDA] = new int[] { 1248, 1344, 1440, 1344 };
            coordenadasY[IZQUIERDA] = new int[] { 0, 0, 0, 0 };
            izquierda = false;
            derecha = false;
            vidas = Configuracion.VIDAS_OSO;
            puntos = 0;
            ActualizarCoordenadasSprite();
        }

        public void Mover()
        {
            // Comparador XOR
            if (izquierda ^ derecha)
            {
                int nuevaX = x;
                if (izquierda)
                {
                    nuevaX -= Math.Min(PASO, x);
                    Animar(IZQUIERDA);
                }
                else
                {
                    nuevaX += Math.Min(PASO,
                        Configuracion.ANCHO_PANTALLA - ANCHURA - x);
                    Animar(DERECHA);
                }
                MoverA(nuevaX, y);
            }
        }

        public void Resetear()
        {
            MoverA(Configuracion.ANCHO_PANTALLA / 2 - ANCHURA / 2,
                    Configuracion.ALTO_PANTALLA - ALTURA - 40);
        }
    }
}
