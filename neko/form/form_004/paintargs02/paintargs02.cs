// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:36 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_004/paintargs02/paintargs02.cs
 * url:  form/form_004/paintargs02/paintargs02.cs
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
// paintargs02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class paintargs02 : Form
{
    public static void Main()
    {
        paintargs02 p = new paintargs02();
        Application.Run(p);
    }

    public static void OnMyHandler(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.DrawLine(new Pen(Color.Red), 10, 100, 200, 100);
    }

    public paintargs02()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = Color.Pink;
        Paint += new PaintEventHandler(OnMyHandler);
    }
}
