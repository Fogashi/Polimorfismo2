using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2
{
    class Pessoa
    {
        Endereco e1 = new Endereco("CEP");
        Endereco e2 = new Endereco("Cidade");
        Endereco e3 = new Endereco("Estado");

        public void MostrarEndereco()
        {
            string mostrar1 = e1.informacao = "Cep = 212121";
            string mostrar2 = e2.informacao = "Cidade = Rua Eclipse";
            string mostrar3 = e3.informacao = "Estado = São Paulo";

            Console.WriteLine("Composição = {0} {1} {2}",mostrar1,mostrar2,mostrar3);
        }




    }
}
