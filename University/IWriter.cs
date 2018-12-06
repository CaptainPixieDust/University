using System;
namespace University
{
    public interface IWriter
    {
        void WriteInfo(string info);
        void WriteError(Exception ex);
    }
}
