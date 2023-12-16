// See https://aka.ms/new-console-template for more information

using CursoCSharp.Models; //Aponta onde a classe está para poder usa-la

//Operadores logicos NOT
bool Choveu = false;
bool EstaTarde = true;

if(!Choveu && !EstaTarde){
    Console.WriteLine("Vamos pedalar");
}else{
    Console.WriteLine("Não vamos pedalar");
}


//Operadores logicos AND/E
// bool PresencaMinima = true;
// double MediaSete = 6.9;

// if(PresencaMinima && MediaSete >= 7){
//     Console.WriteLine("Aprovado");
// }else{
//     Console.WriteLine("Reprovado");
// }


//Operadores logicos OR/OU
// bool MaiorDeIdade = false;
// bool TemAutorizacao = true;

// if(MaiorDeIdade || TemAutorizacao){
//     Console.WriteLine("Entrada Autorizada");
// }else{
//     Console.WriteLine("Entrada não autorizada!");
// }




//Switch case
// Console.WriteLine("Digite uam letra");
// string? Letra = Console.ReadLine();

// switch(Letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("É uma vogaaaaal!");
//     break;

//     default: //mesma função do else
//     Console.WriteLine("Não é uma vogal");
//     break;
// }

// if(Letra == "a" || Letra == "e" || Letra == "i" || Letra == "o" || Letra == "u"){
//     Console.WriteLine("É uma vogal!!");
// }else{
//     Console.WriteLine("É uma consoante!!");
// }



// //Operadores de condição / IF / ELSE / ELSE IF
// int QuantidadeEstoque = 100;
// int QuantidadeCompra = 0;
// bool PossivelVenda = QuantidadeCompra > 0 && QuantidadeEstoque >= QuantidadeCompra;

// Console.WriteLine($"Estoque: {QuantidadeEstoque}");
// Console.WriteLine($"Venda: {QuantidadeCompra}");
// Console.WriteLine($"É possivel fazer a venda? {PossivelVenda}");

// if(QuantidadeCompra == 0){
//     Console.WriteLine("Venda inválilda");
// }else if(PossivelVenda)
// {
//     Console.WriteLine("Compra realizada com sucesso =)");
// }
// else
// {
//     Console.WriteLine("Quantidade não disponível em estoque =(");
// }


// double a = 4 / (2 + 2);
// Console.WriteLine(a);

// long b = long.MinValue;
// Console.WriteLine(b);

// //Cast implicito
// int a = 5;
// double b = a;

//converter para string
// int inteiro = 10;
// string A  = inteiro.ToString();
// Console.WriteLine(A);

//Cast / Casting == converter valores inteiros
//int A = Convert.ToInt32("5");
//int A = int.Parse("9A");

// int A = 19;
// int B = 8;
// int C = A + B;

// C = C + 6; //C é uma variavel já existente pois já foi declarada
// //pode ser utilizado também C += 6
// Console.WriteLine(C);

//DateTime dataAtual = DateTime.Now.AddHours(-3).AddDays(2);//pega a data da maquina onde o codigo está sendo executado

//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
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

