using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;
using Test.Exceptions;

namespace Test.Display
{
public class DisplayCultivos{

    #region Methods

        
        public List<Cultivo> displayColor(String seccionDeseada,String colorDeseado,RepositorioCultivo Datos,List<Seccion> Secciones ){
            ValidarFormato objValidar= new ValidarFormato();
            objValidar.seccionValidar(seccionDeseada);
            objValidar.colorValidar(colorDeseado);           
            Seccion s = Secciones.FirstOrDefault(s=> s.Tipo == seccionDeseada) as Seccion ;
            List<Cultivo> c = s.Cultivos.Where(c=> c.Color == colorDeseado).ToList<Cultivo>();
            Console.WriteLine("Los frutos de color " + colorDeseado +" en la seccion "+ seccionDeseada+ " son: ");
            c.ForEach(v => Console.Write(v.Fruto + "   "));
                     
            return c;
        }

        public List<Cultivo> tiempoMaduracionOrdenado(String seccionDeseada ,RepositorioCultivo Datos,List<Seccion> Secciones ){           
            ValidarFormato objValidar= new ValidarFormato();
           
            objValidar.seccionValidar(seccionDeseada);
            Seccion s = Secciones.FirstOrDefault(s=> s.Tipo == seccionDeseada) as Seccion;
            List<Cultivo> c = s.Cultivos.OrderBy(c=> c.TiempoMaduracion).ToList<Cultivo>();
            Console.WriteLine("Los tiempos de maduracion en ORDEN de la seccion " + seccionDeseada + " son: ");
            c.ForEach(v => Console.Write(v.Fruto + "  ")); Console.WriteLine("   ");
            c.ForEach(v => Console.Write(v.TiempoMaduracion+ "        ")); Console.WriteLine("   ");
            return c;
        }

        public int  maxMantenimiento(String seccionDeseada,RepositorioCultivo Datos,List<Seccion> Secciones){
            ValidarFormato objValidar= new ValidarFormato();
            
            objValidar.seccionValidar(seccionDeseada);
            Seccion s = Secciones.FirstOrDefault(s=> s.Tipo == seccionDeseada) as Seccion ;
            var seccionMasMatenimiento = s.Cultivos.Max(s => s.MantenimientoAlAno );
            Console.WriteLine("El matenimiento más constante de la seccion "+seccionDeseada +" es: "+seccionMasMatenimiento);
            return seccionMasMatenimiento;

        }

       

       

    

     #endregion Methods

}


}