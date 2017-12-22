using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MergeSort.Tests
{
    public class BasicTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[]{ 2, 4, 3, 1 }, new int[]{1, 2, 3, 4})]
        public void FirstTest(int[] input, int[] expectedOutput)
        {
            var output = MergeSort.SortItSucka(input);
            
            Assert.True(output.SequenceEqual(expectedOutput));
        }
    }
}
