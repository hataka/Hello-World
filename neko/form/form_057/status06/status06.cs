// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:05 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_057/status06/status06.cs
 * url:  form/form_057/status06/status06.cs
 * created: Time-stamp: <2016-08-24 13:15:05 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_57.htm
 * description: 
 *
 *================================================================*/
// status06.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class status06 : Form
{
    StatusBarPanel sb1, sb2;

    public static void Main()
    {
        Application.Run(new status06());
    }

    public status06()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        StatusBar sb = new StatusBar();
        sb.Parent = this;
        sb.ShowPanels = true;
        sb1 = new StatusBarPanel();
        sb2 = new StatusBarPanel();
        sb1.AutoSize = StatusBarPanelAutoSize.Contents;
        sb2.AutoSize = StatusBarPanelAutoSize.Spring;

        sb.Panels.Add(sb1);
        sb.Panels.Add(sb2);

        MenuItem miFile = new MenuItem("ファイル(&F)");
        MenuItem miEdit = new MenuItem("編集(&E)");

        MainMenu mm = new MainMenu();
        Menu = mm;

        mm.MenuItems.Add(miFile);
        mm.MenuItems.Add(miEdit);

        MenuItem miNew = new MenuItem("新規作成(&N)");
        miNew.Click += new EventHandler(miNew_Click);
        miNew.Select += new EventHandler(miNew_Select);
        miFile.MenuItems.Add(miNew);

        MenuItem miExit = new MenuItem("終了(&X)");
        miExit.Click += new EventHandler(miExit_Click);
        miExit.Select += new EventHandler(miExit_Select);
        miFile.MenuItems.Add(miExit);

        MenuItem miCopy = new MenuItem("コピー(&C)");
        miCopy.Click += new EventHandler(miCopy_Click);
        miCopy.Select += new EventHandler(miCopy_Select);
        miEdit.MenuItems.Add(miCopy);
    }

    void miNew_Select(object sender, EventArgs e)
    {
        sb1.Text = "新規に作成します";
    }

    void miNew_Click(object sender, EventArgs e)
    {
        MessageBox.Show("「新規作成」が選択されました",
            "猫でもわかるC#プログラミング",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    void miExit_Select(object sender, EventArgs e)
    {
        sb1.Text = "このプログラムを終了します";
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    void miCopy_Select(object sender, EventArgs e)
    {
        sb1.Text = "コピーします";
    }

    void miCopy_Click(object sender, EventArgs e)
    {
        MessageBox.Show("「コピー」が選択されました",
            "猫でもわかるC#プログラミング",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    protected override void OnMenuComplete(EventArgs e)
    {
        base.OnMenuComplete(e);
        sb1.Text = "";
    }
}
