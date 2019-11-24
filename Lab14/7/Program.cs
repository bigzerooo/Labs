using System;
using System.Text;
using System.Text.RegularExpressions;
namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"<upcase>.*</upcase>",RegexOptions.None);//реджекс, который забирает все, что в кавычках вместе с кавычками
            //string result = regex.Replace(text, "hello world!");
            //Console.WriteLine(result);
            MatchCollection matches = regex.Matches(text);//подстроки, которые подходят под реджекс
            foreach(var match in matches)
            {
                Console.WriteLine(match);
            }
            //string[] tokens = new string[matches.Count];
            //for(int i=0;i<3;i++)
            //{
            //   // Console.WriteLine(matches[i]);
            //    tokens[i] = matches[i].ToString().ToUpper().Remove(0, 8);
            //    tokens[i] = tokens[i].Remove(tokens[i].Length - 9, 9);
            //    //Console.WriteLine(tokens[i]);//возвращает верхний текст без кавычек
            //}
            //for(int i = 0; i < tokens.Length; i++)
            //{
            //    if (tokens[i].IndexOf("<UPCASE>") < 0 && tokens[i].IndexOf("</UPCASE>") < 0)                
            //        text = text.Replace(matches[i].ToString(), tokens[i]);                
            //}
            //Console.WriteLine(text);

        }
    }
}
