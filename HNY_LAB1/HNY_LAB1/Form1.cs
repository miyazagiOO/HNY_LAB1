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
            Pen myPen2 = new Pen(System.Drawing.Color.Black, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.Yellow, 2);
            myGraphic.DrawLine(myPen1, 351, 84, 388, 84);  //จุดเร่ิ่ม จุดสิ้นสุด\  
            myGraphic.DrawLine(myPen1, 388, 84, 400, 49);
            myGraphic.DrawLine(myPen1, 400, 49, 411, 84);
            myGraphic.DrawLine(myPen1, 411, 84, 448, 84);
            myGraphic.DrawLine(myPen1, 448, 84, 418, 105);
            myGraphic.DrawLine(myPen1, 418, 105, 429, 142);
            myGraphic.DrawLine(myPen1, 400, 119, 429, 140);
            myGraphic.DrawLine(myPen1, 400, 119, 370, 140);
            myGraphic.DrawLine(myPen1, 381, 105, 370, 140);
            myGraphic.DrawLine(myPen1, 351, 84, 381, 105);
            myGraphic.DrawLine(myPen1, 380, 111, 225, 200);
            myGraphic.DrawLine(myPen1, 225, 200, 275, 200);
            myGraphic.DrawLine(myPen1, 275, 200, 175, 250);
            myGraphic.DrawLine(myPen1, 175, 250, 225, 250);
            myGraphic.DrawLine(myPen1, 225, 250, 125, 300);
            myGraphic.DrawLine(myPen1, 125, 300, 175, 300);
            myGraphic.DrawLine(myPen1, 175, 300, 75, 350);
            myGraphic.DrawLine(myPen1, 75, 350, 125, 350);
            myGraphic.DrawLine(myPen1, 125, 350, 25, 400);
            myGraphic.DrawLine(myPen1, 25, 400, 775, 400);
            myGraphic.DrawLine(myPen1, 419, 111, 575, 200);
            myGraphic.DrawLine(myPen1, 525, 200, 575, 200);
            myGraphic.DrawLine(myPen1, 525, 200, 625, 250);
            myGraphic.DrawLine(myPen1, 575, 250, 625, 250);
            myGraphic.DrawLine(myPen1, 575, 250, 675, 300);
            myGraphic.DrawLine(myPen1, 625, 300, 675, 300);
            myGraphic.DrawLine(myPen1, 625, 300, 725, 350);
            myGraphic.DrawLine(myPen1, 675, 350, 725, 350);
            myGraphic.DrawLine(myPen1, 675, 350, 775, 400);
            myGraphic.DrawLine(myPen1, 330, 400, 330, 450);
            myGraphic.DrawLine(myPen1, 350, 400, 350, 450);
            myGraphic.DrawLine(myPen1, 430, 400, 430, 450);
            myGraphic.DrawLine(myPen1, 450, 400, 450, 450);
            myGraphic.DrawLine(myPen1, 300, 250, 500, 250);
            myGraphic.DrawLine(myPen1, 386, 320, 414, 320);
            myGraphic.DrawLine(myPen1, 386, 320, 400, 340);
            myGraphic.DrawLine(myPen1, 414, 320, 400, 340);

            //Color
            myGraphic.DrawLine(myPen3, 355, 86, 446, 86);
            myGraphic.DrawLine(myPen3, 357, 88, 444, 88);
            myGraphic.DrawLine(myPen3, 360, 90, 441, 90);
            myGraphic.DrawLine(myPen3, 362, 92, 439, 92);
            myGraphic.DrawLine(myPen3, 366, 94, 435, 94);
            myGraphic.DrawLine(myPen3, 370, 96, 433, 96);
            myGraphic.DrawLine(myPen3, 373, 98, 430, 98);
            myGraphic.DrawLine(myPen3, 376, 100, 428, 100);




            myGraphic.DrawRectangle(myPen1, 300, 450, 50, 50);
            myGraphic.DrawRectangle(myPen1, 400, 450, 50, 50);
            myGraphic.DrawRectangle(myPen1, 300, 226, 200, 124);


            myGraphic.DrawEllipse(myPen2, 325, 275, 50, 50);
            myGraphic.DrawEllipse(myPen2, 425, 275, 50, 50);



            //myGraphic.DrawEllipse(myPen2, 300, 450, 50, 50);
            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            //myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            // myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม
        }
    }
}
