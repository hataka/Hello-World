// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:59 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_046/key01/key01.cs
 * url:  form/form_046/key01/key01.cs
 * created: Time-stamp: <2016-08-24 13:14:59 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_46.htm
 * description: 
 *
 *================================================================*/
// key01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class key01 : Form
{
    string str = "";

    public static void Main()
    {
        Application.Run(new key01());
    }

    public key01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);
        str = "KeyCode: " + e.KeyCode.ToString() + "\n";
        str += "KeyValue: " + e.KeyValue.ToString() + "\n";
        str += "KeyData: " + e.KeyData.ToString() + "\n";

        Invalidate();
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        str += "KeyChar: " + e.KeyChar;

        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.DrawString(str, Font, new SolidBrush(ForeColor), new PointF(10f, 10f));
    }
}
