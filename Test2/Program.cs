﻿using System;
using System.Collections.Generic;
using System.Linq;
using Test.Granja;
using Test.Monitoreo;
using Test.Display;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioCultivo Datos = new RepositorioCultivo();
            List<Seccion> Secciones = Datos.Secciones;

          

            ProximoTornado objTornado= new ProximoTornado();
            Clima objClima = new Clima();
            objTornado.ejecutarDomo(90, false, Datos, Secciones);
            Seccion enDomo = Secciones.FirstOrDefault(s=> s.enDomo = true) as Seccion;

            DisplayCultivos objDisplay = new DisplayCultivos();

            objDisplay.displayColor("Frutales","Rojo",Datos,Secciones);

            objDisplay.tiempoMaduracionOrdenado("Cereales",Datos,Secciones);

            objDisplay.maxMantenimiento("Ornamentales",Datos,Secciones);

            objClima.MonitorearClima();    //Desea monitorear el clima?

  
            //Seccion frutales = Secciones.First(s=> s.Tipo =="Frutales") as Seccion ;           
            //List<String> frutos = frutales.Cultivos.Select(c => c.Fruto).ToList();
            //Cultivo FrutoAmarillo = frutales.Cultivos.Last( c => c.Color == "Amarillo"); //Ultimo frutales Amarillo


            //Seccion Hortalizas = Secciones.FirstOrDefault(s=> s.Tipo =="Hortalizas") as Seccion ;
            //List<Cultivo> HortalizasNaranjas = Hortalizas.Cultivos.Where(c=> c.Color == "Naranja").ToList<Cultivo>();



            
            

            
            

          
           
            
        }
    }
}
