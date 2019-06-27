using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Requisitions
{
    public class Requisition
    {
        public Formato Formato { get; private set; }

        public Requisition(Formato formato)
        {
            this.Formato = formato;
        }

    }
    public enum Formato
    {
        Xml,
        Csv,
        Porcento
    }
}
