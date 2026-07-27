using System.Reflection.Metadata;

Console.WriteLine("Bem vindo ao Credito Online!");

Console.WriteLine("Para iniciar, digite seu nome: ");
string nomeCliente = Console.ReadLine();

Console.WriteLine("Olá "+ nomeCliente +" Digite 1- Simulação ou 2- Encerrar");
string resposta = Console.ReadLine();

if (resposta == "1")
{
    Console.WriteLine("Digite sua renda: ");
    decimal rendaCliente = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Seu nome está negativado? digite: Sim ou Nao: ");
    string nomeNegativado = Console.ReadLine().ToLower();

    Console.WriteLine("Digite sua idade: ");
    int idadeCliente = int.Parse(Console.ReadLine());


    // Regra especial: Renda >= R$ 8.000 & Nome limpo = aprovação automatica
    if (rendaCliente >= 8000 & nomeNegativado == "nao")
    {
        Console.WriteLine("Aprovado! Entraremos em contato para prosseguir com a liberação do credito, obrigado!");
    }
    else
    {
        // Regras normais
        if (rendaCliente < 3000)
        {
            Console.WriteLine("Negado: Infelizmente não temos opções de credito disponivel para você no momento.");
        }
        else if (nomeNegativado == "sim")
        {
            Console.WriteLine("Negado: Infelizmente não temos opções de credito disponivel para você no momento.");
        }
        else if (idadeCliente <18 || idadeCliente > 65)
        {
            Console.WriteLine("Negado: Infelizmente não temos opções de credito disponivel para você no momento.");
        }
        else
        {
            Console.WriteLine("Aprovado! Entraremos em contato para prosseguir com a liberação do credito, obrigado! ");
        }
    }
}
else
{
    Console.WriteLine("Agradecemos seu contato, até logo!");
}