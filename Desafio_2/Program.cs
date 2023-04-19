Console.WriteLine("Insira a quantidade de números inteiros que deseja somar (lembrando que essa quantidade pode ter até 1 milhão de números):");
string valorInserido = Console.ReadLine();
ValidarValor(valorInserido);

int[] valoresParaSomar = new int[int.Parse(valorInserido)];
for (int i = 0; i < int.Parse(valorInserido); i++)
{
    Console.WriteLine("");
    Console.WriteLine("Digite um valor para ser somado: ");
    string valorParaAdicionarArray = Console.ReadLine();
    if (ValidarValor(valorParaAdicionarArray))
        valoresParaSomar[i] = int.Parse(valorParaAdicionarArray); 
}

string valorTotalDoArray = SomarValoresDoArray(valoresParaSomar);
Console.WriteLine("================================================");
Console.WriteLine($"O valor total do array é de {valorTotalDoArray}");

string SomarValoresDoArray(int[] arrayParaSomar)
{
    var total = arrayParaSomar.Sum();
    return total.ToString();
}

bool ValidarValor(string valorInformado)
{
    var valorInseridoValido = int.TryParse(valorInformado, out var valor);

    while (valorInseridoValido == false)
    {
        Console.WriteLine("");
        Console.WriteLine("Valor inserido é inválido, lembrando que ele deve ser um INTEIRO");
        Console.WriteLine("Digite outro valor:");
        valorInseridoValido = int.TryParse(Console.ReadLine(), out valor);
    }

    return true;
}