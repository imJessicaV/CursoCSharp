﻿// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Contracts;
using CursoCSharp.Models; //Aponta onde a classe está para poder usa-la
using System.Globalization;

//Throw
new ExemploExcecao().MetodoUm();


//Exceções | Lendo conteudo de um arquivo
// try{
// string[] Linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

// foreach(string linha in Linhas){
//     Console.WriteLine(linha);
// }
// } catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// finally{
//     Console.WriteLine("Chegou até aqui");
// }

// //Formatando o dateTime
// DateTime data = DateTime.Parse("12/06/2024 21:00");

// Console.WriteLine(data);


// //POrcentagem
// double Percent = .3456;

// Console.WriteLine(Percent.ToString("P"));

// int Numero = 323454;
// Console.WriteLine(Numero.ToString("##-##-##"));

//Manipulando valores
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal ValorMonetario = 3482.40M;
// //formata para uma outra cultura mesmo que tenha sido definida a cultura do sistema
// Console.WriteLine(ValorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));// C é de currency(valor monetário/moeda)
// //C pode ser complementado por numeros que significam as casas decimai. EX: C4


//Concatenação de valores
// string NumeroUm = "10";
// int NumeroDois = 20;
// string Resultado = NumeroUm + NumeroDois;

// Console.WriteLine(Resultado);


// Pessoa PessoaUm = new Pessoa(nome:"Jéssica", sobreNome:"Vitoriano");
// Pessoa PessoaDois = new Pessoa(nome:"Davidson", sobreNome:"Vitoriano");// o () é o construtor
// Pessoa PessoaTres = new Pessoa(nome:"Boomer", sobreNome:"Vitoriano");

// Curso CursoIngles = new Curso();
// CursoIngles.NomeCurso = "Ingles";
// CursoIngles.Alunos = new List<Pessoa>();

// CursoIngles.AdicionarAluno(PessoaUm);
// CursoIngles.AdicionarAluno(PessoaDois);
// CursoIngles.AdicionarAluno(PessoaTres);
// CursoIngles.ListarAlunos();


//Propriedades, metodos e construtores
// Pessoa Pessoa = new Pessoa();
// Pessoa.Nome = "Jéssica";
// Pessoa.SobreNome = "Vitoriano";
// Pessoa.Idade = 35;
// Pessoa.Apresentar();

//Listas(array melhorado)
// List<string> listaString = new List<string>();

// listaString.Add("Jessica");
// listaString.Add("Batista");
// listaString.Add("Genilda");
// listaString.Add("Davidson");

// for(int cont = 0; cont < listaString.Count; cont++){
//     Console.WriteLine($"{cont} - {listaString[cont]}");
// }

// Console.WriteLine("Com foreach");

// int contFor = 0;
// foreach(string item in listaString){
//     Console.WriteLine($"{contFor} - {item}");
//     contFor++;
// }

//Arrays
// int[] Inteiros = new int[3];

// Inteiros[0] = 99;
// Inteiros[1] = 67;
// Inteiros[2] = 100;

// int[] novoArray = new int[Inteiros.Length * 2];
// Array.Copy(Inteiros, novoArray, Inteiros.Length);//copias os valores de um array para outro


// //Array.Resize(ref Inteiros, Inteiros.Length * 2);

// //Array e listas usando FOR | quando precisa de um contador
// for (int contador = 0; contador < Inteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição n° {contador} - Array: {Inteiros[contador]}");
// }
// //Array e listas usando foreach
// int contadorForeach = 0;
// foreach (int Valor in Inteiros)
// {
//     Console.WriteLine($"Posição n° {contadorForeach} - Array: {Valor}");
//     contadorForeach++;
// }


//Menu Interativo usando Do While
// string? Opcao = "";
// bool exibirMenu = true;

// while(exibirMenu){
//     Console.Clear();//limpa o menu
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     Opcao = Console.ReadLine();

//     switch(Opcao){
//         case "1":
//         Console.WriteLine("Cadastro de Cliente");
//         break;

//         case "2":
//         Console.WriteLine("Buscar Cliente");
//         break;

//         case "3":
//         Console.WriteLine("Apagar Cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         exibirMenu = false;
//        // Environment.Exit(0);//sai e não executa mais nada mesmo que tenha codigo abaixo do laço de repetição.
//         break;

//         default:
//         Console.WriteLine("Opção Inválida!");
//         break;
//     }
// }
// Console.WriteLine("O programa encerrou =(");

//DO WHILE
// int Soma = 0, Numero = 0; //pode declarar varias variaveis do mesmo tipo em uma unica linha, de uma vez só

// do{
//     Console.WriteLine("Digite um numero, meu jovem!(0 para parar)");
//     Numero = Convert.ToInt32(Console.ReadLine());

//     Soma += Numero;//é igual à soma = soma + numero


// }while(Numero != 0);

// Console.WriteLine($"Total dos numeros digitados é {Soma}");

//WHILE
//  int Numero = 7;
//  int cont = 0;

//  while(cont <= 10){
//      Console.WriteLine($" {Numero} x {cont} = {Numero * cont}");
//     cont++;

//     if(cont == 7){
//         break; // serve para quebrar uma condição
//     }
//  }

//Tabuada | laços de repetição e incremento
// int Numero = 7;
// for(int cont = 0; cont <= 10; cont++){
//     Console.WriteLine($"{Numero} x {cont} = {Numero * cont}"); //laço de repetição FOR
// }

//Calculo de raiz quadrada
// Calculadora calc = new Calculadora();
// calc.RaizQuadrada(121);

//Incremento e decremento
// int Teste = 10;
// int Teste2 = 20;
// Console.WriteLine(Teste);
// Console.WriteLine($"Incremento de {Teste}");
// Teste++;
// Console.WriteLine(Teste);
// Console.WriteLine(Teste2);
// Console.WriteLine($"Decremento de {Teste2}");
// Teste2--;
// Console.WriteLine(Teste2);

//CALCULADORA
// Calculadora calc = new Calculadora();
// calc.Somar(10, 5);
// calc.Multiplicar(20, 9);
// calc.Dividir(100, 2);
// calc.Subtrair(490, 210);
// calc.Potencia(3, 3);
// calc.Seno(10);
// calc.Coseno(30);
// calc.Tangente(25);

//ATIVIDADE
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }


//IF ELSE aninhado
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }


//IF ELSE
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if ((roll1 == roll2) && (roll2 == roll3)) 
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// }

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }



//IF ELSE
// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

//IF ELSE
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if(total > 14){
//     Console.WriteLine("Você ganhou!!");
// }else{
//     Console.WriteLine("Você perdeu");
// }

//Usando Math
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

//Operadores logicos NOT
// bool Choveu = false;
// bool EstaTarde = true;

// if(!Choveu && !EstaTarde){
//     Console.WriteLine("Vamos pedalar");
// }else{
//     Console.WriteLine("Não vamos pedalar");
// }


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

