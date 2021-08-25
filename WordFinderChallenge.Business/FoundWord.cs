namespace WordFinderChallenge.Business
{
    public class FoundWord
    {
        public int Times { get; set; }
        public string Word { get; set; }

        public FoundWord(string word, int times)
        {
            this.Word = word;
            this.Times = times;
        }
    }
}
