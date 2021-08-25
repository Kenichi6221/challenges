using WordFinderChallenge.Business.Test.Utils;
using Xunit;

namespace WordFinderChallenge.Business.Test.CellTest
{    
    public class GetNextCellTest: DefaultFactories
    {
        [Fact]
        public void SuccessAboveCall()
        {
            int currentRow = 5;
            int expectedRow = currentRow-1;

            Cell cell = BuildCell(currentRow:currentRow);
            Cell nextCell = cell.GetNextCell(Cell.ABOVE);

            Assert.NotNull(nextCell);
            Assert.Equal(expectedRow, nextCell.Row);
        }

        [Fact]
        public void SuccessBelowCall()
        {
            int currentRow = 0;
            int expectedRow = currentRow + 1;

            Cell cell = BuildCell(currentRow: currentRow);
            Cell nextCell = cell.GetNextCell(Cell.BELOW);

            Assert.NotNull(nextCell);
            Assert.Equal(expectedRow, nextCell.Row);
        }

        [Fact]
        public void SuccessLeftCall()
        {
            int currentColumn = 5;
            int expectedColumn = currentColumn - 1;

            Cell cell = BuildCell(currentColumn: currentColumn);
            Cell nextCell = cell.GetNextCell(Cell.LEFT);

            Assert.NotNull(nextCell);
            Assert.Equal(expectedColumn, nextCell.Column);
        }

        [Fact]
        public void SuccessRightCall()
        {
            int currentColumn = 0;
            int expectedColumn = currentColumn + 1;

            Cell cell = BuildCell(currentColumn: currentColumn);
            Cell nextCell = cell.GetNextCell(Cell.RIGHT);

            Assert.NotNull(nextCell);
            Assert.Equal(expectedColumn, nextCell.Column);
        }

        [Fact]
        public void ReturnIfDireccionWasNotFound()
        {
            int currentColumn = 0;            

            Cell cell = BuildCell(currentColumn: currentColumn);
            Cell nextCell = cell.GetNextCell(-1);

            Assert.Null(nextCell);            
        }
    }
}
