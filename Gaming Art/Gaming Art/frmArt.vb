Public Class frmArt
    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub

    Private Sub FrmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)

    End Sub
End Class
