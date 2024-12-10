using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_lineales__listas_
{
    internal class Listas
    {
        private Nodo cabeza;

        public Listas()
        {
            cabeza = null;
        }

        // Insertar un producto al final de la lista
        public void Insertar(Producto producto)
        {
            Nodo nuevoNodo = new Nodo(producto);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Ordenar los productos por precio de menor a mayor
        public void OrdenarPorPrecio()
        {
            if (cabeza == null || cabeza.Siguiente == null)
                return;

            bool cambio;
            do
            {
                cambio = false;
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    if (actual.Producto.Precio > actual.Siguiente.Producto.Precio)
                    {
                        Producto temp = actual.Producto;
                        actual.Producto = actual.Siguiente.Producto;
                        actual.Siguiente.Producto = temp;
                        cambio = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (cambio);
        }

        // Obtener todos los productos en la lista
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                productos.Add(actual.Producto);
                actual = actual.Siguiente;
            }
            return productos;
        }
    }
}
