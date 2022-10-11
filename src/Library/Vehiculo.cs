namespace PII_Herencia
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string VehiculoDesc { get; set; }

        public Vehiculo (string marca, string modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.VehiculoDesc = $"{this.Marca} {this.Modelo}";
        }
    }
}