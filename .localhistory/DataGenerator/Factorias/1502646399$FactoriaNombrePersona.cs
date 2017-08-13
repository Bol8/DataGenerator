﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DataGenerator.Factorias
{
    public class FactoriaNombrePersona
    {
        private string url = "http://tempuri.org/DataSchema.xsd";
        private readonly string ELEMENTO_RAIZ = "Nombres";
        private int numElementos;
        private List<string> _nombres;
        private readonly XDocument _xDocument;
        private readonly XNamespace _ns;
        private Random rnd;

        public FactoriaNombrePersona(int numElementos)
        {
            this.numElementos = numElementos;
            _xDocument = XDocument.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Xml\\NombresPersonas.xml"));
            _ns = XNamespace.Get(url);
            rnd = new Random();
            cargarDatos();

            //_nombres = new List<string>();
        }

        private void cargarDatos()
        {
            var elementoRaiz = _xDocument.Element(_ns + ELEMENTO_RAIZ);

            if (elementoRaiz != null)
                _nombres = elementoRaiz.Elements().Select(x => x.Value).ToList();
        }


        public string obtenerNombre()
        {
           // Random rnd = new Random();
            var index = rnd.Next(0, _nombres.Count);

            return _nombres.ElementAtOrDefault(index);
        }

    }
}