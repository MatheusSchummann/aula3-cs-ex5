using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_cs_ex5
{
    internal class Program
    {
        /*Escreva um programa em C# que lê 3 valores, lados de um triângulo, e calcule e 
        escreva a área do triângulo formado.*/
        
        static void Main(string[] args)
        {
            Program start = new Program();
        }
        public Program() 
        {
            Converter Conversor = new Converter();
            List<string> listaS = new List<string>();
            List<double> listaI = new List<double>();
            double resulfinal;

            for(int i = 0; i < 3; i++) 
            {
                Console.Write("Digite o valor 0{0} do triângulo: ", i+1);
                listaS.Add(Console.ReadLine());
            } 
            listaI = Conversor.convertor(listaS);
            resulfinal = Conversor.logica(listaI);

            Console.WriteLine("O resultado final foi: {0} ", resulfinal);
            Console.ReadKey();
        }
    }
}
