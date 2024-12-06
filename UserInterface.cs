
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentregistrering
{
    internal class UserInterface
    {
        private StudentManager _studentManager;

        public UserInterface(StudentManager studentManager)
        {
            _studentManager = studentManager;
        }

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1: Registrera ny Student");
                Console.WriteLine("2: Ändra en student");
                Console.WriteLine("3: Lista alla studenter");
                Console.WriteLine("4: Avsluta program");

                int val = Convert.ToInt32(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        _studentManager.AddStudent();
                        break;

                    case 2:
                        _studentManager.UpdateStudent();
                        break;

                    case 3:
                        _studentManager.ListStudents();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Avslutar program");
                        running = false;
                        break;
                }
            }
        }
    }
}
