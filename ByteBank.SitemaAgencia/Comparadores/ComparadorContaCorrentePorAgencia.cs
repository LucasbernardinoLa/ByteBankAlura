using ByteBank.Modelos;

namespace ByteBank.SitemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }
            return x.Agencia.CompareTo(y.Agencia);
        }
    }
}
