' Title:    Youth League Soccer Team Database
' Author:   Aidan J Culley
' Date:     October 15th, 2019
' Purpose:  the application shows youth league stuff

Option Strict On
Public Class frmYouth
    Private Sub TeamBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TeamBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TeamBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SoccerDataSet)

    End Sub

    Private Sub frmYouth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SoccerDataSet.Team' table. You can move, or remove it, as needed.
        Me.TeamTableAdapter.Fill(Me.SoccerDataSet.Team)

    End Sub

    Private Sub btnAges_Click(sender As Object, e As EventArgs) Handles btnAges.Click
        Dim strSql As String = "SELECT * FROM Team"
        Dim strPath As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=..\\..\\Soccer.mdb"
        Dim odaTeam As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D
        odaTeam.Fill(datValue)
        odaTeam.Dispose()
        For intCount = 0 To datValue.Rows.Count - 1
            decTotalValue += Convert.ToDecimal(datValue.Rows(intCount)("Age"))
        Next
        lblAge.Visible = True
        lblAge.Text = String.Format("Average Age: {0}", Math.Round(decTotalValue / intCount, 2))
    End Sub
End Class
