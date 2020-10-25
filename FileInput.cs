using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Animals
{
    public class FileInput
    {

        //private BufferedReader in = null;
        private StreamReader streamReader = null;
        private String fileName;

        public FileInput(String fileName)
        {
            this.fileName = fileName;
            try
            {
            streamReader = new StreamReader(fileName);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void fileRead()
        {
            String line;
            try
            {
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public String fileReadLine()
        {
            try
            {
                String line = streamReader.ReadLine();
                return line;
            }
            catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
                return null;
            }
        }

        public void fileClose()
        {
            if (this.streamReader != null) {
                try
                {
                this.streamReader.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
