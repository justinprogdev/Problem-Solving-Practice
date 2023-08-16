using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChineseBox[] testBoxes = {
                new ChineseBox(5, 7),
                new ChineseBox(6, 8),
                new ChineseBox(4, 5),
                new ChineseBox(9, 10),
                new ChineseBox(2, 3),
                new ChineseBox(8, 9),
                new ChineseBox(7, 8)
            };

            var n = testBoxes.Length;

            // Find max boxes that will fit in one another
            Array.Sort(testBoxes, (a, b) => (b.Height + b.Width) - (a.Height + a.Width));
            foreach (ChineseBox box in testBoxes) { Console.WriteLine(box.Height + "" + box.Width); }


            int count = CountBoxes(testBoxes);
            Console.WriteLine("Count:" + count);
        }

        private static int CountBoxes(ChineseBox[] testBoxes)
        {
            if (testBoxes.Length == 1)
            {
                return 0;
            }
            if ((testBoxes[0].Width > testBoxes[1].Width && testBoxes[0].Height > testBoxes[1].Height) ||
                    (testBoxes[0].Height > testBoxes[1].Width && testBoxes[0].Width > testBoxes[1].Height))
            {
                return 1 + CountBoxes(testBoxes[1..]);
            }
            else
            {
                return CountBoxes(testBoxes[1..]);
            }

        }
    }

    public class ChineseBox
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public ChineseBox(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}