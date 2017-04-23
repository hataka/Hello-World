// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:35 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_003/paintargs01/paintargs01.cs
 * url:  form/form_003/paintargs01/paintargs01.cs
 * created: Time-stamp: <2016-08-24 13:14:35 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_03.htm
 * description: 
 *
 *================================================================*/
// paintargs01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class paintargs01
{
    public static void Main()
    {
        Form f = new Form();
        f.Text = "猫でもわかるプログラミング";
        f.BackColor = Color.White;

        f.Paint += new PaintEventHandler(MyHandler);

        Application.Run(f);
    }

    static void MyHandler(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.DrawLine(new Pen(Color.Red), 10, 50, 280, 50);
    }
}
