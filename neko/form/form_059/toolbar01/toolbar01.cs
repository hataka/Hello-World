// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:06 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_059/toolbar01/toolbar01.cs
 * url:  form/form_059/toolbar01/toolbar01.cs
 * created: Time-stamp: <2016-08-24 13:15:06 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_59.htm
 * description: 
 *
 *================================================================*/
// toolbar01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class toolbar01 : Form
{
    ToolBarButton tbb1, tbb2, tbb3, tbb4, tbb5;
    ToolBar tb;
    String[] tbstring = { "open", "cut", "delete", "find", "help" };
    String str;

    public static void Main()
    {
        Application.Run(new toolbar01());
    }

    public toolbar01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        tb = new ToolBar();
        tb.Parent = this;
        tb.ButtonClick += new ToolBarButtonClickEventHandler(tb_ButtonClick);
        tb.BorderStyle = BorderStyle.Fixed3D;

        Bitmap bmp = new Bitmap(GetType(), "toolbar01.tool01.bmp");
        ImageList ilst = new ImageList();
        ilst.Images.AddStrip(bmp);
        ilst.TransparentColor = Color.Red;

        tb.ImageList = ilst;
        tb.ShowToolTips = true;

        tbb1 = new ToolBarButton();
        tbb1.ImageIndex = 0;
        tbb1.ToolTipText = tbstring[0];
        tb.Buttons.Add(tbb1);
        

        tbb2 = new ToolBarButton();
        tbb2.ImageIndex = 1;
        tbb2.ToolTipText = tbstring[1];
        tb.Buttons.Add(tbb2);
        
        tbb3 = new ToolBarButton();
        tbb3.ImageIndex = 2;
        tbb3.ToolTipText = tbstring[2];
        tb.Buttons.Add(tbb3);

        tbb4 = new ToolBarButton();
        tbb4.ImageIndex = 3;
        tbb4.ToolTipText = tbstring[3];
        tb.Buttons.Add(tbb4);

        tbb5 = new ToolBarButton();
        tbb5.ImageIndex = 4;
        tbb5.ToolTipText = tbstring[4];
        tb.Buttons.Add(tbb5);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g;
        g = e.Graphics;
        g.DrawString(str, new Font("ＭＳ ゴシック", 14),
            Brushes.Blue, new PointF(10F, 30F));
    }

    void tb_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
        str = String.Format("{0}が選択されました",
            tbstring[tb.Buttons.IndexOf(e.Button)]);
        Invalidate();
    }
}
