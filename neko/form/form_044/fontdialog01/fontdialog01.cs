// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:58 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_044/fontdialog01/fontdialog01.cs
 * url:  form/form_044/fontdialog01/fontdialog01.cs
 * created: Time-stamp: <2016-08-24 13:14:58 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_44.htm
 * description: 
 *
 *================================================================*/
// fontdialog01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class fontdialog01 : Form
{
    public static void Main()
    {
        Application.Run(new fontdialog01());
    }

    public fontdialog01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        MainMenu mm = new MainMenu();

        MenuItem miFile = new MenuItem("ファイル(&F)");
        mm.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem("終了(&X)");
        miExit.Click += new EventHandler(miExit_Click);
        miFile.MenuItems.Add(miExit);

        MenuItem miView = new MenuItem("表示(&V)");
        mm.MenuItems.Add(miView);

        MenuItem miFont = new MenuItem("フォント(&F)");
        miFont.Click += new EventHandler(miFont_Click);
        miView.MenuItems.Add(miFont);

        Menu = mm;
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    void miFont_Click(object sender, EventArgs e)
    {
        MyFontDialog fontdlg = new MyFontDialog(this);

        DialogResult dr = fontdlg.ShowDialog();
        if (dr == DialogResult.OK)
        {
            Font = fontdlg.Font;
            ForeColor = fontdlg.Color;
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.DrawString("猫でもわかるC#",
            Font,
            new SolidBrush(ForeColor),
            new PointF(10f, 10f));
    }
}
