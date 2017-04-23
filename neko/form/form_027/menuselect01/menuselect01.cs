// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:48 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_027/menuselect01/menuselect01.cs
 * url:  form/form_027/menuselect01/menuselect01.cs
 * created: Time-stamp: <2016-08-24 13:14:48 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_27.htm
 * description: 
 *
 *================================================================*/
// menuselect01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class menuselect01 : Form
{
    Bitmap bmp, bmp1, bmp2;
    int nBmp;
    MenuItem miCat1, miCat2, miZero; 

    public static void Main()
    {
        menuselect01 ms = new menuselect01();
        Application.Run(ms);
    }

    public menuselect01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        bmp1 = new Bitmap(GetType(), "menuselect01.cat1.gif");
        bmp2 = new Bitmap(GetType(), "menuselect01.cat2.gif");
        bmp = null;
        nBmp = 0;

        miCat1 = new MenuItem("猫１");
        miCat1.Click += new EventHandler(miCat1_Click);

        miCat2 = new MenuItem("猫２");
        miCat2.Click += new EventHandler(miCat2_Click);

        miZero = new MenuItem("画像なし");
        miZero.Click += new EventHandler(miZero_Click);

        MenuItem miLine = new MenuItem("-");

        MenuItem miExit = new MenuItem("終了(&X)");
        miExit.Click += new EventHandler(miExit_Click);

        MenuItem miFile = new MenuItem("ファイル(&F)",
            new MenuItem[] { miCat1, miCat2, miZero, miLine, miExit });
        miFile.Select += new EventHandler(miFile_Select);

        Menu = new MainMenu(new MenuItem[] { miFile });

    }

    void miFile_Select(object sender, EventArgs e)
    {
        miCat1.Visible = true;
        miCat2.Visible = true;
        miZero.Visible = true;

        switch (nBmp)
        {
            case 0:
                miZero.Visible = false;
                break;
            case 1:
                miCat1.Visible = false;
                break;
            case 2:
                miCat2.Visible = false;
                break;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (nBmp != 0)
        {
            Graphics g = e.Graphics;
            
            Rectangle rc = new Rectangle();
            rc.X = (ClientRectangle.Width - bmp.Width) / 2;
            rc.Y = (ClientRectangle.Height - bmp.Height) / 2;
            rc.Width = bmp.Width;
            rc.Height = bmp.Height;
            g.DrawImage(bmp, rc);
        }
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        Invalidate();
    }

    void miCat1_Click(object sender, EventArgs e)
    {
        bmp = bmp1;
        nBmp = 1;
        Invalidate();
    }

    void miCat2_Click(object sender, EventArgs e)
    {
        bmp = bmp2;
        nBmp = 2;
        Invalidate();
    }

    void miZero_Click(object sender, EventArgs e)
    {
        nBmp = 0;
        Invalidate();
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
