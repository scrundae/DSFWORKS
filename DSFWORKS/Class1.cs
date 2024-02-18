/*
 * This code was written by scrundaegames.
 * Please do not attempt to claim being the creator of this code.
 * Do the right thing.
 */ 

using System.IO;

namespace DSFWORKS
{
    public static class DsfwReader
    {
        private static string FileLoc = String.Empty;
        public static void ReadFile(string FileLocation)
        {
            
            string FileInside = File.ReadAllText(FileLocation);
            foreach (string line in FileInside.Split("\n"))
            {
                if (line.Contains("_write "))
                {
                    string ph = line;
                    ph = ph.Replace("_write ", "");
                    File.WriteAllText(FileLoc, ph);
                }
                else if (line.Contains("_read "))
                {
                    string ph = File.ReadAllText(FileLoc);
                    Console.WriteLine(ph);
                }
            }
        }
    }
}
