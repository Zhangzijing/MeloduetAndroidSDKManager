using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeloduetAndroidSDKManagerWinform.Helper
{
    public static class ListHelper
    {
        public static void AddIfNotExists(List<int> list, int i)
        {
            foreach (int item in list) 
            {
                if (i==item)
                {
                    return;
                }
            }
            list.Add(i);
        }
    }
}
