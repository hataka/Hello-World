// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:49 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_028/textbox01/textbox01.cs
 * url:  form/form_028/textbox01/textbox01.cs
 * created: Time-stamp: <2016-08-24 13:14:49 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_28.htm
 * description: 
 *
 *================================================================*/
// textbox01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class textbox01
{
    public static void Main()
    {
        Application.Run(new MyForm());
    }
}

class MyForm : Form
{
    TextBox textbox;
    
    public MyForm()
    {
        Text = "猫でもわかるC#";
        BackColor = Color.Aqua;
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Width = 200;
        Height = 110;
        MaximizeBox = false;

        textbox = new TextBox();
        textbox.Parent = this;
        textbox.Location = 
            new Point((ClientSize.Width - textbox.Width) / 2, 10);

        Button btn = new Button();
        btn.Text = "押す";
        btn.Parent = this;
        btn.Location = new Point((ClientSize.Width - btn.Width) / 2,
            20 + textbox.Height);
        btn.Click += new EventHandler(btn_Click);
        btn.BackColor = SystemColors.Control;
    }

    void btn_Click(object sender, EventArgs e)
    {
        MessageBox.Show("あなたは「" + textbox.Text + "」と記入しましたね",
            "猫C#",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        DialogResult dr;
        dr = MessageBox.Show("本当に終了してよいですか",
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
