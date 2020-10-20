using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;
using Test.Exceptions;

namespace Test.Robot
{
public class TareasRobot{
    public int probabilidadTornado { get; set; }


    #region Methods
        public void ejecutarLuzArtificial(String climaActual, bool estadoLuzAritificial ){
 
            ValidarFormato objFormato= new ValidarFormato();
            objFormato.climaInvalido(climaActual);
          
            if((climaActual == "Lloviendo" || climaActual == "Nublado") && estadoLuzAritificial==false){
                Console.WriteLine("Ejecutando Luz Artificial");
                estadoLuzAritificial = true;
            }
            else{
                Console.WriteLine("El Clima no es adecuado para usar la Luz Artificial");
            }
        }
         public void ejecutarRobotRiego(int TemperaturaActual, bool estadoRiego ){
             
             ValidarFormato objValidar = new ValidarFormato();
             
             objValidar.numeroInvalido(TemperaturaActual);
             
             
             //if((TemperaturaActual>=40) && estadoRiego==false){
                //Console.WriteLine("Ejecutando Riego");
                //estadoRiego = true;
             ///}
              //else{
               // Console.WriteLine("La temperatura no es adecuado para usar la Luz Artificial");
             //}

            
            
           
        }
}
}
        
        



     #endregion Methods





