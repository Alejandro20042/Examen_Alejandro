namespace Examen_Alejandro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada listaEnlazada = new ListaEnlazada();

            
                while (true)
                {
                   

                    Console.WriteLine("1.- Agregar Producto");
                    Console.WriteLine("2.- Buscar Producto");
                    Console.WriteLine("3.- Imprimir Productos");


                //int opciociones = int.Parse(Console.ReadLine());
                 int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el nombre del producto");
                        string? nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa el precio del producto");
                        int precio = int.Parse(Console.ReadLine());

                        Producto productoNuevo = new Producto(nombre, precio);

                        listaEnlazada.AgregarProducto(productoNuevo);

                        break;
                    case 2:
                        Console.WriteLine("Buscar Producto: ");

                        int nombreProducto = int.Parse(Console.ReadLine());
                       listaEnlazada.BuscarProducto(nombreProducto);
                        break;
                    case 3:
                        listaEnlazada.MostrarProductos();
                        break;
                }

                    
                }
               
        }
    }
}