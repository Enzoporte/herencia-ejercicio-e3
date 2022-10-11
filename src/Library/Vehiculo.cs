namespace PII_Herencia
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string VehiculoDesc { get; set; }
        public int MaxCapacidad { get; set; }

        public Vehiculo (string marca, string modelo, int maxCapacidad)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.VehiculoDesc = $"{this.Marca} {this.Modelo}";
            this.MaxCapacidad = maxCapacidad;
        }
    }
}