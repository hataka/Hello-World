// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:02 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_052/status01/status01.cs
 * url:  form/form_052/status01/status01.cs
 * created: Time-stamp: <2016-08-24 13:15:02 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_52.htm
 * description: 
 *
 *================================================================*/
// status01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class status01
{
    public static void Main()
    {
        MyForm mf = new MyForm();
        Application.Run(mf);
    }
}

class MyForm : Form
{
    public MyForm()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
        StatusBar ms = new StatusBar();
        ms.Parent = this;
        ms.Text = "粂井康孝";
    }
}
