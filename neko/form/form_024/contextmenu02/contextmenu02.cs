// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:47 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_024/contextmenu02/contextmenu02.cs
 * url:  form/form_024/contextmenu02/contextmenu02.cs
 * created: Time-stamp: <2016-08-24 13:14:47 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_24.htm
 * description: 
 *
 *================================================================*/
// contextmenu02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class contextmenu02 : Form
{
    ContextMenu cm;
    string str;

    public static void Main()
    {
        contextmenu02 c2 = new contextmenu02();
        Application.Run(c2);
    }

    // コンストラクタ
    public contextmenu02()
    {
        Text = "猫でもわかるC#";
        BackColor = SystemColors.Window;

        cm = new ContextMenu();
        //ContextMenu = cm;
        //ContextMenuプロパティにcmを設定していない!!

        MenuItem miFile = new MenuItem("ファイル(&F)");
        cm.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem("終了(&X)");
        miExit.Click += new EventHandler(miExit_Click);
        miFile.MenuItems.Add(miExit);
    }

    // メニューの「終了」が選択された
    void miExit_Click(object sender, EventArgs e)
    {
        Close();   
    }

    // Paintイベントが発生した
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        Graphics g = e.Graphics;
        Font f = new Font("ＭＳ ゴシック", 16);
        g.DrawString(str, f, Brushes.Black, new PointF(10F, 10F)); 
    }

    // FormClosingイベントが発生した
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        DialogResult dr;

        dr = MessageBox.Show("終了してもよいですか",
            "猫C#",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
            e.Cancel = false;
        else
            e.Cancel = true;
    }

    // マウスボタン(どのボタンでもよい)が押下された
    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        if (e.Button == MouseButtons.Left)
            str = "左ボタンが押されました";
        else if (e.Button == MouseButtons.Right)
            str = "右ボタンが押されました";
        else if (e.Button == MouseButtons.Middle)
            str = "ホィールが押されました";
        else
            str = "その他のボタンが押されました";

        // Paintイベントを発生させてstrをクライアント領域に再描画
        Invalidate();

        cm.Show(this, new Point(e.X, e.Y));
    }
}
