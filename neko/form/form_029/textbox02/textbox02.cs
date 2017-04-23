// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:49 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_029/textbox02/textbox02.cs
 * url:  form/form_029/textbox02/textbox02.cs
 * created: Time-stamp: <2016-08-24 13:14:49 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_29.htm
 * description: 
 *
 *================================================================*/
// textbox02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class textbox02
{
    public static void Main()
    {
        MyForm mf = new MyForm();

        Point pt1 = new Point(10, 10);
        MyTextBox mt = new MyTextBox(mf, pt1);

        Point pt2 = new Point(10, 20 + mt.Height);
        MyButton mb = new MyButton(mf, mt, pt2);

        Point pt3 = new Point(20 + mb.Width, 20 + mt.Height);
        MyClearButton mc = new MyClearButton(mf, mt, pt3);

        Size sz = new Size(30 + mb.Width + mc.Width, 30 + mt.Height + mb.Height);
        mf.ClientSize = sz;
        mf.FormBorderStyle = FormBorderStyle.FixedSingle;
        mf.MaximizeBox = false;
        mf.MinimizeBox = false;

        Application.Run(mf);
    }
}

class MyTextBox : TextBox
{
    public MyTextBox(Form parent, Point pt)
    {
        Parent = parent;
        Location = pt;
    }
}

class MyButton : Button
{
    TextBox txtbox;

    public MyButton(Form parent, TextBox tb, Point pt)
    {
        txtbox = tb;

        Parent = parent;
        Location = pt;
        Text = "押す";
        BackColor = SystemColors.Control;
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        MessageBox.Show(txtbox.Text, "猫C#",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        txtbox.Focus();
    }
}

class MyClearButton : Button
{
    TextBox txtbox;

    public MyClearButton(Form p, TextBox t, Point pt)
    {
        Parent = p;
        txtbox = t;
        Location = pt;
        BackColor = SystemColors.Control;
        Text = "消す";
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        txtbox.Clear();
        txtbox.Focus();
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
