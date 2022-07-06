using System;
using System.Drawing;

namespace OsoComeFrutas
{
    internal class Fruta : Sprite
    {
        public const int ANCHURA = 30;
        public const int ALTURA = 30;
        private const string FICHERO = "recursos/imagenes/frutas.png";
        private const int PASO = 2;

        private static Random random = new Random();

        public Fruta() : base(ANCHURA, ALTURA)
        {
            imagen = Image.FromFile(FICHERO);
            // Banana
            spriteX = 4;
            spriteY = 40;

            MoverA(random.Next(0,
                Configuracion.ANCHO_PANTALLA - Fruta.ANCHURA), 0);
        }


        public void Mover()
        {
            y += PASO;
        }
    }
}
