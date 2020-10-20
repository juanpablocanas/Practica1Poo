using System;
using System.Collections.Generic;
using Test.Robot;
namespace Test.Monitoreo
{
public class Clima{
    public string climaActual { get; set; }


    #region Methods
        //public void ejecutarLuzArtificial(String climaActual, bool estadoLuzAritificial ){

            //if((climaActual == "Lloviendo" || climaActual == "Nublado") && estadoLuzAritificial==false){
               // Console.WriteLine("Ejecutando Luz Artificial");
                //estadoLuzAritificial = true;
            //}
            //else{
               // Console.WriteLine("El Clima no es adecuado para usar la Luz Artificial");
            //}
       // }

        public void MonitorearClima(){
            TareasRobot objRobot= new TareasRobot();
            objRobot.ejecutarLuzArtificial("Soleado", false);
        }

     #endregion Methods

}


}

