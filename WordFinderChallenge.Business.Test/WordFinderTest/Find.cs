using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordFinderChallenge.Business.Test.Utils;
using Xunit;

namespace WordFinderChallenge.Business.Test.WordFinderTest
{
    public class Find:DefaultFactories
    {
        [Fact]
        public void Success5x5()
        {
            IEnumerable<string> matrix = GetMatrix5x5();
            IEnumerable<string> wordstream = GetWordStream();
            int expectedSize = 3;

            WordFinder finder = new WordFinder(matrix);

            var result = finder.Find(wordstream).ToList();

            Assert.NotNull(result);
            Assert.Equal(expectedSize,result.Count());
        }

        [Fact]
        public void Success14x14()
        {
            IEnumerable<string> matrix = GetMatrix14x14();
            IEnumerable<string> wordstream = GetWordStream();
            int expectedSize = 9;

            WordFinder finder = new WordFinder(matrix);

            var result = finder.Find(wordstream).ToList();

            Assert.NotNull(result);
            Assert.Equal(expectedSize, result.Count());
        }

        [Fact]
        public void EmptyResult()
        {
            IEnumerable<string> matrix = GetMatrix14x14();
            IEnumerable<string> wordstream = GetWordStreamLongWord();
            int expectedSize = 0;

            WordFinder finder = new WordFinder(matrix);

            var result = finder.Find(wordstream).ToList();

            Assert.NotNull(result);
            Assert.Equal(expectedSize, result.Count());
        }


        [Fact]
        public void SuccessMaxSize64x64()
        {
            IEnumerable<string> matrix = GetMatrix64x64();
            IEnumerable<string> wordstream = GetWordStream();
            int expectedSize = 10;

            WordFinder finder = new WordFinder(matrix);

            var result = finder.Find(wordstream).ToList();

            Assert.NotNull(result);
            Assert.Equal(expectedSize, result.Count());
        }
    }
}
