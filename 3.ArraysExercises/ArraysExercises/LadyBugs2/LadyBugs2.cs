using System;
using System.Linq;

namespace LadyBugs2
{
    class LadyBugs2
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] initialBugsIndex = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            PupolateField(field, initialBugsIndex);

            string input = null;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input
                .Split();
                int startIndex = int.Parse(data[0]);
                string direction = data[1];
                int distance = int.Parse(data[2]);


                if(direction == "right")
                {
                    MoveRight(field, startIndex, distance);
                }
                else if (direction == "left")
                {
                    MoveLeft(field, startIndex, distance);
                }

            }

            Console.WriteLine(string.Join(' ', field));

        }






        public static void MoveRight(int[] field, int startIndex, int distance)
        {
            int nextLocation = startIndex + distance;
            if (IsInside(field, startIndex) )
            {
                if (field[startIndex] == 1 && distance != 0)
                {
                    bool traveling = true;

                    while (traveling)
                    {
                        if (IsInside(field, nextLocation))
                        {

                            if (field[nextLocation] == 0)
                            {
                                field[startIndex] = 0;
                                field[nextLocation] = 1;
                                traveling = false;
                            }
                            else if (field[nextLocation] == 1)
                            {
                                nextLocation += distance;
                            }
                        }
                        else
                        {
                            field[startIndex] = 0;
                            traveling = false;
                        }
                    }
                }
            }
        }

        public static void MoveLeft(int[] field, int startIndex, int distance)
        {
            int nextLocation = startIndex - distance;
            if (IsInside(field, startIndex))
            {
                if (field[startIndex] == 1 && distance != 0)
                {
                    bool traveling = true;

                    while (traveling)
                    {
                        if (IsInside(field, nextLocation))
                        {

                            if (field[nextLocation] == 0)
                            {
                                field[startIndex] = 0;
                                field[nextLocation] = 1;
                                traveling = false;
                            }
                            else if (field[nextLocation] == 1)
                            {
                                nextLocation -= distance;
                            }
                        }
                        else
                        {
                            field[startIndex] = 0;
                            traveling = false;
                        }
                    }
                }
            }
        }

        public static bool IsInside(int[] array, int index)
        {
            if (index >= 0 && index < array.Length)
            {
                return true;
            }
            return false;
        }



        public static void PupolateField(int[] field, int[] bugsIndexes)
        {
            for (int i = 0; i < bugsIndexes.Length; i++)
            {
                if (bugsIndexes[i] >= 0 && bugsIndexes[i] < field.Length)
                {
                    field[bugsIndexes[i]] = 1;
                }
            }
        }
    }

}
