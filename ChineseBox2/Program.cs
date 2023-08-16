using System.Runtime.CompilerServices;

namespace ChineseBox2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var box = new ChineseBox(new ChineseBox(new ChineseBox(new ChineseBox(new ChineseBox(new ChineseBox(new ChineseBox()))))));
            Console.WriteLine(box.GetNestedBoxCount()); ;
        }

        public class ChineseBox
        {
            public ChineseBox? NestedBox { get; set; }

            public ChineseBox()
            {
                NestedBox = null;
            }

            public ChineseBox(ChineseBox chineseBox)
            {
                NestedBox = chineseBox;
            }

            public int GetNestedBoxCount()
            {
                if(NestedBox == null)
                {
                    return 0;
                }
                return 1 + NestedBox.GetNestedBoxCount();
            }
        }
    }
}