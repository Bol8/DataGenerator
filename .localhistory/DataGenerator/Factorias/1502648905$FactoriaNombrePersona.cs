using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DataGenerator.Factorias
{
    public class FactoriaNombrePersona : FactoriaBase
    {
        private static string rutaFichero = "Xml\\NombresPersonas.xml";
        private static readonly string ETIQUETA_RAIZ = "Nombres";


        public FactoriaNombrePersona()
            : base(ETIQUETA_RAIZ, rutaFichero)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            var elementoRaiz = _xDocument.Element(_ns + ELEMENTO_RAIZ);

            if (elementoRaiz != null)
                _nombres = elementoRaiz.Elements().Select(x => x.Value).ToList();
        }


        public string obtenerNombre()
        {
            var index = _rnd.Next(0, _nombres.Count);

            return _nombres.ElementAtOrDefault(index);
        }

    }
}