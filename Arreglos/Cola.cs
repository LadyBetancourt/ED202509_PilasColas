namespace Arreglos
{
    internal class Cola
    {
        int _inicio;
        int _final;
        string[] _arreglo;

        public Cola(int elementos)
        {
            _inicio = 0;
            _final = 0;
            _arreglo = new string[elementos];
        }

        // Agrega un dato al final de la cola
        public void Agregar(string dato)
        {
            int max = _arreglo.Length - 1;
            if (_final > max)
            {
                throw new Exception("Cola llena");
            }
            _arreglo[_final] = dato;
            _final++;
        }

        // Elimina el primer dato en entrar
        public void Eliminar()
        {
            if (_final == 0 || _inicio == _final)
            {
                throw new Exception("Cola vacía");
            }

            _arreglo[_inicio] = string.Empty;
            _inicio++;
        }

        // Aqui muestra el contenido de la cola
        public string Imprimir()
        {
            string datos = string.Empty;
            for (int i = _inicio; i < _final; i++)
            {
                datos += _arreglo[i] + Environment.NewLine;
            }
            return datos;
        }
    }
}
