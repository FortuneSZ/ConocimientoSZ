namespace FlappyBird
{
    internal class SpriteAnimado : Sprite
    {
        // Cuántos movimientos diferentes puede hacer el objeto
        protected byte totalMovimientos;
        // Dirección o movimiento actual del objeto
        protected byte movimientoActual;
        // Índice del sprite actual en la animación
        protected byte spriteActual;
        // Contador de iteraciones para siguiente cambio de sprite
        private byte contadorCambioSprite;

        // Array de coordenadas X, Y de cada sprite para cada movimiento
        protected int[][] coordenadasX;
        protected int[][] coordenadasY;

        public SpriteAnimado(int ancho, int alto, byte movimientos)
            : base(ancho, alto)
        {
            totalMovimientos = movimientos;
            coordenadasX = new int[totalMovimientos][];
            coordenadasY = new int[totalMovimientos][];
            movimientoActual = 0;
            spriteActual = 0;
            contadorCambioSprite = 0;
        }

        public void Animar(byte movimiento)
        {
            if (movimiento != movimientoActual)
            {
                movimientoActual = movimiento;
                spriteActual = 0;
                contadorCambioSprite = 0;
            }
            else
            {
                contadorCambioSprite++;
                if (contadorCambioSprite >=
                    Configuracion.TASA_ANIMACION_SPRITES)
                {
                    contadorCambioSprite = 0;
                    spriteActual = (byte)((spriteActual + 1) %
                            coordenadasX[movimientoActual].Length);
                }
            }
            ActualizarCoordenadasSprite();
        }

        protected void ActualizarCoordenadasSprite()
        {
            spriteX = coordenadasX[movimientoActual][spriteActual];
            spriteY = coordenadasY[movimientoActual][spriteActual];
        }
    }
}
