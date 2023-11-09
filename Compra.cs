using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo2
{
    class Compra
    {

        public double RealizarCompra(Cupom cupom, double vp)
        {
            double desconto = vp * 0.5;
            cupom.Desconto = desconto;
            double valorComDesconto = vp - cupom.Desconto;
            return valorComDesconto;     
        }


    }
}
