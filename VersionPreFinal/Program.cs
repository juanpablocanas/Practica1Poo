using System;
using System.Collections.Generic;
using System.Linq;
using Test.Granja;
using Test.Monitoreo;
using Test.Display;
using Test.FachadaUsuario;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioCultivo Datos = new RepositorioCultivo();
            List<Seccion> Secciones = Datos.Secciones;

            MenuUsuario objUsu= new MenuUsuario();
            
            objUsu.Seleccion(Datos,Secciones);

        }
    }
}
