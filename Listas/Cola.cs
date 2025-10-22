namespace Listas
{
    internal class Cola
    {
        private List<string> _lista;

        public Cola()
        {
            _lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            _lista.Add(dato);
        }

        public void Eliminar()
        {
            if (_lista.Count == 0)
            {
                throw new Exception("Cola vacía");
            }

            _lista.RemoveAt(0);
        }

        public void Imprimir()
        {
            foreach (string dato in _lista)
            {
                Console.WriteLine(dato);
            }
        }
    }
}

