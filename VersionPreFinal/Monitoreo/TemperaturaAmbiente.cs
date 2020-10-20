using System;
using System.Collections.Generic;
using Test.Robot;
namespace Test.Monitoreo
{
public class TemperaturaAmbiente{
    public int TemperaturaActual { get; set; }


    #region Methods

        public void MonitorearTemperatura(){
            TareasRobot objRobot= new TareasRobot();
            Console.WriteLine("Ingrese la temperatura actual: ");
            int temp;
            string tempFinal;
            tempFinal= Console.ReadLine();
            temp = Convert.ToInt32(tempFinal);            
            objRobot.ejecutarRobotRiego(temp,false);
        }

      

     #endregion Methods

}


}
