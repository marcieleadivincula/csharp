using System;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine($"idade: {idade}");

            int copiaIdade = idade;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 23;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            int? idade2 = null; // Mesmo que System.Nullable<int> idade3 = null;
            System.Nullable<int> idade3 = null;
        }
    }
}
