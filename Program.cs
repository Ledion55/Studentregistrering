
using System;

namespace Studentregistrering
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dbCtx = new StudentDbContext();
            var studentManager = new StudentManager(dbCtx);
            var userInterface = new UserInterface(studentManager);
            userInterface.Run();
        }



    }
    
}