using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;
using Test.Exceptions;

namespace Test.Robot
{
public class EmergenciaRobot{
    


    #region Methods
       public List<Seccion> ejecutarDomo(int probabilidadTornado, bool estadoDomo,RepositorioCultivo Datos,List<Seccion> Secciones){

            if((probabilidadTornado>=80) && estadoDomo==false){
                Console.WriteLine("Ejecutando Domo");

                Seccion Cereales = Secciones.FirstOrDefault(s=> s.Tipo =="Cereales") as Seccion;
                Cereales.enDomo= true;
                Console.WriteLine("Estado Cereales en domo: "+ Cereales.enDomo);

                Seccion Hortalizas = Secciones.FirstOrDefault(s=> s.Tipo =="Hortalizas") as Seccion ;
                Hortalizas.enDomo=true;
                Console.WriteLine("Estado Hortalizas en domo: "+ Hortalizas.enDomo);

                Seccion Frutales = Secciones.FirstOrDefault(s=> s.Tipo =="Frutales") as Seccion ;
                Frutales.enDomo=true;
                Console.WriteLine("Estado Frutales en domo: "+ Frutales.enDomo);

                Seccion Ornamentales = Secciones.FirstOrDefault(s=> s.Tipo =="Ornamentales") as Seccion ;
                Ornamentales.enDomo = true;
                Console.WriteLine("Estado Ornamentales en domo: "+ Ornamentales.enDomo);
                
                estadoDomo = true;

                


                 //Seccion todasSecciones = Secciones.Where(s=> s.enDomo = false) as Seccion ;
                 //todasSecciones.enDomo = true;     Intenté hacerlo de esta manera pero no pude  
                
                
            }
            else{
                Console.WriteLine("La probabilidad no es adecuada para usar el domo");
                
            }
            return Secciones;
        }
        public List<Seccion> sacarDomo(int probabilidadTornado,RepositorioCultivo Datos,List<Seccion> Secciones){
            if(probabilidadTornado < 80){
                
                
                Seccion Cereales = Secciones.FirstOrDefault(s=> s.Tipo =="Cereales") as Seccion;
                if(Cereales.enDomo==false){
                    Console.WriteLine("Los cereales no estan en el domo para ser retirados");
                }
                else{
                    Cereales.enDomo=false;
                     Console.WriteLine("Sacando Cereales. Estado enDomo: "+ Cereales.enDomo);
                }
                
                Seccion Hortalizas = Secciones.FirstOrDefault(s=> s.Tipo =="Hortalizas") as Seccion ;
                if(Hortalizas.enDomo==false){
                    Console.WriteLine("Las Hortalizas no estan en el domo para ser retirados");
                }
                else{
                    Hortalizas.enDomo=false;
                    Console.WriteLine("Sacando Hortalizas. Estado enDomo: "+ Hortalizas.enDomo);
                }

                Seccion Frutales = Secciones.FirstOrDefault(s=> s.Tipo =="Frutales") as Seccion ;
                 if(Frutales.enDomo==false){
                    Console.WriteLine("Las Frutales no estan en el domo para ser retirados");
                }
                else{
                    Frutales.enDomo=false;
                    Console.WriteLine("Sacando Frutales. Estado enDomo: "+ Frutales.enDomo);
                }

                Seccion Ornamentales = Secciones.FirstOrDefault(s=> s.Tipo =="Ornamentales") as Seccion ;
                if(Ornamentales.enDomo==false){
                    Console.WriteLine("Las Ornamentales no estan en el domo para ser retirados");
                }
                else{
                    Ornamentales.enDomo=false;
                    Console.WriteLine("Sacando Ornamentales. Estado enDomo: "+ Ornamentales.enDomo);
                }
            }

                return Secciones;    
                
            }
           
            

        }
        }
        



     #endregion Methods

