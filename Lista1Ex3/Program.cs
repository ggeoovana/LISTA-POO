using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Diagonal qua;
            qua = new Diagonal();

            Console.WriteLine("Digite um valor para Diagonal do quadrado:  ");
            qua.setDiagonal(int.Parse(Console.ReadLine()));


            qua.calcularArea();

            Console.Write(" O valor da area do quadrado pela diagonel é:");
            Console.WriteLine(qua.getArea());

        }
    }
}
