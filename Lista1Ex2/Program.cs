using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado qua;
            qua = new Quadrado();

            Console.WriteLine("Digite um valor para Aresta do quadrado:    ");
            qua.setAresta(int.Parse(Console.ReadLine()));



            qua.calcularArea();

            Console.WriteLine(qua.getArea());


        }
    }
}
