using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsCounterList
{
    class FileContent
    {
        public static ConcurrentDictionary<string, int> wordsCollection = new ConcurrentDictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
       
        public static IOrderedEnumerable<KeyValuePair<string, int>> splitIntoWords(string text)
        {
            var list = Regex.Split(text, "[,:$% &().?!\\s\\n\\t\\W]+").ToList();

            Parallel.ForEach(list, word =>
            {
                if (wordsCollection == null)
                {
                    wordsCollection.TryAdd(word, 1);
                }
                else
                {
                    wordsCollection.AddOrUpdate(word, 1,
                        (key, value) => value++);
                }
            });

            return null;
        }

    }
}
