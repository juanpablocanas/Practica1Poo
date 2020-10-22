using System;
using System.Collections.Generic;
using System.Linq;
using Test.Granja;
using Test.Monitoreo;
using Test.Display;
using Test.Robot;
namespace Test.FachadaUsuario{

    public class MenuUsuario{
         #region Methods
         public int MenuPrincipal(){
             Console.WriteLine(" ");
             Console.WriteLine(" ");
             Console.WriteLine(" ");
            Console.WriteLine("Buenas Tardes y Bienvenido a la Granja Inteligente. ");
             Console.WriteLine("Opciones LinQ 1-3: \n"+
                                "1. Display por Color\n"+
                                "2. Tiempo Maduracion Ordenado\n"+
                                "3. Maximo Mantenimiento\n"+
                                "Opciones Monitoreo: \n"+
                                "4. Monitorear Clima\n"+
                                "5. Monitorear Temperatura\n"+
                                "6. BOTON ROJO : Ejecutar Emergencia Domo\n"+
                                "7. BOTON VERDE: Sacar del domo\n"+
                                 "-1 Para salir"   );
            int choice;
            string Opcion;
            Opcion = Console.ReadLine();      //////////// SI SE NECESITA
            choice = Convert.ToInt32(Opcion);         ///////////// SI SE NECESITA           
            return choice;    
         }

         public void Seleccion(RepositorioCultivo Datos,List<Seccion> Secciones){
             MenuUsuario objUsu= new MenuUsuario();
             ProximoTornado objTornado= new ProximoTornado();
             Clima objClima = new Clima();
             TemperaturaAmbiente objTemperatura = new TemperaturaAmbiente();
             TareasRobot objRobot= new TareasRobot();
             DisplayCultivos objDisplay = new DisplayCultivos();    
             int choice;         
             do{
                  choice = objUsu.MenuPrincipal();

             switch(choice){
                 case 1: 
                    Console.WriteLine("Nombre de la seccion que desea buscar");                   
                    string seccionDeseada = Console.ReadLine();
                    Console.WriteLine("Color a buscar");                   
                    string colorDeseado = Console.ReadLine();
                    objDisplay.displayColor(seccionDeseada,colorDeseado,Datos,Secciones);              
                 break;
                 case 2:
                    Console.WriteLine("Nombre de la seccion que desea buscar");                   
                    string seccionDeseada1 = Console.ReadLine();
                    objDisplay.tiempoMaduracionOrdenado(seccionDeseada1,Datos,Secciones);
                    Console.WriteLine();
                 break;
                case 3:
                    Console.WriteLine("Nombre de la seccion que desea buscar");                   
                    string seccionDeseada2 = Console.ReadLine();
                    objDisplay.maxMantenimiento(seccionDeseada2,Datos,Secciones);
                    Console.WriteLine();
                 break;
                case 4:
                    objClima.MonitorearClima();
                    Console.WriteLine();
                 break;
                case 5:
                    objTemperatura.MonitorearTemperatura();
                    Console.WriteLine();
                 break;
                case 6:                    
                    objTornado.ejecutarRobotEmergencia(Datos,Secciones);
                    Console.WriteLine();
                break;
                case 7:
                    objTornado.ejecutarSacarDomo(Datos,Secciones);
                    break;

                    }
             }while(choice!=-1);
            


             }
         }    
                                               


         }
        
     #endregion Methods



    
