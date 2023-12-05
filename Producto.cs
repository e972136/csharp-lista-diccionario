namespace Clase
{
    public class Producto
    {
        public int id;
        public String descripcion;
        public double precio;

        public Producto(int id, String descripcion, double precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public String toString(){
            return $"{id}\t{descripcion}\t{precio}";
        }
    }

}
