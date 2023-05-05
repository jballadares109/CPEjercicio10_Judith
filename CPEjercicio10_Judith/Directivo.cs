using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio10_Judith
{
    internal class Directivo : Persona
    {
        private string categoria;

        public Directivo(string categoria)
        {
            this.categoria = categoria;
        }

        public string Categoria { get => categoria; set => categoria = value; }

        public override void Mostrar()
        {
            base.Mostrar();
        }

    }
}
