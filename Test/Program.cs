using System;
using System.Collections.Generic;
using System.Linq;
using Test.Granja;
using Test.Monitoreo;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioCultivo Datos = new RepositorioCultivo();
            List<Seccion> Secciones = Datos.Secciones;

            ProximoTornado objTornado= new ProximoTornado();
            objTornado.ejecutarDomo(90, false, Datos, Secciones);
           Seccion enDomo = Secciones.FirstOrDefault(s=> s.enDomo = true) as Seccion;
  
            Seccion frutales = Secciones.First(s=> s.Tipo =="Frutales") as Seccion ;           
            List<String> frutos = frutales.Cultivos.Select(c => c.Fruto).ToList();
            Cultivo FrutoAmarillo = frutales.Cultivos.Last( c => c.Color == "Amarillo"); //Ultimo frutales Amarillo



            Seccion Hortalizas = Secciones.FirstOrDefault(s=> s.Tipo =="Hortalizas") as Seccion ;
            List<Cultivo> HortalizasNaranjas = Hortalizas.Cultivos.Where(c=> c.Color == "Naranja").ToList<Cultivo>();
            

            
            

          
           
            
        }
    }
}
