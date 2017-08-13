using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace DataGenerator.Factorias
{
    public class FactoriaNombrePersona
    {
        private string ELEMENTO_RAIZ = "Nombres";
        private int numElementos;
        private List<string> _nombres;
        private XDocument _xDocument;

        public FactoriaNombrePersona(int numElementos)
        {
            this.numElementos = numElementos;
            _xDocument = XDocument.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Xml\\NombresPersona.xml"));
            _nombres = new List<string>();
        }
    }
}