using System.Drawing;
namespace OsoComeFrutas
{
    internal class Sprite
    {
        // Anchura y altura de cada sprite
        protected int ancho, alto;
        // Posición actual (esquina superior izquierda)
        protected int x, y;
        // Coordenadas en la imagen del sprite seleccionado
        protected int spriteX, spriteY;
        // Imagen con todos los sprites
        protected Image imagen;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Sprite(int ancho, int alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public void MoverA(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Dibujar(Graphics g)
        {
            // Seleccionamos en la imagen un rectángulo con el sprite seleccionado
            Rectangle rect = new Rectangle(spriteX, spriteY, ancho, alto);
            // Dibujamos en el formulario el rectángulo seleccionado,
            // en las coordenadas actuales del sprite
            g.DrawImage(imagen, x, y, rect, GraphicsUnit.Pixel);
        }

        public bool ColisionaCon(Sprite sp)
        {
            return (x < sp.x + sp.ancho && x + ancho > sp.x &&
                    y < sp.y + alto && y + alto > sp.y);
        }
    }
}
