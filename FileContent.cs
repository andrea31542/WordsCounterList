using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsCounterList
{
    class FileContent
    {
        public static Dictionary<string, int> wordsCollection = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

        public static IOrderedEnumerable<KeyValuePair<string, int>> splitIntoWords(string text)
        {
            var list = Regex.Split(text, "[,:$% &().?!\\s\\n\\t\\W]+").ToList();
            //var list = Regex.Split(text, @"[^\p{L}]*\p{Z}[^\p{L}]*").ToList();

            Parallel.ForEach(list, word =>
            {
                if (wordsCollection == null)
                {
                    wordsCollection.Add(word, 1);
                }
                else if (wordsCollection.ContainsKey(word))
                    wordsCollection[word]++;
                else
                    wordsCollection.Add(word, 1);

            });

            foreach (var VARIABLE in wordsCollection)
            {
                Console.WriteLine(VARIABLE.Key, " ", VARIABLE.Value);
            }

            return null;
        }

    }
}
