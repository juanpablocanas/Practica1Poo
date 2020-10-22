using System.Collections.Generic;

namespace Test.Granja
{
 public class Seccion
    {
        #region Properties  
        public string Tipo { get; set; }
        public int Tamano { get; set; }
        public List <Cultivo> Cultivos{ get; set; }
        public int ProduccionFrutas { get; set; }
        public int ProduccionDinero{ get; set; }
        public bool enDomo{ get; set; }

        public bool LuzArtificial{ get; set; }

        #endregion Properties

        #region Initialize
    
        #endregion Initialize

    }
}
