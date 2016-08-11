
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MeloduetAndroidSDKManagerWinform.Helper
{
    public static class ParseXml
    {
        public static Stream ToStream(this string @this)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(@this);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }


        public static T ParseXML<T>(this string @this) where T : class
        {
            try
            {
                var reader = XmlReader.Create(@this.Trim().ToStream(), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
                return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
            }
            catch (Exception e)
            {
                Logger.Log("Exception at ParseXML(" + typeof(T) + "), msg: "+e.Message);
                throw;
            }
            
        }
        public static string GetXmlFromUri(string uri)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string s = client.DownloadString(uri);
                    return s;
                }
                //通常是404
                catch (System.Net.WebException e)
                {
                    System.Windows.Forms.MessageBox.Show("错误! URI:\n" + uri + "\n有关信息: " + e.Message);
                    Logger.Log("Exception at GetXmlFromUri(" + uri + "), msg: " + e.Message);
                    throw;
                    
                }
                //通常是超时
                catch(System.Net.Sockets.SocketException e)
                {
                    System.Windows.Forms.MessageBox.Show("错误! URI:\n" + uri + "\n有关信息: " + e.Message);
                    Logger.Log("Exception at GetXmlFromUri(" + uri + "), msg: " + e.Message);
                    throw;
                }
                
            }
        }
    }
}
