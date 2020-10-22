using System;
using System.Collections.Generic;
using Test.Granja;
using System.Linq;
using Test.Robot;


namespace Test.Exceptions
{
public class ValidarFormato{
   

    #region Methods

    public void numeroInvalido(int numero){    //5
     
        try{  
            if(numero>3 && numero<60){               
                Console.WriteLine("Ejecutando Riego");
            }
            else if(numero>-30 && numero<2){
                Console.WriteLine("Esta haciendo mucho frio no es necesario el riego");
            }      
        else{
            throw new Exception ( "La temperatura no puede ser mayor a 60 o menor a -30");                           
        }  
      }
        catch(FormatException ){
            Console.WriteLine("La temperatura debe ser un numero");
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
            
        } 
    }

    public void climaInvalido(string clima){ 
        try{               //4
        if(clima == "Soleado" || clima== "Calido" || clima== "Lloviendo"  || clima== "Nublado" ){
                
        }
        else{
            throw new Exception ( "Recuerde que el clima debe ser Soleado o Calido o Lloviendo o Nublado"); 
        }
        }
             
             catch(FormatException ex ){
                 Console.WriteLine("Recuerde que la clima debe ser una palabra" + ex.Message);
             }
             catch (Exception ex){
                 Console.WriteLine( ex.Message);
             }           
        }

       

    public void colorValidar(string color){
        try{
         if(color == "Rojo" || color== "Amarillo" || color== "Morado"  || color== "Verde"|| color== "Naranja" || color== "Blanco"){
            
        }
        else{
            throw new Exception ( "Color no valido");     
        }
        }
        catch(NullReferenceException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }

    }
    public void seccionValidar(string seccion){
        try{
         if(seccion == "Frutales" || seccion== "Hortalizas" || seccion== "Cereales"  || seccion== "Ornamentales"){
            
        }
        else{
            throw new Exception ( "Seccion no valida");     
        }
        }
        catch(NullReferenceException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }

    }

    public void domoValidar(RepositorioCultivo Datos,List<Seccion> Secciones){  //Para Sacar Los Cultivos
        try{
            Seccion Hortalizas = Secciones.FirstOrDefault(s=> s.Tipo =="Hortalizas") as Seccion ;
            if(Hortalizas.enDomo == true){
            }
            Seccion Cereales = Secciones.FirstOrDefault(s=> s.Tipo =="Cereales") as Seccion ;
             if(Cereales.enDomo == true){
                
            }
            Seccion Frutales = Secciones.FirstOrDefault(s=> s.Tipo =="Frutales") as Seccion ;
             if(Frutales.enDomo == true){
            }
            Seccion Oranamentales = Secciones.FirstOrDefault(s=> s.Tipo =="Oranamentales") as Seccion ;
             if(Oranamentales.enDomo == true){
            }
            else{
                throw new Exception ( "Alguno de las secciones no esta en el domo");
                
            }
        }
            catch (Exception ){
                Console.WriteLine("Alguno de las secciones no esta en el domo");
            }
        }

    }


     


        
        
        


     #endregion Methods

}


