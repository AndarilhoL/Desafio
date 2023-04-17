namespace Desafio_1
{
    public static class Conversor
    {
        static string extenso = "";
        static string[] unidade = { "zero", "um", "dois", "três", "quarto", "cinco", "seis", "sete", "oito", "nove" };
        static string[] dezenas = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        static string[] dezenasAcimaDe19 = { "vinte,", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        static string[] centenas = { "cem", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        public static string ConverterInteiroParaExtenso(string numeroParaConverter)
        
        {
            var valor = SepararNumeroParaValidar(numeroParaConverter);

            if(valor.Length == 1 && valor[0] == '0')
                return $"O valor por extenso informado é: {unidade[0]}";

            return "";
        }

        private static char[] SepararNumeroParaValidar(string numeroAjustado)
        {
            var numeroSeparado = numeroAjustado.ToCharArray();

            return numeroSeparado;
        }
    }
}
