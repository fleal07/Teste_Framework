using FrameworkBO;
using System.Text;

namespace FrameworkReactApp.Services.Implementation
{
    public class ServiceCalculos : IServiceCalculos
    {
        public string RetornarDivisores(int numeroDecompor)
        {
            CalculosMatematicos objCalculos = new CalculosMatematicos();
            objCalculos.DecomporNumero(numeroDecompor);

            StringBuilder strRetorno = new StringBuilder();

            strRetorno.AppendLine($"O divisores primos do número {numeroDecompor} são: {string.Join(",", objCalculos.numerosPrimos)}");
            strRetorno.AppendLine($"O divisores do número {numeroDecompor} são: {string.Join(",", objCalculos.numerosDivisores)}");

            return strRetorno.ToString();
        }
    }
}
