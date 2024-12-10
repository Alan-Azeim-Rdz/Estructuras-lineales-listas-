using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_lineales__listas_
{
    internal class Nodo
    {
        public Producto Producto { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Producto producto)
        {
            Producto = producto;
            Siguiente = null;
        }
    }
}
