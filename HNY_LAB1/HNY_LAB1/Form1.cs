using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNY_LAB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();

            Pen myPen1 = new Pen(System.Drawing.Color.Gray, 2);
            Pen myPen2 = new Pen(System.Drawing.Color.Black, 15);
            Pen myPen3 = new Pen(System.Drawing.Color.Yellow, 5);
            Pen myPen4 = new Pen(System.Drawing.Color.DeepPink, 5);
            Pen myPen5 = new Pen(System.Drawing.Color.Green, 5);
            Pen myPen6 = new Pen(System.Drawing.Color.Brown, 5);
            Pen myPen7 = new Pen(System.Drawing.Color.SaddleBrown, 5);
            myGraphic.DrawLine(myPen3, 351, 84, 388, 84);  //จุดเร่ิ่ม จุดสิ้นสุด\  
            myGraphic.DrawLine(myPen3, 388, 84, 400, 49);
            myGraphic.DrawLine(myPen3, 400, 49, 411, 84);
            myGraphic.DrawLine(myPen3, 411, 84, 448, 84);
            myGraphic.DrawLine(myPen3, 448, 84, 418, 105);
            myGraphic.DrawLine(myPen3, 418, 105, 429, 142);
            myGraphic.DrawLine(myPen3, 400, 119, 429, 140);
            myGraphic.DrawLine(myPen3, 400, 119, 370, 140);
            myGraphic.DrawLine(myPen3, 381, 105, 370, 140);
            myGraphic.DrawLine(myPen3, 351, 84, 381, 105);
            
            myGraphic.DrawLine(myPen5, 380, 111, 225, 200);
            myGraphic.DrawLine(myPen5, 225, 200, 275, 200);
            myGraphic.DrawLine(myPen5, 275, 200, 175, 250);
            myGraphic.DrawLine(myPen5, 175, 250, 225, 250);
            myGraphic.DrawLine(myPen5, 225, 250, 125, 300);
            myGraphic.DrawLine(myPen5, 125, 300, 175, 300);
            myGraphic.DrawLine(myPen5, 175, 300, 75, 350);
            myGraphic.DrawLine(myPen5, 75, 350, 125, 350);
            myGraphic.DrawLine(myPen5, 125, 350, 25, 400);
            myGraphic.DrawLine(myPen5, 25, 400, 775, 400);
            myGraphic.DrawLine(myPen5, 419, 111, 575, 200);
            myGraphic.DrawLine(myPen5, 525, 200, 575, 200);
            myGraphic.DrawLine(myPen5, 525, 200, 625, 250);
            myGraphic.DrawLine(myPen5, 575, 250, 625, 250);
            myGraphic.DrawLine(myPen5, 575, 250, 675, 300);
            myGraphic.DrawLine(myPen5, 625, 300, 675, 300);
            myGraphic.DrawLine(myPen5, 625, 300, 725, 350);
            myGraphic.DrawLine(myPen5, 675, 350, 725, 350);
            myGraphic.DrawLine(myPen5, 675, 350, 775, 400);

            myGraphic.DrawLine(myPen7, 330, 400, 330, 450);
            myGraphic.DrawLine(myPen7, 350, 400, 350, 450);
            myGraphic.DrawLine(myPen7, 430, 400, 430, 450);
            myGraphic.DrawLine(myPen7, 450, 400, 450, 450);

            myGraphic.DrawLine(myPen7, 300, 250, 500, 250);

            myGraphic.DrawLine(myPen4, 386, 320, 414, 320);
            myGraphic.DrawLine(myPen4, 386, 320, 400, 340);
            myGraphic.DrawLine(myPen4, 414, 320, 400, 340);




            myGraphic.DrawRectangle(myPen7, 300, 450, 50, 50);
            myGraphic.DrawRectangle(myPen7, 400, 450, 50, 50);
            myGraphic.DrawRectangle(myPen7, 300, 226, 200, 124);


            myGraphic.DrawEllipse(myPen2, 325, 275, 50, 50);
            myGraphic.DrawEllipse(myPen2, 425, 275, 50, 50);



        }
    }
}
