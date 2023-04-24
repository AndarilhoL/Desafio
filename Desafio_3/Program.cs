using System.Text.RegularExpressions;

Console.WriteLine("Digite uma expressão matematica simples (contendo adição, subtração, multiplicação e divisão)");
string expressao = Console.ReadLine();

var teste = decimal.TryParse("+", out var resultadoEmDecimal);

ResolverExpressaoMatematica(expressao);

string ResolverExpressaoMatematica(string expressao)
{
    var valoresSeparados = SepararValorEmCaracteres(expressao);

    var valorAtual = decimal.Parse(valoresSeparados.ElementAt(0));

    for (int i = 1; i < valoresSeparados.Count; i += 2)
    {
        string operador = "";
        var valorDecimalConvertido = decimal.TryParse(valoresSeparados[i], out var resultadoEmDecimal);

        if (valorDecimalConvertido == true && valoresSeparados[i].Contains('-'))
            operador = "-";

        if (valorDecimalConvertido == true && valoresSeparados[i].Contains('+'))
            operador = "+";


        if (operador == "+")
            valorAtual += resultadoEmDecimal;

        else if (operador == "-")
            valorAtual -= resultadoEmDecimal;

        else if (operador == "*")
            valorAtual *= resultadoEmDecimal;

        else if (operador == "/")
            valorAtual /= resultadoEmDecimal;
    }

    return $"O resultado da expressão é: {valorAtual}";
}

List<string> SepararValorEmCaracteres(string expressao)
{
    Regex regex = new Regex(@"([-+]?\d+(\.\d+)?([eE][-+]?\d+)?)|(\+|-|\*|/)");
    var resultado = new List<string>();

    foreach (var item in regex.Split(expressao))
    {
        if (item != "" && item != " ")
            resultado.Add(item.ToString());
    }

    return resultado;
}