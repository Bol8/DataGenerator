using System.Linq;

namespace DataGenerator.Factorias
{
    public class FactoriaApellidos : FactoriaBase
    {
        private static string rutaFichero = "Xml\\ApellidosPersonas.xml";
        private static readonly string ETIQUETA_RAIZ = "Apellidos";


        public FactoriaApellidos() 
            : base(ETIQUETA_RAIZ, rutaFichero)
        {
            cargarDatos();
        }

        protected sealed override void cargarDatos()
        {
            var elementoRaiz = _xDocument.Element(_ns + ELEMENTO_RAIZ);

            if (elementoRaiz != null)
                _nombres = elementoRaiz.Elements().Select(x => x.Value).ToList();
        }

        public string obtenerApellido()
        {
            var index = _rnd.Next(0, _nombres.Count);

            return _nombres.ElementAtOrDefault(index);
        }

        public string obtenerApellidos()
        {
            var apellido2 = "";
            var index = _rnd.Next(0, _nombres.Count);
            var apellido1 = _nombres.ElementAtOrDefault(index);

            var isOk = false;
            while (!isOk)
            {
                index = _rnd.Next(0, _nombres.Count);
                apellido2 = _nombres.ElementAtOrDefault(index);
                isOk = !Equals(apellido1, apellido2);
            }


            return apellido1 + " " + apellido2;
        }
    }
}