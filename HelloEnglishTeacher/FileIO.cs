using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloEnglishTeacher
{    
    class FileIO
    {
        private StreamWriter writer = null;
        private StreamReader reader = null;

        public FileIO() { }
        
        public FileIO(string WR, string path)
        {
            try
            {
                if (WR.Equals(MsgCode.KEY_FILE_IO_READ))
                    reader = new StreamReader(path);
                else if (WR.Equals(MsgCode.KEY_FILE_IO_WRITE))
                    writer = new StreamWriter(path, false); //덮어쓰기
            }
            catch (Exception) { }

        }
        
        public Dictionary<string, string> ReadConfigFile()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            string readLine;
            
            try
            {
                while((readLine = reader.ReadLine()) != null)
                {
                    map[readLine.Split('=')[0]] = readLine.Split('=')[1];
                }
            }
            catch (Exception) { }
            finally
            {
                if (reader != null) { reader.Close(); reader = null; }
            }
            
            return map;
        }

        public void WriteConfig(Dictionary<string, string> config)
        {
            try
            {
                foreach (string key in config.Keys)
                {
                    writer.WriteLine(key + "=" + config[key]);
                    writer.Flush();
                }

            }catch(Exception) { }
            finally
            {
                if (writer != null) { writer.Close(); writer = null; }
            }
        }

        public static bool IsFileOpen(string path)
        {
            FileStream stream = null;

            try
            {
                stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (stream != null) { stream.Close(); stream = null; }
            }
            return true;
        }

        public void Close()
        {
            if(writer != null) { writer.Close(); writer = null; }
            if(reader != null) { reader.Close(); reader = null; }
        }
    }
}
