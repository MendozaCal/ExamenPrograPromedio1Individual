using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograProm1Individual
{
    internal class Tienda
    {
        List<Productos> producto;
        List<Productos> carrito;
        public Tienda()
        {
            producto = new List<Productos>();
            carrito = new List<Productos>();
            producto.Add(new Arcilla("Maceta", "Mediano", "", "Rojo", "Libiano", 10));
            producto.Add(new Arcilla("Olla", "Grande", "", "Marrón", "Ligero", 20));
            producto.Add(new Tela("Sabana", "2 plazas", "Seda", "Gris", "", 12));
            producto.Add(new Tela("Colcha", "1.5 plazas", "Seda", "Gris", "", 30));
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
                    case "2":
                        Carrito();
                        break;
                    case "3":
                    case "4":
                        continueFlag = false;
                        break;
                }
            }
            Console.ReadLine();
        }
        public void Catálogo()
        {
            Console.WriteLine("Catálogo de Productos:");
            Console.WriteLine("Elija un producto");
            for (int i = 0; i < producto.Count; i++)
            {
                Console.WriteLine($"{i+1}. {producto[i].GetData()}");
            }
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < producto.Count)
            {
                producto[index].GetPrice();
            }
        }
        public void Carrito()
        {
            Console.WriteLine("Carrito de Compras:");
            for (int i = 0 ; i < producto.Count; i++)
            {
                Console.WriteLine($"{ i + 1}. {producto[i].GetName()}");
                Console.WriteLine($"{producto[i].GetPrice()}");
            }
        }

    }
}

