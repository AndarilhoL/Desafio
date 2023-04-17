using Desafio_1;

Console.WriteLine("Digite um número:");
var numero = Console.ReadLine();

var resultado = ValidarNumero(numero);
Console.WriteLine(resultado);

string ValidarNumero(string numero)
{
    bool numeroValido = int.TryParse(numero, out int valorNumericoInteiro);

    if (numeroValido && valorNumericoInteiro == 0 || valorNumericoInteiro != 0)
        return Conversor.ConverterInteiroParaExtenso(valorNumericoInteiro.ToString());

    return "O valor informado não é um inteiro ou não representa um valor aceitável";
}