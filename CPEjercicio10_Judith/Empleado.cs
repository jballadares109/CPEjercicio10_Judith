using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEjercicio10_Judith
{
    internal class Empleado : Persona
    {
        private double sueldo_bruto;

        public Empleado(double sueldo_bruto)
        {
            this.sueldo_bruto = sueldo_bruto;
        }

        public double Sueldo_bruto { get => sueldo_bruto; set => sueldo_bruto = value; }

        public override void Mostrar()
        {
            base.Mostrar();
        }
        public void Calcula_salario_neto()
        {
            Console.WriteLine(" ");
        }
    }
}
