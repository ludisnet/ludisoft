'
' Created by SharpDevelop.
' User: lul
' Date: 19.08.2008
' Time: 15:10
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.textBox1 = New System.Windows.Forms.TextBox
		Me.textBox2 = New System.Windows.Forms.TextBox
		Me.textBox3 = New System.Windows.Forms.TextBox
		Me.label1 = New System.Windows.Forms.Label
		Me.button1 = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(50, 82)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(100, 20)
		Me.textBox1.TabIndex = 0
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(191, 82)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(100, 20)
		Me.textBox2.TabIndex = 1
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(122, 183)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(100, 20)
		Me.textBox3.TabIndex = 2
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(156, 79)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(31, 23)
		Me.label1.TabIndex = 3
		Me.label1.Text = "+"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(133, 136)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 4
		Me.button1.Text = "Addition"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(376, 359)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBox3)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.textBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.Text = "toto1"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button1 As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private textBox3 As System.Windows.Forms.TextBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
End Class
