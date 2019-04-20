using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI_Schedule
{
    public class Jsn1
    {
        public string d { get; set; }
    }


    public class Events
    {
        public IList<string> keys { get; set; }
        public IList<IList<object>> values { get; set; }
    }

    public class Jsn2
    {
        public Events events { get; set; }
    }

    public class JsnDec
    {
        public Dictionary<string, string> teachers;
        public Dictionary<string, string> rooms;
        public Dictionary<string, string> groups;

    }


    public class Lesson
    {

        public string time;
        public string room;
        public string groups;
        public string teacher;
        public string name;
        public string comment;
        public string cclass;

    }


    public class Lessons
    {

        public int timestamp;
        public int LessonCount;
        public Lesson[] lessons;

        public Lessons(Jsn2 jsn2, JsnDec codedic, int timestart)
        {


            LessonCount = jsn2.events.values.Count;
            timestamp = timestart;
            //if (LessonCount != 0)
            {
                lessons = new Lesson[LessonCount];
                for (int i = 0; i < LessonCount; i++)
                    lessons[i] = new Lesson();


                for (int i = 0; i < LessonCount; i++)
                {
                    int timeStampTemp = (int)jsn2.events.values.ElementAt(i).ElementAt(0);
                    DateTime dateTimeTemp = new DateTime();
                    dateTimeTemp = dateTimeTemp.AddSeconds(timeStampTemp);
                    lessons[i].time = $"{dateTimeTemp.Hour}:{dateTimeTemp.Minute}";
                    lessons[i].time = lessons[i].time.Replace(":0", ":00");

                    try
                    {
                        lessons[i].room = codedic.rooms[((object[])jsn2.events.values.ElementAt(i).ElementAt(1))[0].ToString()];
                        lessons[i].groups = codedic.groups[((object[])jsn2.events.values.ElementAt(i).ElementAt(2))[0].ToString()];
                        lessons[i].teacher = codedic.teachers[jsn2.events.values.ElementAt(i).ElementAt(3).ToString()];
                    }
                    catch (Exception)
                    {

                    }
                        lessons[i].name = (string)jsn2.events.values.ElementAt(i).ElementAt(4);

                        if (lessons[i].name.Length > 49)
                    {
                        lessons[i].name = lessons[i].name.Substring(0, 49) + ".";
                    }
                        
                        lessons[i].comment = (string)jsn2.events.values.ElementAt(i).ElementAt(5);
                        lessons[i].cclass = (string)jsn2.events.values.ElementAt(i).ElementAt(6);

                    lessons[i].teacher += "  " + lessons[i].comment;
                   

                }
            }
        }

    }
}
