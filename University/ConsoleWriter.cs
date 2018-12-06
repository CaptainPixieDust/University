using System;
namespace University
{
    public class ConsoleWriter : IWriter
    {
        public void WriteError(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        public void WriteInfo(string info)
        {
            Console.WriteLine(info);
        }
    }
}
