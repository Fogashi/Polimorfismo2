using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //dependencia
            Compra comprar = new Compra();
            Cupom cupomzinho = new Cupom();          
            double mostrar = comprar.RealizarCompra(cupomzinho, 12);
            
            Console.WriteLine("valor de sua compra " + mostrar);
            //

            //composicao
            Pessoa pessoa = new Pessoa();
            pessoa.MostrarEndereco();
            //

            //agregacao
            Aluno aluno1 = new Aluno("Mateus",893829);
            Aluno aluno2 = new Aluno("Luna", 23942);

            Disciplina disciplina1 = new Disciplina("técnicas de programação");
            disciplina1.CriarAluno(aluno1);
            disciplina1.CriarAluno(aluno2);

            disciplina1.MostrarAlunos();
            //

        }
    }
}
