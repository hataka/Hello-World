// -*- mode: java -*-  Time-stamp: <2016-08-24 13:15:07 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_060/toolbar02/toolbar02.cs
 * url:  form/form_060/toolbar02/toolbar02.cs
 * created: Time-stamp: <2016-08-24 13:15:07 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_60.htm
 * description: 
 *
 *================================================================*/
// toolbar02.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class toolbar02 : Form
{
    ToolBar tb;
    ToolBarButton[] tbbtn;
    String[] tooltxt, tiptxt;
    MenuItem[] mi;
    MenuItem miFlat, miNormal, miUnder, miRight;

    public static void Main()
    {
        Application.Run(new toolbar02());
    }

    public toolbar02()
    {
        Text = "猫でもわかるC#プログラミング";
        BackColor = SystemColors.Window;

        tooltxt = new string[5] { "開く", "切り取り", "削除", "検索", "ヘルプ" };
        tiptxt = new string[5] { "開きます", "カットします",
            "削除します",
            "検索します",
            "ヘルプを表示します" };
        mi = new MenuItem[5];

        MainMenu mm = new MainMenu();
        Menu = mm;

        MenuItem miFile = new MenuItem();
        miFile.Text = "ファイル(&F)";
        mm.MenuItems.Add(miFile);

        MenuItem miEdit = new MenuItem();
        miEdit.Text = "編集(&E)";
        mm.MenuItems.Add(miEdit);

        MenuItem miView = new MenuItem();
        miView.Text = "表示(&V)";
        mm.MenuItems.Add(miView);

        MenuItem miHelp = new MenuItem();
        miHelp.Text = "ヘルプ(&H)";
        mm.MenuItems.Add(miHelp);

        MenuItem miOpen = new MenuItem();
        miOpen.Text = "開く(&O)";
        miOpen.Click += new EventHandler(miOpen_Click);
        miFile.MenuItems.Add(miOpen);
        mi[0] = miOpen;
        
        MenuItem miCut = new MenuItem();
        miCut.Text = "切り取り(&T)";
        miCut.Click += new EventHandler(miCut_Click);
        miEdit.MenuItems.Add(miCut);
        mi[1] = miCut;

        MenuItem miDelete = new MenuItem();
        miDelete.Text = "削除(&D)";
        miDelete.Click += new EventHandler(miDelete_Click);
        miEdit.MenuItems.Add(miDelete);
        mi[2] = miDelete;

        MenuItem miSearch = new MenuItem();
        miSearch.Text = "検索(&F)";
        miSearch.Click += new EventHandler(miSearch_Click);
        miEdit.MenuItems.Add(miSearch);
        mi[3] = miSearch;

        MenuItem miAbout = new MenuItem();
        miAbout.Text = "バージョン情報";
        miAbout.Click += new EventHandler(miAbout_Click);
        miHelp.MenuItems.Add(miAbout);
        mi[4] = miAbout;

        miUnder = new MenuItem();
        miUnder.Text = "文字を下に";
        miUnder.Click += new EventHandler(miUnder_Click);
        miView.MenuItems.Add(miUnder);

        miRight = new MenuItem();
        miRight.Text = "文字を右に";
        miRight.Click += new EventHandler(miRight_Click);
        miView.MenuItems.Add(miRight);

        miFlat = new MenuItem();
        miFlat.Text = "フラット";
        miFlat.Click += new EventHandler(miFlat_Click);
        miView.MenuItems.Add(miFlat);

        miNormal = new MenuItem();
        miNormal.Text = "ノーマル";
        miNormal.Click += new EventHandler(miNormal_Click);
        miView.MenuItems.Add(miNormal);

        miNormal.Enabled = false;
        miUnder.Enabled = false;

        tbbtn = new ToolBarButton[5];
        tb = new ToolBar();
        tb.Parent = this;
        tb.Appearance = ToolBarAppearance.Normal;
        tb.TextAlign = ToolBarTextAlign.Underneath;

        tb.ButtonClick += new ToolBarButtonClickEventHandler(tb_ButtonClick);

        ImageList iList = new ImageList();
        Bitmap bmp = new Bitmap(GetType(), "toolbar02.tool02.bmp");
        iList.Images.AddStrip(bmp);
        iList.TransparentColor = Color.Red;

        tb.ImageList = iList;

        for (int i = 0; i < 5; i++)
        {
            tbbtn[i] = new ToolBarButton();
            tb.Buttons.Add(tbbtn[i]);

            tbbtn[i].ImageIndex = i;
            tbbtn[i].Text = tooltxt[i];
            tbbtn[i].ToolTipText = tiptxt[i];
            tbbtn[i].Tag = mi[i];
        }
        
    }

    void miOpen_Click(object sender, EventArgs e)
    {
        MessageBox.Show(tooltxt[0] + "が選択されました", this.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    void miCut_Click(object sender, EventArgs e)
    {
        MessageBox.Show(tooltxt[1] + "が選択されました", this.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    void miDelete_Click(object sender, EventArgs e)
    {
        MessageBox.Show(tooltxt[2] + "が選択されました", this.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    void miSearch_Click(object sender, EventArgs e)
    {
        MessageBox.Show(tooltxt[3] + "が選択されました", this.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    void miAbout_Click(object sender, EventArgs e)
    {
        MessageBox.Show("toolbar02.exe", this.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    void miUnder_Click(object sender, EventArgs e)
    {
        tb.TextAlign = ToolBarTextAlign.Underneath;
        miUnder.Enabled = false;
        miRight.Enabled = true;
    }

    void miRight_Click(object sender, EventArgs e)
    {
        tb.TextAlign = ToolBarTextAlign.Right;
        miRight.Enabled = false;
        miUnder.Enabled = true;
    }

    void miFlat_Click(object sender, EventArgs e)
    {
        tb.Appearance = ToolBarAppearance.Flat;
        miFlat.Enabled = false;
        miNormal.Enabled = true;
    }

    void miNormal_Click(object sender, EventArgs e)
    {
        tb.Appearance = ToolBarAppearance.Normal;
        miNormal.Enabled = false;
        miFlat.Enabled = true;
    }

    void tb_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
    {
        ToolBarButton tbb = e.Button;
        MenuItem mi = (MenuItem)tbb.Tag;
        mi.PerformClick();
    }
}
