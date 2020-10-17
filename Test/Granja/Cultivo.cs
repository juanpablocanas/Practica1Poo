namespace Test.Granja
{
    public class Cultivo
    {
        #region Properties  
        public string Fruto { get; set; }
        public string Color { get; set; }
        public double TiempoMaduracion { get; set; }
        public int MantenimientoAlAno { get; set; }
        public bool EsComestible { get; set; }
        

        #endregion Properties

        #region Initialize
        public Cultivo(string Fruto, string Color, double TiempoMaduracion, int MantenimientoAlAno, bool EsComestible) 
        {
            this.Fruto = Fruto;
            this.Color = Color;
            this.TiempoMaduracion = TiempoMaduracion;
            this.MantenimientoAlAno = MantenimientoAlAno;
            this.EsComestible = EsComestible;
            
        }
        #endregion Initialize

    }
}