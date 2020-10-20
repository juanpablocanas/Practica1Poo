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

                Seccion Cereales = Secciones.FirstOrDefault(s=> s.Tipo =="Cereales") as Seccion;
                Cereales.enDomo= true;

                Seccion Hortalizas = Secciones.FirstOrDefault(s=> s.Tipo =="Hortalizas") as Seccion ;
                Hortalizas.enDomo=true;

                Seccion Frutales = Secciones.FirstOrDefault(s=> s.Tipo =="Frutales") as Seccion ;
                Frutales.enDomo=true;

                Seccion Ornamentales = Secciones.FirstOrDefault(s=> s.Tipo =="Ornamentales") as Seccion ;
                Ornamentales.enDomo = true;
                
                estadoDomo = true;
                 //Seccion todasSecciones = Secciones.Where(s=> s.enDomo = false) as Seccion ;
                 //todasSecciones.enDomo = true;     Intenté hacerlo de esta manera pero no pude  
                
                
            }
            else{
                Console.WriteLine("La probabilidad no es adecuada para usar el domo");
                
            }
            return Secciones;
        }
        



     #endregion Methods

}


}
