// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:50 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_030/isbn01/isbn01.cs
 * url:  form/form_030/isbn01/isbn01.cs
 * created: Time-stamp: <2016-08-24 13:14:50 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_30.htm
 * description: 
 *
 *================================================================*/
// isbn01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class isbn01 : Form
{
    // テキストボックスがこのクラスのみんなから見えるように
    // フィールドにしてある
    TextBox tb;

    public static void Main()
    {
        Application.Run(new isbn01());
    }

    // コンストラクタ
    public isbn01()
    {
        Text = "猫でもわかるC#";
        BackColor = SystemColors.Window;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;

        tb = new TextBox();
        tb.Parent = this;
        tb.Location = new Point(10, 10);
        tb.Width = 150;

        Button btn = new Button();
        btn.Parent = this;
        btn.BackColor = SystemColors.Control;
        btn.Text = "チェック";
        btn.Click += new EventHandler(btn_Click);
        btn.Location = new Point(20 + tb.Width, 10);

        // 親フォームの大きさを調整するための計算
        Size sz = new Size();
        sz.Width = 30 + tb.Width + btn.Width;
        sz.Height = 20 + tb.Height;

        // 親フォームのクライアント領域サイズの調整
        tb.Parent.ClientSize = sz;

    }

    void btn_Click(object sender, EventArgs e)
    {
        string strTitle = "ISBN検査結果";

        // nISBNを0に戻しておく
        int nISBN = 0;

        // 入力桁数が10桁でないときはエラー
        if (tb.Text.Length != 10)
        {
            MessageBox.Show("桁が変です",
                strTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
            tb.Clear();
            tb.Focus();
            return;
        }

        // nISBNを９桁目まで計算
        for (int i = 0; i < 9; i++)
        {
            try
            {
                nISBN += Int32.Parse(tb.Text[i].ToString()) * (10 - i);
            }
            catch
            {
                MessageBox.Show("不正な文字が含まれています",
                    strTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                tb.Clear();
                tb.Focus();
                return;
            }
        }

        // 最後の桁がXまたはxの時は10を加える
        if (tb.Text[9] == 'X' || tb.Text[9] == 'x')
            nISBN += 10;
        else
        {
            try
            {
                nISBN += Int32.Parse(tb.Text[9].ToString());
            }
            catch
            {
                MessageBox.Show("最後の文字が数字ではありません",
                    strTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                tb.Clear();
                tb.Focus();
                return;
            }
        }
        if (nISBN % 11 == 0)
            MessageBox.Show("正しいISBNです",
                strTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        else
            MessageBox.Show("不正なISBNです",
                strTitle,
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
    }
}
