'
' Created by SharpDevelop.
' User: lul
' Date: 21.08.2008
' Time: 14:13
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.button1 = New System.Windows.Forms.Button
		Me.button2 = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(24, 44)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(209, 23)
		Me.button1.TabIndex = 0
		Me.button1.Text = "launch form_test"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(557, 364)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 1
		Me.button2.Text = "Close"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(696, 450)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Name = "MainForm"
		Me.Text = "Library_LL"
		Me.ResumeLayout(false)
	End Sub
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
End Class
