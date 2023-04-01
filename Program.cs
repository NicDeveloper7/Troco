//Made by Nicholasdev

//Declaração das variáveis
double valor1, valorpago, troco;

//Pede o valor da compra para o usuário
Console.WriteLine("Digite o valor da compra");
valor1 = double.Parse(Console.ReadLine()!);

//Pede o valor pago para o usuário
Console.WriteLine("Digite o valor pago");
valorpago = double.Parse(Console.ReadLine()!);

//Subtrai o valor da compra pelo valor pago
troco = valorpago - valor1;

//Exibe o troco do usuário
Console.WriteLine($"O seu troco é de: {troco}");