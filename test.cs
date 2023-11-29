// Dans test.cs
using System;

partial class Program
{
    static void Main()
    {
        for (int i = 0; i < 40; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}