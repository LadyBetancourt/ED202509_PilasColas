namespace Listas
{
    internal class Pila
    {
        private List<string> _lista;

        public Pila()
        {
            _lista = new List<string>();
        }

        // Agrega el elemento al tope de la pila
        public void Agregar(string dato)
        {
            _lista.Add(dato);
        }

        // Elimina el último elemento 
        public void Eliminar()
        {
            if (_lista.Count == 0)
            {
                throw new Exception("Pila vacía");
            }

            _lista.RemoveAt(_lista.Count - 1);
        }

        // Mustra los elementos de la pila
        public string Imprimir()
        {
            string datos = string.Empty;
            for (int i = _lista.Count - 1; i >= 0; i--)
            {
                datos += _lista[i] + Environment.NewLine;
            }
            return datos;
        }
    }
}
