using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int parola = int.Parse(Console.ReadLine());
        int broiKodove = int.Parse(Console.ReadLine());
        int counter = 0;
        int kod = 0;

        for (int index = 0; index < broiKodove; index++)
        {
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (char d = (char)097; d < (char)123; d++)
                        {
                            for (char e = (char)097; e < (char)123; e++)
                            {
                                for (int f = 0; f < 10; f++)
                                {
                                    kod = a + b + c + d + e + f;
                                    if (kod == parola)
                                    {
                                        Console.WriteLine("{0}{1}{2}{3}{4}{5} ", a, b, c, d, e, f);
                                        counter++;
                                    }
                                    if(counter >= broiKodove)
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

