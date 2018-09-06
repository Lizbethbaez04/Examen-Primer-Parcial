using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Menus
    {
       public string Nombre { get; set; }
        public string Identificador { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }

        public Menus(string nombre, string identificador, string horaInicio, string horaFin)
        {
            Nombre = nombre;
            Identificador = identificador;
            HoraInicio = HoraInicio;
            HoraFin = horaFin;

            nombre = "Desayunos";
            identificador = "D465962";
            horaInicio = "9";
            horaFin = "11:40";
             List<Platillos> platillos;
            platillos = new List<Platillos>();
            platillos.Add.nombre("Huevo");            
        }
    }
}
