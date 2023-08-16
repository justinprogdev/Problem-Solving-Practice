using System;

class MalwareAnalysis
{


    public static int[] Simulate(int[] entries)
    {
        int[] result = new int[entries.Length];
        for (int i = 0; i < entries.Length; i++)
        {

            int t1 = 0;
            int t2 = 0;
            var x = entries[i];

            if (i < 3)
            {
                // Dont consider the left
                t2 = entries[i + 4];
                if (x <= t2)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = x;
                }
            }
            else if (i > entries.Length - 5)
            {
                // Don't consider the right
                t1 = entries[i - 3];
                if (x <= t1)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = x;
                }
            }
            else
            {
                t1 = entries[i - 3];
                t2 = entries[i + 4];
                if (t1 >= x || x <= t2)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = x;
                }
            }


        }

        return result;
    }

    public static void Main(string[] args)
    {
        int[] records = new int[] { 19, 2, 0, 87, 1, 40, 80, 77, 77, 77, 77 };
        var result = Simulate(records);
        Console.WriteLine(string.Join(", ", result));
    }
}