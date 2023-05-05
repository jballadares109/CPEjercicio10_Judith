using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio10_Judith
{
    internal class Cliente : Persona
    {
        private int telefono_de_contacto;

        public Cliente(int telefono_de_contacto)
        {
            this.telefono_de_contacto = telefono_de_contacto;
        }

        public int Telefono_de_contacto { get => telefono_de_contacto; set => telefono_de_contacto = value; }

        public override void Mostrar()
        {
            base.Mostrar();
        }
    }
}
