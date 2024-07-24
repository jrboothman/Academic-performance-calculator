using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Academic_performance_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to the academic performance calculator.");
            Console.WriteLine("Use the Keyboard to control the program functions");
            Console.WriteLine("");
            Console.WriteLine("1. Login as Teacher");
            Console.WriteLine("");
            Console.WriteLine("2. Login as Admin ");

            int LoginChoice = Convert.ToInt32(Console.ReadLine());

            if (LoginChoice == 1)
            {
                Console.Clear();
                Console.WriteLine("1. Change a Students Grades");
                Console.WriteLine("2. List of Underperforming Students");
                Console.WriteLine("3. Close Application");

                int TeacherChoice = Convert.ToInt32(Console.ReadLine());

                if (TeacherChoice == 1)
                {
                   
                }
                else if (TeacherChoice == 2)
                {

                }
                else 
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Import list of students");
                Console.WriteLine("3. Create Module");
                Console.WriteLine("4. Add student to module");
                Console.WriteLine("5. Close Application");

                int AdminChoice = Convert.ToInt32(Console.ReadLine());

                if (AdminChoice == 1)
                {
                    Console.Clear();

                    List<string> Students = new List<string>();

                    Console.WriteLine("Enter the Students first name");
                    string Fname = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine("Enter the Students last name");
                    string Lname = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine("Enter the Students Attendance out of 100");
                    int Attendance = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Enter the Students Exam score out of 100");
                    int Exam = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Enter the Students Coursework score out of 100");
                    int Coursework = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    int Performance = ((Attendance + Exam + Coursework) / 3);

                    string sPerformance = Performance.ToString();

                    string listStudent = Fname + " " + Lname + " " + sPerformance;

                    Students.Add(listStudent);

                    File.AppendAllLines("Students.txt", Students);
                }
                else if (AdminChoice == 2)
                {
                    Console.Clear();

                    Console.WriteLine("What is the name of the student file you wish to import?");
                    string Filename = Console.ReadLine();

                    if (File.Exists(Filename))
                    {
                        List<string> data = File.ReadAllLines(Filename).ToList();

                        File.AppendAllLines("Students.txt", data);

                        Console.Clear();

                        Console.WriteLine("All data from " + Filename + " has been added to the students file");
                    }
                    else
                    {
                        Console.WriteLine("The file " + Filename + " cant be found");
                    }
                }
                else if (AdminChoice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("What is the name of the module?");

                    string Modulename = Console.ReadLine();
                    string ModuleFileName = Modulename + ".txt";

                    Console.Clear();

                    File.Create(ModuleFileName);
                }
                else if (AdminChoice == 4)
                {
                    Console.Clear();

                    Console.WriteLine("What is the name of the module you wish to add students to?");

                    string Module = Console.ReadLine();

                    Console.Clear();
                    if (File.Exists(Module + ".txt"))
                    {
                        Console.WriteLine("What is the Students First Name?");
                        string Fname = Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("What is the Students Last Name?");
                        string Lname = Console.ReadLine();

                        Console.Clear();

                        string FullName = Fname + " " + Lname;

                        string ModuleFile = Module + ".txt";

                        List<string> NewStudent = new List<string>();

                        NewStudent.Add(FullName);

                        File.AppendAllLines(ModuleFile, NewStudent);
                    }
                    else
                    {
                        Console.WriteLine("That module hasn't been created yet");
                    }
                }
                else 
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
