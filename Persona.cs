using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperProgramazo64
{
    internal class Persona
    {
        public bool esAburrido = false;
        public int[] deudas;

        public string nombre;

        public bool GetEstado() { return esAburrido; }
    }


}
