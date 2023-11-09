using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Ra { get; set; }

        public Aluno(string nome, int ra)
        {
            this.Nome = nome;
            this.Ra = ra;
        }

        public void ExibirAluno()
        {
            Console.WriteLine($"Nome:  {Nome}, Ra: {Ra} ");
        }
    }
}
