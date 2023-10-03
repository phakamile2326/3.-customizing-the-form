Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "my first App in 2023"
        Me.BackColor = Color.Teal
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Size = New Size(800, 400)
        Me.Opacity = 0.85 'makes it a bit transparent
        Me.CenterToParent() 'centres the execution box
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPhakamile.Click
        MsgBox("This is Phakamile",, "Greetings") 'makes the lil box have greetings instead of default
    End Sub

End Class

