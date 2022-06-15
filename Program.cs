using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nome dos Alunos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Nota1: ");
                int nota = int.Parse(Console.ReadLine());
                Console.Write("Nota2: ");
                int nota2 = int.Parse(Console.ReadLine());
            }
        
        
        }
    }
}
