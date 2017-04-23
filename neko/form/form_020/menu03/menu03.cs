// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:45 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_020/menu03/menu03.cs
 * url:  form/form_020/menu03/menu03.cs
 * created: Time-stamp: <2016-08-24 13:14:45 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_20.htm
 * description: 
 *
 *================================================================*/
// menu03.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class menu03
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

        MenuItem miOpen = new MenuItem("開く(&O)",
            new EventHandler(miOpenClick),
            Shortcut.CtrlO);
        MenuItem miAllSave = new MenuItem("すべてを保存(&L)",
            new EventHandler(miAllSaveClick),
            Shortcut.CtrlShiftS);

        MenuItem miFile = new MenuItem("ファイル(&F)",
            new MenuItem[] { miOpen, miAllSave });

        Menu = new MainMenu(new MenuItem[] { miFile });
    }

    void miOpenClick(object sender, EventArgs e)
    {
        MessageBox.Show("「開く」が選択されました",
            Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    void miAllSaveClick(object sender, EventArgs e)
    {
        MessageBox.Show("「すべてを保存」が選択されました",
            Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
