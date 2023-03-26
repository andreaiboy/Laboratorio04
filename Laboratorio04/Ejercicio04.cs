using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio04
    {
        public int[] CalcularBilletes(int cantidad, int[] billetes)
        {
            int[] result = new int[billetes.Length];
            for (int i = 0; i < billetes.Length; i++)
            {
                result[i] = cantidad / billetes[i];
                cantidad = cantidad % billetes[i];
            }
            return result;
        }
    }
}
