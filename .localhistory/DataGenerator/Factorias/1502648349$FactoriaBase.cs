using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DataGenerator.Factorias
{
    public abstract class FactoriaBase
    {
        protected string url = "http://tempuri.org/DataSchema.xsd";
        protected readonly string ELEMENTO_RAIZ = "Nombres";
        protected List<string> _nombres;
        protected readonly XDocument _xDocument;
        protected readonly XNamespace _ns;
        protected readonly Random _rnd;
    }
}