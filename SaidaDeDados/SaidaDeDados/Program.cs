using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            double flutuante = 123.45678;
            int inteiro = 22;
            string nomeProprio = "Pedro";
            char sexo = 'M';

            //imprimindo valores no console.
            Console.Write("Hello World C#");
            Console.Write("Aprendendo C#");

            Console.WriteLine();

            Console.WriteLine(flutuante);
            Console.WriteLine(flutuante.ToString("F2"));
            Console.WriteLine(flutuante.ToString("F4"));
            Console.WriteLine(flutuante.ToString("F2"), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + inteiro);
            Console.WriteLine("O valor do troco é " + flutuante + " reais");
            Console.WriteLine("O valor do troco é " + flutuante.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("O paciente " + nomeProprio + " tem " + inteiro + " anos e seu sexo é: " + sexo);

            Console.ReadLine();
        }
    }
}
