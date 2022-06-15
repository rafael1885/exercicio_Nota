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

            List<Aluno> list = new List<Aluno>();

            for (int i = 1; i < n; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Nota1: ");
                int nota = int.Parse(Console.ReadLine());
                Console.Write("Nota2: ");
                int nota2 = int.Parse(Console.ReadLine());
                int media = int.Parse(Console.ReadLine());
                list.Add(new Aluno(nome, nota, nota2, media));
                Console.WriteLine();

            }


            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Aluno obj in list)
            {
                Console.WriteLine(obj);

            }
    }
}
