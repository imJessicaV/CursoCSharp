using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Models //Pode ser alterado o nome para organização do código
{
    public class Pessoa //Na classe sempre utiliza-se PascalCase
    {
        public string? Nome { get; set; } //get: pegar o valor | set:atribuir um valor
        public int Idade { get; set; } //proprieddae também em PascalCase

        
         public void Apresentar() //Metodo(ação/função) | Também em PascalCase
         {
            
            Console.WriteLine($"Olá, meu nome é {Nome}!!\nTenho {Idade} anos!");
            
         }
    }
}