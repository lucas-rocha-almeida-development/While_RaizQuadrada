using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_RaizQuadrada {
    internal class Program {
        static void Main(string[] args) {
            //estrutura While (Enquanto for verdadeiro execute)
            Console.WriteLine("----------CALCULANDO RAIZ-----------------");
            Console.Write("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //acima sera digitado um valor e logo depois iremos cair na execução do while.
            while (x >= 0.0) { //condição ficara sendo executando enquanto estiver TRUE
            double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite um numero: ");
                x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            }
            //Atenção: caso seja digitado um numero negativo ( ira sair da condição)
            
            Console.WriteLine("Numero negativo!");//imprima essa mensagem quando numero digitado for menor que 0.0
            //fim da execução do programa.
            Console.ReadKey();
        }
    }
}
