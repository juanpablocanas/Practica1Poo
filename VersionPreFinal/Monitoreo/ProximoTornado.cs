using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;
using Test.Robot;


namespace Test.Monitoreo
{
public class ProximoTornado{
    public int probabilidadTornado { get; set; }


    #region Methods

        public void ejecutarRobotEmergencia(RepositorioCultivo Datos,List<Seccion> Secciones){
            EmergenciaRobot objRobot= new EmergenciaRobot();
            int temp;
            string probFinal;
            Console.WriteLine("Ingrese la probabilidad del tonrnado para confirmar la accion");
            probFinal= Console.ReadLine();
            temp = Convert.ToInt32(probFinal);   
            objRobot.ejecutarDomo(temp,false,Datos,Secciones);   //Cambiar parametros para ver validacion
        }
        public void ejecutarSacarDomo(RepositorioCultivo Datos,List<Seccion> Secciones){
            EmergenciaRobot objRobot= new EmergenciaRobot();
             int temp;
            string probFinal;
            Console.WriteLine("Ingrese la probabilidad del tonrnado para confirmar la accion");
            probFinal= Console.ReadLine();
            temp = Convert.ToInt32(probFinal); 
            objRobot.sacarDomo(temp,Datos,Secciones);

        }
        
        


     #endregion Methods

}


}
