using System;
using System.Collections.Generic;
namespace Trombo14_Practica_IV_Asp.net
{
    public delegate bool myDelegate(int x);
    public static class MathStatic
    {
        //Ejercicio 1
        //public static List<int> Pares(this List<int> list, Func<int, bool> func) => list.FindAll(x => func(x));
        public static List<int> Pares(this List<int> list, myDelegate dele) => list.FindAll(x => dele(x));
        //Ejercicio 2
        public static bool isImpar(int x) => (x % 2) != 0 ? true : false;
        public static double calcularITBS(double precio) => precio * 0.18;
        public static DateTime getDate() => DateTime.Now;
        
    }
}