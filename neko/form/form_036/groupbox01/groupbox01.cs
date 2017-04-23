// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:53 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_036/groupbox01/groupbox01.cs
 * url:  form/form_036/groupbox01/groupbox01.cs
 * created: Time-stamp: <2016-08-24 13:14:53 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_36.htm
 * description: 
 *
 *================================================================*/
// groupbox01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class groupbox01
{
    static RadioButton rbmale, rbfemale;

    public static void Main()
    {
        MyForm myform = new MyForm();

        rbmale = new RadioButton();
        rbmale.Text = "男性";
        rbmale.Location = new Point(20, 20);
        rbmale.AutoSize = true;
        rbmale.Checked = true;

        rbfemale = new RadioButton();
        rbfemale.Text = "女性";
        rbfemale.Location = new Point(20, 25 + rbmale.Height);
        rbfemale.AutoSize = true;

        GroupBox gb = new GroupBox();
        gb.Text = "性別";
        gb.Location = new Point(10, 10);
        gb.Width = rbmale.Width + 10;
        gb.Height = rbmale.Height * 2 + 30;

        Button btn = new Button();
        btn.Text = "押す";
        btn.Location = new Point(20, gb.Location.Y + gb.Height + 10);
        btn.BackColor = SystemColors.Control;
        btn.Click += new EventHandler(btn_Click);

        myform.Controls.Add(gb);
        gb.Controls.Add(rbmale);
        gb.Controls.Add(rbfemale);
        myform.Controls.Add(btn);

        Application.Run(myform);
    }

    static void btn_Click(Object sender, EventArgs e)
    {
        if (rbmale.Checked)
            MessageBox.Show("男性が選択されています",
                "猫でもわかるC#",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        else
            MessageBox.Show("女性が選択されています",
                "猫でもわかるC#",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
