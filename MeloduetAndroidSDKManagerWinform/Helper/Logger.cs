using System;
using System.IO;

namespace MeloduetAndroidSDKManagerWinform.Helper
{
    class Logger
    {
        private static string logFilePath = Environment.CurrentDirectory + "/logs/" + DateTime.Now.ToString("yyyy-MM-dd") + Path.GetRandomFileName() + ".log";
        
        public static string FilePath
        {
            get { return Logger.logFilePath; }
            set { if (value.Length > 0) Logger.logFilePath = value; }
        }
        public static void Flush()
        {
            File.WriteAllText(Logger.FilePath, string.Empty);
        }
        private static object obj = new object ();
        public static void Log(string msg)
        {
            lock (obj)
            {
                if (msg.Length > 0)
                {
                    using (StreamWriter sw = File.AppendText(Logger.FilePath))
                    {
                        sw.WriteLine("{0} {1}: {2}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), msg);
                        sw.Flush();
                    }
                }
            }
           
        }
    }
}