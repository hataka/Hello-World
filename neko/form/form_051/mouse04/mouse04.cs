// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:02 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_051/mouse04/mouse04.cs
 * url:  form/form_051/mouse04/mouse04.cs
 * created: Time-stamp: <2016-08-24 13:15:02 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_51.htm
 * description: 
 *
 *================================================================*/
// mouse04.cs

using System;
using System.Drawing;
using System.Windows.Forms;

struct mypaint
{
    public Point ptStart;
    public Point ptEnd;
    public Color clr;
}

class mouse03 : Form
{
    mypaint[] mp;
    int no;
    Point prevpt1, prevpt2;
    const int nMaxNo = 100;
    Color clr;
    int[] custom = null;

    public static void Main()
    {
        Application.Run(new mouse03());
    }

    public mouse03()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        mp = new mypaint[nMaxNo];

        clr = Color.Black;
        mp[0].clr = clr;
        
        no = 0;
        
        MainMenu mm = new MainMenu();
        Menu = mm;

        MenuItem miFile = new MenuItem("ファイル(&F)");
        mm.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem("終了(&X)");
        miFile.MenuItems.Add(miExit);
        miExit.Click += new EventHandler(miExit_Click);

        MenuItem miColor = new MenuItem("色(&C)");
        mm.MenuItems.Add(miColor);

        MenuItem miChooseColor = new MenuItem("色の選択");
        miColor.MenuItems.Add(miChooseColor);
        miChooseColor.Click += new EventHandler(miChooseColor_Click);
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    void miChooseColor_Click(object sender, EventArgs e)
    {
        ColorDialog cdlg = new ColorDialog();
        cdlg.Color = clr;
        cdlg.CustomColors = custom;

        DialogResult dr = cdlg.ShowDialog();
        if (dr == DialogResult.OK)
        {
            clr = cdlg.Color;
            custom = cdlg.CustomColors;
        }

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

        mp[no].ptStart = e.Location;
        mp[no].clr = clr;
        prevpt1 = e.Location;
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        
        mp[no].ptEnd = e.Location;
        no++;
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        for (int i = 0; i < no; i++)
        {
            g.DrawLine(new Pen(new SolidBrush(mp[i].clr)),
                mp[i].ptStart, mp[i].ptEnd);
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (e.Button == MouseButtons.None)
            return;

        Graphics g = CreateGraphics();
        g.DrawLine(new Pen(new SolidBrush(Color.White)), prevpt1, prevpt2);
        g.DrawLine(new Pen(new SolidBrush(clr)), e.Location, prevpt1);
        prevpt2 = e.Location;
        g.Dispose();
    }
}
