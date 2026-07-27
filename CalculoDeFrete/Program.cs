Console.WriteLine("Bem vindo ao Calculo de frete virtual! \n\n Digite PREMIUM para cliente Premium ou COMUM para cliente Comum: ");
string tipoCliente = Console.ReadLine();

Console.WriteLine("Digite a disntacia do local da entrega: ");
double distEntrega = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o peso total da carga a ser transportada: ");
double pesoTotal = double.Parse(Console.ReadLine());

if (distEntrega > 0 && 
pesoTotal > 0 &&
(tipoCliente.ToUpper() == "PREMIUM" || tipoCliente.ToUpper() == "COMUM"))
{
    double freteBase = distEntrega * 1.5;
    double taxa = 0;

    if (tipoCliente.ToUpper() == "PREMIUM" && pesoTotal < 200)
    {
        taxa += -0.15;
    }

    if (pesoTotal > 100)
    {
        taxa += 0.12; //taxa = taxa + 0.12
    }

    if (pesoTotal > 150 && distEntrega > 1000)
    {
        taxa += 0.08;
    }

    double freteFinal = freteBase * (1 + taxa); //freteBase + (freteBase * taxa);

    Console.WriteLine($"O valor do frete é: {freteFinal:C2}");
}
else
{
    Console.WriteLine("Dados Invalidos");
}