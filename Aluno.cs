using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio
{
    class Aluno
    {
        string Nome { get; set; }
        int Nota1 { get; set; }
        int Nota2 { get; set; }
        int Media { get; set; }
        public  Aluno (string nome, int nota, int nota2, int media)
        {
            Nome = nome;
            Nota1 = nota;
            Nota2 = nota2;
            Media = media;
            
            
        }
    
        public void MediaNota()
        {
            Media += Nota1 + Nota2 / 2;

        }
        public override string ToString()
        {
            return Nome + ": ," + Media.ToString("F2", CultureInfo.InvariantCulture); 
        }


    }
}
