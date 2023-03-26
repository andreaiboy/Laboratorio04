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
            int acSuma = 0;
            int maxLength = Math.Max(num1.Length, num2.Length);
            StringBuilder result = new StringBuilder(maxLength + 1);

            for (int i = 0; i < maxLength; i++)
            {
                int digit1 = i < num1.Length ? num1[num1.Length - 1 - i] - '0' : 0;
                int digit2 = i < num2.Length ? num2[num2.Length - 1 - i] - '0' : 0;
                int sum = digit1 + digit2 + acSuma;
                acSuma = sum / 10;
                result.Append(sum % 10);
            }

            if (acSuma > 0)
            {
                result.Append(acSuma);
            }

            char[] charArray = result.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
