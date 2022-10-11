namespace PII_Herencia
{
    public abstract class Pasajero : Person
    {
        public Pasajero (string nombre, string apellido, string cedula)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = 5.0f;
        }

        

    }
}