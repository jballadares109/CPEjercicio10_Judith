using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio10_Judith
{
    internal class Empresa
    {
        private string nombre;

        public Empresa(string nombre)
        {
            this.nombre = nombre;
        }
        public Empresa() { }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
