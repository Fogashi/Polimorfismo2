using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2
{
    class Disciplina
    {
        public string NomeDisciplina;
        private List<Aluno> alunos = new List<Aluno>();

        public Disciplina(string nomeDisciplina)
        {
            NomeDisciplina = nomeDisciplina;
        }

        public void CriarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public void MostrarAlunos()
        {
            Console.WriteLine("alunos:");
            foreach(var aluno in alunos)
            {
                aluno.ExibirAluno();
            }
        }
    }
}
