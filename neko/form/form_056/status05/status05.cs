// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:04 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_056/status05/status05.cs
 * url:  form/form_056/status05/status05.cs
 * created: Time-stamp: <2016-08-24 13:15:04 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_56.htm
 * description: 
 *
 *================================================================*/
// status05.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class status05
{
    static StatusBarPanel sbp01, sbp02, sbp03;

    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "猫でもわかるC#プログラミング";
        fm.BackColor = SystemColors.Window;

        StatusBar sb = new StatusBar();
        sb.Parent = fm;
        sb.ShowPanels = true;

        sbp01 = new StatusBarPanel();
        sbp02 = new StatusBarPanel();
        sbp03 = new StatusBarPanel();

        sbp01.Width = 50;
        sbp01.Alignment = HorizontalAlignment.Center;
        sbp01.Style = StatusBarPanelStyle.OwnerDraw;

        sbp02.AutoSize = StatusBarPanelAutoSize.Spring;
        sbp02.Style = StatusBarPanelStyle.OwnerDraw;

        sbp03.Alignment = HorizontalAlignment.Center;
        sbp03.Width = 50;
        sbp03.Style = StatusBarPanelStyle.OwnerDraw;

        sb.Panels.Add(sbp01);
        sb.Panels.Add(sbp02);
        sb.Panels.Add(sbp03);

        sb.DrawItem += new StatusBarDrawItemEventHandler(sb_DrawItem);

        Application.Run(fm);
    }

    static void sb_DrawItem(object sender, StatusBarDrawItemEventArgs sbdevent)
    {
        Graphics g = sbdevent.Graphics;
        Font font = new Font("ＭＳ ゴシック", 14);

        switch (sbdevent.Index)
        {
            case 0:
                g.FillRectangle(Brushes.Red, sbdevent.Bounds);
                break;
            case 1:
                g.FillRectangle(Brushes.Blue, sbdevent.Bounds);
                g.DrawString("粂井康孝・著", font, Brushes.White, new PointF(sbp01.Width + 30, 2));
                break;
            case 2:
                g.FillRectangle(Brushes.Yellow, sbdevent.Bounds);
                break;
        }
    }
}
