using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio03
    {
        public string Sumar(string num1, string num2)
        {
            if ("0".Equals(num1))
                return num2;

            if ("0".Equals(num2))
                return num1;

            string result = "";

            int i = num1.Length - 1, j = num2.Length - 1;
            int acarreo = 0;

            while (i >= 0 && j >= 0)
            {
                int r = acarreo + (num1[i] - '0') + (num2[j] - '0');
                acarreo = r / 10;

                result = (r % 10) + result;

                i--;
                j--;
            }
            while (i >= 0)
            {
                int r = acarreo + (num1[i] - '0');
                acarreo = r / 10;
                result = (r % 10) + result;

                i--;
            }

            while (j >= 0)
            {
                int r = acarreo + (num2[j] - '0');
                acarreo = r / 10;
                result = (r % 10) + result;

                j--;
            }

            if (acarreo > 0)
                result = acarreo + result;

            return result;
        }
    }
}