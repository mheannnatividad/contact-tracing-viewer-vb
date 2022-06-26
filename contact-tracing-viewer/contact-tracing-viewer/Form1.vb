Public Class Form1
    Private Sub readBtn_Click(sender As Object, e As EventArgs) Handles readBtn.Click
        Dim filenameReader As System.IO.StreamReader
        Dim filename As String = filenameBox.Text + ".txt"

        filenameReader = My.Computer.FileSystem.OpenTextFileReader(filename)


        While Not filenameReader.EndOfStream()



            If readTextBox.Text = "" Then
                readTextBox.Text = filenameReader.ReadLine()
            End If

            readTextBox.Text += vbNewLine + filenameReader.ReadLine()

        End While
    End Sub
End Class
