Public Class Form1

    Private Sub tombolOK_Click(sender As Object, e As EventArgs) Handles tombolOK.Click
        Dim intIndeks As Integer  'indeks kotak list

        For intIndeks = 0 To clbKota.Items.Count - 1
            If clbKota.GetItemChecked(intIndeks) = True Then
                listPeriksa.Items.Add(clbKota.Items(intIndeks))
            End If
        Next
    End Sub
End Class
