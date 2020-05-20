using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtParser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string>();
            string inputPath = "D:/Storage/Test.txt";
            string outputPath = "D:/Storage/Ekin.txt";
            using (StreamReader sr = File.OpenText(inputPath))
            {
                string s = String.Empty;
                string temp = String.Empty;
                while ((temp = sr.ReadLine()) != null)
                {
                    if (temp != s)
                    {
                        text.Add(s);
                        s = temp;
                    }
                }
            }
            text = text.Distinct().ToList();

            File.WriteAllLines(outputPath, text);

        }

    }
}
