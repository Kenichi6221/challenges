using WordFinderChallenge.Business.Test.Utils;
using Xunit;

namespace WordFinderChallenge.Business.Test.CellTest
{
  public class Right: DefaultFactories
    {
        [Fact]
        public void ReturnNullIfAreadyIsInLastColumn()
        {
            int currentColumn = 5;
            Cell currentCell = BuildCell(currentColumn: currentColumn,maxColumn: currentColumn);
            Cell nextCell = currentCell.Right();
            Assert.Null(nextCell);
        }

        [Fact]
        public void ReturnRightColumnSuccessfully()
        {
            int currentColumn = 0;
            int expectedColumn = currentColumn+1;

            Cell currentCell = BuildCell(currentColumn: currentColumn);
            Cell nextCell = currentCell.Right();

            Assert.NotNull(nextCell);
            Assert.Equal(expectedColumn, nextCell.Column);
        }              
    }
}
