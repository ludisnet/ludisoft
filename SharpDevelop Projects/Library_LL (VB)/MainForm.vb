'
' Created by SharpDevelop.
' User: lul
' Date: 21.08.2008
' Time: 14:13
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
		
		form_test.showdialog()
		
	End Sub
	

	
	Sub Button2Click(ByVal sender As Object, ByVal e As EventArgs)
		
		Me.Close()
		
	End Sub
End Class
