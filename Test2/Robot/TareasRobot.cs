using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;

namespace Test.Robot
{
public class TareasRobot{
    public int probabilidadTornado { get; set; }


    #region Methods
        public void ejecutarLuzArtificial(String climaActual, bool estadoLuzAritificial ){

            if((climaActual == "Lloviendo" || climaActual == "Nublado") && estadoLuzAritificial==false){
                Console.WriteLine("Ejecutando Luz Artificial");
                estadoLuzAritificial = true;
            }
            else{
                Console.WriteLine("El Clima no es adecuado para usar la Luz Artificial");
            }
        }
        }
        



     #endregion Methods

}



