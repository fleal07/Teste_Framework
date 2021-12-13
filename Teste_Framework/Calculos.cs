using System;
using System.Collections;

public class Calculos
{
    public Calculos()
    {
        private const int mumeroMaximo = 1000000;
        private static BitArray numerosPrimosArmazenados = new BitArray(mumeroMaximo, true);

        public int[] numerosPrimos { get; set; }

        public int[] numerosCompostos { get; set; }


        public void DecomporNumero(int numeroADecompor)
        {
            
        }

        public static int ehNumeroPrimo(int index)
        {
            if ((numerosPrimosArmazenados(index) == true))
                return 1;
            else
                return 0;
        }

        public static Int32[] geraListaNumeroPrimos1(Int32 NumeroMaximo)
        {
            Int32[] primos = new Int32[NumeroMaximo + 1];
            int index = 1;
            int contador;
            int i = 0;
            while ((index <= (NumeroMaximo - 1)))
            {
                index += 1;
                // separa os números primos atribuindo false aos não primos
                if ((numerosPrimosArmazenados(index) == true))
                {
                    for (contador = index * 2; contador <= NumeroMaximo - 1; contador += index)
                        numerosPrimosArmazenados(contador) = false;
                }
            }
            for (contador = 2; contador <= NumeroMaximo; contador++)
            {
            if ((GetBit(contador) == 1))
                primos[contador] = contador;
            else
                numerosCompostos[contador] = contador;
            }

            numerosPrimosArmazenados = primos;  

            return primos;
        }


}
}
