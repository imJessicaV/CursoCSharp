using System.Collections.ObjectModel;

namespace CursoCSharp.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) //assinatura do metodo | void:quando não precisa retornar um valor
        {
            Alunos.Add(aluno);
        }

        public int ObterQtdAlunosMatriculados() //int: retorna um valor inteiro | sem argumento
        {
            int Quantidade= Alunos.Count;
            return Quantidade; //retorna o valor
        }
    }
}