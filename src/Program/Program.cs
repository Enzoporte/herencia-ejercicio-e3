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

            Person pasajero1 = new Pasajero("Lucas", "Peguri", "99999999");
            Person pasajero2 = new Pasajero("Ignacio", "Berra", "12345678");
            Person pasajero3 = new Pasajero("Vinta", "Grios", "11111111");
            Person conductorComun1 = new Conductor("Enzo", "Cantoni", "54321840", VolkswagenUp1, 2);
            Person conductorPool1 = new Conductor("Matias", "La Cruz", "5363561", Kicks1, 4);

            List<Person> rideShareList = new List<Person> { pasajero1, pasajero2, pasajero3, conductorComun1, conductorPool1 }; 

/*             for (int i = 0; i < rideShareList.Count; i++)
            {
                
                if (rideShareList[i] is Conductor)
                {
                    Conductor persona = rideShareList[i];
                    Console.WriteLine(twitter.PublishToTwitter($"- Bienvenido {persona.NombreCompleto} a los ConductoresUCU! -\n{persona.BioBreve} ","../../Gol.jpg"));
                }
                else
                {
                    Console.WriteLine(twitter.PublishToTwitter(,"../../Gol.jpg"));
                }
            } */
            

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
