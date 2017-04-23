// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:55 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_039/dialog01/dialog01.cs
 * url:  form/form_039/dialog01/dialog01.cs
 * created: Time-stamp: <2016-08-24 13:14:55 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_39.htm
 * description: 
 *
 *================================================================*/
// dialog01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class dialog01 : Form
{
    public static void Main()
    {
        Application.Run(new dialog01());
    }

    public dialog01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        MainMenu mm = new MainMenu();
        Menu = mm;

        MenuItem miFile = new MenuItem();
        miFile.Text = "ファイル(&F)";
        mm.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem();
        miExit.Text = "終了(&X)";
        miExit.Click += new EventHandler(miExit_Click);
        miFile.MenuItems.Add(miExit);

        MenuItem miOption = new MenuItem();
        miOption.Text = "オプション(&O)";
        mm.MenuItems.Add(miOption);

        MenuItem miDialog = new MenuItem();
        miDialog.Text = "ダイアログボックスを出す(&D)";
        miDialog.Click += new EventHandler(miDialog_Click);
        miOption.MenuItems.Add(miDialog);
    }

    void miDialog_Click(object sender, EventArgs e)
    {
        MyDialog mydlg = new MyDialog();
        mydlg.ShowDialog();
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}

class MyDialog : Form
{
    public MyDialog()
    {
        Text = "ダイアログボックス";

        FormBorderStyle = FormBorderStyle.FixedDialog;
        ControlBox = false;
        ShowInTaskbar = false;
        MaximizeBox = false;
        MinimizeBox = false;

        Button btnOK = new Button();
        btnOK.Text = "OK";
        btnOK.Parent = this;
        btnOK.Location = 
            new Point((ClientSize.Width - btnOK.Width) / 2,
            ClientSize.Height - btnOK.Height - 10);
        btnOK.DialogResult = DialogResult.OK;
    }
}
