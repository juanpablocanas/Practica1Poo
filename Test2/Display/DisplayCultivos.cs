using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;

namespace Test.Display
{
public class DisplayCultivos{

    #region Methods
        public List<Cultivo> displayColor(String seccionDeseada,String colorDeseado,RepositorioCultivo Datos,List<Seccion> Secciones ){
            
            Seccion s = Secciones.FirstOrDefault(s=> s.Tipo == seccionDeseada) as Seccion ;
            List<Cultivo> c = s.Cultivos.Where(c=> c.Color == colorDeseado).ToList<Cultivo>();
            return c;
        }

        public List<Cultivo> tiempoMaduracionOrdenado(String seccionDeseada ,RepositorioCultivo Datos,List<Seccion> Secciones ){
            List<Cultivo> cultivosOrdenados = Secciones.FirstOrDefault(s=> s.Tipo == seccionDeseada).Cultivos.OrderBy(c=> c.TiempoMaduracion).ToList<Cultivo>();
            return cultivosOrdenados;
        }

        public int  maxMantenimiento(String seccionDeseada,RepositorioCultivo Datos,List<Seccion> Secciones){
            Seccion s = Secciones.FirstOrDefault(s=> s.Tipo == seccionDeseada) as Seccion ;
            var seccionMasDinero = s.Cultivos.Max(s => s.MantenimientoAlAno );
            return seccionMasDinero;

        }

     #endregion Methods

}


}