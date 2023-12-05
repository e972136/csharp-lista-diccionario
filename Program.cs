using System.IO.Compression;
using Clase;

ejercicioListas();
ejercicioDiccionarios();

void ejercicioListas()
{
    List<Producto> productos = new List<Producto>();

    productos.Add(new Producto(1, "a", 1.0));
    productos.Add(new Producto(2, "b", 1.0));
    productos.Add(new Producto(3, "c", 1.0));
    productos.Add(new Producto(4, "d", 1.0));
    productos.Add(new Producto(5, "e", 1.0));
    productos.Add(new Producto(6, "f", 1.0));
    productos.Add(new Producto(7, "g", 1.0));
    productos.Add(new Producto(8, "h", 1.0));
    productos.Add(new Producto(9, "i", 1.0));
    productos.Add(new Producto(10, "j", 1.0));

    mostrarProductos(productos);
    productos.Insert(3, new Producto(100, "x", 0.0));
    productos.RemoveAt(productos.Count - 1);
    mostrarProductos(productos);

}


void mostrarProductos(List<Producto> productos)
{
    Console.WriteLine("Productos");
    foreach (Producto p in productos)
    {
        Console.WriteLine(p.toString());
    }
    Console.WriteLine();
}

void ejercicioDiccionarios(){
    var apartamentos = new Dictionary<String,Apartamento>();
    apartamentos.Add("0101",new Apartamento("Atlantida","La ceiba",100.5,5000));
    apartamentos.Add("1801",new Apartamento("Francisco Morazar","MDC",150.5,50000));
    apartamentos.Add("1010",new Apartamento("Cortes","San Pedro Sula",200.5,8000));
    Console.WriteLine("Diccionario");
    foreach(var a in apartamentos){
        Console.WriteLine($"Clave <{a.Key}> Valor <{a.Value.ToString()}>");
    }
}