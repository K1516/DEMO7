using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace h1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rivi = null;
            StreamWriter outputFile = new StreamWriter(@"d:\H1test.txt");
            // kysytään käyttäjältä rivejä
            do
            {
                Console.Write(" Give a text line (enter ends) : ");
               rivi = Console.ReadLine();
                // kirjoitetaan levylle
                outputFile.WriteLine(rivi); 
            } while (rivi.Length != 0);
            // suljetaan tiedosto
            outputFile.Close();

            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            try
            {
                string text = File.ReadAllText(mydocpath + @"d:\H1test.txt");
                Console.WriteLine("Contents of H1test.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}