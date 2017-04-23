// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:35 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_002/formprop02/formprop02.cs
 * url:  form/form_002/formprop02/formprop02.cs
 * created: Time-stamp: <2016-08-24 13:14:35 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_02.htm
 * description: 
 *
 *================================================================*/
// formprop02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class formprop02
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
        Text = "猫でもわかるプログラミング";
        BackColor = Color.Yellow;
    }
}
