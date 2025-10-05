Public Class Form1

    Dim angkapertama As Double
    Dim angkakedua As Double
    Dim operasi As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdisplay.TextAlign = HorizontalAlignment.Left
        txtdisplay.Multiline = True
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtdisplay.Text &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtdisplay.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtdisplay.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtdisplay.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtdisplay.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtdisplay.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtdisplay.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtdisplay.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtdisplay.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtdisplay.Text &= "9"
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        txtdisplay.Clear()
        angkapertama = 0
        angkakedua = 0
        operasi = ""
    End Sub

    Private Sub btnbackspace_Click(sender As Object, e As EventArgs) Handles btnbackspace.Click
        If txtdisplay.Text.Length > 0 Then
            txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1)
        End If
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        angkapertama = Val(txtdisplay.Text)
        txtdisplay.Clear()
        operasi = "+"
    End Sub

    Private Sub btnkurang_Click(sender As Object, e As EventArgs) Handles btnkurang.Click
        angkapertama = Val(txtdisplay.Text)
        txtdisplay.Clear()
        operasi = "-"
    End Sub

    Private Sub btnkali_Click(sender As Object, e As EventArgs) Handles btnkali.Click
        angkapertama = Val(txtdisplay.Text)
        txtdisplay.Clear()
        operasi = "*"
    End Sub

    Private Sub btnbagi_Click(sender As Object, e As EventArgs) Handles btnbagi.Click
        angkapertama = Val(txtdisplay.Text)
        txtdisplay.Clear()
        operasi = "/"
    End Sub

    Private Sub btnhasil_Click(sender As Object, e As EventArgs) Handles btnhasil.Click
        Try
            angkakedua = Val(txtdisplay.Text)
            Select Case operasi
                Case "+"
                    txtdisplay.Text = angkapertama + angkakedua
                Case "-"
                    txtdisplay.Text = angkapertama - angkakedua
                Case "*"
                    txtdisplay.Text = angkapertama * angkakedua
                Case "/"
                    If angkakedua = 0 Then
                        MessageBox.Show("Error: Division by zero is not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtdisplay.Clear()
                    Else
                        txtdisplay.Text = angkapertama / angkakedua
                    End If
                Case Else
                    MessageBox.Show("Please select an operation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnkurang.Click

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btn1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btntambah.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn5.Click

    End Sub
End Class