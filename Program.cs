using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Training\Assisted Projects\Pratice Projects\PracticeProject1\PracticeProject1\StudentData.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] strings = File.ReadAllLines(filePath);
                    foreach (string s in strings)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("The Student data file does not exists");
                }
            } 
            
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nProgram Successfully Executed");
            }

            Console.ReadKey();

        }
    }
}
