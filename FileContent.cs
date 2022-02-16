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

        public static List<KeyValuePair<string, int>> splitIntoWords(ConcurrentDictionary<string, int> wordsCollection, string text)
        {

            var list = Regex.Split(text, "[,:$% &().?!\\s\\n\\t\\W]+").ToList();
            list.RemoveAll(s => string.IsNullOrEmpty(s));

            Parallel.ForEach(list, word =>
            {
                if (wordsCollection == null)
                {
                    wordsCollection.TryAdd(word, 1);
                }
                else
                {
                    wordsCollection.AddOrUpdate(word, 1,
                        (key, value) => value + 1);
                }
            });

            return orderDictionaryWords(wordsCollection);
        }

        public static List<KeyValuePair<string, int>> 
            orderDictionaryWords(ConcurrentDictionary<string, int> wordsCollection)
        {
            IOrderedEnumerable<KeyValuePair<string, int>> items = from pair in wordsCollection
                orderby pair.Key ascending 
                orderby pair.Value descending 
                select pair;
            return items.ToList();
        }

    }
}
