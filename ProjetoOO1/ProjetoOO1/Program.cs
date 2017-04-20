using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace ProjetoOO1 {
    class Program {
        static void Main(string[] args) {

            List<Figura> lista = new List<Figura>();
            int n;

            Console.Write("Quantas figuras voce vai digitar ?: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Figura " + i + 1 + " - triangulo ou retangulo? (r / t): ");
                char caracter = Char.Parse(Console.ReadLine());

                if (caracter == 'r') {
                    Console.Write("largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Retangulo(largura, altura, "azul"));

                    Retangulo ret = new Retangulo(largura, altura, "azul");
                    
                }
                else {
                    Console.Write("lado a: ");
                    double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("lado b: ");
                    double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("lado c: ");
                    double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Triangulo(a, b, c, "vermelho"));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Àreas das figuras: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Figura "+ (i+1) + " : " + lista[i].area()); 
            }



           

            Console.ReadLine();
        }
    }
}
