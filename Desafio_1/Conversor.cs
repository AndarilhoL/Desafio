namespace Desafio_1
{
    public static class Conversor
    {
        public static string ValidarNumero(string numero)
        {
            bool numeroValido = int.TryParse(numero, out int valorNumericoInteiro);

            if (numeroValido && valorNumericoInteiro == 0)
                return "O número digitado por extenso é Zero";

            if (numeroValido && valorNumericoInteiro != 0)
                return SepararNumeroParaValidar(numero).ToString();

            return "O valor informado não é um inteiro ou não representa um valor aceitável";
        }

        private static char[] ConverterInteiroParaExtenso(string numeroAjustado)
        {
            var numeroSeparado = numeroAjustado.ToCharArray();
        
        
        
            return numeroSeparado;
        }

        private static char[] SepararNumeroParaValidar(string numeroAjustado)
        {
            var numeroSeparado = numeroAjustado.ToCharArray();



            return numeroSeparado;
        }

        
    }
}
