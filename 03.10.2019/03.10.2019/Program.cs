using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Text.RegularExpressions;

namespace _03._10._2019
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ///////////////////////1111111///////////////
            //    string path = @"D:\Tolyan\C\Text.txt";
            //    string newPath = @"D:\Tolyan\C\NewText.txt";
            //    string text = "";
            //    string[] word = { "Bl'aha", "Blin", "Kaban" };
            //    try
            //    {
            //        using (StreamReader sr = new StreamReader(path))
            //        {
            //            text = sr.ReadToEnd().ToString();
            //            Console.WriteLine(text);
            //        }

            //        string[] words = text.Split(new char[] { ' ', ',', '-', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            //        for (int i = 0; i < words.Length; i++)
            //        {
            //            for (int j = 0; j < word.Length; j++)
            //            {
            //                if (words[i] == word[j])
            //                {
            //                    words[i] = new string('*', words.Length);
            //                }
            //            }
            //        }
            //        text = string.Join(" ", words, 0, words.Length);
            //        Console.WriteLine(text);


            //        using (StreamWriter sw = new StreamWriter(newPath, false, System.Text.Encoding.Default))
            //        {
            //            sw.Write(text);
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }



            ///////////////////////222222//////////
            //string path = @"D:\Tolyan\C\Text1.txt";
            //string newPath = @"D:\Tolyan\C\NewText1.txt";
            //string text = "";

            //try
            //{
            //    using (StreamReader sr = new StreamReader(path))
            //    {
            //        text = sr.ReadToEnd().ToString();
            //        Console.WriteLine(text);

            //    }
            //    string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        char st = words[i][0];
            //        words[i] = words[i].Remove(0, 1).Insert(0, st.ToString().ToUpper()) + ".";
            //    }

            //    text = string.Join(" ", words, 0, words.Length);
            //    Console.WriteLine(text);

            //    using (StreamWriter sw = new StreamWriter(newPath, false, System.Text.Encoding.Default))
            //    {
            //        for (int i = 0; i < words.Length; i++) 
            //        {
            //            sw.WriteLine(words[i]);
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            ///////////////////////3333333//////////
            string path = @"D:\Tolyan\C\Text2ListInt.txt";
            string newPath = @"D:\Tolyan\C\NewText2ListInt.txt";
            string text = "";
            string pattern = @"[0-9]+";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadToEnd().ToString();
                    Console.WriteLine(text);

                }
                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    char st = words[i][0];
                    words[i] = words[i].Remove(0, 1).Insert(0, st.ToString().ToUpper()) + ".";
                }

                text = string.Join(" ", words, 0, words.Length);
                Console.WriteLine(text);

                using (StreamWriter sw = new StreamWriter(newPath, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        sw.WriteLine(words[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
