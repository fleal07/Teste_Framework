using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrameworkBO
{
    public class CalculosMatematicos
    {
        private const int mumeroMaximo = 1000000;
        private static BitArray numerosPrimosArmazenados = new BitArray(mumeroMaximo, true);
        private static List<int> _numerosPrimos = new List<int>();
        private static List<int> _numerosDivisores = new List<int>();

        public CalculosMatematicos()
        {
            numerosPrimos.Clear();
            numerosDivisores.Clear();
        }


        #region Propriedades

        public List<int> numerosPrimos
        {
            get { return _numerosPrimos; }
            set { _numerosPrimos = value; }
        }

        public List<int> numerosDivisores
        {
            get { return _numerosDivisores; }
            set { _numerosDivisores = value; }
        }

        #endregion

        #region Metodos
        public void DecomporNumero(int numeroADecompor)
        {
            int index = 1;
            int contador;

            while ((index <= (numeroADecompor)))
            {
                index += 1;
                // separa os números primos atribuindo false aos não primos
                if ((numerosPrimosArmazenados[index] == true))
                {
                    for (contador = index * 2; contador <= numeroADecompor; contador += index)
                        numerosPrimosArmazenados[contador] = false;
                }
            }

            _numerosDivisores.Add(1);
            for (contador = 2; contador <= numeroADecompor; contador++)
            {
                if (numeroADecompor % contador == 0)
                {
                    _numerosDivisores.Add(contador);

                    if ((ehNumeroPrimo(contador) == 1))
                        _numerosPrimos.Add(contador);
                }
            }
        }

        private int ehNumeroPrimo(int index)
        {
            if (numerosPrimosArmazenados[index] == true)
                return 1;
            else
                return 0;
        }

        #endregion

    }
}