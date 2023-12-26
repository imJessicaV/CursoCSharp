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

        public void ListarAlunos()
        {
            Console.WriteLine($"Lista de alunos do curso de {NomeCurso}");
            Console.WriteLine("------------------------------------------");
                    
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine($"Aluno(a): {aluno.NomeCompleto}");
                Console.WriteLine("------------------------------------------");
                
            }
        }
    }
}