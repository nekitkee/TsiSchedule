using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSI_Schedule
{
    public partial class MyLessons : UserControl
    {
        public MyLessons()
        {
            InitializeComponent();
            
        }

        public int? countOflesson = null;
        public int dayindex = 0;
        string group;
        JsnDec codedict;

         public void MakeVisible(bool flag , int countOfLesson)
        {
            
                if (countOfLesson < 5)
                {
                    Lab_name4.Visible = flag;
                    Lab_room4.Visible = flag;
                    Lab_teacher4.Visible = flag;
                    Lab_time4.Visible = flag;
                }else
            {
                Lab_name4.Visible = !flag;
                Lab_room4.Visible = !flag;
                Lab_teacher4.Visible = !flag;
                Lab_time4.Visible = !flag;

            }

                if (countOfLesson < 4)
                {
                    Lab_name3.Visible = flag;
                    Lab_room3.Visible = flag;
                    Lab_teacher3.Visible = flag;
                    Lab_time3.Visible = flag;
            }
            else
            {
                Lab_name3.Visible = !flag;
                Lab_room3.Visible = !flag;
                Lab_teacher3.Visible = !flag;
                Lab_time3.Visible = !flag;
            }

                if (countOfLesson < 3)
                {
                    Lab_name2.Visible = flag;
                    Lab_room2.Visible = flag;
                    Lab_teacher2.Visible = flag;
                    Lab_time2.Visible = flag;
                }else
            {
                Lab_name2.Visible = !flag;
                Lab_room2.Visible = !flag;
                Lab_teacher2.Visible = !flag;
                Lab_time2.Visible = !flag;
            }

                if (countOfLesson < 2)
                {
                    Lab_name1.Visible = flag;
                    Lab_room1.Visible = flag;
                    Lab_teacher1.Visible = flag;
                    Lab_time1.Visible = flag;
                }
            else
            {
                Lab_name1.Visible = !flag;
                Lab_room1.Visible = !flag;
                Lab_teacher1.Visible = !flag;
                Lab_time1.Visible = !flag;

            }

                if (countOfLesson == 0)
                {
                    Lab_name0.Visible = flag;
                    Lab_room0.Visible = flag;
                    Lab_teacher0.Visible = flag;
                    Lab_time0.Visible = flag;
                }else
            {
                Lab_name0.Visible = !flag;
                Lab_room0.Visible = !flag;
                Lab_teacher0.Visible = !flag;
                Lab_time0.Visible = !flag;
            }
            
        }


        public void LoadTable (Lessons les , string grp , JsnDec dic )
        {
            Lab_group.Text = grp;
            int i = les.LessonCount;
            group = grp;
            codedict = dic;

            //if (countOflesson == null)
                countOflesson = i;

             MakeVisible(false, countOflesson.Value);

            if (TableLoaded == false)
            {
                TableLoaded = true;
                this.countOflesson = les.LessonCount;

                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddSeconds(les.timestamp);
                Lab_date.Text = dt.ToString().Substring(0,10);
                


                if (i != 0 && i < 7)
                {
                    LabFree.Visible = false;
                    do
                    {
                        switch (i)
                        {
                            case 5:
                                {
                                    Lab_name4.Text = les.lessons[4].name;
                                    Lab_room4.Text = les.lessons[4].room;
                                    Lab_teacher4.Text = les.lessons[4].teacher;
                                    Lab_time4.Text = les.lessons[4].time;

                                }
                                break;
                            case 4:
                                {
                                    Lab_name3.Text = les.lessons[3].name;
                                    Lab_room3.Text = les.lessons[3].room;
                                    Lab_teacher3.Text = les.lessons[3].teacher;
                                    Lab_time3.Text = les.lessons[3].time;
                                }
                                break;
                            case 3:
                                {
                                    Lab_name2.Text = les.lessons[2].name;
                                    Lab_room2.Text = les.lessons[2].room;
                                    Lab_teacher2.Text = les.lessons[2].teacher;
                                    Lab_time2.Text = les.lessons[2].time;
                                }
                                break;
                            case 2:
                                {
                                    Lab_name1.Text = les.lessons[1].name;
                                    Lab_room1.Text = les.lessons[1].room;
                                    Lab_teacher1.Text = les.lessons[1].teacher;
                                    Lab_time1.Text = les.lessons[1].time;

                                }
                                break;
                            case 1:
                                {
                                    Lab_name0.Text = les.lessons[0].name;
                                    Lab_room0.Text = les.lessons[0].room;
                                    Lab_teacher0.Text = les.lessons[0].teacher;
                                    Lab_time0.Text = les.lessons[0].time;

                                }
                                break;

                            
                        }
                        i = i - 1;
                    } while (i > 0);
                }
                else
                {


                    LabFree.Visible = true;
                }
            }
        }

        public bool TableLoaded = false;


        private void MyLessons_Load(object sender, EventArgs e)
        {

        }

        public delegate void ChangeLessonsVar(Lessons les);
        public event ChangeLessonsVar ChangeLesVar;
        public delegate void NoInet();
        public event NoInet NoInternetEv;

        private void BackDayBtn_Click(object sender, EventArgs e)
        {
            dayindex -= 1;
            TableLoaded = false;
            try
            {
                Lessons les = Worker.GetLessons( group , Worker.GetTimestampThisDay() + dayindex * 86400, codedict);

                this.countOflesson = les.LessonCount;
                ChangeLesVar?.Invoke(les);
                
                LoadTable(les, this.group, this.codedict);
            }
            catch (Exception)
            {
                NoInternetEv?.Invoke();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NextDayBtn_Click(object sender, EventArgs e)
        {
            dayindex += 1;
            TableLoaded = false;
            try
            {
                Lessons les = Worker.GetLessons(group, Worker.GetTimestampThisDay() + dayindex * 86400, codedict);
                this.countOflesson = les.LessonCount;
                ChangeLesVar?.Invoke(les);
                LoadTable(les, this.group, this.codedict);
            }
            catch (Exception)
            {
                NoInternetEv?.Invoke();
            }

        }
    }
}
