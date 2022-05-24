namespace ByteBank.SitemaAgencia
{
    internal class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get;}
        public ExtratorValorDeArgumentosURL(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("o argumento url não poder nulo ou vazio", nameof(url));
            }
            
            URL = url;
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoEmCaixaAlta = _argumentos.ToUpper();

            string termo = nomeParametro + "=";
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }
    }
}
