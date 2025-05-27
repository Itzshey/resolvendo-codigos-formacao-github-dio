using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resolucoes_code
{
    public class ConcatenandoDados
    {
        public static void Main()
        {
            // Objetivo: Receber dois dados diferentes do usuário e concatena-los em uma única string
            string palavra1, palavra2;
            Console.WriteLine("Digite a primeira informação que deseja juntar");
            palavra1 = Console.ReadLine();
            Console.WriteLine("Digite a segunda informação que deseja juntar");
            palavra2 = Console.ReadLine();
            string juncao = $"A junção das duas informações fica {palavra1}{palavra2}";
            Console.WriteLine(juncao);

        }
               
    }
}