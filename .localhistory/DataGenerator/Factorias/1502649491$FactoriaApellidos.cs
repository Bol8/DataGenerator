namespace DataGenerator.Factorias
{
    public class FactoriaApellidos : FactoriaBase
    {
        private static string rutaFichero = "Xml\\ApellidosPersonas.xml";
        private static readonly string ETIQUETA_RAIZ = "Apellidos";


        public FactoriaApellidos() 
            : base(ETIQUETA_RAIZ, rutaFichero)
        {

        }


        protected override void cargarDatos()
        {
            throw new System.NotImplementedException();
        }
    }
}