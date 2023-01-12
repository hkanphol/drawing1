using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();


            Pen myPen1 = new Pen(System.Drawing.Color.Aqua, 5);
            Pen myPen2 = new Pen(System.Drawing.Color.Coral, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.DarkCyan, 5);

            //myGraphic.DrawLine(myPen1, 25, 50, 200, 50); //จุดเร่ิ่ม จุดสิ้นสุด 
            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            //myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            //myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม

            //กล่องของวัญ
            myGraphic.DrawLine(myPen1, 40, 146, 216, 146);
            myGraphic.DrawLine(myPen1, 40, 146, 40, 173);
            myGraphic.DrawLine(myPen1, 40, 173, 216, 173);
            myGraphic.DrawLine(myPen1, 216, 146, 216, 173);
            myGraphic.DrawLine(myPen1, 70, 173, 70, 253);
            myGraphic.DrawLine(myPen1, 70, 253, 195, 253);
            myGraphic.DrawLine(myPen1, 195, 173, 195, 253);
            myGraphic.DrawLine(myPen1, 70, 200, 195, 200);
            myGraphic.DrawLine(myPen1, 130, 173, 130, 253);
            myGraphic.DrawLine(myPen1, 128, 146, 73, 117);
            myGraphic.DrawLine(myPen1, 73, 117, 102, 117);
            myGraphic.DrawLine(myPen1, 124, 146, 102, 117);
            myGraphic.DrawLine(myPen1, 124, 146, 124, 117);
            myGraphic.DrawLine(myPen1, 124, 117, 157, 117);
            myGraphic.DrawLine(myPen1, 124, 146, 157, 117);

            //HNY
            //H
            myGraphic.DrawLine(myPen2, 300, 27, 300, 97);
            myGraphic.DrawLine(myPen2, 300, 62, 341, 62);
            myGraphic.DrawLine(myPen2, 341, 27, 341, 97);
            //N
            myGraphic.DrawLine(myPen2, 378, 26, 378, 97);
            myGraphic.DrawLine(myPen2, 378, 26, 420, 93);
            myGraphic.DrawLine(myPen2, 420, 26, 420, 93);
            //Y
            myGraphic.DrawLine(myPen2, 442, 26, 471, 64);
            myGraphic.DrawLine(myPen2, 492, 26, 471, 64);
            myGraphic.DrawLine(myPen2, 471, 64, 471, 95);

            //2023
            //2
            myGraphic.DrawLine(myPen2, 14, 324, 60, 324);
            myGraphic.DrawLine(myPen2, 14, 349, 60, 349);
            myGraphic.DrawLine(myPen2, 14, 371, 60, 371);
            myGraphic.DrawLine(myPen2, 60, 324, 60, 349);
            myGraphic.DrawLine(myPen2, 14, 349, 14, 371);

            //0
            myGraphic.DrawLine(myPen2, 72, 324, 110, 324);
            myGraphic.DrawLine(myPen2, 72, 324, 72, 371);
            myGraphic.DrawLine(myPen2, 72, 371, 110, 371);
            myGraphic.DrawLine(myPen2, 110, 324, 110, 371);

            //2
            myGraphic.DrawLine(myPen2, 121, 324, 170, 324);
            myGraphic.DrawLine(myPen2, 121, 347, 170, 347);
            myGraphic.DrawLine(myPen2, 121, 371, 170, 371);
            myGraphic.DrawLine(myPen2, 170, 324, 170, 347);
            myGraphic.DrawLine(myPen2, 121, 347, 121, 371);

            //3
            myGraphic.DrawLine(myPen2, 180, 324, 230, 324);
            myGraphic.DrawLine(myPen2, 180, 347, 230, 347);
            myGraphic.DrawLine(myPen2, 180, 371, 230, 371);
            myGraphic.DrawLine(myPen2, 230, 324, 230, 371);

            //คริสมาสต์
            myGraphic.DrawLine(myPen1, 380, 404, 380, 351);
            myGraphic.DrawLine(myPen1, 420, 404, 420, 351);
            myGraphic.DrawLine(myPen1, 260, 351, 530, 351);
            myGraphic.DrawLine(myPen1, 260, 351, 350, 276);
            myGraphic.DrawLine(myPen1, 290, 276, 350, 276);
            myGraphic.DrawLine(myPen1, 290, 276, 370, 210);
            myGraphic.DrawLine(myPen1, 370, 210, 320, 210);
            myGraphic.DrawLine(myPen1, 320, 210, 400, 148);
            myGraphic.DrawLine(myPen1, 530, 351, 425, 280);
            myGraphic.DrawLine(myPen1, 420, 280, 495, 280);
            myGraphic.DrawLine(myPen1, 495, 285, 445, 209);
            myGraphic.DrawLine(myPen1, 440, 207, 490, 207);
            myGraphic.DrawLine(myPen1, 490, 203, 393, 148);

            //ดาว
            myGraphic.DrawLine(myPen1, 355, 148, 362, 116);
            myGraphic.DrawLine(myPen1, 343, 129, 376, 149);
            myGraphic.DrawLine(myPen1, 350, 148, 380, 129);
            myGraphic.DrawLine(myPen1, 380, 129, 343, 129);
            myGraphic.DrawLine(myPen1, 362, 116, 376, 149);

        }
    }
}
