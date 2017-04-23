// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:51 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_031/anchor01/anchor01.cs
 * url:  form/form_031/anchor01/anchor01.cs
 * created: Time-stamp: <2016-08-24 13:14:51 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_31.htm
 * description: 
 *
 *================================================================*/
// anchor01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class anchor01 : Form
{
    public static void Main()
    {
        Application.Run(new anchor01());
    }

    public anchor01()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        //親のControls[0]に相当
        Button btn = new Button();
        btn.Parent = this;
        btn.BackColor = SystemColors.Control;
        btn.Text = "押す";
        btn.Click += new EventHandler(btn_Click);
        btn.Location = new Point(ClientSize.Width - btn.Width - 10, ClientSize.Height - btn.Height - 10);
        btn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);

        //親のControls[1]に相当
        TextBox tbox = new TextBox();
        tbox.Parent = this;
        tbox.Location = new Point(10, 10);
        tbox.Anchor = AnchorStyles.Top | AnchorStyles.Left;
    }

    void btn_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        Form parent = (Form)btn.Parent;
        MessageBox.Show(parent.Controls[1].Text,
            "猫C#",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}
