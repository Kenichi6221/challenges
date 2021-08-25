using System;
using System.Collections.Generic;
namespace WordFinderChallenge.Business
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int MaxRow { get; set; }
        public int MaxColumn { get; set; }

        private Dictionary<int, Func<Cell>> _CellActions;
        protected Dictionary<int, Func<Cell>> CellActions
        {
            get
            {
                if (_CellActions == null)
                {
                    _CellActions = BuildCellActions();
                }
                return _CellActions;

            }
            set
            {
                _CellActions = value;
            }
        }
        public static int ABOVE = 1;
        public static int BELOW = 2;
        public static int LEFT = 3;
        public static int RIGHT = 4;
        public Cell(int row, int column, int maxRow, int maxColumn)
        {
            Row = row;
            MaxRow = maxRow;
            Column = column;
            MaxColumn = maxColumn;
        }

        public Cell Above()
        {
            if (Row > 0)
            {
                return new Cell(Row - 1, Column, MaxRow, MaxColumn);
            }
            return null;
        }

        public Cell Below()
        {
            if (Row + 1 < MaxRow)
            {
                return new Cell(Row + 1, Column, MaxRow, MaxColumn);
            }
            return null;
        }

        public Cell Left()
        {
            if (Column > 0)
            {
                return new Cell(Row, Column - 1, MaxRow, MaxColumn);
            }
            return null;
        }

        public Cell Right()
        {
            if (Column + 1 < MaxColumn)
            {
                return new Cell(Row, Column + 1, MaxRow, MaxColumn);
            }
            return null;
        }

        private Dictionary<int, Func<Cell>> BuildCellActions()
        {
            var actionsDictionary = new Dictionary<int, Func<Cell>>();
            actionsDictionary[ABOVE] = new Func<Cell>(Above);
            actionsDictionary[BELOW] = new Func<Cell>(Below);
            actionsDictionary[LEFT] = new Func<Cell>(Left);
            actionsDictionary[RIGHT] = new Func<Cell>(Right);
            return actionsDictionary;
        }

        public Cell GetNextCell(int direction)
        {
            if (CellActions.ContainsKey(direction))
            {
                Func<Cell> buildNextCell = CellActions[direction];
                return buildNextCell();
            }

            return null;
        }
    }
}