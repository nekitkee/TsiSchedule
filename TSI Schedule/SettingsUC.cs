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
    public partial class SettingsUC : UserControl
    {
        public SettingsUC()
        {
            InitializeComponent();
            
        }

        public Font myFont;
        public delegate void ChangeGroupArr( string [] arr );
        public event ChangeGroupArr ChangeGroup;

        public string[] Groups = new string[3] { "4701BD", "3702BD", "4702BD" };
        public JsnDec CodeDict = null;
        Dictionary<string, string> invertCodeDict = null;
        private void SettingsUC_Load(object sender, EventArgs e)
        {

            Textbox1.DataBindings.Add("text", Groups[0], null);
            Textbox2.DataBindings.Add("text", Groups[2], null);
            Textbox3.DataBindings.Add("text", Groups[1], null);
            label1.Font = myFont;
            label2.Font = myFont;
            label3.Font = myFont;

            //custom groupbox
            //groupBox1.Paint += groupBox1_Paint; 
        }


        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.Black);
            box.BackColor = Color.WhiteSmoke;
        }


        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor  );
                Pen borderPen = new Pen(borderBrush , 4);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                //Clear text and border
                //g.Clear(this.BackColor);



                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, new Point(rect.X , rect.Y + 11), new Point(rect.X, rect.Y + rect.Height+11));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y+11), new Point(rect.X + rect.Width, rect.Y + rect.Height+11));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                ////Top1
                //g.DrawLine(borderPen, new Point(rect.X, rect.Y + 20), new Point(rect.X + box.Padding.Left, rect.Y + 20));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y + 13), new Point(rect.X + rect.Width, rect.Y + 13));
                //box.BackColor = Color.Azure;
            }
        }

        public  void GroupCheck()
        {

            //дичь со словарем
            if (invertCodeDict == null || invertCodeDict.Count == 0)
            {
                invertCodeDict = new Dictionary<string, string>();

                try
                {
                    foreach (var line in CodeDict.groups)
                        try
                        {
                            invertCodeDict.Add(line.Value, line.Key);
                        }
                        catch (Exception)
                        {

                        }
                }
                catch (Exception)
                {
                    
                }
            }

            bool check = true;

            if (invertCodeDict.ContainsKey(Textbox1.Text))
                pictureBox1CheckFail.Visible = false;
            else
            {
                pictureBox1CheckFail.Visible = true;
                check = false;
            }


            if (invertCodeDict.ContainsKey(Textbox3.Text))
                pictureBox2CheckFail.Visible = false;
            else
            {
                pictureBox2CheckFail.Visible = true;
                check = false;
            }

            if (invertCodeDict.ContainsKey(Textbox2.Text))
                pictureBox3CheckFail.Visible = false;
            else
            {
                pictureBox3CheckFail.Visible = true;
                check = false;
            }

            if (check)
            {
                Groups[0] = Textbox1.Text;
                Groups[1] = Textbox3.Text;
                Groups[2] = Textbox2.Text;

                ChangeGroup?.Invoke(Groups);
            }
        }


        

        

       

        private void Textbox1_OnValueChanged(object sender, EventArgs e)
        {
            GroupCheck();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1CheckFail_Click(object sender, EventArgs e)
        {

        }
    }


}
