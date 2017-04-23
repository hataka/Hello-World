// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:37 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_006/drawstring02/drawstring02.cs
 * url:  form/form_006/drawstring02/drawstring02.cs
 * created: Time-stamp: <2016-08-24 13:14:37 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_06.htm
 * description: 
 *
 *================================================================*/
// drawstring02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class drawstring02 : Form
{
    public static void Main()
    {
        drawstring02 d2 = new drawstring02();

        Application.Run(d2);
    }

    public drawstring02()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        string str = "今日はよい天気です。\n" +
            "しかし明日もよい天気かどうかはわかりません。" +
            "明日は、明日の風が吹きます。";
        Font ft = new Font("ＭＳ ゴシック", 20);
        RectangleF rf = new RectangleF(10F, 10F, 230F, 200F);
        g.DrawRectangle(new Pen(Color.Blue), 10, 10, 230, 200 );
        g.DrawString(str, ft, Brushes.Black, rf); 
    }
}
