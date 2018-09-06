using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Platillos
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }

        public Platillos(string identificador, string nombre, string descripcion, string precio)
        {
            Identificador = identificador;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;

            identificador = "48646652";
            nombre = "Entomatadas";
            descripcion = "Tortilla bañada en salsa de tomate, hecha burrito y adentro tiene Pollo";
            precio = "90";

            List<Ingredientes> ingrediente;
            ingrediente = new List<Ingredientes>();
            ingrediente.Add.nombre("Tortilla");
        } 
        
    }
}
