'
' Created by SharpDevelop.
' User: lul
' Date: 21.08.2008
' Time: 14:18
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class form2
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
		Me.label1 = New System.Windows.Forms.Label
		Me.label2 = New System.Windows.Forms.Label
		Me.textBox1 = New System.Windows.Forms.TextBox
		Me.textBox2 = New System.Windows.Forms.TextBox
		Me.label3 = New System.Windows.Forms.Label
		Me.textBox3 = New System.Windows.Forms.TextBox
		Me.textBox4 = New System.Windows.Forms.TextBox
		Me.label4 = New System.Windows.Forms.Label
		Me.button1 = New System.Windows.Forms.Button
		Me.button2 = New System.Windows.Forms.Button
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(26, 21)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Author :"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(26, 67)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Subject :"
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(26, 35)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(370, 20)
		Me.textBox1.TabIndex = 2
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(26, 82)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(725, 20)
		Me.textBox2.TabIndex = 3
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(26, 116)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 4
		Me.label3.Text = "Files :"
		'
		'textBox3
		'
		Me.textBox3.Location = New System.Drawing.Point(26, 132)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(725, 20)
		Me.textBox3.TabIndex = 5
		'
		'textBox4
		'
		Me.textBox4.Location = New System.Drawing.Point(26, 196)
		Me.textBox4.Multiline = true
		Me.textBox4.Name = "textBox4"
		Me.textBox4.Size = New System.Drawing.Size(725, 341)
		Me.textBox4.TabIndex = 6
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(26, 170)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 7
		Me.label4.Text = "Text :"
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(676, 32)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 8
		Me.button1.Text = "Cancel"
		Me.button1.UseVisualStyleBackColor = true
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(545, 32)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(109, 23)
		Me.button2.TabIndex = 9
		Me.button2.Text = "Save and Close"
		Me.button2.UseVisualStyleBackColor = true
		'
		'form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(771, 561)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.textBox4)
		Me.Controls.Add(Me.textBox3)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Name = "form2"
		Me.Text = "Item"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private textBox4 As System.Windows.Forms.TextBox
	Private textBox3 As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
