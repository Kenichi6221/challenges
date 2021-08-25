using System.Collections.Generic;

namespace WordFinderChallenge.Business
{
    public class FoundWordCollection
    {
        protected List<FoundWord> _FoundWordCollection;

        protected List<FoundWord> Collection
        {
            get
            {
                if (_FoundWordCollection == null)
                {
                    _FoundWordCollection = new List<FoundWord>();
                }
                return _FoundWordCollection;
            }

            set { _FoundWordCollection = value; }
        }

        public void AddFoundWord(string word, int times)
        {
            if (times > 0)
            {
                Collection.Add(new FoundWord(word, times));
            }
        }

        public IEnumerable<string> GetWords(int maxSize = 10)
        {
            Collection.Sort((currentElement, nextElement) => { return nextElement.Times - currentElement.Times; });
            int totalFound = Collection.Count;
            int added = 0;
            while (added < maxSize && added < totalFound)
            {
                yield return Collection[added].Word;
                added++;
            }
        }
    }
}
