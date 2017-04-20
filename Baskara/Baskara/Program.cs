using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Baskara {
    class Program {
        static void Main(string[] args) {
            double a, b, c, x1, x2, delta;

            string[] entrada = Console.ReadLine().Split(' ');
            a = Double.Parse(entrada[0], CultureInfo.InvariantCulture);
            b = Double.Parse(entrada[1], CultureInfo.InvariantCulture);
            c = Double.Parse(entrada[2], CultureInfo.InvariantCulture);

            delta = b * b - 4 * a * c;

            if (a == 0.0 || delta < 0.0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Valor de x1 eh: " + x1.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Valor de x2 eh: " + x2.ToString("F4", CultureInfo.InvariantCulture));
            }


            Produto produto = new Produto("Tv");
            string nomeProduto = produto.nome;
            Console.ReadLine();
        }
    }
}
