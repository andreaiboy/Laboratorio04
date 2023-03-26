using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio02
    {
        public double[] Calcular(int[] nums)
        {
            double suma = 0.0;

            for (int i = 0; i < nums.Length; i++)
            {
                suma = suma + nums[i];
            }
            return new double[] {suma, suma / nums.Length};
        }
    }
}
