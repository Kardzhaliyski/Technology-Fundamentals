using System;
using System.Text.RegularExpressions;

namespace _02._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSequences = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            string[] bestSequence = null;
            int bestSequenceLenght = 0;
            int bestSequenceIndex = 0;
            int bestSequenceSumOnes = 0;
            int sample = 0;
            int bestSample = 0;

            while (line != "Clone them!")
            {

                sample++;
                var currentSequence = line.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries);
                int currentSequenceLenght = 0;
                int currentSequenceStartIndex = 0;
                int currentSequenceSumOnes = 0;
                bool newSequenceStarted = true;

                for (int j = 0; j < currentSequence.Length; j++)
                {
                    if (currentSequence[j] == "1")
                    {
                        currentSequenceSumOnes++;
                    }
                }

                for (int i = 0; i < currentSequence.Length; i++)
                {
                    if (currentSequence[i] != "1")
                    {
                        currentSequenceLenght = 0;
                        newSequenceStarted = true;
                    }
                    else
                    {
                        currentSequenceLenght++;
                        if (newSequenceStarted)
                        {
                            newSequenceStarted = false;
                            currentSequenceStartIndex = i;
                        }
                    }

                    if (currentSequenceLenght > bestSequenceLenght || bestSequence == null
                        || (currentSequenceLenght == bestSequenceLenght && currentSequenceStartIndex < bestSequenceIndex)
                        || (currentSequenceLenght == bestSequenceLenght && currentSequenceStartIndex == bestSequenceIndex && currentSequenceSumOnes > bestSequenceSumOnes))
                    {
                        bestSequenceLenght = currentSequenceLenght;
                        bestSequenceIndex = currentSequenceStartIndex;
                        bestSequence = (string[])currentSequence;
                        bestSequenceSumOnes = currentSequenceSumOnes;
                        bestSample = sample;
                    }
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSumOnes}.");
            Console.WriteLine($"{string.Join(" ", bestSequence)}");
        }
    }
}