namespace CarPanel {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraGauges.Core.Drawing.SolidBrushObject solidBrushObject6 = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel4 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Drawing.SolidBrushObject solidBrushObject7 = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel5 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Drawing.SolidBrushObject solidBrushObject8 = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject();
            DevExpress.XtraGauges.Core.Model.ScaleLabel scaleLabel6 = new DevExpress.XtraGauges.Core.Model.ScaleLabel();
            DevExpress.XtraGauges.Core.Drawing.SolidBrushObject solidBrushObject9 = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject();
            DevExpress.XtraGauges.Core.Drawing.SolidBrushObject solidBrushObject10 = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject();
            this.bgGaugeControl = new DevExpress.XtraGauges.Win.GaugeControl();
            this.speedometer = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.fuel = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge2 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.temperature = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge3 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.distance = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgGaugeControl
            // 
            this.bgGaugeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bgGaugeControl.Location = new System.Drawing.Point(126, 171);
            this.bgGaugeControl.Name = "bgGaugeControl";
            this.bgGaugeControl.Size = new System.Drawing.Size(148, 109);
            this.bgGaugeControl.TabIndex = 0;
            // 
            // speedometer
            // 
            this.speedometer.BackColor = System.Drawing.Color.Transparent;
            this.speedometer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.speedometer.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.speedometer.Location = new System.Drawing.Point(280, 20);
            this.speedometer.Name = "speedometer";
            this.speedometer.Size = new System.Drawing.Size(260, 260);
            this.speedometer.TabIndex = 1;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 248, 248);
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1";
            this.arcScaleBackgroundLayerComponent1.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.815F);
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style10;
            this.arcScaleBackgroundLayerComponent1.Size = new System.Drawing.SizeF(250F, 154F);
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 10F);
            solidBrushObject6.Color = System.Drawing.Color.Silver;
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = solidBrushObject6;
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F);
            this.arcScaleComponent1.EndAngle = 0F;
            scaleLabel4.AppearanceText.Font = new System.Drawing.Font("Tahoma", 14F);
            scaleLabel4.FormatString = "{0} {1:F0} Mph";
            scaleLabel4.Name = "Label0";
            scaleLabel4.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F);
            scaleLabel4.Size = new System.Drawing.SizeF(100F, 25F);
            scaleLabel4.Text = "";
            this.arcScaleComponent1.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel4});
            this.arcScaleComponent1.MajorTickCount = 7;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -2F;
            this.arcScaleComponent1.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F);
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4;
            this.arcScaleComponent1.MajorTickmark.TextOffset = -15F;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 180F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F);
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3;
            this.arcScaleComponent1.Name = "arcScaleComponent1";
            this.arcScaleComponent1.RadiusX = 105F;
            this.arcScaleComponent1.RadiusY = 105F;
            this.arcScaleComponent1.StartAngle = -180F;
            this.arcScaleComponent1.Value = 124F;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = -5F;
            this.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10;
            this.arcScaleNeedleComponent1.StartOffset = -9F;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // fuel
            // 
            this.fuel.BackColor = System.Drawing.Color.Transparent;
            this.fuel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fuel.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge2});
            this.fuel.Location = new System.Drawing.Point(126, 12);
            this.fuel.Name = "fuel";
            this.fuel.Size = new System.Drawing.Size(148, 153);
            this.fuel.TabIndex = 2;
            // 
            // circularGauge2
            // 
            this.circularGauge2.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent2});
            this.circularGauge2.Bounds = new System.Drawing.Rectangle(6, 6, 136, 141);
            this.circularGauge2.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent2});
            this.circularGauge2.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent2});
            // 
            // arcScaleBackgroundLayerComponent2
            // 
            this.arcScaleBackgroundLayerComponent2.ArcScale = this.arcScaleComponent2;
            this.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent2";
            this.arcScaleBackgroundLayerComponent2.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.78F, 0.78F);
            this.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style10Left;
            this.arcScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // arcScaleComponent2
            // 
            this.arcScaleComponent2.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 14F);
            solidBrushObject7.Color = System.Drawing.Color.Silver;
            this.arcScaleComponent2.AppearanceTickmarkText.TextBrush = solidBrushObject7;
            this.arcScaleComponent2.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(195F, 195F);
            this.arcScaleComponent2.EndAngle = -90F;
            scaleLabel5.AppearanceText.Font = new System.Drawing.Font("Tahoma", 14F);
            scaleLabel5.FormatString = "{0}";
            scaleLabel5.Name = "Label0";
            scaleLabel5.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(135F, 175F);
            scaleLabel5.Size = new System.Drawing.SizeF(50F, 30F);
            scaleLabel5.Text = "Fuel";
            this.arcScaleComponent2.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel5});
            this.arcScaleComponent2.MajorTickCount = 4;
            this.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent2.MajorTickmark.ShapeOffset = -6F;
            this.arcScaleComponent2.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F);
            this.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4;
            this.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent2.MaxValue = 60F;
            this.arcScaleComponent2.MinorTickCount = 4;
            this.arcScaleComponent2.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F);
            this.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3;
            this.arcScaleComponent2.Name = "arcScaleComponent2";
            this.arcScaleComponent2.RadiusX = 144F;
            this.arcScaleComponent2.RadiusY = 144F;
            this.arcScaleComponent2.StartAngle = -180F;
            this.arcScaleComponent2.Value = 50F;
            // 
            // arcScaleNeedleComponent2
            // 
            this.arcScaleNeedleComponent2.ArcScale = this.arcScaleComponent2;
            this.arcScaleNeedleComponent2.EndOffset = -12F;
            this.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2";
            this.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10;
            this.arcScaleNeedleComponent2.StartOffset = -14F;
            this.arcScaleNeedleComponent2.ZOrder = -50;
            // 
            // temperature
            // 
            this.temperature.BackColor = System.Drawing.Color.Transparent;
            this.temperature.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.temperature.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge3});
            this.temperature.Location = new System.Drawing.Point(546, 20);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(159, 153);
            this.temperature.TabIndex = 3;
            // 
            // circularGauge3
            // 
            this.circularGauge3.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent3});
            this.circularGauge3.Bounds = new System.Drawing.Rectangle(6, 6, 147, 141);
            this.circularGauge3.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent3});
            this.circularGauge3.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent3});
            // 
            // arcScaleBackgroundLayerComponent3
            // 
            this.arcScaleBackgroundLayerComponent3.ArcScale = this.arcScaleComponent3;
            this.arcScaleBackgroundLayerComponent3.Name = "arcScaleBackgroundLayerComponent3";
            this.arcScaleBackgroundLayerComponent3.ScaleCenterPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.22F, 0.78F);
            this.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style10Right;
            this.arcScaleBackgroundLayerComponent3.ZOrder = 1000;
            // 
            // arcScaleComponent3
            // 
            this.arcScaleComponent3.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 14F);
            solidBrushObject8.Color = System.Drawing.Color.Silver;
            this.arcScaleComponent3.AppearanceTickmarkText.TextBrush = solidBrushObject8;
            this.arcScaleComponent3.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(55F, 195F);
            this.arcScaleComponent3.EndAngle = 0F;
            scaleLabel6.AppearanceText.Font = new System.Drawing.Font("Tahoma", 14F);
            scaleLabel6.FormatString = "{0}{1:F0}C°";
            scaleLabel6.Name = "Label0";
            scaleLabel6.Position = new DevExpress.XtraGauges.Core.Base.PointF2D(120F, 175F);
            scaleLabel6.Size = new System.Drawing.SizeF(100F, 30F);
            scaleLabel6.Text = "t=";
            this.arcScaleComponent3.Labels.AddRange(new DevExpress.XtraGauges.Core.Model.ILabel[] {
            scaleLabel6});
            this.arcScaleComponent3.MajorTickCount = 4;
            this.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent3.MajorTickmark.ShapeOffset = -6F;
            this.arcScaleComponent3.MajorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F);
            this.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4;
            this.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent3.MaxValue = 130F;
            this.arcScaleComponent3.MinorTickCount = 4;
            this.arcScaleComponent3.MinorTickmark.ShapeScale = new DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F);
            this.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3;
            this.arcScaleComponent3.MinValue = 40F;
            this.arcScaleComponent3.Name = "arcScaleComponent3";
            this.arcScaleComponent3.RadiusX = 144F;
            this.arcScaleComponent3.RadiusY = 144F;
            this.arcScaleComponent3.StartAngle = -90F;
            this.arcScaleComponent3.Value = 83F;
            // 
            // arcScaleNeedleComponent3
            // 
            this.arcScaleNeedleComponent3.ArcScale = this.arcScaleComponent3;
            this.arcScaleNeedleComponent3.EndOffset = -12F;
            this.arcScaleNeedleComponent3.Name = "arcScaleNeedleComponent3";
            this.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10;
            this.arcScaleNeedleComponent3.StartOffset = -14F;
            this.arcScaleNeedleComponent3.ZOrder = -50;
            // 
            // distance
            // 
            this.distance.BackColor = System.Drawing.Color.Transparent;
            this.distance.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.distance.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge1});
            this.distance.Location = new System.Drawing.Point(546, 191);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(213, 89);
            this.distance.TabIndex = 4;
            // 
            // digitalGauge1
            // 
            solidBrushObject9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.digitalGauge1.AppearanceOff.ContentBrush = solidBrushObject9;
            solidBrushObject10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.digitalGauge1.AppearanceOn.ContentBrush = solidBrushObject10;
            this.digitalGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.digitalGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 201, 77);
            this.digitalGauge1.DigitCount = 6;
            this.digitalGauge1.Text = "90125";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(327.775F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style10;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 292);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.fuel);
            this.Controls.Add(this.speedometer);
            this.Controls.Add(this.bgGaugeControl);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl bgGaugeControl;
        private DevExpress.XtraGauges.Win.GaugeControl speedometer;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl fuel;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent2;
        private DevExpress.XtraGauges.Win.GaugeControl temperature;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent3;
        private DevExpress.XtraGauges.Win.GaugeControl distance;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;

    }
}

