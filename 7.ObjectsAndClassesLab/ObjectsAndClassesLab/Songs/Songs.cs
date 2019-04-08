using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Songs
    {
        static void Main(string[] args)
        {
            int songAdded = int.Parse(Console.ReadLine());


            var songList = new List<Song>();
            string[] tokens;
            
            while (true)
            {
                tokens = Console.ReadLine()
                    .Split('_')
                    .ToArray();
                if (tokens.Length == 1)
                {
                    break;
                }

                songList.Add(new Song
                {
                    TypeList = tokens[0],
                    Name = tokens[1]
                });
            }

            if (tokens[0] == "all")
            {
                foreach (var song in songList)
                {
                    Console.WriteLine(song.Name);
                }
            }

            else
            {
                foreach (var song in songList)
                {
                    if (song.TypeList == tokens[0])
                    {
                    Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
