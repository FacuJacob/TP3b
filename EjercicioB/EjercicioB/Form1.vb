Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ejec.Click
        Dim cont1 As Integer
        Dim contp As Integer
        Dim mayor As Integer
        Dim num As Integer
        Dim i As Integer
        Dim b As Integer
        Dim a As Integer
        cont1 = 0
        contp = 0
        mayor = 0
        For i = 1 To 20 Step 1
            cont1 = cont1 + 1
            num = InputBox("Numeros", "Ingrese numeros")
            If mayor < num Then
                mayor = num
                b = cont1
            End If
        Next
    End Sub
End Class
