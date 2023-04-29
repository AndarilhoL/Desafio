using System.Text.RegularExpressions;

Console.WriteLine("Digite uma expressão matematica simples (contendo adição, subtração, multiplicação e divisão)");
string expressao = Console.ReadLine();

var resultadoExpressao = ResolverExpressaoMatematica(expressao);

Console.WriteLine("");
Console.WriteLine($"O resultado da expressão é: {resultadoExpressao}");

decimal ResolverExpressaoMatematica(string expressao)
{
    var valoresSeparados = SepararValorEmCaracteres(expressao);
    decimal valorAtual = 0;

    for (int i = 0; i < valoresSeparados.Count; i++)
    {
        if (valoresSeparados[i] == "*")
        {
            valorAtual = decimal.Parse(valoresSeparados[i - 1]) * decimal.Parse(valoresSeparados[i + 1]);
            valoresSeparados.RemoveAt(i);
            valoresSeparados.Insert(i, valorAtual.ToString());
            valoresSeparados.RemoveAt(i + 1);
            valoresSeparados.RemoveAt(i - 1);
        }

        if (!valoresSeparados.Contains("*") && !valoresSeparados.Contains("/"))
        {
            for (i=0; i < valoresSeparados.Count; i++)
            {
                if (valoresSeparados[i] == "+")
                {
                    valorAtual = decimal.Parse(valoresSeparados[i - 1]) + decimal.Parse(valoresSeparados[i + 1]);
                    valoresSeparados.RemoveAt(i);
                    valoresSeparados.Insert(i, valorAtual.ToString());
                    valoresSeparados.RemoveAt(i + 1);
                    valoresSeparados.RemoveAt(i - 1);
                }

                if (valoresSeparados[i] == "-")
                {
                    valorAtual = decimal.Parse(valoresSeparados[i - 1]) - decimal.Parse(valoresSeparados[i + 1]);
                    valoresSeparados.RemoveAt(i);
                    valoresSeparados.Insert(i, valorAtual.ToString());
                    valoresSeparados.RemoveAt(i + 1);
                    valoresSeparados.RemoveAt(i - 1);
                }
            }
        }
    }

    return valorAtual;
}

List<string> SepararValorEmCaracteres(string expressao)
{
    Regex regex = new Regex(@"([-]?\d+(\.\d+)?([eE][-+]?\d+)?)|(\+|-|\*|/)");
    var resultado = new List<string>();

    foreach (var item in regex.Split(expressao))
    {
        if (item != "" && item != " ")
            resultado.Add(item.ToString());
    }

    return resultado;
}