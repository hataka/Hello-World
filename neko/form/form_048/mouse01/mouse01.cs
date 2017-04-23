// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:00 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_048/mouse01/mouse01.cs
 * url:  form/form_048/mouse01/mouse01.cs
 * created: Time-stamp: <2016-08-24 13:15:00 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_48.htm
 * description: 
 *
 *================================================================*/
// mouse01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class mouse01
{
    public static void Main()
    {
        Application.Run(new MyForm());
    }
}

class MyForm : Form
{
    string str = "";

    public MyForm()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.DrawString(str, Font, new SolidBrush(ForeColor),
            new PointF(10F, 10F));
    }


    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        str = string.Format("({0}, {1})", e.X, e.Y);
        str += "[MouseDown]";
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        str = string.Format("({0}, {1})", e.X, e.Y);
        str += "[MouseUp]";
        Invalidate();
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        Text = string.Format("MouseMove[({0}, {1})]", e.X, e.Y);
    }
}
