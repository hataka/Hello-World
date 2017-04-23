// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:54 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_038/threestate01/threestate01.cs
 * url:  form/form_038/threestate01/threestate01.cs
 * created: Time-stamp: <2016-08-24 13:14:54 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_38.htm
 * description: 
 *
 *================================================================*/
// threestate01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class threestate01 : Form
{
    public static void Main()
    {
        string[] str = new string[3] { "Check0", "Check1", "Check2" };

        threestate01 form = new threestate01();
        form.Padding = new Padding(10);

        MyCheck[] mc = new MyCheck[3];

        for (int i = 2; i >= 0; i--)
        {
            mc[i] = new MyCheck(str[i]);
            form.Controls.Add(mc[i]);
        }

        Label label = new Label();
        label.Parent = form;
        label.BackColor = SystemColors.Control;
        label.Dock = DockStyle.Bottom;
        label.TextAlign = ContentAlignment.MiddleLeft;
        
        Application.Run(form);
    }

    public threestate01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
    }
}

class MyCheck : CheckBox
{
    public MyCheck(string str)
    {
        Text = str;
        BackColor = SystemColors.Control;
        ThreeState = true;
        Dock = DockStyle.Top;
        Margin = new Padding(10);
        CheckStateChanged += new EventHandler(MyCheck_CheckStateChanged);
    }

    void MyCheck_CheckStateChanged(object sender, EventArgs e)
    {
        CheckBox cb = (CheckBox)sender;

        string str = cb.CheckState.ToString();
        cb.Parent.Controls[3].Text = cb.Text + "が「" + str + "」に変化しました";
    }
}
