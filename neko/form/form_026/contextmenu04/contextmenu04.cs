// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:48 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_026/contextmenu04/contextmenu04.cs
 * url:  form/form_026/contextmenu04/contextmenu04.cs
 * created: Time-stamp: <2016-08-24 13:14:48 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_26.htm
 * description: 
 *
 *================================================================*/
// contextmenu04.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class contextmenu04
{
    public static void Main()
    {
        Application.Run(new MyForm());
    }
}

class MyForm : Form
{
    public MyForm()
    {
        Text = "猫でもわかるC#";
        BackColor = SystemColors.Window;

        ContextMenu contextmenu = new ContextMenu();
        ContextMenu = contextmenu;
        
        MenuItem miFile = new MenuItem("ファイル(&F)");
        contextmenu.MenuItems.Add(miFile);

        MyOwnerDraw mo = new MyOwnerDraw();
        miFile.MenuItems.Add(mo);

        MenuItem miExit = new MenuItem("終了(&F)");
        miExit.Click += new EventHandler(miExit_Click);
        miFile.MenuItems.Add(miExit);
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        DialogResult dr;
        dr = MessageBox.Show("本当に終了してもよろしいですか",
            "猫C#",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
        if (dr == DialogResult.Yes)
            e.Cancel = false;
        else
            e.Cancel = true;
    }
}

class MyOwnerDraw : MenuItem
{
    Bitmap bmpcat;

    public MyOwnerDraw()
    {
        bmpcat = new Bitmap(GetType(), "contextmenu04.cat.gif");
        OwnerDraw = true;
    }
    
    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        MessageBox.Show("猫をクリックしたね",
            "猫C#",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk);
    }

    protected override void OnMeasureItem(MeasureItemEventArgs e)
    {
        base.OnMeasureItem(e);

        e.ItemWidth = bmpcat.Width;
        e.ItemHeight = bmpcat.Height;
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        base.OnDrawItem(e);

        Rectangle rc = e.Bounds;
        Graphics g = e.Graphics;

        rc.X = (rc.Width - bmpcat.Width) / 2;
        rc.Width = bmpcat.Width;

        e.DrawBackground();
        g.DrawImage(bmpcat, rc);
    }
}
