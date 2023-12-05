namespace Clase
{


    public class Apartamento
    {
        public String nombre;
        public String cabecera;

        public double superficie;
        public int poblacion;

        public Apartamento(String nombre, String cabecera, double superficie, int poblacion)
        {
            this.nombre = nombre;
            this.cabecera = cabecera;
            this.superficie = superficie;
            this.poblacion = poblacion;
        }

        public override String ToString(){
            return $"{nombre} / {cabecera} / {superficie} / {poblacion}";
        }
    }
}