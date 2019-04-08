using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonymus
{
    class WordSynonymus
    {
        static void Main(string[] args)
        {
            int givenWords = int.Parse(Console.ReadLine());
            var synonymousWords = new Dictionary<string, List<string>>();

            for (int i = 0; i < givenWords; i++)
            {
                string word = Console.ReadLine().ToLower();
                string synonym = Console.ReadLine().ToLower();

                if (synonymousWords.ContainsKey(word) == false)
                {
                    synonymousWords[word] = new List<string>();
                }
                
                if(synonymousWords[word].Contains(synonym) == false)
                {
                    synonymousWords[word].Add(synonym);
                }
            }
            
            foreach (var kvp in synonymousWords)
            {
                Console.Write(kvp.Key + " - ");
                Console.WriteLine(string.Join(", ", kvp.Value));
            }
        }
    }
}
