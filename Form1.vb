Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Public Class Form1
    Dim lines As New List(Of String)
    Dim currentLineIndex As Integer = 0
    Dim textToDisplay As New StringBuilder()
    Dim timer As New Timer()
    Dim stopwatch As New Stopwatch()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lines.Add("SHEEEEEET")
        lines.Add("10 pm na pala?? It's I MISS YOU TIMEEEEEEEE NA")
        lines.Add("Fuck 10pm na pala SHEEEEEEEET")
        lines.Add("*/Tuloooooooongg")
        lines.Add("*/nag-iba ang anyo* ughhhhhhhhhh")
        lines.Add("Di mapigilang mag isip")
        lines.Add("Na baka sa tagal")
        lines.Add("Mahulog ang loob sa iba")
        timer.Interval = 100
        AddHandler timer.Tick,
            Sub(senderTimer As Object, eTimer As EventArgs)
                AnimateText()
            End Sub
        stopwatch.Start()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        currentLineIndex = 0
        textToDisplay.Clear()
        TextBox1.Clear()
        timer.Start()
    End Sub
    Private Sub AnimateText()
        If currentLineIndex < lines.Count Then
            Dim isSlowLine As Boolean = currentLineIndex = 3
            If textToDisplay.Length < lines(currentLineIndex).Length Then
                Dim nextChar As Char = lines(currentLineIndex)(textToDisplay.Length)
                If isSlowLine Then

                    System.Threading.Thread.Sleep(500)
                End If
                textToDisplay.Append(nextChar)
                TextBox1.Text = textToDisplay.ToString()
            Else
                currentLineIndex += 1
                textToDisplay.Clear()
                timer.Interval = 100
            End If
            If stopwatch.ElapsedMilliseconds >= 300000 Then
                timer.Stop()
            End If
        Else
            timer.Stop()
        End If
    End Sub
End Class