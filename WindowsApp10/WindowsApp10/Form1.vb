Public Class Form1
    Private Sub TouristAttractionsAZBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TouristAttractionsAZBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tourist_AttractionsAZDataSet)

    End Sub

    Private Sub TouristAttractionsAZBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TouristAttractionsAZBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TouristAttractionsAZBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tourist_AttractionsAZDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tourist_AttractionsAZDataSet.TouristAttractionsAZ' table. You can move, or remove it, as needed.
        Me.TouristAttractionsAZTableAdapter.Fill(Me.Tourist_AttractionsAZDataSet.TouristAttractionsAZ)

    End Sub

    Private Sub ThemeParkButton_Click(sender As Object, e As EventArgs) Handles ThemeParkButton.Click
        Dim Attraction = From r In Tourist_AttractionsAZDataSet Where r = r.ThemePark = True
    End Sub
End Class
