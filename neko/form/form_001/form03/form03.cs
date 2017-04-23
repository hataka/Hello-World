// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:34 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_001/form03/form03.cs
 * url:  form/form_001/form03/form03.cs
 * created: Time-stamp: <2016-08-24 13:14:34 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_01.htm
 * description: 
 *
 *================================================================*/
// form03.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class form03
{
    public static void Main()
    {
        MyForm mf = new MyForm();
        Application.Run(mf);
    }
}

// 今は独自のものが無い!
class MyForm : Form
{
}
