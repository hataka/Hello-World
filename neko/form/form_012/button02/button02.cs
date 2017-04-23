// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:40 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_012/button02/button02.cs
 * url:  form/form_012/button02/button02.cs
 * created: Time-stamp: <2016-08-24 13:14:40 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_12.htm
 * description: 
 *
 *================================================================*/
// button02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class button02 : Form
{
    static Button btn1, btn2;

    public static void Main()
    {
        button02 f = new button02();
        
        Application.Run(f);
    }

    static void btnOnClick(object sender, EventArgs e)
    {
        String mtitle = "button02";

        Button btn = (Button)sender;

        if (btn == btn1)
            MessageBox.Show("ボタン１が押されました", mtitle);
        else if (btn == btn2)
            MessageBox.Show("ボタン２が押されました", mtitle);
        else
            MessageBox.Show("これは何かの間違いです", mtitle);       
    }

    public button02()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = SystemColors.Window;

        btn1 = new Button();
        btn1.Parent = this;
        btn1.Text = "ボタン&1";
        btn1.BackColor = SystemColors.Control;
        btn1.Location = new Point(10, 10);
        btn1.Click += new EventHandler(btnOnClick);

        btn2 = new Button();
        btn2.Parent = this;
        btn2.Text = "ボタン&2";
        btn2.BackColor = SystemColors.Control;
        btn2.Location = new Point(20 + btn1.Width, 10);
        btn2.Click += new EventHandler(btnOnClick);

    }
}
