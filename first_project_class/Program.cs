using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowMessage();
            //GenerateValue(10.5f);
            //int result = SumValues(20, 30, 31);
            //Console.WriteLine("O resultado é: " + result);
            string[] produtos = new String[3] { "Produto 1", "Produto 2", "Produto 3" };
            for (int i = 0; i < produtos.Length; i++) {
                Console.WriteLine(produtos[i]);
            }
            Console.ReadLine();
        }

        static void ShowMessage() {
            Console.WriteLine("Usando funções tops");
        }
        static void GenerateValue(float value) {
            Console.WriteLine("O valor é: " + value);
        }

        static int SumValues(int a, int b, int c) {
            int result = a + b + c;
            return result;
        }
    }
}
