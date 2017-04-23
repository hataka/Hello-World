// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:05 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_058/statusstrip01/statusstrip01.cs
 * url:  form/form_058/statusstrip01/statusstrip01.cs
 * created: Time-stamp: <2016-08-24 13:15:05 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_58.htm
 * description: 
 *
 *================================================================*/
// statusstrip01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class statusstrip01 : Form
{
    StatusStrip ss;

    public static void Main()
    {
        Application.Run(new statusstrip01());
    }

    public statusstrip01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        ss = new StatusStrip();
        ss.Parent = this;

        ToolStripStatusLabel tssl0 = new ToolStripStatusLabel();
        tssl0.BorderSides = ToolStripStatusLabelBorderSides.All;
        tssl0.BorderStyle = Border3DStyle.Bump;
        tssl0.BackColor = SystemColors.Control;
        tssl0.Text = "Bump";

        ToolStripStatusLabel tssl1 = new ToolStripStatusLabel();
        tssl1.BorderSides = ToolStripStatusLabelBorderSides.All;
        tssl1.BorderStyle = Border3DStyle.Raised;
        tssl1.BackColor = SystemColors.Control;
        tssl1.Text = "Raised";

        ToolStripStatusLabel tssl2 = new ToolStripStatusLabel();
        tssl2.BorderSides = ToolStripStatusLabelBorderSides.All;
        tssl2.BorderStyle = Border3DStyle.Sunken;
        tssl2.BackColor = SystemColors.Control;
        tssl2.Text = "Sunken";

        ToolStripStatusLabel tssl3 = new ToolStripStatusLabel();
        tssl3.BorderSides = ToolStripStatusLabelBorderSides.All;
        tssl3.BorderStyle = Border3DStyle.SunkenInner;
        tssl3.BackColor = SystemColors.Control;
        tssl3.Text = "SunkenInner";

        ToolStripStatusLabel tssl4 = new ToolStripStatusLabel();
        tssl4.BorderSides = ToolStripStatusLabelBorderSides.All;
        tssl4.BorderStyle = Border3DStyle.SunkenOuter;
        tssl4.BackColor = SystemColors.Control;
        tssl4.Text = "SunkenOuter";

        ToolStripStatusLabel[] ts = { tssl0, tssl1, tssl2, tssl3, tssl4 };
        ss.Items.AddRange(ts);
    }
}
