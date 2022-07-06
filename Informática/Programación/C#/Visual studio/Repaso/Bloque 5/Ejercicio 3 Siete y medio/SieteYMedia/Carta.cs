using System;

/*
 * Clase para gestionar las cartas del juego
 */
class Carta
{
    private Palo paloCarta;
    private Simbolo simboloCarta;

    public Carta(Palo paloCarta, Simbolo simboloCarta)
    {
        this.paloCarta = paloCarta;
        this.simboloCarta = simboloCarta;
    }

    public override string ToString()
    {
        return simboloCarta + " de " + paloCarta;
    }

    public float ValorCarta()
    {
        switch(simboloCarta)
        {
            case Simbolo.UNO: return 1;
            case Simbolo.DOS: return 2;
            case Simbolo.TRES: return 3;
            case Simbolo.CUATRO: return 4;
            case Simbolo.CINCO: return 5;
            case Simbolo.SEIS: return 6;
            case Simbolo.SIETE: return 7;
            default: return 0.5f;
        }
    }
}