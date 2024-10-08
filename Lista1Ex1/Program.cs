using System
    ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retângulo ret;
            ret = new Retângulo();

            Console.WriteLine("Digite um valor para Base do retangulo:    ");
            ret.setBase(int.Parse(Console.ReadLine()));

           Console.WriteLine("Digite um valor para Altura do Retangulo:");
            ret.setAltura(int.Parse(Console.ReadLine()));

           
            ret.calcularArea();

            Console.WriteLine(ret.getArea());


        }
    }
}
