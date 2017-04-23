// -*- mode: java -*-  Time-stamp: <2016-08-24 13:14:43 kahata>
/*================================================================
 * title: 
 * file: 
 * path; form/form_017/backgroundimage01/backgroundimage01.cs
 * url:  form/form_017/backgroundimage01/backgroundimage01.cs
 * created: Time-stamp: <2016-08-24 13:14:43 kahata>
 * revision: $Id$
 * Programmed By: kahata
 * To compile:
 * To run: 
 * link: http://www.kumei.ne.jp/c_lang/
 * link: http://www.kumei.ne.jp/c_lang/form/form_17.htm
 * description: 
 *
 *================================================================*/
// backgroundimage01.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class backgroundimage01
{
    public static void Main()
    {
        MyForm mf = new MyForm();
        Application.Run(mf);
    }
}

class MyForm : Form
{
    public MyForm()
    {
        Text = "Tile";
        BackColor = Color.Blue;
        BackgroundImage = new Bitmap(GetType(), "backgroundimage01.cat.gif");
        BackgroundImageLayout = ImageLayout.Tile;
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        if (BackgroundImageLayout == ImageLayout.Center)
        {
            BackgroundImageLayout = ImageLayout.None;
            Text = "None";
        } 
        else if (BackgroundImageLayout == ImageLayout.None)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            Text = "Stretch";
        }
        else if (BackgroundImageLayout == ImageLayout.Stretch)
        {
            BackgroundImageLayout = ImageLayout.Tile;
            Text = "Tile";
        }
        else if (BackgroundImageLayout == ImageLayout.Zoom)
        {
            BackgroundImageLayout = ImageLayout.Center;
            Text = "Center";
        }
        else
        {
            BackgroundImageLayout = ImageLayout.Zoom;
            Text = "Zoom";
        }
    }
}
