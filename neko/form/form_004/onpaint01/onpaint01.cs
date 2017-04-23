// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:36 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_004/onpaint01/onpaint01.cs
 * url:  form/form_004/onpaint01/onpaint01.cs
 * created: Time-stamp: <2016-08-24 13:14:36 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_04.htm
 * description: 
 *
 *================================================================*/
// onpaint01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class onpaint01 : Form
{
    public static void Main()
    {
        onpaint01 myform = new onpaint01();
        Application.Run(myform);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.DrawLine(new Pen(Color.Yellow, 5F),
            new Point(10, 50), new Point(180, 50));
    }

    public onpaint01()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = Color.Green;
    }
}
