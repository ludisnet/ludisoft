'
' Created by SharpDevelop.
' User: lul
' Date: 21.08.2008
' Time: 14:36
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form_test
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
		Me.progressBar1 = New System.Windows.Forms.ProgressBar
		Me.textBox1 = New System.Windows.Forms.TextBox
		Me.textBox2 = New System.Windows.Forms.TextBox
		Me.label1 = New System.Windows.Forms.Label
		Me.label2 = New System.Windows.Forms.Label
		Me.textBox3 = New System.Windows.Forms.TextBox
		Me.label3 = New System.Windows.Forms.Label
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(292, 386)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(181, 23)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Close"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'progressBar1
		'
		Me.progressBar1.Location = New System.Drawing.Point(63, 346)
		Me.progressBar1.Name = "progressBar1"
		Me.progressBar1.Size = New System.Drawing.Size(376, 23)
		Me.progressBar1.TabIndex = 1
	'	AddHandler Me.progressBar1.Click, AddressOf Me.ProgressBar1Click
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(63, 71)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(376, 20)
		Me.textBox1.TabIndex = 2
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(63, 131)
		Me.textBox2.Multiline = true
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(376, 20)
		Me.textBox2.TabIndex = 3
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(63, 42)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 4
		Me.label1.Text = "Date"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(63, 102)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Program path"
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(63, 201)
		Me.textBox3.Multiline = true
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(376, 20)
		Me.textBox3.TabIndex = 3
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(63, 172)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(203, 23)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Program path_modified"
		'
		'form_test
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(485, 421)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.textBox3)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.progressBar1)
		Me.Controls.Add(Me.button1)
		Me.Name = "form_test"
		Me.Text = "form_test"
		AddHandler Load, AddressOf Me.Form_testLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label3 As System.Windows.Forms.Label
	Private textBox3 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private progressBar1 As System.Windows.Forms.ProgressBar
	Private button1 As System.Windows.Forms.Button
End Class
