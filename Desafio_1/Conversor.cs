namespace Desafio_1
{
    public static class Conversor
    {
        private static string extenso = "";
        private static string[] unidade = { "zero", "um", "dois", "três", "quarto", "cinco", "seis", "sete", "oito", "nove" };
        private static string[] dezenas = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        private static string[] dezenasAcimaDe19 = { "vinte,", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        private static string[] centenas = { "cem", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        public static string ConverterInteiroParaExtenso(string numeroParaConverter) 
        {
            var valor = SepararNumeros(numeroParaConverter);
          
            return "";
        }

        private static Dictionary<int,string> SepararNumeros(string valor)
        {
            Dictionary<int,string> valoresNumericosSeparados = new Dictionary<int,string>();

            int totalDeCasas = valor.Length-1;
            string numeroSeparado = "";

            if(valor.Length > 1)
            {
                string unidadeSeparada = valor.Substring(totalDeCasas, 1) ;
            }         

            return valoresNumericosSeparados;
        }
    }
}
