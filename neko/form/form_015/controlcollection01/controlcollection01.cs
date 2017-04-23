// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:42 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_015/controlcollection01/controlcollection01.cs
 * url:  form/form_015/controlcollection01/controlcollection01.cs
 * created: Time-stamp: <2016-08-24 13:14:42 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_15.htm
 * description: 
 *
 *================================================================*/
// controlcollection01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

struct MyStr
{
    public static string strTitle;
}

class controlcollection01
{
    public static void Main()
    {
        MyForm mf = new MyForm();

        Button btn1 = new Button();
        btn1.Text = "ボタン１(&1)";
        btn1.BackColor = SystemColors.Control;
        btn1.Location = new Point(10, 10);
        btn1.Click += new EventHandler(btn_Click);

        Button btn2 = new Button();
        btn2.Text = "ボタン２(&2)";
        btn2.BackColor = SystemColors.Control;
        btn2.Location = new Point(20 + btn1.Width, 10);
        btn2.Click += new EventHandler(btn_Click);

        mf.Controls.Add(btn1);
        mf.Controls.Add(btn2);

        Application.Run(mf);
    }

    static void btn_Click(object sender, EventArgs e)
    {
        Button from = (Button)sender;
        string str;

        if (from.Parent.Controls[0] == (Button)sender)
        {
            str = "ボタン１を押したね";
            MyStr.strTitle = str;
        }
        else if (from.Parent.Controls[1] == (Button)sender)
        {
            str = "ボタン２を押したね";
            MyStr.strTitle = str;
        }
        else
        {
            str = "";
            MyStr.strTitle = "";
        }
        from.Parent.Invalidate();
        MessageBox.Show(str, "猫でもわかるプログラミング",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

class MyForm : Form
{
    public MyForm()
    {
        Text = "ねこでもわかるプログラミング";
        BackColor = SystemColors.Window;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        Font font = new Font("ＭＳ ゴシック", 14);
        g.DrawString(MyStr.strTitle, font, Brushes.Black,
            new PointF(10.0F, this.Controls[0].Height + 20.0F));
    }
}
