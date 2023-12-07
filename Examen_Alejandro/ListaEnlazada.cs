using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Alejandro
{
    class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public Producto(string nombre, int precio) 
        {
            Nombre = nombre;
            Precio = precio;
        
        }
    }

    class Nodo
    {
        public Producto Dato { get; set; }
        public Nodo Siguiente { get; set; }
    }
    
    internal class ListaEnlazada
    {
        private Nodo cabeza;

        public void AgregarProducto(Producto producto)
        {
            Nodo nuevoNodo = new Nodo { Dato = producto, Siguiente = null};

            if(cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;

        }

        public int BuscarProducto(int precio)
        {
            Nodo actual = cabeza;
            int posicion = 0;
            if (posicion != null) 
            {
                while (actual.Dato.Precio == precio )
                {
                    Console.WriteLine($"El producto {actual.Dato.Precio}: del {actual.Dato.Nombre} esta en la posicion: {posicion}");
                }
                actual = actual.Siguiente;
                posicion++;
            }
            return -1;
        }

        public void MostrarProductos()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine($"Nombre: {actual.Dato.Nombre}, Precio: {actual.Dato.Precio}");
                actual = actual.Siguiente;
            }
        }
    }
}
