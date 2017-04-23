// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:54 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_037/bmpchk01/bmpchk01.cs
 * url:  form/form_037/bmpchk01/bmpchk01.cs
 * created: Time-stamp: <2016-08-24 13:14:54 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_37.htm
 * description: 
 *
 *================================================================*/
// bmpchk01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class bmpchk01 : Form
{
    public static void Main()
    {
        Application.Run(new bmpchk01());
    }

    public bmpchk01()
    {
        Text = "猫でもわかるC#プログラミング";
        
        BackColor = SystemColors.Window;
        Padding = new Padding(10);

        Bitmap bmpFile, bmpOpen, bmpSave, bmpExit;

        bmpFile = new Bitmap(GetType(), "bmpchk01.file.gif");
        bmpOpen = new Bitmap(GetType(), "bmpchk01.open.gif");
        bmpSave = new Bitmap(GetType(), "bmpchk01.save.gif");
        bmpExit = new Bitmap(GetType(), "bmpchk01.exit.gif");

        MyCheckBox mcb3 = new MyCheckBox(this, bmpExit, "Exit");
        MyCheckBox mcb2 = new MyCheckBox(this, bmpSave, "Save");
        MyCheckBox mcb1 = new MyCheckBox(this, bmpOpen, "Open");
        MyCheckBox mcb0 = new MyCheckBox(this, bmpFile, "File");
    }
}

class MyCheckBox : CheckBox
{
    public MyCheckBox(Form f, Bitmap bmp, string str)
    {
        Parent = f;
        BackColor = SystemColors.Control;
        Dock = DockStyle.Top;
        Image = bmp;
        ImageAlign = ContentAlignment.MiddleCenter;
        Height = bmp.Height;
        Text = str;
        TextImageRelation = TextImageRelation.ImageBeforeText;
    }

    protected override void OnMouseHover(EventArgs e)
    {
        base.OnMouseHover(e);
        Cursor = Cursors.Hand;
        BackColor = Color.Red;
    }

    protected override void OnMouseLeave(EventArgs eventargs)
    {
        base.OnMouseLeave(eventargs);
        Cursor = Cursors.Arrow;
        BackColor = SystemColors.Control;
    }

    protected override void OnCheckedChanged(EventArgs e)
    {
        base.OnCheckedChanged(e);
        int n = Parent.Controls.Count;
        CheckBox[] cb = new CheckBox[n];
        string str = "";

        for (int i = 0; i < n; i++)
        {
            cb[i] = (CheckBox)Parent.Controls[i];
            if (cb[i].Checked)
                str += (cb[i].Text + " ");
        }

        if (str != "")
            str = "現在選択されているのは" + str + "です";
        else
            str = "現在選択されている項目はありません";

        Parent.Text = str;
        
    }
}
