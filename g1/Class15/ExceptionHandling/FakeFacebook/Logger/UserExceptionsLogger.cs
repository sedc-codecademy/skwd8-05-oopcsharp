using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFacebook.Logger
{
    public class UserExceptionsLogger
    {
        private string FilePath { get; set; } = @"C:\Users\Goce.Kabov\Desktop\ServerResponse\skwd8-05-oopcsharp\g1\Class15Prep\ExceptionHandling\ExceptionLogger.txt";
        public void LogException(Exception ex)
        {
            // open conection to file
            StreamWriter sw = new StreamWriter(FilePath);
            // write in file
            sw.WriteLine($"{ex.GetType().Name}  {ex.Message} {ex.StackTrace}");
            // close connection to file
            sw.Close();
        }
    }
}
