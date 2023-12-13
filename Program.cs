// See https://aka.ms/new-console-template for more information

using CursoCSharp.Models; //Aponta onde a classe está para poder usa-la

DateTime dataAtual = DateTime.Now.AddHours(-3).AddDays(2);//pega a data da maquina onde o codigo está sendo executado

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// string Moeda = "Real";

// int Quantidade = 1;
// Quantidade = 10;

// double Variacao = 1.90; //double ignora o zero no final do valor

// decimal Cotacao = 4.99M; //para decimal precisa colocar M no final do valor

// bool Condicao = true;


// Console.WriteLine("Moeda: " + Moeda);
// Console.WriteLine("Quantidade: " + Quantidade);
// Console.WriteLine("Variação: " + Variacao.ToString("0.00")); //toString: tratamento para trazer todas as casas decimais da variavel
// Console.WriteLine("Cotação: R$" + Cotacao);
// Console.WriteLine("Condição: " + Condicao);


//Pessoa p = new Pessoa(); //p é uma variavel, que receberá os dados a serem vinculados a classe pessoa | New Pessoa() serve para "construir" de fato a classe para poder ser manipulada
//para variaveis é utilizado o camelCase

//passar os dados para a Pessoa após ter instanciado a classe Pesssoa
//p.Nome = "Jéssica";
//p.Idade = 35;
//p.Apresentar();

