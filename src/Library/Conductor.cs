namespace PII_Herencia
{
    public abstract class Conductor : Person
    {
        public string BioBreve { get; }
        public Vehiculo Vehiculo { get; }
        public Conductor (string nombre, string apellido, string cedula, Vehiculo vehiculo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreCompleto = $"{Nombre} {Apellido}";
            this.Cedula = cedula;
            this.Calificacion = 5.0f;
            this.Vehiculo = vehiculo;
            this.BioBreve = $"Mi nombre es {NombreCompleto}, y conduzco un {Vehiculo.VehiculoDesc}.";
        }

        
    }
}