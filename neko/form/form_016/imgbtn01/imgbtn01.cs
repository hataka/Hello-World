// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:42 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_016/imgbtn01/imgbtn01.cs
 * url:  form/form_016/imgbtn01/imgbtn01.cs
 * created: Time-stamp: <2016-08-24 13:14:42 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_16.htm
 * description: 
 *
 *================================================================*/
// imgbtn01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class imgbtn01
{
    public static void Main()
    {
        Form form = new Form();
        form.Text = "猫でもわかるプログラミング";
        form.BackColor = SystemColors.Window;
        form.ClientSize = new Size(230, 230);

        MyButton mb1 = new MyButton();
        mb1.Location = new Point(10, 10);

        MyButton mb2 = new MyButton();
        mb2.Location = new Point(20 + mb1.Width, 10);

        MyButton mb3 = new MyButton();
        mb3.Location = new Point(10, 20 + mb1.Height);

        MyButton mb4 = new MyButton();
        mb4.Location = new Point(20 + mb1.Width, 20 + mb1.Height);

        form.Controls.Add(mb1);
        form.Controls.Add(mb2);
        form.Controls.Add(mb3);
        form.Controls.Add(mb4);

        Application.Run(form);
    }
}

class MyButton : Button
{
    public MyButton()
    {
        Text = "猫";
        TextAlign = ContentAlignment.TopCenter;
        Font = new Font("ＭＳ ゴシック", 30);
        ForeColor = Color.Green;
        Size = new Size(100, 100);
        BackColor = SystemColors.Control;
        Image = new Bitmap(GetType(), "imgbtn01.cat.gif");
        ImageAlign = ContentAlignment.BottomCenter;

    }

    protected override void OnMouseHover(EventArgs e)
    {
        base.OnMouseHover(e);
        ForeColor = Color.Red;
        Cursor = Cursors.Hand;
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        ForeColor = Color.Green;
        Cursor = Cursors.Arrow;
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        string str;

        int n = Parent.Controls.IndexOf(this);

        switch (n)
        {
            case 0:
                str = "左上のボタンがクリックされました";
                break;
            case 1:
                str = "右上のボタンがクリックされました";
                break;
            case 2:
                str = "左下のボタンがクリックされました";
                break;
            case 3:
                str = "右下のボタンがクリックされました";
                break;
            default:
                str = "";
                break;
        }
        MessageBox.Show(str, "猫でもわかるプログラミング",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

}
