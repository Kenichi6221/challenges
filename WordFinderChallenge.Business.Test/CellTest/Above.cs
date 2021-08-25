using WordFinderChallenge.Business.Test.Utils;
using Xunit;

namespace WordFinderChallenge.Business.Test.CellTest
{
  public class Above: DefaultFactories
    {
        [Fact]
        public void ReturnNullIfAreadyIsInlastCellAbove()
        {   
            Cell currentCell = BuildCell(currentRow: 0);
            Cell nextCell = currentCell.Above();
            Assert.Null(nextCell);
        }

        [Fact]
        public void ReturnAboveRowSuccessfully()
        {
            int currentRow = 5;
            int expectedRow = 4;

            Cell currentCell = BuildCell(currentRow: currentRow, maxRow: currentRow);
            Cell nextCell = currentCell.Above();

            Assert.NotNull(nextCell);
            Assert.Equal(expectedRow,nextCell.Row);
        }              
    }
}
