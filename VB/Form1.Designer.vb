Imports Microsoft.VisualBasic
Imports System
Namespace CarPanel
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim solidBrushObject6 As New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject()
			Dim scaleLabel4 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim solidBrushObject7 As New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject()
			Dim scaleLabel5 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim solidBrushObject8 As New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject()
			Dim scaleLabel6 As New DevExpress.XtraGauges.Core.Model.ScaleLabel()
			Dim solidBrushObject9 As New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject()
			Dim solidBrushObject10 As New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject()
			Me.bgGaugeControl = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.speedometer = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.fuel = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.temperature = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.distance = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.digitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
			Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.digitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' bgGaugeControl
			' 
			Me.bgGaugeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.bgGaugeControl.Location = New System.Drawing.Point(126, 171)
			Me.bgGaugeControl.Name = "bgGaugeControl"
			Me.bgGaugeControl.Size = New System.Drawing.Size(148, 109)
			Me.bgGaugeControl.TabIndex = 0
			' 
			' speedometer
			' 
			Me.speedometer.BackColor = System.Drawing.Color.Transparent
			Me.speedometer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.speedometer.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.speedometer.Location = New System.Drawing.Point(280, 20)
			Me.speedometer.Name = "speedometer"
			Me.speedometer.Size = New System.Drawing.Size(260, 260)
			Me.speedometer.TabIndex = 1
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 248)
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1})
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1"
			Me.arcScaleBackgroundLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.815F)
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style10
			Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(250F, 154F)
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10F)
			solidBrushObject6.Color = System.Drawing.Color.Silver
			Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = solidBrushObject6
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 165F)
			Me.arcScaleComponent1.EndAngle = 0F
			scaleLabel4.AppearanceText.Font = New System.Drawing.Font("Tahoma", 14F)
			scaleLabel4.FormatString = "{0} {1:F0} Mph"
			scaleLabel4.Name = "Label0"
			scaleLabel4.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 135F)
			scaleLabel4.Size = New System.Drawing.SizeF(100F, 25F)
			scaleLabel4.Text = ""
			Me.arcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() { scaleLabel4})
			Me.arcScaleComponent1.MajorTickCount = 7
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -2F
			Me.arcScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 0.8F)
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
			Me.arcScaleComponent1.MajorTickmark.TextOffset = -15F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 180F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6F, 1F)
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
			Me.arcScaleComponent1.Name = "arcScaleComponent1"
			Me.arcScaleComponent1.RadiusX = 105F
			Me.arcScaleComponent1.RadiusY = 105F
			Me.arcScaleComponent1.StartAngle = -180F
			Me.arcScaleComponent1.Value = 124F
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = -5F
			Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10
			Me.arcScaleNeedleComponent1.StartOffset = -9F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' fuel
			' 
			Me.fuel.BackColor = System.Drawing.Color.Transparent
			Me.fuel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.fuel.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge2})
			Me.fuel.Location = New System.Drawing.Point(126, 12)
			Me.fuel.Name = "fuel"
			Me.fuel.Size = New System.Drawing.Size(148, 153)
			Me.fuel.TabIndex = 2
			' 
			' circularGauge2
			' 
			Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent2})
			Me.circularGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 136, 141)
			Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent2})
			Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent2})
			' 
			' arcScaleBackgroundLayerComponent2
			' 
			Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
			Me.arcScaleBackgroundLayerComponent2.Name = "arcScaleBackgroundLayerComponent2"
			Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.78F, 0.78F)
			Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style10Left
			Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
			' 
			' arcScaleComponent2
			' 
			Me.arcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 14F)
			solidBrushObject7.Color = System.Drawing.Color.Silver
			Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = solidBrushObject7
			Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(195F, 195F)
			Me.arcScaleComponent2.EndAngle = -90F
			scaleLabel5.AppearanceText.Font = New System.Drawing.Font("Tahoma", 14F)
			scaleLabel5.FormatString = "{0}"
			scaleLabel5.Name = "Label0"
			scaleLabel5.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(135F, 175F)
			scaleLabel5.Size = New System.Drawing.SizeF(50F, 30F)
			scaleLabel5.Text = "Fuel"
			Me.arcScaleComponent2.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() { scaleLabel5})
			Me.arcScaleComponent2.MajorTickCount = 4
			Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -6F
			Me.arcScaleComponent2.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
			Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
			Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent2.MaxValue = 60F
			Me.arcScaleComponent2.MinorTickCount = 4
			Me.arcScaleComponent2.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
			Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
			Me.arcScaleComponent2.Name = "arcScaleComponent2"
			Me.arcScaleComponent2.RadiusX = 144F
			Me.arcScaleComponent2.RadiusY = 144F
			Me.arcScaleComponent2.StartAngle = -180F
			Me.arcScaleComponent2.Value = 50F
			' 
			' arcScaleNeedleComponent2
			' 
			Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
			Me.arcScaleNeedleComponent2.EndOffset = -12F
			Me.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2"
			Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10
			Me.arcScaleNeedleComponent2.StartOffset = -14F
			Me.arcScaleNeedleComponent2.ZOrder = -50
			' 
			' temperature
			' 
			Me.temperature.BackColor = System.Drawing.Color.Transparent
			Me.temperature.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.temperature.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge3})
			Me.temperature.Location = New System.Drawing.Point(546, 20)
			Me.temperature.Name = "temperature"
			Me.temperature.Size = New System.Drawing.Size(159, 153)
			Me.temperature.TabIndex = 3
			' 
			' circularGauge3
			' 
			Me.circularGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent3})
			Me.circularGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 147, 141)
			Me.circularGauge3.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent3})
			Me.circularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent3})
			' 
			' arcScaleBackgroundLayerComponent3
			' 
			Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent3
			Me.arcScaleBackgroundLayerComponent3.Name = "arcScaleBackgroundLayerComponent3"
			Me.arcScaleBackgroundLayerComponent3.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.22F, 0.78F)
			Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularQuarter_Style10Right
			Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
			' 
			' arcScaleComponent3
			' 
			Me.arcScaleComponent3.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 14F)
			solidBrushObject8.Color = System.Drawing.Color.Silver
			Me.arcScaleComponent3.AppearanceTickmarkText.TextBrush = solidBrushObject8
			Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(55F, 195F)
			Me.arcScaleComponent3.EndAngle = 0F
			scaleLabel6.AppearanceText.Font = New System.Drawing.Font("Tahoma", 14F)
			scaleLabel6.FormatString = "{0}{1:F0}C°"
			scaleLabel6.Name = "Label0"
			scaleLabel6.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(120F, 175F)
			scaleLabel6.Size = New System.Drawing.SizeF(100F, 30F)
			scaleLabel6.Text = "t="
			Me.arcScaleComponent3.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() { scaleLabel6})
			Me.arcScaleComponent3.MajorTickCount = 4
			Me.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent3.MajorTickmark.ShapeOffset = -6F
			Me.arcScaleComponent3.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
			Me.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
			Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent3.MaxValue = 130F
			Me.arcScaleComponent3.MinorTickCount = 4
			Me.arcScaleComponent3.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.6F, 1.6F)
			Me.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
			Me.arcScaleComponent3.MinValue = 40F
			Me.arcScaleComponent3.Name = "arcScaleComponent3"
			Me.arcScaleComponent3.RadiusX = 144F
			Me.arcScaleComponent3.RadiusY = 144F
			Me.arcScaleComponent3.StartAngle = -90F
			Me.arcScaleComponent3.Value = 83F
			' 
			' arcScaleNeedleComponent3
			' 
			Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent3
			Me.arcScaleNeedleComponent3.EndOffset = -12F
			Me.arcScaleNeedleComponent3.Name = "arcScaleNeedleComponent3"
			Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style10
			Me.arcScaleNeedleComponent3.StartOffset = -14F
			Me.arcScaleNeedleComponent3.ZOrder = -50
			' 
			' distance
			' 
			Me.distance.BackColor = System.Drawing.Color.Transparent
			Me.distance.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.distance.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.digitalGauge1})
			Me.distance.Location = New System.Drawing.Point(546, 191)
			Me.distance.Name = "distance"
			Me.distance.Size = New System.Drawing.Size(213, 89)
			Me.distance.TabIndex = 4
			' 
			' digitalGauge1
			' 
			solidBrushObject9.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.digitalGauge1.AppearanceOff.ContentBrush = solidBrushObject9
			solidBrushObject10.Color = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(250))))))
			Me.digitalGauge1.AppearanceOn.ContentBrush = solidBrushObject10
			Me.digitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() { Me.digitalBackgroundLayerComponent1})
			Me.digitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 201, 77)
			Me.digitalGauge1.DigitCount = 6
			Me.digitalGauge1.Text = "90125"
			' 
			' digitalBackgroundLayerComponent1
			' 
			Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(327.775F, 99.9625F)
			Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
			Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style10
			Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
			Me.digitalBackgroundLayerComponent1.ZOrder = 1000
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1023, 292)
			Me.Controls.Add(Me.distance)
			Me.Controls.Add(Me.temperature)
			Me.Controls.Add(Me.fuel)
			Me.Controls.Add(Me.speedometer)
			Me.Controls.Add(Me.bgGaugeControl)
			Me.DoubleBuffered = True
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Form1"
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.digitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.digitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private bgGaugeControl As DevExpress.XtraGauges.Win.GaugeControl
		Private speedometer As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private fuel As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge2 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private temperature As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge3 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private distance As DevExpress.XtraGauges.Win.GaugeControl
		Private digitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
		Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

	End Class
End Namespace

