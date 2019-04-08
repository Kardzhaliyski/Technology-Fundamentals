using System;
using System.Linq;

class LadyBugs
{
    static void Main(string[] args)
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] fieldArr = new int[fieldSize];
        int[] ladyBugsInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < ladyBugsInput.Length; i++)
        {
            if (ladyBugsInput[i] >= 0 && ladyBugsInput[i] < fieldSize)
            {
                fieldArr[ladyBugsInput[i]] = 1;
            }
        }
        string input = "";

        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input
                .Split();
            int inputIndex = int.Parse(command[0]);
            string direction = command[1];
            int distance = int.Parse(command[2]);

            if (inputIndex >= 0 && inputIndex < fieldSize && fieldArr[inputIndex] == 1)
            {
                bool isFree = false;

                if (direction.ToLower() == "right")
                {
                    int nextLocation = inputIndex + distance;

                    while (!isFree)
                    {
                        if (distance == 0)
                            isFree = true;
                        else if (nextLocation >= 0 && nextLocation < fieldSize && Math.Abs(distance) < fieldSize)
                        {
                            if (fieldArr[nextLocation] == 0)
                            {
                                isFree = true;
                                fieldArr[inputIndex] = 0;
                                fieldArr[nextLocation] = 1;
                            }
                            else
                            {
                                nextLocation += distance;
                            }
                        }
                        else
                        {
                            isFree = true;
                            fieldArr[inputIndex] = 0;
                        }
                    }
                }
                else if (direction.ToLower() == "left")
                {
                    int nextLocation = inputIndex - distance;

                    while (!isFree)
                    {
                        if (distance == 0)
                            isFree = true;

                        else if(nextLocation >= 0 && nextLocation < fieldSize && Math.Abs(distance) < fieldSize)
                        {
                            if (fieldArr[nextLocation] == 0)
                            {
                                isFree = true;
                                fieldArr[inputIndex] = 0;
                                fieldArr[nextLocation] = 1;
                            }
                            else
                            {
                                nextLocation -= distance;
                            }
                        }
                        else
                        {
                            fieldArr[inputIndex] = 0;
                            isFree = true;
                        }
                    }
                }

            }

        }

        Console.WriteLine(string.Join(' ',fieldArr));
    }
}
