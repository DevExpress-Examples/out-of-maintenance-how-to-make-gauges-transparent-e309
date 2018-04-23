Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace CarPanel
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			BuildCarPanel()
		End Sub
		Private Sub BuildCarPanel()
			bgGaugeControl.Location = New Point(10, 10)
            bgGaugeControl.Size = New Size(1000, 264) 'Image Size
            bgGaugeControl.BackColor = Color.FromArgb(0, 0, 0, 0)
            Dim thisExe As Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim file As IO.Stream = thisExe.GetManifestResourceStream("gauge_cluster2.png")
            bgGaugeControl.BackgroundImage = Image.FromStream(file)
			bgGaugeControl.BackgroundImageLayout = ImageLayout.Center

			fuel.Parent = bgGaugeControl
			fuel.Location = New Point(200, 100)
			fuel.Size = New Size(150, 150)

			speedometer.Parent = bgGaugeControl
			speedometer.Location = New Point(375, 10)
			speedometer.Size = New Size(250, 250)

			temperature.Parent = bgGaugeControl
			temperature.Location = New Point(650, 100)
			temperature.Size = New Size(150, 150)

			distance.Parent = speedometer
			distance.Location = New Point(0, 200)
			distance.Size = New Size(250, 50)
		End Sub
	End Class
End Namespace