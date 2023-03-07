using System.Collections.Generic;
using System.Linq;

namespace Bridge.ERP.Helpers
{
    public static class CompareDictionaries
    {
        public static Dictionary<string, int> CompareDictionaryReturnSecondOne(Dictionary<string, int> dictionaryOne, Dictionary<string, int> dictionaryTwo)
        {
            var dictionary = new Dictionary<string, int>();
                foreach (var item in dictionaryOne)
                {
                    var keyInDictionary = dictionaryTwo.ContainsKey(item.Key); 
                    if (keyInDictionary)
                    {
                        var dictTwoValue = dictionaryTwo[item.Key];
                        dictionary.Add(item.Key, dictTwoValue);
                    }
                    else
                    {
                        dictionary.Add(item.Key, 0);
                    }
                }
            
            return dictionary;
        }
    }
}
