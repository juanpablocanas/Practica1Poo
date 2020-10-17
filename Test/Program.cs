using System;
using System.Collections.Generic;
using System.Linq;
using Test.Granja;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioCultivo Datos = new RepositorioCultivo();
            List<Seccion> Secciones = Datos.Secciones;
  
            Seccion frutales = Secciones.First(s=> s.Tipo =="Frutales") as Seccion ;
            List<String> frutos = frutales.Cultivos.Select(c => c.Fruto).ToList();

            Cultivo FrutoAmarillo = frutales.Cultivos.Last( c => c.Color == "Amarillo"); //Ultimo frutales Amarillo

            Seccion Hortalizas = Secciones.First(s=> s.Tipo =="Hortalizas") as Seccion ; 
            List<Cultivo> HortalizasRojas = Hortalizas.Cultivos.Where(c => c.Color == "Naranja").ToList<Cultivo>(); //Todas las hortalizas naranjas

            
            

          
           
            
        }
    }
}
