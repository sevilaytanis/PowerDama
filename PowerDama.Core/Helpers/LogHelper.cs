using System;
using System.IO;

namespace PowerDama.Core.Helpers
{
    /// <summary>
    /// Loglama İşlemleri
    /// </summary>
    public static class LogHelper
    {
        /// <summary>
        /// Text formatında log tutar
        /// </summary>
        /// <param name="content"></param>
        public static void FileLog(string content)
        {
            string fileName = DateTime.Now.ToString("yyyyMMddTHHmmss") + ".txt";
            FileStream fs = new FileStream(ConfigurationHelper.LogPath() + fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.WriteLine(DateTime.Now + " => " + content);
            sw.Flush();
            sw.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool DatabaseLog(string content)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
