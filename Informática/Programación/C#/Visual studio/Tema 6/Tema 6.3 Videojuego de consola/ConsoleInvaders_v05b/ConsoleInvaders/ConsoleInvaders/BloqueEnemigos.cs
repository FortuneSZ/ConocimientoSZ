﻿using System;

/* Clase para gestionar todo el bloque entero de enemigos, y moverlos a todos a 
 * la par */
class BloqueEnemigos
{
    // Array de enemigos a mostrar
    Enemigo[,] enemigos;

    // Disparo del bloque
    Disparo[] disparos;

    // Semilla de números aleatorios para disparos
    Random r = new Random();

    // Direccion actual de movimiento del bloque (+1 hacia la derecha, -1 hacia
    // la izquierda)
    int direccion;

    // Constructor. Inicializa el array de enemigos
    public BloqueEnemigos()
    {
        enemigos = new Enemigo[3, 10];
        disparos = new Disparo[Configuracion.MAX_DISPAROS];
        for (int i = 0; i < disparos.Length; i++)
        {
            disparos[i] = new Disparo();
        }
        for (int i = 0; i < enemigos.GetLength(0); i++)
        {
            for (int j = 0; j < enemigos.GetLength(1); j++)
            {
                // Creamos 3 filas de enemigos, en cada fila será de un tipo
                // diferente
                if (i == 0)
                    enemigos[i, j] = new Enemigo1(j * 7 + 5, 5);
                else if (i == 1)
                    enemigos[i, j] = new Enemigo2(j * 7 + 5, 7);
                else
                    enemigos[i, j] = new Enemigo3(j * 7 + 5, 9);
            }
        }

        direccion = 1;
    }

    // Obtiene el enemigo con una X más a la izquierda que el resto
    private Enemigo GetEnemigoIzquierdo()
    {
        Enemigo elegido = null;
        int minX = Configuracion.ANCHO_PANTALLA;

        for (int i = 0; i < enemigos.GetLength(0); i++)
            for (int j = 0; j < enemigos.GetLength(1); j++)
            {
                if (enemigos[i, j].GetX() < minX && enemigos[i, j].GetActivo())
                {
                    minX = enemigos[i, j].GetX();
                    elegido = enemigos[i, j];
                }
            }
        return elegido;
    }

    // Obtiene el enemigo con una X más a la derecha que el resto
    private Enemigo GetEnemigoDerecho()
    {
        Enemigo elegido = null;
        int maxX = -1;

        for (int i = 0; i < enemigos.GetLength(0); i++)
            for (int j = 0; j < enemigos.GetLength(1); j++)
            {
                if (enemigos[i, j].GetX() > maxX && enemigos[i, j].GetActivo())
                {
                    maxX = enemigos[i, j].GetX();
                    elegido = enemigos[i, j];
                }
            }
        return elegido;
    }

    // Mover el bloque de enemigos
    public void Mover()
    {
        Enemigo referencia;
        // Cogemos el enemigo más a la derecha o a la izquierda, dependiendo de
        // la dirección de movimiento actual
        if (direccion > 0)
            referencia = GetEnemigoDerecho();
        else
            referencia = GetEnemigoIzquierdo();

        // Intentamos mover en la dirección actual si se puede. Si no,
        // cambiamos la dirección de movimiento
        if ((referencia.GetX() < Configuracion.ANCHO_PANTALLA - 
             referencia.GetImagen().Length && direccion > 0) || 
            (referencia.GetX() > 0 && direccion < 0))
        {
            // Mover a la derecha o izquierda, según la dirección
            for (int i = 0; i < enemigos.GetLength(0); i++)
                for (int j = 0; j < enemigos.GetLength(1); j++)
                {
                    enemigos[i, j].MoverA(enemigos[i, j].GetX() + direccion, 
                        enemigos[i, j].GetY());
                }
        }
        else
        {
            // Cambiar la dirección de movimiento
            direccion = -direccion;
        }
    }

    // Dibujar el bloque de enemigos
    public void Dibujar()
    {
        for (int i = 0; i < enemigos.GetLength(0); i++)
            for (int j = 0; j < enemigos.GetLength(1); j++)
                enemigos[i, j].Dibujar();

        foreach (Disparo d in disparos)
        {
            d.Dibujar();
        }
    }

    // Intenta generar un disparo enemigo, obteniendo las coordenadas x e y de
    // inicio del disparo
    public void IntentarDisparo()
    {
        int j, n = 0;
        bool encontrado = false;

        while (n < disparos.Length && ! encontrado)
        {
            if (!disparos[n].GetActivo())
            {
                // Recorremos los enemigos activos, y a cada uno le damos el
                // 10% de probabilidades de generar un disparo
                for (int i = 0; i < enemigos.GetLength(0); i++)
                {
                    j = 0;
                    while (j < enemigos.GetLength(1) && 
                           !disparos[n].GetActivo())
                    {
                        if (enemigos[i, j].GetActivo())
                        {
                            int num = r.Next(0, 10);
                            if (num >= 9)
                            {
                                disparos[n].MoverA(enemigos[i, j].GetX(), 
                                    enemigos[i, j].GetY() + 1);
                                disparos[n].SetActivo(true);
                                encontrado = true;
                            }
                        }
                        j++;
                    }
                }
            }
            n++;
        }
    }

    // Mueve el disparo hacia abajo
    public void MoverDisparos()
    {
        for (int i = 0; i < disparos.Length; i++)
        {
            if (disparos[i].GetActivo())
            {
                if (disparos[i].GetY() < Configuracion.ALTO_PANTALLA - 1)
                    disparos[i].MoverA(disparos[i].GetX(), 
                        disparos[i].GetY() + 1);
                else
                {
                    disparos[i].SetActivo(false);
                    disparos[i].MoverA(0, 0);
                }
            }
        }
    }
}