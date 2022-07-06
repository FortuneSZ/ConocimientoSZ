using System.Drawing;
namespace FlappyBird
{
    internal class Pajaro : SpriteAnimado
    {
        public const byte DERECHA = 0;
        public const int ANCHURA = 43;
        public const int ALTURA = 30;

        private const string FICHERO = "imagenes/bird_spritesheet.png";

        private int puntos;

        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        public Pajaro() : base(ANCHURA, ALTURA, 1)
        {
            imagen = Image.FromFile(FICHERO);
            coordenadasX[DERECHA] = new int[] { 0, 43, 86, 0 };
            coordenadasY[DERECHA] = new int[] { 0, 0, 0, 0 };
            puntos = 0;
            ActualizarCoordenadasSprite();
        }

        public void Resetear()
        {
            MoverA(Configuracion.ANCHO_PANTALLA / 3 - ANCHURA / 2,
                    Configuracion.ALTO_PANTALLA / 3 - ALTURA / 2);
        }
    }
}
