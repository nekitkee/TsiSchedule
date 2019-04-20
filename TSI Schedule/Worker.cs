using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;
using System.Web;
using System.IO;

namespace TSI_Schedule
{
    public static class Worker
    {

        public static int GetTimestampNow()
        {
            return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;

        }

        public static int GetTimestampThisDay()
        {
            return (int)(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day) - new DateTime(1970, 1, 1)).TotalSeconds;

        }

        public static string Getresponse(string link)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            return wc.DownloadString(link);
        }

        public static Lessons GetLessons(string group, int timestart, JsnDec codedic)
        {

            int timefinish = timestart + 86400;
            group = codedic.groups.FirstOrDefault(x => x.Value == group).Key;
            string reguest = $"http://services.tsi.lv/schedule/api/service.asmx/GetLocalizedEvents?from={timestart}&to={timefinish}&teachers=&rooms=&groups={group}&lang=%27ru%27";
            string response = Getresponse(reguest);
            response = response.Replace("(", "");
            response = response.Replace(")", "");
            var jser = new JavaScriptSerializer();
            Jsn1 dic = jser.Deserialize<Jsn1>(response);
            Jsn2 dic2 = jser.Deserialize<Jsn2>(dic.d);
            return new Lessons(dic2, codedic, timestart);

        }

        public static JsnDec GetCodedic()
        {
            var jser = new JavaScriptSerializer();
            string reguest2 = @"http://services.tsi.lv/schedule/api/service.asmx/GetItems";
            string response2 = Getresponse(reguest2);
            response2 = response2.Replace("(", "");
            response2 = response2.Replace(")", "");
            Jsn1 dicdic = jser.Deserialize<Jsn1>(response2);
            return jser.Deserialize<JsnDec>(dicdic.d);

        }




    }
}
