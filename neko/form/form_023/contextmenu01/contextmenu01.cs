// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:46 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_023/contextmenu01/contextmenu01.cs
 * url:  form/form_023/contextmenu01/contextmenu01.cs
 * created: Time-stamp: <2016-08-24 13:14:46 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_23.htm
 * description: 
 *
 *================================================================*/
// contextmenu01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class contextmenu01
{
    public static void Main()
    {
        MyForm mf = new MyForm();
        Application.Run(mf);
    }
}

class MyForm : Form
{
    string strTitle;

    public MyForm()
    {
        strTitle = "猫でもわかるプログラミング";

        Text = strTitle;
        BackColor = SystemColors.Window;

        ContextMenu cm = new ContextMenu();
        ContextMenu = cm;

        MenuItem miFile = new MenuItem("ファイル(&F)");
        cm.MenuItems.Add(miFile);

        MenuItem miOpen = new MenuItem("開く(&O)");
        miOpen.Shortcut = Shortcut.CtrlO;
        miOpen.Click += new EventHandler(miOpen_Click);
        miFile.MenuItems.Add(miOpen);

        MenuItem miLine = new MenuItem("-");
        miFile.MenuItems.Add(miLine);

        MenuItem miExit = new MenuItem("終了(&X)");
        miExit.Click += new EventHandler(miExit_Click);
        miFile.MenuItems.Add(miExit);

        
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    void miOpen_Click(object sender, EventArgs e)
    {
        MessageBox.Show("「開く」が選択されました",
            strTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    protected override void  OnFormClosing(FormClosingEventArgs e)
    {
 	    base.OnFormClosing(e);

        DialogResult dr;
        dr = MessageBox.Show("終了してもよろしいですか",
            strTitle, MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (dr == DialogResult.Yes)
            e.Cancel = false;
        else
            e.Cancel = true;

    }
}
