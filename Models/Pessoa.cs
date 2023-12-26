using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//get: pegar o valor | set:atribuir um valor - quando tem get; set; é uma propriedade

namespace CursoCSharp.Models //Pode ser alterado o nome para organização do código
{
    public class Pessoa //Na classe sempre utiliza-se PascalCase
    {

        //O construtor sempro fica abaixo da classe

        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobreNome)
        {
            Nome = nome;
            SobreNome = sobreNome;
        }

        private string _nome;
        public string Nome
        {
             get => _nome.ToUpper(); //forma simplificada de retornar um valor | bodry expressions
        
             
             set{
                if(value ==""){
                    throw new ArgumentException("O nome não pode ser vazio");//tratamento de erro
                }
                _nome = value;
             } 
        } 


        public string SobreNome 
        { 
            get; 
            set;
            
        }

        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpperInvariant();

        private int _idade;
        public int Idade
        { 
            get => _idade;

            set{
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }


        

        
         public void Apresentar() //Metodo(ação/função) | Também em PascalCase
         {
            
            Console.WriteLine($"Olá, meu nome é {NomeCompleto}!!\nTenho {Idade} anos!");
            
         }
    }
}