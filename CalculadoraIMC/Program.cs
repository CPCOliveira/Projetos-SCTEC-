//Programa desenvolvido para calculo de IMC


//Linhas 5 e 7 Captura informação "altura" do usuario e armazena em variavel
Console.Write("Digite sua altura em centimetros: ");

float altura = float.Parse(Console.ReadLine());

//Linhas 10 e 12 Captura informação "peso" do usuario e armazena em variavel
Console.Write("Digite seu peso: ");

float peso = float.Parse(Console.ReadLine());


//Transformamos as informações em uma nova variavel calculando IMC
float imc = peso / (altura * altura);

Console.Write("Seu IMC é: "+ imc);
