//Mensagem de apresentação
Console.WriteLine("Bem vindo ao programa de calculo de media: ");

//Nas proximas linhas estamos capturando do usuario o valor das notas
//Estamos utilizando 2 formas diferentes de converter a informação inserida do usuario para a variavel "double"
//Utilizamos o double.Parse e tambem o Convert.ToDouble
//Como boa pratica estamos utilizando a variavel "double" mas tambem poderiamos utilizar a variavel "Float"

Console.WriteLine("Digite uma media para começar: ");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite uma segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a ultima nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());


//variavel para calcular a media
double media = (nota1 + nota2 + nota3) / 3;

//Vamos implementar a logica de aprovação
//Se media >= 7 = Aluno Aprovado
//Se media >= 5 = Aluno em Recuperação
//Se media <5 Reprovado

if (media >= 7)
{
    Console.WriteLine("Aluno Aprova, media: "+ media);
}

else
{
    Console.WriteLine("Aluno Reprovado! media: "+ media);
}


