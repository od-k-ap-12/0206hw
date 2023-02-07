using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0206hw
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "Just a sample string.";

            #region 8

            int position = Convert.ToInt32(Console.ReadLine());
            s = s.Remove(position - 1, 1);
            Console.WriteLine(s);

            #endregion

            #region 9
            var remove = new string[] { Console.ReadLine() };
            foreach (var c in remove)
            {
                s = s.Replace(c, string.Empty);
            }
            Console.WriteLine(s);

            #endregion

            #region 10

            position = Convert.ToInt32(Console.ReadLine());
            string insert = Console.ReadLine();
            s = s.Insert(position, insert);

            #endregion

            #region 11

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            if (string.Equals(s, reversed) == true)
            {
                Console.WriteLine("палиндром");
            }
            else
            {
                Console.WriteLine("не палиндром");
            }

            #endregion


            #region 12

            int wordcounter = 0;
            string[] arrayOfString = s.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in arrayOfString)
            {
                Console.WriteLine(str);
                wordcounter++;
            }
            Console.WriteLine(wordcounter);

            #endregion

            #region 13
            string search = Console.ReadLine();
            string replace = Console.ReadLine();
            if (s.Contains(search))
            {
                s = s.Replace(search, replace);
                Console.WriteLine(s);
            }
            #endregion

            #region 14

            for (int i = 0; i < arrayOfString.Length-1; i++)
            {
                (arrayOfString[i], arrayOfString[i + 1]) = (arrayOfString[i+1], arrayOfString[i]);
            }
            foreach (string str in arrayOfString)
            {
                Console.WriteLine(str);
            }

            #endregion

            #region 15

            int vowelcounter = 0;
            string stringtocount = Console.ReadLine();
            arrayOfString = s.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i=0;i<arrayOfString.Length;i++)
            {
                charArray = arrayOfString[i].ToCharArray();
                Array.Reverse(charArray);
                if (charArray[0] == 'a' || charArray[0] == 'e' || charArray[0] == 'и' || charArray[0] == 'э' || charArray[0] == 'я' || charArray[0] == 'ю' || charArray[0] == 'о' || charArray[0] == 'ы' || charArray[0] == 'ы' || charArray[0] == 'ё')
                {
                    vowelcounter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(vowelcounter);

            #endregion
        }
    }
}
