using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace MeloduetAndroidSDKManagerWinform.Helper
{
    public class ApplicationSetting
    {
        public List<string> Repository { get;  } = new List<string>();
        public int SeletedRepository { get; set; } = 0;
        public static ApplicationSetting Load(string path)
        {
            
            if (System.IO.File.Exists(path))
            {
                ApplicationSetting obj = null; 
                string json = System.IO.File.ReadAllText(path);
                obj = JsonConvert.DeserializeObject<ApplicationSetting>(json);
                return obj;
            }
            else
            {
                var obj = new ApplicationSetting();
                obj.Repository.Add("http://mirrors.neusoft.edu.cn/android/repository");
                obj.Save(path);
                return obj;       
            }

        }
        public void Save(string path)
        {
            System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(this),Encoding.UTF8);
        }

    }
}
