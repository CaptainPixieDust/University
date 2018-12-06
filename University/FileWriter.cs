using System;
using System.IO;

namespace University
{
    public class FileWriter : IWriter
    {
        const string path = "/Users/admin/Documents";
        StreamWriter writer;
        
        public void WriteError(Exception ex)
        {
            
        }

        public void WriteInfo(string info)
        {
            throw new NotImplementedException();
        }

        private bool IsFileExist(){
            return false;
        }
    }
}
