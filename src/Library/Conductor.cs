namespace PII_Herencia
{
    public class Conductor : Person
    {
        public string BioBreve { get; }
        public Vehiculo Vehiculo { get; }
        public int MaxCapacidad { get; }
        public bool IsPool { get; }

        public Conductor (string nombre, string apellido, string cedula, Vehiculo vehiculo, int maxCapacidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreCompleto = $"{Nombre} {Apellido}";
            this.Cedula = cedula;
            this.Calificacion = 5.0f;

            this.Vehiculo = vehiculo;
            this.MaxCapacidad = maxCapacidad;
            this.IsPool = (this.MaxCapacidad > 2);
            this.BioBreve = $"Hola! Mi nombre es {NombreCompleto}, y conduzco un {Vehiculo.VehiculoDesc}.";
        }

        
    }
}