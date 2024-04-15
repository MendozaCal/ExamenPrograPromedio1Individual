﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograProm1Individual
{
    internal class Arcilla:Productos
    {
         string n;
         string t;
         string m;
         string c;
         string p;
         float pr;
        public Arcilla (string name, string tamaño, string material, string color, string peso, float precio)
        {
            this.n = name;
            this.t = tamaño;
            this.m = material;
            this.c = color;
            this.p = peso;
            this.pr = precio;
        }
        public override string GetData()
        {
            return $"El producto {name} pesa {peso} es {tamaño} y es de color {color}";
        }
        public override float GetPrice()
        {
            return pr;
        }
    }
}
