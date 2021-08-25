using System.Collections.Generic;
using System.Linq;

namespace WordFinderChallenge.Business
{
    public class WordFinder
    {
        protected IEnumerable<string> Matrix;

        protected List<List<Cell>> _CandidatesCollection;
        protected List<List<Cell>> CandidatesCollection
        {
            get
            {
                if (_CandidatesCollection == null)
                {
                    _CandidatesCollection = StartCandidatesCollection();
                }
                return _CandidatesCollection;

            }
            set
            {
                _CandidatesCollection = value;
            }
        }       

        public WordFinder(IEnumerable<string> matrix)
        {
            Matrix = matrix;
            FillCandidates();
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            FoundWordCollection foundCollection = new FoundWordCollection();
            HashSet<string> uniqueWords = new HashSet<string>(wordstream);
            int firstPosition = 0;


            foreach (string missing in uniqueWords)
            {

                int firstLetterPosition = GetCandidatePosition(missing[firstPosition]);
                List<Cell> candidates = CandidatesCollection[firstLetterPosition];
                int total_times_in_matrix = 0;

                foreach (Cell candidate in candidates)
                {
                    total_times_in_matrix += Deep(candidate, missing, firstPosition + 1);
                }

                foundCollection.AddFoundWord(missing, total_times_in_matrix);
            }


            // O(unique_missinWords*m*n*candidates)
            return foundCollection.GetWords();
        }

        protected int CheckDirection(Cell cell, string word, int index, int direction)
        {
            Cell currentCell = cell;
            int wordSize = word.Length;
            bool lastCharacterWasFound = true;
            int result = 0;

            while (lastCharacterWasFound && index < wordSize)
            {
                currentCell = currentCell.GetNextCell(direction);
                lastCharacterWasFound = LetterWasFound(currentCell, word, index);
                index++;
            }

            if (index == wordSize && lastCharacterWasFound)
            {
                result = 1;
            }

            return result;
        }

        protected int Deep(Cell cell, string word, int startIn)
        {
            int bottomUp = CheckDirection(cell, word, startIn, Cell.ABOVE);
            int topDown = CheckDirection(cell, word, startIn, Cell.BELOW);
            int rightLeft = CheckDirection(cell, word, startIn, Cell.LEFT);
            int leftRight = CheckDirection(cell, word, startIn, Cell.RIGHT);

            return bottomUp + topDown + rightLeft + leftRight;
        }

        protected List<List<Cell>> StartCandidatesCollection()
        {
            int totalAlphaberLetters = 26;
            List<List<Cell>> defaultCandidates = new List<List<Cell>>(totalAlphaberLetters);
            for (int letter = 0; letter < totalAlphaberLetters; letter++)
            {
                defaultCandidates.Add(new List<Cell>());
            }
            return defaultCandidates;
        }

        protected void FillCandidates()
        {
            int maxRow = Matrix.Count();
            int maxColumn = Matrix.ElementAt(0).Length;
            for (int line = 0; line < maxRow; line++)
            {
                for (int letter = 0; letter < maxColumn; letter++)
                {
                    int position = GetCandidatePosition(Matrix.ElementAt(line)[letter]);
                    CandidatesCollection[position].Add(new Cell(line, letter, maxRow, maxColumn));
                }
            }
        }

        protected bool LetterWasFound(Cell cell, string word, int index)
        {
            bool isValidCell = cell != null;
            bool isValidIndex = index < word.Length;

            return
            isValidCell &&
            isValidIndex &&
            word[index] == Matrix.ElementAt(cell.Row)[cell.Column];
        }

        protected int GetCandidatePosition(char letter)
        {
            return (int)letter - (int)'a';
        }
    }
}
