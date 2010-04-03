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
        /// <summary>
        /// Constructor to set the current map
        /// </summary>
        /// <param name="map">map object to set to current map</param>
        public FlagControl(Map map)
        {
            this.map = map;
            InitializeComponent();
        }

        //property for flag
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

        //Resets the flag back to its starting location with starting dialogue
        //Then redraws the map to show the change
        private void button1_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Flags.UnSetflag(label1.Text);

            map.reloadMap();
        }
    }
}
