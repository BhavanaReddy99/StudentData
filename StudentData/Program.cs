using System;
using System.IO;
using System.Linq;

namespace StudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the path to the student data file 
            string filePath = "StudentData.txt";

            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("File does not exist.");
                }

                // Read the student data from the text file
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("---------------------------------RAINBOW SCHOOLS-------------------------------------");
                Console.WriteLine("Student Data:");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-20}{4,-20}", "StudentID", "StudentName", "Grade", "Course", "Marks");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                

                // Display each student's data
                foreach (string line in lines.Skip(1))
                {
                    string[] data = line.Split(',');
                    int studentID = int.Parse(data[0]);
                    string studentName = data[1];
                    string grade = data[2];
                    string course = data[3];
                    string marks = data[4];

                    Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-20}{4,-20}", studentID, studentName, grade, course, marks);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
