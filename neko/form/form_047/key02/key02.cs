// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:59 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_047/key02/key02.cs
 * url:  form/form_047/key02/key02.cs
 * created: Time-stamp: <2016-08-24 13:14:59 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_47.htm
 * description: 
 *
 *================================================================*/
// key02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class key02
{
    public static void Main()
    {
        MyForm mf = new MyForm();
        Application.Run(mf);
    }
}

class MyForm : Form
{
    string str;

    public MyForm()
    {
        str = "";
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);
        if ((e.KeyData & Keys.Modifiers) == Keys.Shift)
        {
            str = "Shift";
        }
        if ((e.KeyData & Keys.Modifiers) == Keys.Control)
        {
            str = "Control";
        }
        if ((e.KeyData & Keys.Modifiers) == Keys.Alt)
        {
            str = "Alt";
        }
        if ((e.KeyData & Keys.Modifiers) == (Keys.Shift | Keys.Control))
        {
            str = "Shift + Control";
        }
        if ((e.KeyData & Keys.Modifiers) == (Keys.Shift | Keys.Alt))
        {
            str = "Shift + Alt";
        }
        if ((e.KeyData & Keys.Modifiers) == (Keys.Control | Keys.Alt))
        {
            str = "Control + Alt";
        }
        if ((e.KeyData & Keys.Modifiers) == (Keys.Shift | Keys.Control | Keys.Alt))
        {
            str = "Shift + Control + Alt";
        }
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.DrawString(str, Font, new SolidBrush(ForeColor), new Point(10, 10));
    }
}
