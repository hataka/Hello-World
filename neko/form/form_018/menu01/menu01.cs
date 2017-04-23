// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:44 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_018/menu01/menu01.cs
 * url:  form/form_018/menu01/menu01.cs
 * created: Time-stamp: <2016-08-24 13:14:44 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_18.htm
 * description: 
 *
 *================================================================*/
// menu01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class menu01
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        Application.Run(mc);
    }
}

class MyClass : Form
{
    public MyClass()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = SystemColors.Window;

        MenuItem miTest = new MenuItem("テスト(&T)",
            new EventHandler(miTestClick));
        Menu = new MainMenu(new MenuItem[]{miTest});
    }

    void miTestClick(object sender, EventArgs e)
    {
        MessageBox.Show("テスト成功!", "猫でもわかるプログラミング",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
