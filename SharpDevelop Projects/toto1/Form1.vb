'
' Created by SharpDevelop.
' User: lul
' Date: 21.08.2008
' Time: 09:46
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Public Partial Class Form1
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
'	Sub Button1Click(ByVal sender As Object, ByVal e As EventArgs)
'		    Dim cat As New ADOX.Catalog
'    Dim tbl As New ADOX.Table
'    Dim key As New ADOX.key
'
'    ' Création de la base de donnée
'    cat.Create "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Mes Documents\MyDataBase.mdb"
'
'    ' Ajout d'une table
'    tbl.Name = "Table1"
'    tbl.Columns.Append "Champ1", adInteger
'    tbl.Columns.Append "Champ2", adInteger
'    tbl.Columns.Append "Champ3", adVarWChar, 50
'    cat.Tables.Append tbl
'
'    ' Ajout d'une clé primaire
'    key.Name = "ClePrimaire"
'    key.Type = adKeyPrimary
'    key.RelatedTable = "Table1"
'    key.Columns.Append "Champ1"
'    tbl.Keys.Append key
'
'    Set key = Nothing
'    Set tbl = Nothing
'    Set cat = Nothing
'	End Sub
End Class
