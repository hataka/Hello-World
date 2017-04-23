// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:57 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_043/modeless02/modeless02.cs
 * url:  form/form_043/modeless02/modeless02.cs
 * created: Time-stamp: <2016-08-24 13:14:57 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_43.htm
 * description: 
 *
 *================================================================*/
// modeless02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class modeless02 : Form
{
    public static void Main()
    {
        modeless02 form = new modeless02();
        Application.Run(form);
    }

    public modeless02()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        MainMenu mm = new MainMenu();

        MenuItem miFile = new MenuItem("ファイル(&F)");
        mm.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem("終了(&X)");
        miExit.Click += new EventHandler(miExit_Click);
        miFile.MenuItems.Add(miExit);

        MenuItem miOption = new MenuItem("オプション(&O)");
        mm.MenuItems.Add(miOption);

        MenuItem miDlg = new MenuItem("ダイアログを出す(&D)");
        miDlg.Click += new EventHandler(miDlg_Click);
        miOption.MenuItems.Add(miDlg);

        Menu = mm;

        CheckBox cb0 = new CheckBox();
        cb0.Text = "チェックボックス0";
        cb0.Location = new Point(10, 10);
        cb0.Parent = this;
        cb0.CheckedChanged += new EventHandler(cb_CheckedChanged);

        CheckBox cb1 = new CheckBox();
        cb1.Text = "チェックボックス1";
        cb1.Location = new Point(10, 15 + cb0.Height);
        cb1.Parent = this;
        cb1.CheckedChanged += new EventHandler(cb_CheckedChanged);
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    void miDlg_Click(object sender, EventArgs e)
    {
        if (OwnedForms.Length >= 1)
        {
            MessageBox.Show("すでにダイアログは出ています",
                "猫C#", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }
        MyModeless modeless = new MyModeless();
        modeless.Owner = this;
        modeless.Show();
    }

    void cb_CheckedChanged(object sender, EventArgs e)
    {
        if (OwnedForms.Length == 0)
            return;

        for (int i = 0; i < 2; i++)
        {
            if (sender == Controls[i])
            {
                ((CheckBox)OwnedForms[0].Controls[i]).Checked =
                    ((CheckBox)sender).Checked;
                break;
            }

        }

    }
}
