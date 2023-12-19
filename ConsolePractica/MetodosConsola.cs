using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePraactica
{
    public class MetodosConsola
    {
        public MetodosConsola()
        {
            
        }


        public int Fobonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fobonacci(n - 1) + Fobonacci(n - 2);
        }

        public bool EsAnagrama(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] contador = new int[26]; // Contador de las letras del alfabeto inglés (puedes ajustarlo según tus necesidades)

            for (int i = 0; i < s.Length; i++)
            {
                contador[s[i] - 'a']++; // Aumentar el contador para la letra de s
                contador[t[i] - 'a']--; // Disminuir el contador para la letra de t
            }

            for (int i = 0; i < contador.Length; i++)
            {
                if (contador[i] != 0)
                    return false; // Hay una diferencia en la frecuencia de las letras, por lo que no son anagramas
            }

            return true;
        }

        public int diagonalResta(List<List<int>> arr)
        {
            int i = 0;
            int j = arr.Count-1;
            decimal sumI = 0;
            decimal sumJ = 0;

            foreach (var colum in arr)
            {
                sumI += colum[i];
                sumJ += colum[j];
                i++;
                j--;
            }

            var resul = Math.Abs(sumI - sumJ);
            return (int)resul;
        }

    }
}
