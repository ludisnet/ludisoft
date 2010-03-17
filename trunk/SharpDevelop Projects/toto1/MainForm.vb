'
' Created by SharpDevelop.
' User: lul
' Date: 19.08.2008
' Time: 15:10
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'

	End Sub
	

	
	Sub Button1Click(ByVal sender As Object, ByVal e As EventArgs)
		'	mes variables :

		Dim a,b,c as double
		
		'calcul :
		
		a = textbox1.Text
		b =textbox2.Text
		
		c=a+b
		textbox3.Text=c
		
		
	End Sub
End Class
