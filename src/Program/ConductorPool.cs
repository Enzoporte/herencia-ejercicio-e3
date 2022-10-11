namespace PII_Herencia
{
    public class ConductorPool : Person
    {
        public string BioBreve { get; }
        public Vehiculo Vehiculo { get; }
        public int MaxCapacidad { get; }
        public ConductorPool (string nombre, string apellido, string cedula, Vehiculo vehiculo, int maxCapacidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreCompleto = $"{Nombre} {Apellido}";
            this.Cedula = cedula;
            this.Calificacion = 5.0f;
            this.Vehiculo = vehiculo;
            this.MaxCapacidad = maxCapacidad;
            this.BioBreve = $"Mi nombre es {NombreCompleto}, y conduzco un {Vehiculo.VehiculoDesc}.";
        }

        
    }
}