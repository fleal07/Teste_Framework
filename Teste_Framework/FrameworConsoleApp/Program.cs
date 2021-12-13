using System;
using FrameworkBO;

namespace FrameworConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Decomposição de números naturais");
                Console.WriteLine(new string('-', 50));

                Console.WriteLine("");
                Console.WriteLine("Informe um número para listar os seus divisores:");


                string strRetorno = Console.ReadLine();
                if (!int.TryParse(strRetorno, out int numeroEntrada))
                {
                    throw new ApplicationException("Valor incorreto! Por favor informe um número natural (inteiro, não negativo).");
                }

                CalculosMatematicos objCalculos = new CalculosMatematicos();
                objCalculos.DecomporNumero(numeroEntrada);

                Console.WriteLine("");
                Console.WriteLine($"O divisores primos do número {numeroEntrada} são: {string.Join(",", objCalculos.numerosPrimos)}");

                Console.WriteLine("");
                Console.WriteLine($"O divisores do número {numeroEntrada} são: {string.Join(",", objCalculos.numerosDivisores)}");

                Console.WriteLine("");
                Console.WriteLine("Pressione uma tecla para encerrar.");

                Console.ReadKey();
                Environment.Exit(0);

            }
            catch (FormatException ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }
    }
}
