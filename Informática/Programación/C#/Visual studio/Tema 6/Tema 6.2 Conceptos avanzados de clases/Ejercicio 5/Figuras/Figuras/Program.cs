
IFiguraGeometrica[] figuras = 
    new IFiguraGeometrica[3];
figuras[0] = new Cuadrado(8);
figuras[1] = new Circulo(3.5);
figuras[2] = new Rectangulo(5, 2);

foreach(IFiguraGeometrica f in figuras)
{
    Console.WriteLine(f.CalcularArea());
    Console.WriteLine(f.CalcularPerimetro());
    Console.WriteLine();
}