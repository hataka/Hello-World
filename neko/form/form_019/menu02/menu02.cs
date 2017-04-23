// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:44 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_019/menu02/menu02.cs
 * url:  form/form_019/menu02/menu02.cs
 * created: Time-stamp: <2016-08-24 13:14:44 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_19.htm
 * description: 
 *
 *================================================================*/
// menu02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class menu02
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
        Text = "猫でもわかるプログラミング";
        BackColor = SystemColors.Window;

        MenuItem miExit = new MenuItem("終了(&X)",
            new EventHandler(miExitClick));
        MenuItem miSave = new MenuItem("保存(&S)",
            new EventHandler(miSaveClick));

        MenuItem miFile = new MenuItem("ファイル(&F)",
            new MenuItem[] { miSave, miExit });

        Menu = new MainMenu(new MenuItem[] { miFile });
    }

    void miSaveClick(object sender, EventArgs e)
    {
        MessageBox.Show("「保存」が選択されました", Text,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    void miExitClick(object sender, EventArgs e)
    {
        Close();
    }
}
