Imports System

Public Class RowWeightsClass

    Public Function RowWeights(ByVal array As Integer()) As Integer()
        Dim x As Integer = 0
        Dim y As Integer = 0

        For counter = 0 To array.Length - 1
            Dim remainder As Integer = counter Mod 2

            If remainder = 0 Then
                x += array(counter)
            Else
                y += array(counter)
            End If
        Next

        Return {x, y}
    End Function

End Class
