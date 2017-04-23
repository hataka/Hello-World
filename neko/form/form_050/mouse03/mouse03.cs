// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:01 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_050/mouse03/mouse03.cs
 * url:  form/form_050/mouse03/mouse03.cs
 * created: Time-stamp: <2016-08-24 13:15:01 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_50.htm
 * description: 
 *
 *================================================================*/
// mouse03.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class mouse03 : Form
{
    Point[] pt;
    int no;
    Point prevpt1, prevpt2;
    const int nMaxNo = 100;

    public static void Main()
    {
        Application.Run(new mouse03());
    }

    public mouse03()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
        
        pt = new Point[nMaxNo];
        no = 0;
        
        MainMenu mm = new MainMenu();
        Menu = mm;

        MenuItem miFile = new MenuItem("ファイル(&F)");
        mm.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem("終了(&X)");
        miFile.MenuItems.Add(miExit);
        miExit.Click += new EventHandler(miExit_Click);
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        if (no >= nMaxNo)
        {
            MessageBox.Show("設定数を超えました",
                "限界", MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
            return;
        }

        pt[no] = e.Location;
        prevpt1 = e.Location;
        no++;
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        
        pt[no] = e.Location;
        no++;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        for (int i = 0; i < no / 2; i++)
        {
            g.DrawLine(new Pen(new SolidBrush(Color.Red)),
                pt[i * 2], pt[i * 2 + 1]);
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (e.Button == MouseButtons.None)
            return;

        Graphics g = CreateGraphics();
        g.DrawLine(new Pen(new SolidBrush(Color.White)), prevpt1, prevpt2);
        g.DrawLine(new Pen(new SolidBrush(Color.Blue)), e.Location, prevpt1);
        prevpt2 = e.Location;
        g.Dispose();
    }
}
