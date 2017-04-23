// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:03 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_053/status02/status02.cs
 * url:  form/form_053/status02/status02.cs
 * created: Time-stamp: <2016-08-24 13:15:03 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_53.htm
 * description: 
 *
 *================================================================*/
// status02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class status02 : Form
{
    StatusBar sb;
    int no1, no2;

    public static void Main()
    {
        Application.Run(new status02());
    }

    public status02()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        no1 = 0;
        no2 = 0;

        sb = new StatusBar();
        sb.Parent = this;
        sb.ShowPanels = true;

        StatusBarPanel sbp1 = new StatusBarPanel();
        sb.Panels.Add(sbp1);

        StatusBarPanel sbp2 = new StatusBarPanel();
        sb.Panels.Add(sbp2);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        string str;

        if (e.Button == MouseButtons.Left)
        {
            no1++;
            str = string.Format("Left:{0}", no1);
            sb.Panels[0].Text = str;
        }
        else if (e.Button == MouseButtons.Right)
        {
            no2++;
            str = string.Format("Right:{0}", no2);
            sb.Panels[1].Text = str;
        }
        else
            return;
    }
}
