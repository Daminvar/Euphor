using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euphor
{
    public partial class FlagControl : UserControl
    {
        Map map;

        public FlagControl()
        {
            
            InitializeComponent();
        }

        public FlagControl(Map map)
        {
            this.map = map;
            InitializeComponent();
        }

        public string Flag
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void FlagControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Flags.UnSetflag(label1.Text);

            map.reloadMap();
        }
    }
}
