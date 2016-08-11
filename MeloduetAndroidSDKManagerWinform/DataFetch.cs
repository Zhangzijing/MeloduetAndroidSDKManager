using MeloduetAndroidSDKManagerWinform.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeloduetAndroidSDKManagerWinform
{
    class DataFetch
    {

        public static void FetchAll(Action<int, string> up,Action update)
        {

            int progress = 0;
            up(progress, "Fetching SdkRepository...");
            Logger.Log("...Fetch SdkRepository");
            FetchSdkRepository();
            progress = 13;
            up(progress, "Fetching SdkAddon...");
            Logger.Log("...Fetch SdkAddon");
            FetchSdkAddon();
            progress = 25;
            up(progress, "Fetching SdkGlassAddon...");
            Logger.Log("...Fetch SdkGlassAddon");
            FetchSdkGlassAddon();
            progress = 38;
            up(progress, "Fetching ExtraIntelSdkAddon...");
            Logger.Log("...Fetch ExtraIntelSdkAddon");
            FetchExtraIntelSdkAddon();
            progress = 50;
            up(progress, "Fetching AndroidSysimg...");
            Logger.Log("...Fetch AndroidSysimg");
            FetchAndroidSysimg();
            progress = 63;
            up(progress, "Fetching AndroidTvSysimg...");
            Logger.Log("...Fetch AndroidTvSysimg");
            FetchAndroidTvSysimg();
            progress = 75;
            up(progress, "Fetching AndroidWearSysimg...");
            Logger.Log("...Fetch AndroidWearSysimg");
            FetchAndroidWearSysimg();
            progress = 88;
            up(progress, "Fetching GoogleApiSysimg...");
            Logger.Log("...Fetch GoogleApiSysimg");
            FetchGoogleApiSysimg();
            progress = 100;
            up(progress, "Fetched All...");
            Data.Inited = true;
            update.Invoke();
           
        }
        public static void FetchSdkRepository()
        {
            string xml = ParseXml.GetXmlFromUri(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/repository-11.xml");
            Data.SdkRepository = xml.ParseXML<sdkrepository>();
        }
        public static void FetchSdkAddon()
        {
            string xml = ParseXml.GetXmlFromUri(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/addon.xml");
            Data.SdkAddon = xml.ParseXML<sdkaddon>();
        }
        public static void FetchSdkGlassAddon()
        {
            string xml = ParseXml.GetXmlFromUri(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/glass/addon.xml");
            Data.GlassSdkAddon = xml.ParseXML<glass.sdkaddon>();
        }
        public static void FetchExtraIntelSdkAddon()
        {
            string xml = ParseXml.GetXmlFromUri(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/extras/intel/addon.xml");
            Data.ExtraIntelSdkAddon = xml.ParseXML<extras.intel.sdkaddon>();
        }

        public static void FetchAndroidSysimg()
        {
            string xml = ParseXml.GetXmlFromUri(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/sys-img/android/sys-img.xml");
            Data.AndroidSysimg = xml.ParseXML<sdksysimg.android.sdksysimg>();
        }
        public static void FetchAndroidTvSysimg()
        {
            string xml = ParseXml.GetXmlFromUri(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/sys-img/android-wear/sys-img.xml");
            Data.AndroidWearSysimg = xml.ParseXML<sdksysimg.androidwear.sdksysimg>();
        }
        public static void FetchAndroidWearSysimg()
        {
            string xml = ParseXml.GetXmlFromUri(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/sys-img/android-tv/sys-img.xml");
            Data.AndroidTvSysimg = xml.ParseXML<sdksysimg.androidtv.sdksysimg>();
        }
        public static void FetchGoogleApiSysimg()
        {
            string xml = ParseXml.GetXmlFromUri(Data.AppSet.Repository[Data.AppSet.SeletedRepository] + "/sys-img/google_apis/sys-img.xml");
            Data.GoogleApiSysimg = xml.ParseXML<sdksysimg.googleapis.sdksysimg>();
        }


    }
}
