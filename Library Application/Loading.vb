Imports System.Globalization

Public Class Loading
    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblPercent.Text = PBLoading.Value & "%"

        PBLoading.Value += 2
        If PBLoading.Value = 100 Then
            lblPercent.Text = "Complete! Launching"
            MainForm.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub
End Class