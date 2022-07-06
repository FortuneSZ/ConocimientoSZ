using System.Drawing;
namespace FlappyBird
{
    internal class Segmento : Sprite
    {
        public const int ANCHURA = 50;
        public const int ALTURA = 60;
        private const string FICHERO = "imagenes/pipe_segment.png";

        public Segmento() : base(ANCHURA, ALTURA)
        {
            imagen = Image.FromFile(FICHERO);
            spriteX = 0;
            spriteY = 0;
        }
    }
}
