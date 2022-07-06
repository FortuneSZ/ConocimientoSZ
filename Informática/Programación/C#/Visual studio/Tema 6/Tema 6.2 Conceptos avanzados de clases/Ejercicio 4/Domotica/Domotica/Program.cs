
ElementoDomotico[] elementos = new ElementoDomotico[4];

elementos[0] = new Puerta("Puerta principal", true);
elementos[1] = new Horno("Horno cocina", 180, true);
elementos[2] = new Puerta("Puerta garaje", false);
elementos[3] = new Luz("Luz entrada", false);

Array.Sort(elementos);

// Recorrer y encender elementos encendibles
foreach(ElementoDomotico elem in elementos)
{
    if (elem is IEncendible)
    {
        ((IEncendible)elem).Encender();
    }
}

// Mostrar resultado
foreach(ElementoDomotico elem in elementos)
{
    Console.WriteLine(elem);
}

// Recorrer y apagar elementos encendibles
foreach (ElementoDomotico elem in elementos)
{
    if (elem is IEncendible)
    {
        ((IEncendible)elem).Apagar();
    }
}

// Mostrar resultado
foreach (ElementoDomotico elem in elementos)
{
    Console.WriteLine(elem);
}