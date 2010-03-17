'
' Created by SharpDevelop.
' User: lul
' Date: 21.08.2008
' Time: 14:36
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Public Partial Class form_test
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		progressbar1.Style = ProgressBarStyle.Marquee
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.Close()
	End Sub
	
	Sub Form_testLoad(ByVal sender As Object, ByVal e As EventArgs)
		Dim path_prog_main As String
		Dim path_prog_main_mod As String
		Dim sep As Char()="\"
		
		path_prog_main = System.Reflection.Assembly.GetEntryAssembly().Location
		textbox1.Text = system.DateTime.now
		textbox2.Text = path_prog_main
		path_prog_main_mod = path_prog_main
		path_prog_main_mod=path_prog_main_mod.Substring(0,path_prog_main.lastindexof(sep)+1)
		textbox3.Text=path_prog_main_mod
		
		
		'textbox3.Text=path_prog_main_mod.Substring(0,path_prog_main.lastindexof(sep)+1)
				
	End Sub
	
	
End Class
