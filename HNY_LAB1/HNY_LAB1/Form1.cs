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
            Pen myPen2 = new Pen(System.Drawing.Color.DarkGreen, 5);
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

            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            //myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            // myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม
        }
    }
}
