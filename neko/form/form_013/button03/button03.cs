// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:41 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_013/button03/button03.cs
 * url:  form/form_013/button03/button03.cs
 * created: Time-stamp: <2016-08-24 13:14:41 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_13.htm
 * description: 
 *
 *================================================================*/
// button03.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class button03
{
    public static void Main()
    {
        MyForm mf = new MyForm();

        MyButton mb1 = new MyButton("ボタン１", mf, new Point(10, 10));

        MyButton mb2 = new MyButton("ボタン２", mf, new Point(20 + mb1.Width, 10));

        Application.Run(mf);
    }
}

class MyForm : Form
{
    public MyForm()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = SystemColors.Window;
    }
}

class MyButton : Button
{
    string btnstr;

    public MyButton(string str, Form form, Point pt)
    {
        Text = str;
        Parent = form;
        Location = pt;
        BackColor = SystemColors.Control;
        btnstr = str;
    }
    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        MessageBox.Show(btnstr + "を押したね", "猫でもわかるプログラミング",
            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
}
