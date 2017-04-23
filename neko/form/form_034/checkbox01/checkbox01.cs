// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:52 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_034/checkbox01/checkbox01.cs
 * url:  form/form_034/checkbox01/checkbox01.cs
 * created: Time-stamp: <2016-08-24 13:14:52 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_34.htm
 * description: 
 *
 *================================================================*/
// checkbox01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class checkbox01
{
    static CheckBox cb0, cb1;
    static Label label;

    public static void Main()
    {
        Form form = new Form();
        form.Text = "猫でもわかるC#プログラミング";
        form.BackColor = SystemColors.Window;

        cb0 = new CheckBox();
        cb0.Parent = form;
        cb0.Text = "国語";
        cb0.Location = new Point(10, 10);
        cb0.CheckedChanged += new EventHandler(cb_CheckedChanged);

        cb1 = new CheckBox();
        cb1.Parent = form;
        cb1.Text = "算数";
        cb1.Location = new Point(10, 10 + cb0.Height);
        cb1.CheckedChanged += new EventHandler(cb_CheckedChanged);

        label = new Label();
        label.Parent = form;
        label.Location = new Point(10, 20 + cb0.Height * 2);
        label.Width = 150;

        Application.Run(form);
    }

    static void cb_CheckedChanged(Object sender, EventArgs e)
    {
        CheckBox cb = (CheckBox)sender;

        if (cb == cb0)
        {
            if (cb.Checked)
                label.Text = "国語がチェックされました";
            else
                label.Text = "国語のチェックが外されました";
        }

        if (cb == cb1)
        {
            if (cb.Checked)
            {
                label.Text = "算数がチェックされました";
            }
            else
            {
                label.Text = "算数のチェックが外されました";
            }
        }
    }
}
