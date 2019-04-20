using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Drawing.Text;

namespace TSI_Schedule
{



    public partial class Form1 : Form
    {
        //check con 
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        //Open Sans Font

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
       IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont_OpenSans_Bold;
        Font myFont_OpenSans;
        Font myFont_openSans_Semibold;
        static int FontCount;

        Font InitFontFromRes(byte[] fontData , float emSize)
        {
            
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            FontCount += 1;

            return new Font(fonts.Families[0], emSize );
        }

        Font InitFontFromRes(byte[] fontData, float emSize, FontStyle fontStyle)
        {

            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            FontCount += 1;

            return new Font(fonts.Families[0], emSize , fontStyle);
        }


        string filename = "TSIscheduleDATA.json";


       

        public Form1()
        {
            InitializeComponent();

            ///__INIT_FONT___
            ///
            myFont_OpenSans_Bold = InitFontFromRes(Properties.Resources.OpenSans_Bold, 16.0F);
            myFont_OpenSans = InitFontFromRes(Properties.Resources.OpenSans_Regular, 10);
            myFont_openSans_Semibold = InitFontFromRes(Properties.Resources.OpenSans_Semibold, 13 , FontStyle.Bold);



            label1.Font = myFont_openSans_Semibold;
            MyLesButton.Font = myFont_OpenSans;
            FriendLessBtn.Font = myFont_OpenSans;
            Friend2LessBtn.Font = myFont_OpenSans;
            SettingsBtn.Font = myFont_OpenSans;
            ContactBtn.Font = myFont_OpenSans;


            //label1.Font = myFont_OpenSans;
            




            SidePanel.Height = MyLesButton.Height;
            myLessons1.BringToFront();

            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).ToString();
            filename = $"{path}/{filename}";
            //load json from file
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    var jser = new JavaScriptSerializer();
                    this.GroupStr=jser.Deserialize<string[]>(sr.ReadToEnd());
                }
            }else
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    var jser = new JavaScriptSerializer();
                    sw.Write(jser.Serialize(this.GroupStr));
                }
            }

            

            //init events listiners
            settingsUC1.ChangeGroup += ChangeGroupArray;
            settingsUC1.Groups = this.GroupStr;

            myLessons1.ChangeLesVar += LoadMyless;
            myLessons2.ChangeLesVar += LoadFrndless;
            myLessons3.ChangeLesVar += LoadFrnd2less;
            myLessons1.NoInternetEv += NoInternetReaction;
            myLessons2.NoInternetEv += NoInternetReaction;
            myLessons3.NoInternetEv += NoInternetReaction;
            noInternet1.TryToConnectInterEvent += TryToConnectInternet;
            noInternet1.TryToConnectInterEvent += settingsUC1.GroupCheck;

            noInternet1.Visible = false;


            try
            {
                LoadCodeDict();
                lessMy = Worker.GetLessons(GroupStr[0], Worker.GetTimestampThisDay(), CodeDict);
                myLessons1.LoadTable(lessMy , GroupStr[0], CodeDict);
                settingsUC1.CodeDict = CodeDict;


            }
            
            catch (Exception)
            {
                NoInternetReaction();
            }
           

        }

        private void NoInternetReaction()
        {
            //label2.Visible = true;
            //button4.Visible = true;

            myLessons1.Enabled = false;
            myLessons2.Enabled = false;
            myLessons3.Enabled = false;
            settingsUC1.Enabled = false;

            ContactBtn.Enabled = false;
            Friend2LessBtn.Enabled = false;
            FriendLessBtn.Enabled = false;
            MyLesButton.Enabled = false;
            SettingsBtn.Enabled = false;
            

            noInternet1.BringToFront();
            noInternet1.Visible = true;
        }

        private JsnDec CodeDict = null;
        public Lessons lessMy = null;
        private Lessons lessFrn = null;
        private Lessons lessfrnd2 = null;

        void LoadMyless(Lessons les)
        {
            this.lessMy = les;
        }

        void LoadFrndless(Lessons les)
        {
            this.lessFrn = les;
        }

        void LoadFrnd2less(Lessons les)
        {
            this.lessfrnd2 = les;
        }

        private string[] GroupStr = new string[3] { "4701BD", "3702BD", "4702BD" };



        public void ChangeGroupArray(string [] arr)
        {
            this.GroupStr = arr;
            myLessons1.TableLoaded = false;
            myLessons2.TableLoaded = false;
            myLessons3.TableLoaded = false;
        }




        private void LoadCodeDict()
        {
            try
            {
                this.CodeDict = Worker.GetCodedic();
            }
            catch (WebException)
            {
                NoInternetReaction();
            }
            
    }
        
        


        private void MyLesButton_Click(object sender, EventArgs e)
        {
            if (CheckNet())
            {
                SidePanel.Height = MyLesButton.Height;
                SidePanel.Top = MyLesButton.Top;
                myLessons1.BringToFront();



                try
                {
                    if (lessMy == null || !myLessons1.TableLoaded)
                    {
                        lessMy = Worker.GetLessons(GroupStr[0], Worker.GetTimestampThisDay(), CodeDict);
                        myLessons1.dayindex = 0;
                    }
                    myLessons1.LoadTable(lessMy, GroupStr[0], CodeDict);
                }
                catch (Exception)
                {
                    NoInternetReaction();
                }
            }
            else NoInternetReaction();
            
        }



        private void FriendLessBtn_Click(object sender, EventArgs e)
        {
            if (CheckNet())
            {

                SidePanel.Height = FriendLessBtn.Height;
                SidePanel.Top = FriendLessBtn.Top;
                myLessons2.BringToFront();


                try
                {
                    if (lessFrn == null || !myLessons2.TableLoaded)
                    {
                        lessFrn = Worker.GetLessons(GroupStr[1], Worker.GetTimestampThisDay(), CodeDict);
                        myLessons2.dayindex = 0;
                    }
                    myLessons2.LoadTable(lessFrn, GroupStr[1], CodeDict);
                }
                catch (Exception)
                {
                    NoInternetReaction();
                }
            }
            else
                NoInternetReaction();
            
        }

        private void Friend2LessBtn_Click(object sender, EventArgs e)
        {
            if (CheckNet())
            {
                SidePanel.Height = Friend2LessBtn.Height;
                SidePanel.Top = Friend2LessBtn.Top;
                myLessons3.BringToFront();


                try
                {
                    if (lessfrnd2 == null || !myLessons3.TableLoaded)
                        lessfrnd2 = Worker.GetLessons(GroupStr[2], Worker.GetTimestampThisDay(), CodeDict);
                    {
                        myLessons3.LoadTable(lessfrnd2, GroupStr[2], CodeDict);
                        myLessons3.dayindex = 0;
                    }
                }
                catch (Exception)
                {
                    NoInternetReaction();
                }
            }
            else
                NoInternetReaction();
                
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingsBtn.Height;
            SidePanel.Top = SettingsBtn.Top;
            settingsUC1.BringToFront();
            settingsUC1.myFont = myFont_OpenSans;
            if (noInternet1.Visible == true)
                noInternet1.BringToFront();
            
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ContactBtn.Height;
            SidePanel.Top = ContactBtn.Top;
            contactsUI1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                var jser = new JavaScriptSerializer();
                sw.Write(jser.Serialize(this.GroupStr));
            }
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void myLessons3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //shadow
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        //moveable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        void TryToConnectInternet()
        {
            try
            {
                LoadCodeDict();
                lessMy = Worker.GetLessons(GroupStr[0], Worker.GetTimestampThisDay(), CodeDict);
                myLessons1.LoadTable(lessMy, GroupStr[0], CodeDict);
                settingsUC1.CodeDict = CodeDict;

                myLessons1.Enabled = true;
                myLessons2.Enabled = true;
                myLessons3.Enabled = true;
                settingsUC1.Enabled = true;

                ContactBtn.Enabled = true;
                Friend2LessBtn.Enabled = true;
                FriendLessBtn.Enabled = true;
                MyLesButton.Enabled = true;
                SettingsBtn.Enabled = true;

                noInternet1.Visible = false;

            }
            catch (Exception)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }


}
