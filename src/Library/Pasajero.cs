namespace PII_Herencia
{
    public class Pasajero : Person
    {
        public Pasajero (string nombre, string apellido, string cedula, string fotoPath)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreCompleto = $"{Nombre} {Apellido}";
            this.Cedula = cedula;
            this.Calificacion = 5.0f;
            this.Foto = fotoPath;
        }

        

    }
}