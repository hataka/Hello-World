// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:37 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_005/drawstring01/drawstring01.cs
 * url:  form/form_005/drawstring01/drawstring01.cs
 * created: Time-stamp: <2016-08-24 13:14:37 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_05.htm
 * description: 
 *
 *================================================================*/
// drawstring01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class drawstring01
{
    public static void Main()
    {
        Form f = new Form();
				int w = Screen.PrimaryScreen.Bounds.Width;
				int h = Screen.PrimaryScreen.Bounds.Height;
				int width = (int)(w * 0.75);
			  int height = (int)(h * 0.75);
			
			  f.StartPosition = FormStartPosition.CenterScreen;
				f.ClientSize = new Size(width,height);
				f.Text = "猫でもわかるプログラミング";
        f.BackColor = SystemColors.Window;
        f.Paint += new PaintEventHandler(MyHandler);
       
        Application.Run(f);
    }

    static void MyHandler(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Font f = new Font("ＭＳ 明朝", 140);
        g.DrawString("猫", f, Brushes.Red, new PointF(10F, 10F)); 
    }
}
