Public Class Form1
    Private Sub readBtn_Click(sender As Object, e As EventArgs) Handles readBtn.Click
        Dim filenameReader As System.IO.StreamReader
        Dim filename As String = filenameBox.Text + ".txt"

        If System.IO.File.Exists(filename) Then
            filenameReader = My.Computer.FileSystem.OpenTextFileReader(filename)

            While Not filenameReader.EndOfStream()



                If readTextBox.Text = "" Then
                    readTextBox.Text = filenameReader.ReadLine()
                End If

                readTextBox.Text += vbNewLine + filenameReader.ReadLine()

            End While
        Else
            MessageBox.Show("Invalid filename.")
        End If


    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        readTextBox.Text = ""
    End Sub
End Class
