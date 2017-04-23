// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:46 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_022/menu05/menu05.cs
 * url:  form/form_022/menu05/menu05.cs
 * created: Time-stamp: <2016-08-24 13:14:46 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_22.htm
 * description: 
 *
 *================================================================*/
// menu05.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class menu05 : Form
{
    static string Title = "猫でもわかるプログラミング";

    public static void Main()
    {
        menu05 m5 = new menu05();
        Application.Run(m5);
    }

    public menu05()
    {
        Text = Title;
        BackColor = SystemColors.Window;

        EventHandler eh = new EventHandler(OnMyClick);

        MainMenu mm = new MainMenu();
        Menu = mm;

        MenuItem miFile = new MenuItem();
        miFile.Text = "ファイル(&F)";
        miFile.Index = 0;
        mm.MenuItems.Add(miFile);

        MenuItem miEdit = new MenuItem();
        miEdit.Text = "編集(&E)";
        miEdit.Index = 1;
        mm.MenuItems.Add(miEdit);

        MenuItem miOpen = new MenuItem();
        miOpen.Text = "開く(&O)";
        miOpen.Index = 0;
        miOpen.Click += eh;
        miOpen.Shortcut = Shortcut.CtrlO;
        miFile.MenuItems.Add(miOpen);

        MenuItem miExit = new MenuItem();
        miExit.Text = "終了(&X)";
        miExit.Index = 1;
        miExit.Click += eh;
        miFile.MenuItems.Add(miExit);

        MenuItem miCopy = new MenuItem();
        miCopy.Text = "コピー(&C)";
        miCopy.Index = 0;
        miCopy.Click += eh;
        miCopy.Shortcut = Shortcut.CtrlC;
        miEdit.MenuItems.Add(miCopy);
    }

    static void OnMyClick(object sender, EventArgs e)
    {
        MessageBox.Show(((MenuItem)sender).Text,
            Title,
            MessageBoxButtons.OK, 
            MessageBoxIcon.Asterisk);
    }
}
