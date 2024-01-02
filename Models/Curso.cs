using System.Collections.ObjectModel;

namespace CursoCSharp.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) //assinatura do metodo | void:quando não precisa retornar um valor
        {
            Alunos.Add(aluno); //add é um metodo
        }

        public int ObterQtdAlunosMatriculados() //int: retorna um valor inteiro | sem argumento
        {
            int Quantidade= Alunos.Count;
            return Quantidade; //retorna o valor
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno); //remove também é um metodo | retorno o resultado do metodo remove
            //return true;
        }

        //refatoração
        public void ListarAlunos()
        {
            Console.WriteLine($"Lista de alunos do curso de {NomeCurso}");//interpolação de string
            Console.WriteLine("------------------------------------------");

            for(int cont = 0; cont < Alunos.Count; cont++){

                //string Texto = "Aluno n°: " + cont + " " + Alunos[cont].NomeCompleto;
                string Texto = $"Aluno n°{cont}: {Alunos[cont].NomeCompleto}";
                Console.WriteLine(Texto);
                Console.WriteLine("------------------------------------------");
            }
                
        }
    }
}