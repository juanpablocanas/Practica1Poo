using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;

namespace Test.Monitoreo
{
public class ProximoTornado{
    public int probabilidadTornado { get; set; }


    #region Methods
        public List<Seccion> ejecutarDomo(int probabilidadTornado, bool estadoDomo,RepositorioCultivo Datos,List<Seccion> Secciones){

            if((probabilidadTornado>=80) && estadoDomo==false){
                Console.WriteLine("Ejecutando Domo");
                 Seccion frutales = Secciones.First(s=> s.Tipo =="Frutales") as Seccion ;
                 frutales.enDomo=true;       
                estadoDomo = true;
                
            }
            else{
                Console.WriteLine("La probabilidad no es adecuada para usar el domo");
                
            }
            return Secciones;
        }

     #endregion Methods

}


}
