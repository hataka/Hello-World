// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:35 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_002/formprop01/formprop01.cs
 * url:  form/form_002/formprop01/formprop01.cs
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
// formprop01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class formprop01 : Form
{
    public static void Main()
    {
        formprop01 f1 = new formprop01();

        Application.Run(f1);
    }

    // コンストラクタ
    public formprop01()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = Color.Yellow;
    }
}
