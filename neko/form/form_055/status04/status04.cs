// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:04 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_055/status04/status04.cs
 * url:  form/form_055/status04/status04.cs
 * created: Time-stamp: <2016-08-24 13:15:04 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_55.htm
 * description: 
 *
 *================================================================*/
// status04.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class status04 : Form
{
    StatusBar sb;
    StatusBarPanel sbp0, sbp1, sbp2;

    public static void Main()
    {
        status04 fm = new status04();
        Application.Run(fm);
    }

    public status04()
    {
        Icon icon = new Icon(GetType(), "status04.icon1.ico");

        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
        Icon = icon;
        BackgroundImage = icon.ToBitmap();

        sb = new StatusBar();
        sb.Parent = this;
        sb.ShowPanels = true;

        sbp0 = new StatusBarPanel();
        sbp1 = new StatusBarPanel();
        sbp2 = new StatusBarPanel();

        sbp0.AutoSize = StatusBarPanelAutoSize.Contents;
        sbp0.Alignment = HorizontalAlignment.Center;

        sbp1.AutoSize = StatusBarPanelAutoSize.Spring;
        sbp1.Alignment = HorizontalAlignment.Center;

        sbp2.AutoSize = StatusBarPanelAutoSize.Contents;
        sbp2.Alignment = HorizontalAlignment.Center;

        sbp0.Icon = icon;
        sbp1.Icon = icon;
        sbp2.Icon = icon;
        sbp1.Text = Text;

        sb.Panels.Add(sbp0);
        sb.Panels.Add(sbp1);
        sb.Panels.Add(sbp2);
    }
}
