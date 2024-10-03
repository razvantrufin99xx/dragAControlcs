/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 10/4/2024
 * Time: 2:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace imgeanimations
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public int ismousedown = 0;
		public int cx = 0;
		public int cy = 0;
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void PictureBox1MouseMove(object sender, MouseEventArgs e)
		{
			if(ismousedown ==1 )
			{
				pictureBox1.Left += e.X -cx ;
				pictureBox1.Top += e.Y - cy;
			}
		}
		void PictureBox1MouseUp(object sender, MouseEventArgs e)
		{
			ismousedown = 0;
		}
		void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{
			ismousedown = 1;
			cx = e.X;
			cy = e.Y;
		}
	}
}
