using System.Collections.Generic;
using System.Linq;

namespace Test.Granja
{
public class RepositorioCultivo{
     #region Properties  
        public List<Seccion> Secciones { get; set; }
        #endregion Properties

        #region Initialize
        public RepositorioCultivo()
        {
            Secciones = CrearSecciones();
        }
        #endregion Initialize


        #region Methods
        public List<Seccion> CrearSecciones()
        {
            List<Seccion> secciones = new List<Seccion>();
            secciones.Add(new Seccion()
            {
                Tipo = "Cereales",
                Cultivos = new List<Cultivo>()
                {
                    new Cultivo("Arroz", "Blanco", 5, 3, true),
                    new Cultivo("Trigo", "Amarillo", 7, 4, true),
                    new Cultivo("Sorgo", "Cafe", 2, 8, false),
                                  
                }
            });
            secciones.Add(new Seccion()
            {
                Tipo = "Hortalizas",
                Cultivos = new List<Cultivo>()
                {
                    new Cultivo("Papa", "Amarillo", 2, 8, true),
                    new Cultivo("Zanahorias", "Naranja", 4, 7, true),
                    new Cultivo("Calabaza", "Naranja", 1, 2, true),
                    new Cultivo("Flor de Jamaica", "Naranja", 1, 2, false),  
                }
            });
            secciones.Add(new Seccion()
            {
                Tipo = "Frutales",
                Cultivos = new List<Cultivo>()
                {
                    new Cultivo("Bananos", "Amarillo", 1, 9, true),
                    new Cultivo("Manzanas", "Rojo", 2, 9, true),
                    new Cultivo("Fresas", "Rojo", 3, 10, true),
                    new Cultivo("Limon", "Verde", 1, 9, false),  
                }
            });
            secciones.Add(new Seccion()
            {
                Tipo = "Ornamentales",
                Cultivos = new List<Cultivo>()
                {
                    new Cultivo("Lavanda", "Morado", 8, 2, false),
                    new Cultivo("Eucalipto", "Verde", 7, 3, true),
                    new Cultivo("Menta", "Verde", 5, 4, true),
                    
                }
            });
            return secciones;
        
}
 #endregion Methods
        }
}
