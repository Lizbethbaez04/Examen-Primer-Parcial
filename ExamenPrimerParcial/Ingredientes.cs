using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Ingredientes
    {
        public string Nombre { get; set; }
        public string Identificador { get; set; }

        public Ingredientes(string nombre, string identificador)
        {
            Nombre = nombre;
            Identificador = identificador;
            nombre = "Tomate";
            identificador = "186983";
        }
    }
}
