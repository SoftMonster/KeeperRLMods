Imports System.ComponentModel

Public Class frmEffect

    Public Property EffectText As String
        Get
            Return TextBox1.Text
        End Get
        Set(value As String)
            TextBox1.Text = value
        End Set
    End Property

    Private Sub CloseMe(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Me.DesignMode Then Exit Sub
        Me.Visible = False
        e.Cancel = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.StartsWith("Chain") Then
            TextBox1.Text = TextBox1.Text.Substring(8, TextBox1.Text.Length - 10)
            TextBox1.Text = "Chain { " + TextBox1.Text + " " + ComboBox1.Text + " }"
        ElseIf TextBox1.Text = "" Then
            TextBox1.Text = ComboBox1.Text
        Else
            TextBox1.Text = "Chain { " + TextBox1.Text + " " + ComboBox1.Text + " }"
        End If
    End Sub

End Class