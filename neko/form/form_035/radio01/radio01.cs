// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:53 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_035/radio01/radio01.cs
 * url:  form/form_035/radio01/radio01.cs
 * created: Time-stamp: <2016-08-24 13:14:53 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_35.htm
 * description: 
 *
 *================================================================*/
// radio01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class radio01
{
    static int nNo = 6;
    static RadioButton[] rb = new RadioButton[nNo];
    static string[] str = new string[]
        {"国語", "数学", "理科", "社会", "英語", "音楽"};
    static Label label;

    public static void Main()
    {
        MyForm mf = new MyForm();

        for (int i = 0; i < nNo; i++)
        {
            rb[i] = new RadioButton();
            rb[i].Text = str[i];
            rb[i].Location = new Point(10, 10 + i * rb[0].Height);
            rb[i].CheckedChanged += new EventHandler(radio_CheckedChanged);
        }
        mf.Controls.AddRange(rb);
        

        label = new Label();
        label.Parent = mf;
        label.Location = new Point(10, 20 + nNo * rb[0].Height);
        label.Width = mf.ClientSize.Width;
        

        Application.Run(mf);
    }

    static void radio_CheckedChanged(object sender, EventArgs e)
    {
        bool bEx = false;

        for (int i = 0; i < nNo; i++)
        {
            if ((RadioButton)sender == rb[i] && rb[i].Checked == true)
            {
                label.Text = str[i] + "が選択されています";
                bEx = true;
            }
            if (bEx)
                break;
        }
    }
}

class MyForm : Form
{
    public MyForm()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        DialogResult dr;
        dr = MessageBox.Show("本当に終了してもよろしいですか",
            "猫C#",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
        if (dr == DialogResult.Yes)
            e.Cancel = false;
        else
            e.Cancel = true;
    }
}
