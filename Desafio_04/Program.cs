// Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas,
//  o valor que recebe por hora e calcula o salário desse funcionário.
//   A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

// Entrada
// O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais,
//  representando o número, quantidade de horas trabalhadas e o valor que o funcionário 
//  recebe por hora trabalhada, respectivamente.

// Saída
// Imprima o número e o salário do funcionário, conforme exemplo fornecido,
//  com um espaço em branco antes e depois da igualdade. No caso do salário,
//   também deve haver um espaço em branco após o $.

// string nomeFuncionario = (Console.ReadLine());
// double salarioFuncionario = double.Parse(Console.ReadLine());
// double totalVendas = double.Parse(Console.ReadLine());

// double comissaoMes = totalVendas * 1.15;

// Console.WriteLine("TOTAL = R$ "+ comissaoMes.ToString("f2"));



int num1 = int.(ParseConsole.ReadLine());
int num2 = int.Parse(Console.ReadLine());



int somaNumeros(int num1, int num2)
{
    int soma = num1 + num2; 
    Console.WriteLine($"{num1} + {num2} = {soma}");
    return soma; 
}

int multiplicaNumeros(int num1, int num2)
{
    int multiplica = num1 * num2; 
    Console.WriteLine($"{num1} * {num2} = {multiplica}");
    return multiplica; 
}

int divideNumeros(int num1, int num2)
{
    int divide = num1 / num2; 
    Console.WriteLine($"{num1} / {num2} = {divide}");
    return divide; 
}