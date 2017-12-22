using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSort
    {
        public static int[] SortItSucka(int[] input)
        {
            if (input.Length == 1)
            {
                return input;
            }

            //split it
            var side1 = SortItSucka(input.Take(input.Length / 2).ToArray());
            var side2 = SortItSucka(input.Skip(side1.Count()).ToArray());

            // merge
            int i = 0, j = 0;
            var result = new int[input.Length];
            while (i < side1.Length || j < side2.Length)
            {
                if (i >= side1.Length)
                {
                    result[i + j] = side2[j++];
                }
                else if (j >= side2.Length)
                {
                    result[i + j] = side1[i++];
                }
                else if (side1[i] < side2[j])
                {
                    result[i + j] = side1[i++];
                }
                else
                {
                    result[i + j] = side2[j++];
                }
            }

            return result;
        }

    }
}
