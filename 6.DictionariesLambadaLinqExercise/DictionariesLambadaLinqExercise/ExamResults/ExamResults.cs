using System;
using System.Linq;
using System.Collections.Generic;


namespace ExamResults
{
    class ExamResults
    {
        static void Main(string[] args)
        {
            var usersScore = new Dictionary<string, int>();
            var languageSubmissions = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }

                var tokens = input
                    .Split('-')
                    .ToArray();
                var user = tokens[0];

                if (tokens[1] == "banned")
                {
                    usersScore.Remove(user);
                    continue;
                }

                else
                {
                    if (usersScore.ContainsKey(user) == false)
                    {
                        usersScore[user] = 0;
                    }

                    string language = tokens[1];
                    int scores = int.Parse(tokens[2]);

                    if (languageSubmissions.ContainsKey(language) == false)
                    {
                        languageSubmissions[language] = 0;
                    }

                    languageSubmissions[language]++;
                    if (usersScore[user] < scores)
                    {
                        usersScore[user] = scores;
                    }
                }

            }

            usersScore = OrderDict(usersScore);
            languageSubmissions = OrderDict(languageSubmissions);

            Console.WriteLine("Results:");
            foreach (var user in usersScore)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var lang in languageSubmissions)
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }


        }

        private static Dictionary<string, int> OrderDict(Dictionary<string, int> usersScore)
        {
            usersScore = usersScore
                            .OrderByDescending(x => x.Value)
                            .ThenBy(x => x.Key)
                            .ToDictionary(x => x.Key, x => x.Value);
            return usersScore;
        }

    }
}
