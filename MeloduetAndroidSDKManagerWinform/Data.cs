using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeloduetAndroidSDKManagerWinform
{
    public class Data
    {
        
     

        public static Helper.ApplicationSetting AppSet { get; set; } = null;


       public static List<int> ApiLevel { get; set; } = new List<int>();
       public static Dictionary<int, string> AndroidLevel { get; set; } = new Dictionary<int, string>
#region androidLevel
       {
            {24,"Android 7.0"},
            {23,"Android 6.0"},
            {22,"Android 5.1"},
            {21,"Android 5.0"},
            {20,"Android 4.4"},
            {19,"Android 4.4"},
            {18,"Android 4.3"},
            {17,"Android 4.2,4.2.2"},
            {16,"Android 4.1,4.1.1"},
            {15,"Android 4.0.3,4.0.4"},
            {14,"Android 4.0,4.0.1,4.0.2"},
            {13,"Android 3.2"},
            {12,"Android 3.1.x"},
            {11,"Android 3.0.x"},
            {10,"Android 2.3.4,2.3.3"},
            {9,"Android 2.3.2,2.3.1,2.3"},
            {8,"Android 2.2.x"},
            {7,"Android 2.1.x"},
            {6,"Android 2.0.1"},
            {5,"Android 2.0"},
            {4,"Android 1.6"},
            {3,"Android 1.5"},
            {2,"Android 1.1"},
            {1,"Android 1.0"}
        };
        #endregion
        public static sdkrepository SdkRepository { get; set; } = null;

        public static sdkaddon SdkAddon { get; set; } = null;
        public static glass.sdkaddon GlassSdkAddon { get; set; } = null;
        public static extras.intel.sdkaddon ExtraIntelSdkAddon { get; set; } = null;

        public static sdksysimg.android.sdksysimg AndroidSysimg { get; set; } = null;
        public static sdksysimg.androidtv.sdksysimg AndroidTvSysimg { get; set; } = null;
        public static sdksysimg.androidwear.sdksysimg AndroidWearSysimg { get; set; } = null;
        public static sdksysimg.googleapis.sdksysimg GoogleApiSysimg { get; set; }= null;

        public static bool Inited { get; set; } = false;
    }
}
