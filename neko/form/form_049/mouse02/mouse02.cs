// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:01 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_049/mouse02/mouse02.cs
 * url:  form/form_049/mouse02/mouse02.cs
 * created: Time-stamp: <2016-08-24 13:15:01 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_49.htm
 * description: 
 *
 *================================================================*/
// mouse02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class mouse02 : Form
{
    static Point[] pt;
    bool bStart;

    public static void Main()
    {
        Application.Run(new mouse02());
    }

    public mouse02()
    {
        bStart = false;
        pt = new Point[2];
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
        MouseDown += new MouseEventHandler(mouse02_MouseDown);
        MouseUp += new MouseEventHandler(mouse02_MouseUp);
        MouseMove += new MouseEventHandler(mouse02_MouseMove);
    }

    void mouse02_MouseDown(object sender, MouseEventArgs e)
    {
        bStart = true;
        pt[0] = e.Location;
    }

    void mouse02_MouseUp(object sender, MouseEventArgs e)
    {
        bStart = false;
    }

    void mouse02_MouseMove(object sender, MouseEventArgs e)
    {
        if (bStart)
        {
            Graphics g = CreateGraphics();
            pt[1] = e.Location;

            g.DrawLine(new Pen(new SolidBrush(Color.Red)), pt[0], pt[1]);
            g.Dispose();
        }
    }
}
