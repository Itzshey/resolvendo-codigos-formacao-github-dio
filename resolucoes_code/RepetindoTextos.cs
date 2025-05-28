using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resolucoes_code
{
    public class RepetindoTextos
    {
        public static void Main()
        {
            // Objetivo: Solicitar uma string e um número inteiro como entrada. 
            // Depois teremos que retornar a string repetida o número de vezes informado.

            string texto, num;
            Console.WriteLine("Digite o texto que deseja repetir");
            texto = Console.ReadLine();
            Console.WriteLine("Digite o texto que deseja repetir");
            num = Console.ReadLine();
            int numero = int.Parse(num);

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(texto);
            }
            

        }
    }
}