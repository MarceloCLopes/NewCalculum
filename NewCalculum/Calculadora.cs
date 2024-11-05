namespace NewCalculum
{
    public class Calculadora
    {
        private readonly List<string> _historico;
        private readonly string _data;

        public Calculadora(string data)
        {
            _historico = [];
            _data = data;
        }

        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            _historico.Insert(0, $"Res: {resultado} - {_data}");
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            _historico.Insert(0, $"Res: {resultado} - {_data}");
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
            _historico.Insert(0, $"Res: {resultado} - {_data}");
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            var resultado = val1 / val2;
            _historico.Insert(0, $"Res: {resultado} - {_data}");
            return resultado;
        }

        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}
