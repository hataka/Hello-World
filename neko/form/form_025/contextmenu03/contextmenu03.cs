// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:47 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_025/contextmenu03/contextmenu03.cs
 * url:  form/form_025/contextmenu03/contextmenu03.cs
 * created: Time-stamp: <2016-08-24 13:14:47 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_25.htm
 * description: 
 *
 *================================================================*/
// contextmenu03.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class contextmenu03
{
    public static void Main()
    {
        MyForm mf = new MyForm();
        Application.Run(mf);
    }
}

class MyForm : Form
{
    Bitmap bmpCat;

    public MyForm()
    {
        Text = "猫でもわかるC#";
        BackColor = SystemColors.Window;

        bmpCat = new Bitmap(GetType(), "contextmenu03.cat.gif");
       

        ContextMenu cm = new ContextMenu();
        ContextMenu = cm;

        MenuItem miFile = new MenuItem();
        miFile.Text = "ファイル(&F)";
        cm.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem("終了(&X)");
        miExit.Click += new EventHandler(miExit_Click);
        miFile.MenuItems.Add(miExit);

        MenuItem miCat = new MenuItem();
        miCat.OwnerDraw = true;
        miCat.MeasureItem += new MeasureItemEventHandler(miCat_MeasureItem);
        miCat.DrawItem += new DrawItemEventHandler(miCat_DrawItem);
        miCat.Click += new EventHandler(miCat_Click);
        miFile.MenuItems.Add(miCat);

        MenuItem miOpen = new MenuItem("開く(&O)");
        miOpen.Click += new EventHandler(miOpen_Click);
        miFile.MenuItems.Add(miOpen);
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    void miOpen_Click(object sender, EventArgs e)
    {
        MessageBox.Show("「開く」が選択されました",
            "猫C#",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    void miCat_MeasureItem(object sender, MeasureItemEventArgs e)
    {
        e.ItemWidth = bmpCat.Width;
        e.ItemHeight = bmpCat.Height;
    }

    void miCat_DrawItem(object sender, DrawItemEventArgs e)
    {
        Rectangle rc = e.Bounds;
        rc.X = (rc.Width - bmpCat.Width) / 2;
        rc.Width = bmpCat.Width;

        Graphics g = e.Graphics;

        e.DrawBackground();
        g.DrawImage(bmpCat, rc);
    }

    void miCat_Click(object sender, EventArgs e)
    {
        MessageBox.Show("猫がクリックされました",
            "猫C#",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}
