using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograProm1Individual
{
    internal class Productos:Carrito
    {
        protected string name;
        protected string tamaño;
        protected string material;
        protected string color;
        protected string peso;
        protected float precio;

        public virtual string GetName()
        {
            return name;
        }
        public virtual string GetData()
        {
            return $"";
        }
        public virtual float GetPrice()
        {
            return 0;
        }
        
    }
}
