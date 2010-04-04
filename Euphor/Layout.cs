using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euphor
{
    public partial class Layout : Form
    {
        Map map;
        public Layout(Map map)
        {
            this.map = map;
            
            InitializeComponent();
            
        }
        /// <summary>
        /// Adds a flag to the list, name of flag is equal to the entered text
        /// from textbox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            FlagControl fg = new FlagControl(map);
            Flags.SetFlag(textBox1.Text);
            fg.Flag = textBox1.Text;
            flowLayoutPanel1.Controls.Add(fg);
            textBox1.Text = "";
            map.reloadMap();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
