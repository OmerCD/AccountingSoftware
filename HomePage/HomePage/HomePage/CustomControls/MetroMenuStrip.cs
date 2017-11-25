﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModernUISample.metro;

namespace HomePage.CustomControls
{
    public partial class MetroMenuStrip : MenuStrip
    {
        public MetroMenuStrip()
            : base()
        {
            Renderer = new metroToolStripRenderer();
            Font = MetroUI.Style.BaseFont;
            ForeColor = MetroUI.Style.ForeColor;
        }

        /// <summary>
        /// OnItemAdded-Event we adjust the font and forecolor of this item
        /// </summary>
        /// <param name="e"></param>
        protected override void OnItemAdded(System.Windows.Forms.ToolStripItemEventArgs e)
        {
            base.OnItemAdded(e);

            e.Item.Font = MetroUI.Style.BaseFont;
            e.Item.ForeColor = MetroUI.Style.ForeColor;
        }
    }
}
