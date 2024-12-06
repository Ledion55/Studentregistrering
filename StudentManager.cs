
using System;
using System.Linq;

namespace Studentregistrering
{
    internal class StudentManager
    {
        private StudentDbContext _dbCtx;

        public StudentManager(StudentDbContext dbCtx)
        {
            _dbCtx = dbCtx;
        }

        public void AddStudent()
        {
            Console.Clear();
            Console.WriteLine("Ange förnamn:");
            string name = Console.ReadLine();

            Console.WriteLine("Ange stad:");
            string city = Console.ReadLine();

            Console.WriteLine("Ange ålder:");
            int age = Convert.ToInt32(Console.ReadLine());

            Student student = new Student
            {
                Name = name,
                City = city,
                Age = age
            };

            _dbCtx.Students.Add(student);
            _dbCtx.SaveChanges();

            Console.WriteLine("Studenten är tillagd i databasen");
        }

        public void UpdateStudent()
        {
            Console.Clear();
            Console.WriteLine("Ändra en student");
            ListStudents();

            Console.WriteLine("Ange id för att ändra:");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ange förnamn:");
            string name = Console.ReadLine();

            Console.WriteLine("Ange stad:");
            string city = Console.ReadLine();

            Console.WriteLine("Ange ålder:");
            int age = Convert.ToInt32(Console.ReadLine());

            var std = _dbCtx.Students.FirstOrDefault(s => s.StudentId == studentId);

            if (std != null)
            {
                std.Name = name;
                std.City = city;
                std.Age = age;

                _dbCtx.SaveChanges();
                Console.WriteLine("Studenten är uppdaterad.");
            }
            else
            {
                Console.WriteLine("Student hittades inte.");
            }
        }

        public void ListStudents()
        {
            Console.Clear();
            foreach (var item in _dbCtx.Students)
            {
                Console.WriteLine($"{item.StudentId}: {item.Name} {item.City}, {item.Age}");
            }
            Console.ReadKey();
        }
    }
}
