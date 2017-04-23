// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:39 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_009/messagebox01/messagebox01.cs
 * url:  form/form_009/messagebox01/messagebox01.cs
 * created: Time-stamp: <2016-08-24 13:14:39 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_09.htm
 * description: 
 *
 *================================================================*/
// messagebox01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class messagebox01
{
    static string str, str2;
    static int n;

    public static void Main()
    {
        Form f = new Form();
        f.Text = "猫でもわかるプログラミング";
        f.BackColor = SystemColors.Window;
        f.Paint += new PaintEventHandler(OnMyPaint);
        f.MouseDown += new MouseEventHandler(OnMyMouseDown);

        Application.Run(f);
    }

    static void OnMyPaint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Font f = new Font("ＭＳ ゴシック", 14);
        g.DrawString(str, f, Brushes.Black, new PointF(10F, 10F));
        g.DrawString(str2, f, Brushes.Red, new PointF(10F, 40F));
    }

    static void OnMyMouseDown(object sender, MouseEventArgs e)
    {
        DialogResult dr;
        n++;
        str = String.Format("{0}回目のクリックです", n);
        str2 = "";
        Form form = (Form)sender;
        form.Invalidate();
        dr = MessageBox.Show(str, "猫でもわかるプログラミング", 
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);
        switch (dr)
        {
            case DialogResult.OK:
                str2 = "「OK」ボタン";
                break;
            case DialogResult.Cancel:
                str2 = "「キャンセル」ボタン";
                break;
            default:
                str2 = "エラーかな・・・";
                break;
        }
        form.Invalidate();
    }
}
