using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Models //Pode ser alterado o nome para organização do código
{
    public class Pessoa
    {
        public string? Nome { get; set; } //get: pegar o valor | set:atribuir um valor
        public int Idade { get; set; }

        
         public void Apresentar() //Metodo(ação/função)
         {
            
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos!");
         }
    }
}