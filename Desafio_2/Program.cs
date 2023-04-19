Console.WriteLine("Insira a quantidade de números inteiros que deseja somar (lembrando que essa quantidade pode ter até 1 milhão de números):");
var valorInseridoValido = int.TryParse(Console.ReadLine(), out var valor);

while (valorInseridoValido == false)
{
    Console.WriteLine("");
    Console.WriteLine("Valor inserido é inválido, lembrando que ele deve ser um INTEIRO");
    Console.WriteLine("Digite outro valor:");
    valorInseridoValido = int.TryParse(Console.ReadLine(), out valor);
}




