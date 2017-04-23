// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:40 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_011/button01/button01.cs
 * url:  form/form_011/button01/button01.cs
 * created: Time-stamp: <2016-08-24 13:14:40 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_11.htm
 * description: 
 *
 *================================================================*/
// button01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class button01
{

    public static void Main()
    {
        Form form = new MyForm();
        Button btn = new Button();
        btn.Parent = form;
        btn.Location = new Point(10, 10);
        btn.Text = "押す";
        btn.BackColor = SystemColors.Control;
        btn.Click += new EventHandler(btnOnClick);

        Application.Run(form);
    }
    static void btnOnClick(object sender, EventArgs e)
    {
        MessageBox.Show("ボタンを押したね", "button01",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
