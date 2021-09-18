using System;
using System.Collections.Generic;

namespace Trombo14_Practica_IV_Asp.net
{
     class Program
    {
        private static bool isPar(int x) => (x % 2) == 0 ? true : false;
        static void Main(string[] args)
        {

            Ejercicio1();
            Ejercicio2();
        }

        //Metodos que tienen los ejercicios
        static void Ejercicio1()
        {
            List<int> listNum = new List<int>() { 1, 3, 4, 5, 6 ,5,10,30,20,53,12};
            Console.WriteLine("Ejercicio 1");
            myDelegate delIsPar = new myDelegate(isPar);
            listNum.Pares(delIsPar).ForEach(x => Console.Write(x+","));
            Console.WriteLine("");
        }

        static void Ejercicio2()
        {
            double precio = 3500.32;
            int impar = 5;
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine($"{impar} es impar: {MathStatic.isImpar(impar)}");
            Console.WriteLine($"Precio: {precio} itbs: {MathStatic.calcularITBS(precio)}");
            Console.WriteLine($"getDate: {MathStatic.getDate()}");
        }

    }


}