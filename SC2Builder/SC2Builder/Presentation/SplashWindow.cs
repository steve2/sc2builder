﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SC2Builder.Properties;

namespace SC2Builder.Presentation
{
	public partial class SplashWindow : Form
	{
		public SplashWindow()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SplashWindow_Load(object sender, EventArgs e)
		{
			SplashLabelVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}
	}
}
