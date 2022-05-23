using ProductoApp;

//Crear un vectos de productos:
Producto[] productos = new Producto[3];

//Crear 1 pack y 2 productos sueltos dentro del vector:
productos[0] = new Pack(1, "Genérico", 100, 10);
productos[1] = new Suelto(3, "Marca 01", 10, 1);
productos[2] = new Suelto(55, "Marca 02", 50, 2);

//variables:
int cSueltos = 0;
int cPacks = 0;
float acuPrecioSuelto = 0;
Producto mayor = null;

//Mostrar resultados:
//1: Cantidad de productos sueltos y packs:
for (int i = 0; i < productos.Length; i++)
{
    if (mayor == null || productos[i].GetPrecio() > mayor.GetPrecio())
        mayor = productos[i];


    if (productos[i] is Suelto)
    {
        cSueltos++;
        acuPrecioSuelto += productos[i].PrecioUnitario;
    }
    else if (productos[i] is Pack)
    {
        cPacks++;
    }
}

Console.WriteLine("Total de productos sueltos: " + cSueltos);
Console.WriteLine("Total de productos pack: " + cPacks);

//2. Precio promedio solo de productos sueltos:
float precioPromedio = acuPrecioSuelto / cSueltos;
Console.WriteLine("Precio promedio de productos sueltos: " + precioPromedio);

//3. Porcentaje de packs respecto del total:
float porcentaje = cPacks * 100 / (cPacks + cSueltos);
Console.WriteLine("Porcentaje de packs sobre el total: " + porcentaje + " %");

//4. Código y marca del producto más costoso:
Console.WriteLine("Código producto más costoso: " + mayor.Codigo);
Console.WriteLine("Marca producto más costoso: " + mayor.Marca);



