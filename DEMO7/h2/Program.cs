using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace h2
{
    class Program
    {
        static void Main(string[] args)
        {
            string luku = null;
            StreamWriter outputFile = new StreamWriter(@"d:\H2test1.txt");
            // kysytään käyttäjältä rivejä
            do
            {
                
                Console.Write(" Give a number (enter ends) : ");
                luku = Console.ReadLine();
                int luku1;
                bool luku2 = int.TryParse(luku, out luku1);
                if ( ) 
                {
                    // kirjoitetaan levylle
                    outputFile.WriteLine(luku);
                }else 
                {
                    StreamWriter outputFile1 = new StreamWriter(@"d:\H2test2.txt");
                    outputFile1.WriteLine(luku);
                }
            } while (luku.Length != 0);
            // suljetaan tiedosto
            outputFile.Close();
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            try
            {
                string text = File.ReadAllText(mydocpath + @"d:\H2test1.txt");
                Console.WriteLine("Contents of H2test1.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            string mydocpath1 = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            try
            {
                string text = File.ReadAllText(mydocpath + @"d:\H2test2.txt");
                Console.WriteLine("Contents of H2test2.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
