// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:52 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_033/label01/label01.cs
 * url:  form/form_033/label01/label01.cs
 * created: Time-stamp: <2016-08-24 13:14:52 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_33.htm
 * description: 
 *
 *================================================================*/
// label01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class label01 : Form
{
    public static void Main()
    {
        label01 form = new label01();

        MyLabel ml = new MyLabel();
        ml.Parent = form;

        MyTextBox mt = new MyTextBox();
        mt.Parent = form;
        mt.Location = new Point(10, ml.Height + 20);

        Application.Run(form);
    }

    public label01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
    }
}

class MyLabel : Label
{
    public MyLabel()
    {
        Location = new Point(10, 10);
        Size = new Size(200, 100);
        BorderStyle = BorderStyle.Fixed3D;
    }
}

class MyTextBox : TextBox
{
    public MyTextBox()
    {
        BackColor = SystemColors.Control;
        Multiline = true;
        Size = new Size(200, 100);
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        Parent.Controls[0].Text = Text;
    }
}
