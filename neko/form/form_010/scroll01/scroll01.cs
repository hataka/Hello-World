// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:39 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_010/scroll01/scroll01.cs
 * url:  form/form_010/scroll01/scroll01.cs
 * created: Time-stamp: <2016-08-24 13:14:39 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_10.htm
 * description: 
 *
 *================================================================*/
// scroll01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class scroll01 : Form
{
    string str = "今日はよい天気です。\n" +
        "明日もよい天気でしょう。\n" +
        "しかし明後日はどうなるかどうなるかわかりません。\n" +
        "明日は明日の風が吹きます。";
    Font font;

    public static void Main()
    {
        scroll01 s1 = new scroll01();

        Application.Run(s1);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        
        StringFormat strformat = new StringFormat();
        strformat.Alignment = StringAlignment.Near;
        Point pt = AutoScrollPosition;

        g.DrawString(str, font, Brushes.Black, pt.X, pt.Y, strformat);
    }


    public scroll01()
    {
        Size size = new Size();

        Text = "猫でもわかるプログラミング";
        BackColor = SystemColors.Window;
        font = new Font("ＭＳ ゴシック", 14);
        AutoScroll = true;

        Graphics g = CreateGraphics();
        SizeF s = g.MeasureString(str, font);
        size.Width = (int)s.Width;
        size.Height = (int)s.Height;
        AutoScrollMinSize = size;
        g.Dispose();
    }
}
