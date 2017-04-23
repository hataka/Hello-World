// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:55 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_040/dialog02/dialog02.cs
 * url:  form/form_040/dialog02/dialog02.cs
 * created: Time-stamp: <2016-08-24 13:14:55 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_40.htm
 * description: 
 *
 *================================================================*/
// dialog02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class dialog02 : Form
{
    public static string str;

    public static void Main()
    {
        dialog02 form = new dialog02();
        Application.Run(form);
    }

    public dialog02()
    {
        Text = "猫でもわかるプログラミング";
        BackColor = SystemColors.Window;

        MainMenu mm = new MainMenu();

        MenuItem miFile = new MenuItem();
        miFile.Text = "ファイル(&F)";
        mm.MenuItems.Add(miFile);

        MenuItem miExit = new MenuItem();
        miExit.Text = "終了(&X)";
        miFile.MenuItems.Add(miExit);
        miExit.Click += new EventHandler(miExit_Click);

        MenuItem miOption = new MenuItem();
        miOption.Text = "オプション(&O)";
        mm.MenuItems.Add(miOption);

        MenuItem miDialog = new MenuItem();
        miDialog.Text = "ダイアログを出す(&D)";
        miDialog.Click += new EventHandler(miDialog_Click);
        miOption.MenuItems.Add(miDialog);

        Menu = mm;
    }

    void miDialog_Click(object sender, EventArgs e)
    {
        MyDialog dlg = new MyDialog();
        DialogResult dr = dlg.ShowDialog();

        if (dr == DialogResult.OK)
        {
            Invalidate();
        }
    }

    void miExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;
        g.DrawString(str, Font, Brushes.Black, new PointF(10f, 10f));
    }
}

class MyDialog : Form
{
    TextBox txtBox;

    public MyDialog()
    {
        Text = "オプション";
        MaximizeBox = false;
        MinimizeBox = false;
        ControlBox = false;
        ShowInTaskbar = false;
        FormBorderStyle = FormBorderStyle.FixedDialog;

        Width = 250;
        Height = 130;

        Button btnOK = new Button();
        btnOK.Text = "OK";
        btnOK.Location = new Point(10, ClientSize.Height - btnOK.Height - 5);
        btnOK.Parent = this;
        btnOK.TabIndex = 1;
        btnOK.Click += new EventHandler(btnOK_Click);
        btnOK.DialogResult = DialogResult.OK;

        Button btnCancel = new Button();
        btnCancel.Text = "Cancel";
        btnCancel.Location = new Point(ClientSize.Width - btnCancel.Width - 10,
            ClientSize.Height - btnCancel.Height - 5);
        btnCancel.Parent = this;
        btnCancel.TabIndex = 2;
        btnCancel.DialogResult = DialogResult.Cancel;

        txtBox = new TextBox();
        txtBox.Parent = this;
        txtBox.Location = new Point(10, 10);
        txtBox.Width = ClientSize.Width - 20;
        txtBox.TabIndex = 0;
    }

    void btnOK_Click(object sender, EventArgs e)
    {
        dialog02.str = txtBox.Text;
    }
}
