// See https://aka.ms/new-console-template for more information

using CursoCSharp.Models; //Aponta onde a classe está para poder usa-la

Pessoa p = new Pessoa(); //p é uma variavel, que receberá os dados a serem vinculados a classe pessoa | New Pessoa() serve para "construir" de fato a classe para poder ser manipulada

//passar os dados para a Pessoa após ter instanciado a classe Pesssoa
p.Nome = "Jéssica";
p.Idade = 35;
p.Apresentar();

