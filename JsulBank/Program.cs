// Projeto Jsul Bank é um projeto de sistema bancário simples, 
// desenvolvido em C# para fins educacionais. 
// O sistema permite que os usuários realizem operações básicas de depósito,
// saque e verificação de extrato, garantindo que o saldo da conta não fique negativo. 
// O menu é exibido repetidamente até que o usuário escolha sair, proporcionando uma experiência interativa e contínua.

using System.Collections;

void ExibirMenu()
{
    Console.WriteLine("Bem vindos ao SC-Bank, aqui o cliente é sempre nossa prioridade! \n\n");
    Console.WriteLine("Escolha uma opção para continuar: \n");

    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 = Sacar");
    Console.WriteLine("3 - Verificar Extrato");
    Console.WriteLine("4 - Sair");
}

decimal PedirDecimal()
{
    bool ehNumero = decimal.TryParse(Console.ReadLine(), out decimal valor);
    while ( !ehNumero )
    {
        Console.WriteLine("Valor invalido, tente novamente. \n\n\n");
        ehNumero = decimal.TryParse(Console.ReadLine(), out valor);
    }
    return valor;
}


List<decimal> extrato = new List<decimal>();

decimal ObterSaldo()
{
    decimal saldo = 0;
    foreach (var transacao in extrato)
    {
        saldo += transacao;
    }
    return saldo;
}


void Depositar()
{
    Console.WriteLine("\nDigite o valor que deseja depositar: \n\n");
    decimal valor = PedirDecimal();
    extrato.Add(valor);
}

void Sacar()
{
    Console.WriteLine("Digite o valor que deseja sacar: \n");
    decimal valor = PedirDecimal();
    if (valor > 0)
        valor = valor *-1;

    if(ObterSaldo() < valor*-1)
    {
        Console.WriteLine("Saldo insuficiente, tente novamente. \n\n");
        return;
    }
    else
    {
    extrato.Add(valor);
    }
}

void VerExtrato()
{
    Console.WriteLine("Seu saldo é: \n\n");

    foreach( var transacao in extrato)
        {
            Console.WriteLine(transacao);
        }
    Console.WriteLine("Seu saldo é de: " + ObterSaldo());
}

string opcao;
do
{
    ExibirMenu();
    opcao = Console.ReadLine();
    if (opcao == "1")
    {
        Depositar();
    }
    else if (opcao == "2")
    {
        Sacar();
    }
    else if (opcao == "3")
    {
        VerExtrato();
    }
    else if (opcao == "4")
    {
    }
    else
    {
        Console.WriteLine("Opcao invalida, tente novamente. \n\n");
    }
}while( opcao != "4");

