using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surname
{
    public partial class FormFIO : Form
    {
        public FormFIO()
        {
            InitializeComponent();
        }

        private void FormName_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen penLemonChiffon = new Pen(Color.LemonChiffon, 3);
            Pen penMintCream = new Pen(Color.MintCream, 3);
            Pen penOldLace = new Pen(Color.OldLace, 3);
            Pen penNavajoWhite = new Pen(Color.NavajoWhite, 3);
            Pen penMistyRose = new Pen(Color.MistyRose, 3);
            gr.DrawLine(penLemonChiffon, 20, 10, 70, 80); //X
            gr.DrawLine(penLemonChiffon, 20, 80, 70, 10);//X
            gr.DrawLine(penLemonChiffon, 165, 15, 165, 80);//T
            gr.DrawLine(penLemonChiffon, 140, 10, 190, 10);//T
            gr.DrawLine(penOldLace, 210, 27, 210, 80);//I
            gr.DrawLine(penLemonChiffon, 235, 10, 235, 80);//H
            gr.DrawLine(penLemonChiffon, 235, 40, 270, 40);//H
            gr.DrawLine(penLemonChiffon, 270, 10, 270, 80);//H
            gr.DrawLine(penMintCream, 295, 10, 295, 80);//Ь
            gr.DrawEllipse(new Pen(Brushes.MistyRose, 3), 80, 10, 50, 70); //O
            gr.DrawEllipse(new Pen(Brushes.OldLace, 3), 206, 10, 10, 10);//I
            gr.DrawArc(new Pen(Brushes.MintCream, 3), 180, 40, 140, 40, -20, 40);//Ь
            gr.DrawLine(penNavajoWhite, 20, 110, 20, 180);//K
            gr.DrawLine(penNavajoWhite, 20, 150, 55, 110);//K
            gr.DrawLine(penNavajoWhite, 30, 135, 60, 180);//K
            gr.DrawLine(penLemonChiffon, 100, 110, 85, 180);//A
            gr.DrawLine(penLemonChiffon, 100, 110, 115, 180);//A
            gr.DrawLine(penLemonChiffon, 93, 150, 107, 150);//A
            gr.DrawLine(penMintCream, 140, 110, 140, 180);//P
            gr.DrawArc(new Pen(Brushes.MintCream, 3), 30, 110, 140, 40, -20, 40);//P
            gr.DrawLine(penLemonChiffon, 190, 110, 190, 180);//И
            gr.DrawLine(penLemonChiffon, 190, 180, 220, 110);//И
            gr.DrawLine(penLemonChiffon, 220, 110, 220, 180);//И
            gr.DrawLine(penMistyRose, 245, 110, 245, 180);//H
            gr.DrawLine(penMistyRose, 245, 140, 275, 140);//H
            gr.DrawLine(penMistyRose, 275, 110, 275, 180);//H
            gr.DrawLine(penLemonChiffon, 305, 110, 295, 180);//A
            gr.DrawLine(penLemonChiffon, 300, 150, 315, 150);//A
            gr.DrawLine(penLemonChiffon, 305, 110, 320, 180);//A
            gr.DrawLine(penOldLace, 20, 210, 20, 280);//Ю
            gr.DrawLine(penOldLace, 20, 240, 40, 240);//Ю
            gr.DrawEllipse(new Pen(Brushes.OldLace, 3), 40, 210, 30, 70); //Ю
            gr.DrawLine(penLemonChiffon, 90, 210, 90, 280);//P
            gr.DrawArc(new Pen(Brushes.LemonChiffon, 3),0, 210, 110, 40, -20, 40);//P
            gr.DrawLine(penMistyRose, 130, 230, 130, 280);//I
            gr.DrawEllipse(new Pen(Brushes.MistyRose, 3), 125, 210, 10, 10);//I
            gr.DrawLine(penLemonChiffon, 165, 230, 165, 280);//Ї
            gr.DrawEllipse(new Pen(Brushes.LemonChiffon, 3), 150, 210, 10, 10);//Ї
            gr.DrawEllipse(new Pen(Brushes.LemonChiffon, 3), 170, 210, 10, 10);//Ї
            gr.DrawLine(penNavajoWhite, 200, 210, 200, 280);//В
            gr.DrawArc(new Pen(Brushes.NavajoWhite, 3), 80, 210, 150, 40, -20, 40);//В
            gr.DrawArc(new Pen(Brushes.NavajoWhite, 3), 80, 240, 150, 40, -20, 40);//В
            gr.DrawLine(penLemonChiffon, 255, 210, 255, 280);//H
            gr.DrawLine(penLemonChiffon, 255, 240, 285, 240);//H
            gr.DrawLine(penLemonChiffon, 285, 210, 285, 280);//H
            gr.DrawLine(penMintCream, 320, 210, 307, 280);//A
            gr.DrawLine(penMintCream, 310, 250, 325, 250);//A
            gr.DrawLine(penMintCream, 320, 210, 330, 280);//A

        }
    }
}