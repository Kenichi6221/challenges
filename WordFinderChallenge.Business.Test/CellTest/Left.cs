using WordFinderChallenge.Business.Test.Utils;
using Xunit;

namespace WordFinderChallenge.Business.Test.CellTest
{
  public class Left: DefaultFactories
    {
        [Fact]
        public void ReturnNullIfAreadyIsInFirstColumn()
        {   
            Cell currentColumn = BuildCell(currentColumn: 0);
            Cell nextCell = currentColumn.Left();
            Assert.Null(nextCell);
        }

        [Fact]
        public void ReturnLeftColumnSuccessfully()
        {
            int currentColumn = 5;
            int expectedColumn = currentColumn-1;

            Cell currentCell = BuildCell(currentColumn: currentColumn,maxColumn:currentColumn);
            Cell nextCell = currentCell.Left();

            Assert.NotNull(nextCell);
            Assert.Equal(expectedColumn, nextCell.Column);
        }              
    }
}
