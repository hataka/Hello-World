// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:45 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_021/menu04/menu04.cs
 * url:  form/form_021/menu04/menu04.cs
 * created: Time-stamp: <2016-08-24 13:14:45 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_21.htm
 * description: 
 *
 *================================================================*/
// menu04.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class menu04
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "猫でもわかるプログラミング";
        fm.BackColor = SystemColors.Window;

        EventHandler evh = new EventHandler(OnEvent);

        MenuItem miNew = new MenuItem("新規(&N)", evh, Shortcut.CtrlN);
        MenuItem miOpen = new MenuItem("開く(&O)", evh);
        MenuItem miExit = new MenuItem("終了(&X)", evh);

        MenuItem[] mis = new MenuItem[]{miNew, miOpen, miExit};

        MenuItem miFile = new MenuItem("ファイル(&F)", mis);

        fm.Menu = new MainMenu(new MenuItem[]{miFile});

        Application.Run(fm);
    }

    static void OnEvent(object sender, EventArgs e)
    {
        MenuItem mi = (MenuItem)sender;

        MessageBox.Show(mi.Text, "猫でもわかるプログラミング",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
}
