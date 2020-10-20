using System;
using System.Collections.Generic;
using Test.Robot;
namespace Test.Monitoreo
{
public class Clima{
    public string climaActual { get; set; }


    #region Methods
       
        public void MonitorearClima(){
            TareasRobot objRobot= new TareasRobot();
            //QUEDO QUE TENGO QUE PONER x 
            Console.WriteLine("Ingrese el clima actual: ");
            climaActual=Console.ReadLine();
            objRobot.ejecutarLuzArtificial(climaActual, false);  //Cambiar parametros para ver validacion
        }

     #endregion Methods

}


}

