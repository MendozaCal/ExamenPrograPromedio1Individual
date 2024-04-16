using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograProm1Individual
{
    internal class Tienda
    {
        List<Productos> producto;

        public Tienda() 
        {
            producto = new List<Productos>();
            AgregarProductos();
        }
        public void ListadeProductos()
        {
            
        }
        public void Execute()
        {
            MainMenu();
        }
        public void MainMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Elija una opción");
                Console.WriteLine("1. Elegir un producto");
                Console.WriteLine("2. Ver Carrito");
                Console.WriteLine("3. Pagar");
                Console.WriteLine("4. Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1": 
                        Catálogo();
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                }
            }
            Console.ReadLine();
        }
        public void AgregarProductos()
        {
            producto.Add(new Arcilla("Maceta", "Mediano", "", "Rojo", "Libiano", 10));
            producto.Add(new Arcilla("Olla", "Grande", "", "Marrón", "Ligero", 20));
            producto.Add(new Tela("Sabana", "2 plazas", "Seda", "Gris", "", 12));
            producto.Add(new Tela("Colcha", "1.5 plazas", "Seda", "Gris", "", 30));
        }
        public void Catálogo()
        {
            if (producto != null)
            {
                Console.WriteLine("Catálogo de Productos:");
                foreach (Productos prod in producto)
                {
                    Console.WriteLine(prod.GetData());
                }
            }
            else
            {
                Console.WriteLine("No hay productos disponibles en el catálogo.");
            }
        }

    }
}

