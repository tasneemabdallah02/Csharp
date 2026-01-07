using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task4_day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InputFile = "Employee.txt";
           
            string[] lines = File.ReadAllLines(InputFile);
            {
                Console.WriteLine("Employee Information:");
                Console.WriteLine("----------------------");

                foreach (string line in lines)
                {
                    string[] Data = line.Split('\\');
                    string Name = Data[0];
                    string Salary = Data[1];
                    string Department = Data[2];
                    double salary = double.Parse(Salary);
                    Console.WriteLine("Name : " + Name + "\n" + "Department : " + Department + "\n" + "Salary : " + Salary + "\n");
                }
                string OutputFile = "result.txt";
                File.WriteAllText(OutputFile, "\n");
                foreach (string line in lines)
                    {
                        string[] Data = line.Split('\\');

                        string Name = Data[0];
                        string Department = Data[1];
                        string Salary = Data[2];

                        double slary = double.Parse(Salary);
                    string resultLine = $"{Name} Work At {Department} with salary {Salary} years old";
                    File.AppendAllText(OutputFile, resultLine + "\n");
                }
            }
        }
    }
}
