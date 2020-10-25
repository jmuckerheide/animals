using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Animals
{
    public class FileOutput
    {

        private StreamWriter streamWriter = null;
        private String fileName;

        public FileOutput(String fileName)
        {
            this.fileName = fileName;
            try
            {
            streamWriter = new StreamWriter(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void fileWrite(String line)
        {
            try
            {
            streamWriter.Write(line + "\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public void fileClose()
        {
            if (streamWriter != null) {
                try
                {
                streamWriter.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
