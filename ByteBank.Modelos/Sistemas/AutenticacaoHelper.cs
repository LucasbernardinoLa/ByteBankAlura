namespace ByteBank.Modelos.Sistemas
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenha(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
