using System;
using System.Collections.Generic;
namespace Test.Monitoreo
{
public class TemperaturaAmbiente{
    public int TemperaturaActual { get; set; }


    #region Methods
        public void ejecutarRiego(int TemperaturaActual, bool estadoRiego ){

            if((TemperaturaActual>=40) && estadoRiego==false){
                Console.WriteLine("Ejecutando Riego");
                estadoRiego = true;
            }
            else{
                Console.WriteLine("La temperatura no es adecuado para usar la Luz Artificial");
            }
        }

     #endregion Methods

}


}
