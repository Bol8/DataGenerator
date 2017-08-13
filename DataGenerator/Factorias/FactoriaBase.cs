using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace DataGenerator.Factorias
{
    public abstract class FactoriaBase
    {
        protected string url = "http://tempuri.org/DataSchema.xsd";
        protected readonly string ELEMENTO_RAIZ;
        protected List<string> _nombres;
        protected readonly XDocument _xDocument;
        protected readonly XNamespace _ns;
        protected readonly Random _rnd;

        protected FactoriaBase(string elementoRaiz, string rutaFichero)
        {
            ELEMENTO_RAIZ = elementoRaiz;
            _xDocument = XDocument.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, rutaFichero));
            _ns = XNamespace.Get(url);
            _rnd = new Random();
        }

        protected abstract void cargarDatos();
    }
}