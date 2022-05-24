namespace ByteBank.SitemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> listaDeInteiros, params T[] itens)
        {
            foreach (T item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}
