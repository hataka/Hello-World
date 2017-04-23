// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:03 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_054/status03/status03.cs
 * url:  form/form_054/status03/status03.cs
 * created: Time-stamp: <2016-08-24 13:15:03 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_54.htm
 * description: 
 *
 *================================================================*/
// status03.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class status03
{
    public static void Main()
    {
        Application.Run(new MyForm());
    }
}

class MyForm : Form
{
    MyStatus ms;

    public MyForm()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
        ms = new MyStatus();
        ms.Parent = this;
        ms.ShowPanels = true;

        Timer timer = new Timer();
        timer.Interval = 50;
        timer.Tick += new EventHandler(timer_Tick);
        timer.Start();
    }

    void timer_Tick(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;

        String str = dt.ToShortDateString();
        ms.Panels[0].Text = str;
        str = String.Format("{0:00}:{1:00}:{2:00}", dt.Hour, dt.Minute, dt.Second);
        ms.Panels[2].Text = str;
    }
}

class MyStatus : StatusBar
{
    public MyStatus()
    {
        StatusBarPanel sbp0 = new StatusBarPanel();
        StatusBarPanel sbp1 = new StatusBarPanel();
        StatusBarPanel sbp2 = new StatusBarPanel();


        sbp0.AutoSize = StatusBarPanelAutoSize.Contents;
        sbp0.Alignment = HorizontalAlignment.Center;
        sbp0.ToolTipText = "日付です";

        sbp1.AutoSize = StatusBarPanelAutoSize.Spring;

        sbp2.AutoSize = StatusBarPanelAutoSize.Contents;
        sbp2.Alignment = HorizontalAlignment.Center;
        sbp2.ToolTipText = "時刻です";
        
        Panels.Add(sbp0);
        Panels.Add(sbp1);
        Panels.Add(sbp2);
    }
}
