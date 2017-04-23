// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:38 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_008/application01/application01.cs
 * url:  form/form_008/application01/application01.cs
 * created: Time-stamp: <2016-08-24 13:14:38 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_08.htm
 * description: 
 *
 *================================================================*/
// application01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class application01
{
    public static void Main()
    {
        MyForm mf = new MyForm();
        Application.Run(mf);
    }
}

class MyForm : Form
{
    public MyForm()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = SystemColors.Window;
        Width = 790;
        Height = 180;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        String cul = Application.CurrentCulture.EnglishName;
        String path = Application.ExecutablePath;
        String start = Application.StartupPath;
        String comp = Application.CompanyName;

        Font font = new Font("ＭＳ ゴシック", 12);

        g.DrawString(cul, font, Brushes.Black, 10F, 10F);
        g.DrawString(path, font, Brushes.Black, 10F, 30F);
        g.DrawString(start, font, Brushes.Black, 10F, 50F);
        g.DrawString(comp, font, Brushes.Black, 10F, 70F);
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        Application.Exit();
    }
}
