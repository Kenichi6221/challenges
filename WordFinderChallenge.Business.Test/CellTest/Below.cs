using WordFinderChallenge.Business.Test.Utils;
using Xunit;

namespace WordFinderChallenge.Business.Test.CellTest
{
  public class Below: DefaultFactories
    {
        [Fact]
        public void ReturnNullIfAreadyIsInFirstCell()
        {
            int currentRow = 5;
            int maxRows = currentRow;
            Cell currentCell = BuildCell(currentRow: currentRow,maxRows);
            Cell nextCell = currentCell.Below();
            Assert.Null(nextCell);
        }

        [Fact]
        public void ReturnBelowRowSuccessfully()
        {
            int currentRow = 0;
            int expectedRow = currentRow+1;

            Cell currentCell = BuildCell(currentRow: currentRow);
            Cell nextCell = currentCell.Below();

            Assert.NotNull(nextCell);
            Assert.Equal(expectedRow,nextCell.Row);
        }              
    }
}
