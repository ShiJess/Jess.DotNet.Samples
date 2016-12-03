using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

public class DIY:Form
{
	private Button btncont=new Button();
	private TextBox TBox=new TextBox();
	private int count=0;


	DIY()
	{
		InitalizeComponent();
	}



	private void InitalizeComponent()
	{
		btncont.Text="µãµã¿´";
	}


	TBox.Location=new Point(0,80);
	TBox.Size=new Size(150,50);
	TBox.TabIndex=1;


	this.ClientSize=new System.Drawing.Size(230,170);
}