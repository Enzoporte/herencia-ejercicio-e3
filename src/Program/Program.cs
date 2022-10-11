using System;
using System.Collections;
using System.Collections.Generic;
using TwitterUCU;

namespace PII_Herencia
{
    class Program
    {


        static void Main(string[] args)
        {

            var twitter = new TwitterImage();

            Vehiculo VolkswagenUp1 = new Vehiculo("Volkswagen", "Up!");
            Vehiculo Kicks1 = new Vehiculo("Nissan", "Kicks");

            Person pasajero1 = new Pasajero("Lucas", "Peguri", "99999999", "../../Peguri.jpg");
            Person pasajero2 = new Pasajero("Ignacio", "Berra", "12345678", "../../Berra.jpg");
            Person pasajero3 = new Pasajero("Vinta", "Grios", "11111111", "../../Vintagrios.jpg");
            Person conductorComun1 = new Conductor("Enzo", "Cantoni", "54321840", "../../Cantoni.jpg", VolkswagenUp1, 2);
            Person conductorPool1 = new Conductor("Matias", "La Cruz", "5363561", "../../LaCruz.jpg", Kicks1, 4);

            ArrayList rideShareList = new ArrayList { pasajero1, pasajero2, pasajero3, conductorComun1, conductorPool1 };

            for (int i = 0; i < rideShareList.Count; i++)
            {
                if (rideShareList[i] is Conductor)
	            {
                    Conductor conductor = (Conductor)rideShareList[i];
	                Console.WriteLine(twitter.PublishToTwitter(
	                    $"- Bienvenido {conductor.NombreCompleto} a los ConductoresUCU! -\n{conductor.BioBreve} ",
                        conductor.Foto));
	            }
	            else if (rideShareList[i] is Pasajero)
	            {
                   Pasajero pasajero = (Pasajero)rideShareList[i];
	                Console.WriteLine(twitter.PublishToTwitter(
	                    $"- Nuevo Pasajero UCU! {pasajero.NombreCompleto} -\n", pasajero.Foto));
	            }
            }



            /*  UcuRideShare rideShare = new UcuRideShare();

             rideShare.Add(conductor1)
             Se publica en Twitter un nuevo conductor!

             rideShare.Add(conductorPool1)
             Se publica en Twitter un nuevo conductor!

             rideShare.Add(pasajero1)
             Se publica en Twitter nuevo registro de pasajero!

             rideShare.Add(pasajero2)
             Se publica en Twitter nuevo registro de pasajero!

             rideShare.Add(pasajero3)
             Se publica en Twitter nuevo registro de pasajero! */


        }
    }
}
