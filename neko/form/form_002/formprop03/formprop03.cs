// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:35 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_002/formprop03/formprop03.cs
 * url:  form/form_002/formprop03/formprop03.cs
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
// formprop03.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class formprop03
{
    public static void Main()
    {
        Form myform = new Form();

        myform.Text = "猫でもわかるプログラミング";
        myform.BackColor = Color.Yellow;

        Application.Run(myform);
    }
}
