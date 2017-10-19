using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDeAS
{
    class Produto
    {
        public string Nome { get; set; }

        public double Preco { get; set; }

        public Produto(string nome = null, double preco = 0)
        {
            if (!(string.IsNullOrWhiteSpace(nome)) && !(double.IsNaN(preco) && preco == 0))
            {
                Nome = nome;
                Preco = preco;
            }
        }

         public static List<Produto> Produtos ()
        {
            List<Produto> prods = new List<Produto>(2);
            prods[0].Nome = "Picole simples";
            prods[0].Preco = 1.20;
            prods[1].Nome = "Cascinha";
            prods[1].Preco = 3.00;

            return prods;
        }  

    }
}
