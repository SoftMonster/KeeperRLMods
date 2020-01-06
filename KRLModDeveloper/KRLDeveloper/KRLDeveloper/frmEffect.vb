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
    Private Sub LoadMe() Handles Me.Load
        If Me.DesignMode Then Exit Sub
        TextBox2.Text = "1.0"
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text.Trim = "" Then
            Exit Sub
        End If
        If ComboBox1.Text.Contains("<EFFECT>") And UcLastingEffect1.Text = "" Then
            Exit Sub
        End If
        Dim dbl As Double = 1
        If Not Double.TryParse(TextBox2.Text, dbl) Then
            TextBox2.Text = "1.0"
            dbl = 1
        End If
        Dim TotalText As String = Replace(ComboBox1.Text, "<EFFECT>", UcLastingEffect1.Text)
        If dbl < 1 Then
            TotalText = "Chance " + dbl.ToString() + " " + TotalText
        End If
        If TextBox1.Text.StartsWith("Chain") Then
            TextBox1.Text = TextBox1.Text.Substring(8, TextBox1.Text.Length - 10)
            TextBox1.Text = "Chain { " + TextBox1.Text + " " + TotalText + " }"
        ElseIf TextBox1.Text = "" Then
            TextBox1.Text = TotalText
        Else
            TextBox1.Text = "Chain { " + TextBox1.Text + " " + TotalText + " }"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        DoVisability()
    End Sub

    Private Sub DoVisability()
        Dim vis As Boolean = ComboBox1.Text.Contains("<EFFECT>")
        UcLastingEffect1.Visible = vis
        Label2.Visible = vis
        If Not vis Then
            UcLastingEffect1.Text = ""
        End If
    End Sub
End Class