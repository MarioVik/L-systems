using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Write_Rules
{
    static class FileHandler
    {
        static public string FilePath { get { return @"Instructions.txt"; } }

        static public void Save(List<string> instructions)
        {
            StreamWriter streamWriter = new StreamWriter(FilePath);
            foreach (string tempstring in instructions)
            {
                streamWriter.WriteLine(tempstring);
            }
            streamWriter.Close();
        }

        static public void SaveNewLine(string instructions, bool append)
        {
            StreamWriter streamWriter = new StreamWriter(FilePath, append);
            streamWriter.WriteLine(instructions);
            streamWriter.Close();
        }

        static public List<string> Load()
        {
            List<string> instructions = new List<string>();
            StreamReader streamReader = new StreamReader(FilePath);
            while (!streamReader.EndOfStream)
            {
                instructions.Add(streamReader.ReadLine());
            }
            streamReader.Close();
            return instructions;
        }
    }
}