using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarPanel.Properties;

namespace CarPanel {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            BuildCarPanel();
        }
        void BuildCarPanel() {
            bgGaugeControl.Location = new Point(10, 10);
            bgGaugeControl.Size = new Size(1000, 264); //Image Size
            bgGaugeControl.BackColor = Color.FromArgb(0, 0, 0, 0);
            bgGaugeControl.BackgroundImage = Resources.gauge_cluster2;
            bgGaugeControl.BackgroundImageLayout = ImageLayout.Center;

            fuel.Parent = bgGaugeControl;
            fuel.Location = new Point(200, 100);
            fuel.Size = new Size(150, 150);

            speedometer.Parent = bgGaugeControl;
            speedometer.Location = new Point(375, 10);
            speedometer.Size = new Size(250, 250);

            temperature.Parent = bgGaugeControl;
            temperature.Location = new Point(650, 100);
            temperature.Size = new Size(150, 150);

            distance.Parent = speedometer;
            distance.Location = new Point(0, 200);
            distance.Size = new Size(250, 50);
        }
    }
}