// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:51 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_032/dock01/dock01.cs
 * url:  form/form_032/dock01/dock01.cs
 * created: Time-stamp: <2016-08-24 13:14:51 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_32.htm
 * description: 
 *
 *================================================================*/
// dock01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class dock01
{
    public static void Main()
    {
        MyForm mf = new MyForm();

        MyTextBox mt = new MyTextBox();
        mt.Parent = mf;

        MyButton mb1 = new MyButton();
        mb1.Parent = mf;

        MyClsButton mcls = new MyClsButton();
        mcls.Parent = mf;
        
        Application.Run(mf);
    }
}

class MyForm : Form
{
    public MyForm()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
    }
}

class MyButton : Button
{
    public MyButton()
    {
        Text = "押す";
        BackColor = SystemColors.Control;
        Dock = DockStyle.Bottom;
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        MessageBox.Show(Parent.Controls[0].Text,
            "猫C#",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}

class MyClsButton : Button
{
    public MyClsButton()
    {
        Text = "消す";
        BackColor = SystemColors.Control;
        Dock = DockStyle.Bottom;
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        Parent.Controls[0].Text = "";
        Parent.Controls[0].Focus();
    }
}

class MyTextBox : TextBox
{
    public MyTextBox()
    {
        Dock = DockStyle.Top;
        Font = new Font("ＭＳ ゴシック", 26);
    }
}
