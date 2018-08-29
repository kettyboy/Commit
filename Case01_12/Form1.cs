using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace Case01_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
            gp.AddEllipse(rect);
            this.Region = new Region(gp);

            GraphicsPath gpl = new GraphicsPath();
            Rectangle rectl = new Rectangle(new Point(0, 0), new Size(this.panel1.Width, this.panel1.Height));
            gpl.AddEllipse(rectl);
            this.panel1.Region = new Region(gpl);

            GraphicsPath gpr = new GraphicsPath();
            Rectangle rectr = new Rectangle(new Point(0, 0), new Size(this.panel2.Width, this.panel2.Height));
            gpr.AddEllipse(rectr);
            this.panel2.Region = new Region(gpr);

            GraphicsPath myPath = new GraphicsPath();
            Rectangle rectm = new Rectangle(0, 0, this.panel4.Width, this.panel4.Height);
            myPath.StartFigure();
            myPath.AddArc(rectm, 0, 180);
            myPath.CloseFigure();
            this.panel4.Region = new Region(myPath);



            /*GraphicsPath gpp = new GraphicsPath();
            string stringText = "退出";
            FontFamily family = new FontFamily("宋体");
            int fontStyle = (int)FontStyle.Bold;
            int emSize = 20;
            Point origin = new Point(0, 0);
            StringFormat format = StringFormat.GenericDefault;
            gpp.AddString(stringText, family, fontStyle, emSize, origin, format);
            this.button1.Region = new Region(gpp);*/

            //MessageBox.Show("yyy","信息提示",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
            //if (MessageBox.Show("你确定要退出吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //    Application.Exit();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            //    Application.Exit();
            CloseReason rtCloseReason = e.CloseReason;
            switch (rtCloseReason)
            {
                case CloseReason.None:
                    {

                    }
                    break;
                case CloseReason.FormOwnerClosing:
                    {

                    }
                    break;
                case CloseReason.UserClosing:
                    {
                        MessageBox.Show("用户关闭软件！");
                    }
                    break;
                case CloseReason.ApplicationExitCall:
                    {
                        MessageBox.Show("系统关闭软件！");
                    }
                    break;

            }


        }
    }
}
