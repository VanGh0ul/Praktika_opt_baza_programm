﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Data;


namespace Skladik.NewComponents {	
													// Начальный класс для списков панелей		
	public class PanelList : FlowLayoutPanel {

		public PanelList() {

			Dock = DockStyle.Fill;
			AutoScroll = false;
			HorizontalScroll.Enabled = false;
			HorizontalScroll.Visible = false;
			VerticalScroll.Enabled = true;
			AutoScroll = true;
			this.FlowDirection = FlowDirection.TopDown;
			this.WrapContents = false;
			
			//Margin = new Padding(0, 0, 15, 0);

		}

	}
}
