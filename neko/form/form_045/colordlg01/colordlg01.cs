// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:58 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_045/colordlg01/colordlg01.cs
 * url:  form/form_045/colordlg01/colordlg01.cs
 * created: Time-stamp: <2016-08-24 13:14:58 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_45.htm
 * description: 
 *
 *================================================================*/
// colordlg01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class colordlg01 : Form
{
    int[] custom = null;

    public static void Main()
    {
        Application.Run(new colordlg01());
    }

    public colordlg01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        Menu = new MainMenu();

        MenuItem miFile = new MenuItem("ファイル(&F)");
        Menu.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem("終了(&X)");
        miExit.Click += new EventHandler(miExit_Click);
        miFile.MenuItems.Add(miExit);

        MenuItem miOption = new MenuItem("オプション(&O)");
        Menu.MenuItems.Add(miOption);

        MenuItem miColor = new MenuItem("色の選択(&C)");
        miColor.Click += new EventHandler(miColor_Click);
        miOption.MenuItems.Add(miColor);
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    void miColor_Click(object sender, EventArgs e)
    {
        MyColorDlg mcd = new MyColorDlg();
        mcd.Color = ForeColor;
        mcd.CustomColors = custom;

        DialogResult dr = mcd.ShowDialog();
        if (dr == DialogResult.OK)
        {
            ForeColor = mcd.Color;
            custom = mcd.CustomColors;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.DrawString("猫でもわかる\nC#プログラミング",
            new Font("ＭＳ ゴシック", 24),
            new SolidBrush(ForeColor),
            new PointF(10f, 10f)
        );
    }
}
