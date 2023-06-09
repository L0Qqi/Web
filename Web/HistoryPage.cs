﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web
{
    
    public partial class HistoryPage : UserControl
    {
        public List<Panel> Panels = new List<Panel>();
        public List<string> hist = new List<string>();
       
        public HistoryPage()
        {
            InitializeComponent();
        }
        public void ShowHistory(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Label label = new Label
                {
                    Text = list[i],
                    AutoSize = true,
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                    Location = new Point(20, 5),
                    Tag = i,
                    BackColor = SystemColors.ControlLightLight
                };
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(2, 64 + 30 * i),
                    Size = new Size(700, 30),
                    Tag = i,
                    BackColor = SystemColors.ControlLightLight
                };
                panel.Controls.Add(label);
                this.Controls.Add((Control)panel);
                Panels.Add(panel);
            }
        }
        private void closeHPButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void historyClearButton(object sender, EventArgs e)
        {
            if (!hist.Count.Equals(0))
            {
                hist.Clear();
                foreach (var panel in Panels)
                {
                    panel.Visible = false;
                }
                FormBrowser m = new FormBrowser();
                m.DeleteDataHis();
            }
            else
            {
                MessageBox.Show("История уже очищена.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!hist.Count.Equals(0))
            {
                hist.Clear();
                foreach (var panel in Panels)
                {
                    panel.Visible = false;
                }
                FormBrowser m = new FormBrowser();
                m.DeleteDataHis();
            }
            else
            {
                MessageBox.Show("История уже очищена.");
            }
        }
    }
}
